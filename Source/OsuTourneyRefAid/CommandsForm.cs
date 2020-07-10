using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Diagnostics;
using System.Runtime.Remoting.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Text.RegularExpressions;
using OsuTourneyRefHelper.Data.Settings;
using OsuTourneyRefHelper.Data.Mappool;
using OsuTourneyRefHelper.Data.Commands;
using System.Net;
using AutoUpdaterDotNET;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;
using System.Reflection;
using OsuTourneyRefHelper.Properties;
using OsuTourneyRefHelper.Data;

namespace OsuTourneyRefHelper
{
    public partial class MainForm : Form
    {
        string appPath = AppDomain.CurrentDomain.BaseDirectory;

        //[DllImport("user32.dll", EntryPoint = "FindWindow")]
        //private static extern IntPtr FindWindow(string lp1, string lp2);

        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        MapPoolManager poolManager = new MapPoolManager();
        CommandManager commManager;
        MapPool_OLD currentPool = null;
        //Beatmap previousPick = null;
        string previousMod = "";

        TabPage nmPage;
        TabPage hdPage;
        TabPage hrPage;
        TabPage dtPage;
        TabPage fmPage;
        TabPage tbPage;

        IntPtr osuIrcHandle;
        bool isIircConnected = false;

        Color defaultStageBackColor;

        bool isSending = false;

        public MainForm()
        {
            InitializeComponent();
            if (!Directory.Exists(appPath + "/Data"))
            {
                Console.WriteLine("Data dir doesn't exist, creating");
                Directory.CreateDirectory($"{appPath}/Data");
            }
            else
            {
                Console.WriteLine("Data dir exists.");
            }
            if (Directory.Exists(appPath + "/ApiKey"))
            {
                if (File.Exists($"{appPath}/ApiKey/Api.txt"))
                {
                    SettingsManager.ApiKey = File.ReadLines($"{appPath}/ApiKey/Api.txt").First();
                }
            }
            errorLbl.Location = new Point(172, 26);

            nmPage = nomodTabPage;
            hdPage = hiddenTabPage;
            hrPage = hardrockTabPage;
            dtPage = doubletimeTabPage;
            fmPage = freemodTabPage;
            tbPage = tiebreakerTabPage;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Initialize();
            if (CheckForProgramUpdate())
            {
                updateStripButt.BackColor = Color.LightGreen;
            }
            if (CheckForPoolUpdate())
            {
                poolStripButt.BackColor = Color.LightGreen;
                updatePoolToolStripMenuItem.BackColor = Color.LightGreen;
            }
        }
        public void Reset()
        {
            previousMod = "";
            currentPool = null;
            osuIrcHandle = IntPtr.Zero;
            isSending = false;
        }
        public void Initialize()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string assemblyVersion = fvi.FileVersion;

            SettingsManager.Version = assemblyVersion;
            InitializeSettings();
            LoadPools();

            //Console.WriteLine(poolManager.version);
            //SetupStageComBox();

            //Console.WriteLine(poolManager.ToString());

            defaultStageBackColor = stageComBox.BackColor;

            //string output = JsonConvert.SerializeObject(poolManager);
            //File.WriteAllText($"{appPath}/Data/Pools.json", JsonPrettify(output));
        }
        void InitializeSettings()
        {
            //CreateDummyPool();
            SettingsManager.Settings = LoadSettings();
            commManager = new CommandManager();

            LinkIirc();

            ChangeWindowTitle();
        }
        bool CheckForProgramUpdate()
        {
            XmlTextReader reader = new XmlTextReader("https://raw.githubusercontent.com/Iojioji/OsurRefHelper/dev/AutoUpdater.xml");
            bool nextIsVersion = false;
            string version = "";
            while (reader.Read())
            {
                if (nextIsVersion && reader.NodeType == XmlNodeType.Text)
                {
                    version = reader.Value;
                    break;
                }
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "version")
                {
                    Console.WriteLine("Hijuesu el siguiente es el bueno");
                    nextIsVersion = true;
                }
            }
            Console.WriteLine($"Latest version is '{version}', current is '{SettingsManager.Version}'");
            //MessageBox.Show($"Latest version is '{version}', current is '{SettingsManager.Version}'");

            return IsVersionNewer(SettingsManager.Version, version);
        }
        bool CheckForPoolUpdate()
        {
            MapPoolManager aux = new MapPoolManager();
            bool result = false;
            if (!string.IsNullOrEmpty(SettingsManager.Settings.Program.PoolURL))
            {
                try
                {
                    using (WebClient wc = new WebClient())
                    {
                        var json = wc.DownloadString(SettingsManager.Settings.Program.PoolURL);
                        aux = LoadPool(json);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Hijuesu, algo se rompio intentando descargar el pool de \r\n'{SettingsManager.Settings.Program.PoolURL}'\r\n\r\nMandale esto al menso del Iojioji\r\n\r\n{e.Message}", "Error inesperado al descargar el pool O:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
                if (poolManager.version == null)
                {
                    result = true;
                }
                else
                {
                    return IsVersionNewer(poolManager.version, aux.version);
                }

                return result;
            }
            else
            {
                //Hard set the current poolmanager to something else just to avoid null exceptions.
                //Move this code to somewhere less obfuscated pls.

                if (poolManager.version == null)
                {
                    poolManager.version = "0.0.0";
                }
                if (poolManager.pools_old.Count == 0)
                {
                    poolManager.pools_old.Add(new MapPool_OLD
                    {
                        Stage = "Crea tu pool pls",
                        nmPool = new List<Beatmap_OLD>(),
                        hdPool = new List<Beatmap_OLD>(),
                        hrPool = new List<Beatmap_OLD>(),
                        dtPool = new List<Beatmap_OLD>(),
                    });
                }
                return false;
            }
        }
        void LinkIirc()
        {
            try
            {
                if (SettingsManager.Settings.Program.DebuggingToNotepad)
                {
                    osuIrcHandle = WinGetHandle("Notepad");
                }
                else
                {
                    osuIrcHandle = WinGetHandle("chat4osu");
                }

                if (osuIrcHandle.Equals(IntPtr.Zero))
                {
                    errorLbl.Visible = true;
                    isIircConnected = false;
                }
                else
                {
                    errorLbl.Visible = false;
                    isIircConnected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void UpdateMappool(bool manualRequest = false)
        {
            if (CheckForPoolUpdate())
            {
                MapPoolManager aux = new MapPoolManager();
                try
                {
                    using (WebClient wc = new WebClient())
                    {
                        var json = wc.DownloadString(SettingsManager.Settings.Program.PoolURL);
                        aux = LoadPool(json);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Hijuesu, algo se rompio intentando descargar el pool de <link>\r\nMandale esto al menso del Iojioji\r\n\r\n{e.Message}", "Error inesperado al descargar el pool O:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                poolManager = aux;
                SavePool();
            }
            else if (manualRequest)
            {
                MessageBox.Show("No hay updates ahorita, checa mas tarde");
            }

            SetupStageComBox();
            //SwitchToStage("Qualifiers");
            SwitchToStage(0);
        }
        bool IsVersionNewer(string currentVersion, string newVersion)
        {
            Console.WriteLine($"Current Version: {currentVersion}, New Version: {newVersion}");
            string[] currentVer = currentVersion.Split('.');
            string[] newVer = newVersion.Split('.');

            if (currentVer.Length < newVer.Length)
            {
                return true;
            }
            for (int i = 0; i < currentVer.Length; i++)
            {
                int currentNumber = int.Parse(currentVer[i]);
                int newNumber = int.Parse(newVer[i]);
                if (newNumber > currentNumber)
                {
                    return true;
                }
                else if (newNumber < currentNumber)
                {
                    return false;
                }
            }
            return false;
        }
        void SetupStageComBox()
        {
            stageComBox.DataSource = poolManager.GetStageNames();
        }
        void LoadPools()
        {
            if (File.Exists($"{appPath}/Data/Pools.json"))
            {
                try
                {
                    poolManager = JsonConvert.DeserializeObject<MapPoolManager>(File.ReadAllText($"{appPath}/Data/Pools.json"));
                    SetupStageComBox();
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Hijuesu, algo se rompio intentando cargar el pool\r\nMandale esto al menso del Iojioji\r\n\r\n{e.Message}", "Error inesperado al cargar el pool O:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                UpdateMappool();
                //MessageBox.Show($"No se encontro el archivo de pools\r\nAsegurate que se encuentre en '{appPath}/Data' un archivo llamado Pools.json", "No pude cargar el pool :'c", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        MapPoolManager LoadPool(string json)
        {
            MapPoolManager aux = new MapPoolManager();
            try
            {
                aux = JsonConvert.DeserializeObject<MapPoolManager>(json);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hijuesu, algo se rompio intentando cargar el pool\r\nMandale esto al menso del Iojioji\r\n\r\n{e.Message}", "Error inesperado al cargar el pool O:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return aux;
        }
        void SavePool()
        {
            string output = JsonConvert.SerializeObject(poolManager);
            if (File.Exists($"{appPath}/Data/Pools.json"))
            {
                if (MessageBox.Show("Estas a punto de sobreescribir tu archivo de pools.\r\nQuieres guardar?", "Guardar Pools.json", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    File.WriteAllText($"{appPath}/Data/Pools.json", JsonPrettify(output));
                }
            }
            else
            {
                File.WriteAllText($"{appPath}/Data/Pools.json", JsonPrettify(output));
            }
        }
        void ChangeWindowTitle()
        {
            this.Text = $"{SettingsManager.Settings.Tournament.TourneyAcronym} Ref Helper{(SettingsManager.Settings.Program.DebuggingToNotepad ? "   ! ! ! DEBUGGING TO NOTEPAD ! ! !" : "")}";
        }
        SettingsCollection LoadSettings()
        {
            SettingsCollection aux = new SettingsCollection();
            if (File.Exists($"{appPath}/Data/Settings.json"))
            {
                try
                {
                    aux = JsonConvert.DeserializeObject<SettingsCollection>(File.ReadAllText($"{appPath}/Data/Settings.json"));
                    return aux;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Hijuesu, algo se rompio intentando los settings\r\nMandale esto al menso del Iojioji\r\n\r\n{e.Message}", "Error inesperado al cargar el pool O:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            else
            {
                MessageBox.Show($"No se encontro un archivo de configuracion valido, por favor configura el programa dando click en \"Preferencias\"", "Ref Helper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProgramSettings auxProgSett = new ProgramSettings() {
                    DebuggingToNotepad = false,
                    PoolURL = ""
                };
                TournamentSettings auxTourSett = new TournamentSettings() {
                    TourneyAcronym = "TRN",
                    TeamMode = TeamMode.TeamVs,
                    Scoring = ScoreMode.ScoreV2,
                    TeamSize = 2
                };

                aux.Program = auxProgSett;
                aux.Tournament = auxTourSett;

                return aux;
            }
        }
        void CreateDummyPool()
        {
            poolManager = new MapPoolManager();
            poolManager.version = "1.0.0.0";
            poolManager.pools_old.Add(new MapPool_OLD
            {
                Stage = "Qualifiers",
                nmPool = new List<Beatmap_OLD>() { new Beatmap_OLD(1, "wea", "El artista", "weon", "la wea loca", 123.33f, 5.21f, 0, 1), new Beatmap_OLD(2, "aew", "El artista", "noew", "aaaaaa la weaa", 30f, 2.44f, 0, 2) },
                hdPool = new List<Beatmap_OLD>() { new Beatmap_OLD(3, "weaHD", "El artista", "weon", "la wea loca", 123.33f, 5.21f, 1, 1) },
                hrPool = new List<Beatmap_OLD>() { new Beatmap_OLD(4, "weaHR", "El artista", "weon", "la wea loca", 123.33f, 5.21f, 2, 1) },
                dtPool = new List<Beatmap_OLD>() { new Beatmap_OLD(5, "weaDT", "El artista", "weon", "la wea loca", 123.33f, 5.21f, 3, 1) },
            });
            poolManager.pools_old.Add(new MapPool_OLD
            {
                Stage = "Groups",
                nmPool = new List<Beatmap_OLD>() { new Beatmap_OLD(1, "wea", "El artista", "weon", "la wea loca", 123.33f, 5.21f, 0, 1), new Beatmap_OLD(2, "aew", "El artista", "noew", "aaaaaa la weaa", 30f, 2.44f, 0, 2) },
                hdPool = new List<Beatmap_OLD>() { new Beatmap_OLD(3, "weaHD", "El artista", "weon", "la wea loca", 123.33f, 5.21f, 1, 1) },
                hrPool = new List<Beatmap_OLD>() { new Beatmap_OLD(4, "weaHR", "El artista", "weon", "la wea loca", 123.33f, 5.21f, 2, 1) },
                dtPool = new List<Beatmap_OLD>() { new Beatmap_OLD(5, "weaDT", "El artista", "weon", "la wea loca", 123.33f, 5.21f, 3, 1) },
                fmPool = new List<Beatmap_OLD>() { new Beatmap_OLD(6, "weaFM", "El artista", "weon", "la wea loca", 123.33f, 5.21f, 4, 1) },
                tbPool = new List<Beatmap_OLD>() { new Beatmap_OLD(7, "rompehuevos", "El artista", "el extrim", "a romper", 302.21f, 6.21f, 5, 1) },
            });
        }
        TournamentSettings CreateDummySettings()
        {
            return new TournamentSettings() { TourneyAcronym = "TTM", TeamMode = TeamMode.TeamVs, Scoring = ScoreMode.ScoreV2, TeamSize = 1 };
        }
        public string JsonPrettify(string json)
        {
            using (var stringReader = new StringReader(json))
            using (var stringWriter = new StringWriter())
            {
                var jsonReader = new JsonTextReader(stringReader);
                var jsonWriter = new JsonTextWriter(stringWriter) { Formatting = Formatting.Indented };
                jsonWriter.WriteToken(jsonReader);
                return stringWriter.ToString();
            }
        }
        public void SwitchToStage(string stageToSwitchTo)
        {
            try
            {
                currentPool = poolManager.pools_old.Find(x => x.Stage == stageToSwitchTo);
                commManager.CurrentPool = currentPool;
                ShowTabPages(false);
                ShowTabPages(true);
                RemoveAllButtonsFromTabs();
                AddButtonsToTabs();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hijuesu, algo se rompio intentando cambiar de pool\r\nMandale esto al menso del Iojioji\r\n\r\n{e.Message}", "Error inesperado al cambiar de pool O:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SwitchToStage(int stageToSwitchTo)
        {
            if (poolManager.pools_old.Count > stageToSwitchTo)
            {
                currentPool = poolManager.pools_old[stageToSwitchTo];
                commManager.CurrentPool = currentPool;
                ShowTabPages(false);
                ShowTabPages(true);
                RemoveAllButtonsFromTabs();
                AddButtonsToTabs();
            }
            else
            {
                Console.WriteLine("Error! Trying to access a pool that doesn't exist!");
            }
        }
        void ShowTabPages(bool show)
        {
            if (currentPool != null)
            {
                if (show)
                {
                    if (currentPool.nmPool.Count > 0)
                        tabMenu.TabPages.Add(nmPage);
                    if (currentPool.hdPool.Count > 0)
                        tabMenu.TabPages.Add(hdPage);
                    if (currentPool.hrPool.Count > 0)
                        tabMenu.TabPages.Add(hrPage);
                    if (currentPool.dtPool.Count > 0)
                        tabMenu.TabPages.Add(dtPage);
                    if (currentPool.fmPool.Count > 0)
                        tabMenu.TabPages.Add(fmPage);
                    if (currentPool.tbPool.Count > 0)
                        tabMenu.TabPages.Add(tbPage);
                }
                else
                {
                    tabMenu.TabPages.Remove(nmPage);
                    tabMenu.TabPages.Remove(hdPage);
                    tabMenu.TabPages.Remove(hrPage);
                    tabMenu.TabPages.Remove(dtPage);
                    tabMenu.TabPages.Remove(fmPage);
                    tabMenu.TabPages.Remove(tbPage);
                }
            }
        }

        void AddButtonsToTabs()
        {
            if (currentPool != null)
            {
                AddButtonsToTab(nomodButtFlowLayout, currentPool.nmPool, true);
                AddButtonsToTab(hiddenButtFlowLayout, currentPool.hdPool, true);
                AddButtonsToTab(hardrockButtFlowLayout, currentPool.hrPool, true);
                AddButtonsToTab(doubletimeButtFlowLayout, currentPool.dtPool, true);
                AddButtonsToTab(freemodButtFlowLayout, currentPool.fmPool, true);
                AddButtonsToTab(tiebreakerButtFlowLayout, currentPool.tbPool, true);
            }
            else
            {
                if (poolManager != null)
                {
                    //MessageBox.Show($"Ay, tu pool no existe\r\nMandale esto al menso del Iojioji\r\n\r\n{poolManager}", "Error de pool al crear los botoncitos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Ay, tu pool manager no existe\r\nCheca que Pools.json exista en \"{appPath}/Data\"", "Error de pool al crear los botoncitos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void AddButtonsToTab(FlowLayoutPanel panel, List<Beatmap_OLD> pool, bool modButton = false)
        {
            if (modButton)
            {
                if (pool.Count > 0)
                {
                    Button newButton = new Button();
                    newButton.Name = $"{pool[0].ToMod()}-{pool[0].MapCategory()}-ModButt";
                    newButton.Text = $"!mp mods {pool[0].ToMod()}";
                    newButton.Size = new Size(506, 30);
                    newButton.UseVisualStyleBackColor = true;
                    newButton.Click += new EventHandler(ModSelectButton_Click);

                    panel.Controls.Add(newButton);
                }
            }
            for (int i = 0; i < pool.Count; i++)
            {
                Button newButton = new Button();

                newButton.Name = $"{pool[i].MapCategory()}-Butt";
                //newButton.Text = $"{pool[i].MapCategory()}\r\n•{pool[i].Title}\r\n•{pool[i].Artist}\r\n•Diff: [{pool[i].DiffName}]\r\n•Mapper: {pool[i].Mapper}";
                //newButton.Text = $"{pool[i].MapCategory()}\r\n\r\n•{pool[i].Title}\r\n•{pool[i].Artist}\r\n•Mapper: {pool[i].Mapper}";
                newButton.Text = $"{pool[i].MapCategory()}\r\n\r\n•{pool[i].MapName()}\r\n•Mapper: {pool[i].Mapper}";
                newButton.Size = new Size(250, 60);
                newButton.UseVisualStyleBackColor = true;
                newButton.Click += new EventHandler(MapSelectButton_Click);

                panel.Controls.Add(newButton);
            }
        }

        void RemoveAllButtonsFromTabs()
        {
            RemoveButtonsFromTab(nomodButtFlowLayout);
            RemoveButtonsFromTab(hiddenButtFlowLayout);
            RemoveButtonsFromTab(hardrockButtFlowLayout);
            RemoveButtonsFromTab(doubletimeButtFlowLayout);
            RemoveButtonsFromTab(freemodButtFlowLayout);
            RemoveButtonsFromTab(tiebreakerButtFlowLayout);
        }

        void RemoveButtonsFromTab(FlowLayoutPanel panel)
        {
            //Console.WriteLine($"Removing buttons from {panel.Name} ({panel.Controls.Count} buttons)");
            for (int i = 0; i < panel.Controls.Count;)
            {
                Button aux = panel.Controls[i] as Button;
                Console.WriteLine($"{i}.- {aux.Name} - {aux.Text}");
                if (i == 0)
                {
                    aux.Click -= new EventHandler(ModSelectButton_Click);
                }
                else
                {
                    aux.Click -= new EventHandler(MapSelectButton_Click);
                }
                panel.Controls.Remove(aux);
                aux.Dispose();
            }
        }

        public async Task SendInput(string input, bool autoSend = true)
        {
            if (!isSending)
            {
                isSending = true;
                stageComBox.BackColor = Color.Red;
                //Console.WriteLine("isSending = true");
                try
                {
                    if (!osuIrcHandle.Equals(IntPtr.Zero))
                    {
                        if (SetForegroundWindow(osuIrcHandle))
                        {
                            //SendKeys.Send("{TAB}");
                            Console.WriteLine($">> {input}");
                            SendKeys.Send(Regex.Replace(input, "[+^%~()]", "{$0}"));
                            await Task.Delay(125);
                            if (autoSend)
                            {
                                Console.WriteLine("Disque mandando enter dice el vato");
                                SendKeys.Send("{ENTER}");
                                await Task.Delay(30);
                            }
                            Console.WriteLine($"Message sent '{input}'");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Handle not found");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    isSending = false;
                    stageComBox.BackColor = defaultStageBackColor;
                    //Console.WriteLine("isSending = false");
                }
            }
            else
            {
                SetForegroundWindow(osuIrcHandle);
                Console.WriteLine("Tried to start but it was sending");
            }
        }

        public IntPtr WinGetHandle(string wName)
        {
            IntPtr hWnd = new IntPtr();
            foreach (Process pList in Process.GetProcesses())
            {
                if (pList.MainWindowTitle.Contains(wName))
                {
                    hWnd = pList.MainWindowHandle;
                }
            }
            return hWnd;
        }

        #region events
        private void SwitchStage(object sender, EventArgs e)
        {
            //Console.WriteLine($"Switched stage to <{stageComBox.SelectedItem}>");
            SwitchToStage(stageComBox.SelectedItem.ToString());
        }

        private async void ModSelectButton_Click(object sender, EventArgs e)
        {
            Button objectClicked = (Button)sender;
            previousMod = objectClicked.Text.Split(' ')[2];
            await SendInput(objectClicked.Text);
        }

        private async void MapSelectButton_Click(object sender, EventArgs e)
        {
            Button objectClicked = (Button)sender;
            Beatmap_OLD selectedBeatmap = currentPool.GetBeatmap(objectClicked.Name.Split('-')[0]);
            if (previousMod != "")
            {
                if (previousMod != selectedBeatmap.ToMod())
                {
                    await SendInput($"!mp mods {selectedBeatmap.ToMod()}");
                }
            }
            else
            {
                await SendInput($"!mp mods {selectedBeatmap.ToMod()}");
            }

            await SendInput($"!mp map {selectedBeatmap.MapID}");

            previousMod = selectedBeatmap.ToMod();
            //Console.WriteLine($"previous pick was {previousPick}");
            Console.WriteLine($"previous mod was {previousMod}");
        }
        private void errorLblClick(object sender, EventArgs e)
        {
            Console.WriteLine("Clickeado el error si que si");
            LinkIirc();
        }
        private async void mpmakeBtn_Click(object sender, EventArgs e)
        {
            //await SendInput(commManager.Make(), false);
            if (stageComBox.SelectedItem.ToString() == "Qualifiers")
            {
                await SendInput($"!mp make {SettingsManager.Settings.Tournament.TourneyAcronym}: Qualifiers Lobby #<numerito>", false);
            }
            else
            {
                await SendInput($"!mp make {SettingsManager.Settings.Tournament.TourneyAcronym}: (<red>) vs (<blue>)", false);
            }
        }
        private async void mppasswordButt_Click(object sender, EventArgs e)
        {
            await SendInput(commManager.Pass());
        }
        private async void mpsetupButt_Click(object sender, EventArgs e)
        {
            Console.WriteLine(stageComBox.SelectedItem.ToString());
            if (stageComBox.SelectedItem.ToString() == "Qualifiers")
            {
                await SendInput("!mp set 0 3 16");
            }
            else
            {
                await SendInput(commManager.Set());
            }
        }
        private async void mpsettingsButt_Click(object sender, EventArgs e)
        {
            await SendInput("!mp settings");
        }
        private async void mpstart10Butt_Click(object sender, EventArgs e)
        {
            await SendInput("!mp start 10");
        }
        private async void mpabortButt_Click(object sender, EventArgs e)
        {
            await SendInput("!mp abort");
        }
        private async void mptimer_Click(object sender, EventArgs e)
        {
            await SendInput("!mp timer 120");
        }
        private async void mpaborttimerButt_Click(object sender, EventArgs e)
        {
            await SendInput("!mp aborttimer");
        }

        private async void mpinviteButt_Click(object sender, EventArgs e)
        {
            await SendInput("!mp invite <player>", false);
        }

        private async void mpcloseButt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas a punto de cerrar la sala.\r\n\r\nYa termino el match?\r\nYa enviaste el link de la sala a discord?", "! ! Estas a punto de cerrar la sala ! !", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                await SendInput("!mp close", false);
            }
        }
        private async void mpmoveButt_Click(object sender, EventArgs e)
        {
            await SendInput("!mp move <player> <slot>", false);
        }
        private async void mpteamButt_Click(object sender, EventArgs e)
        {
            await SendInput("!mp team <player> <color>", false);
        }
        private async void mplockButt_Click(object sender, EventArgs e)
        {
            await SendInput("!mp lock");
        }
        private async void mpunlockButt_Click(object sender, EventArgs e)
        {
            await SendInput("!mp unlock");
        }
        private async void extraButt_Click(object sender, EventArgs e)
        {
            await SendInput("(´◉◞౪◟◉)");
        }
        private void exportSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveSettingsDialog = new SaveFileDialog();
            saveSettingsDialog.Filter = "JSON file|*json";
            saveSettingsDialog.Title = "Exportar Settings";
            saveSettingsDialog.InitialDirectory = $"{appPath}/Data";
            if (saveSettingsDialog.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(saveSettingsDialog.FileName);
                string output = JsonConvert.SerializeObject(SettingsManager.Settings);
                File.WriteAllText(saveSettingsDialog.FileName, JsonPrettify(output));
            }

        }
        private void updatePoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMappool(true);
        }
        private void importPoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Do the explorer thing
            SavePool();
        }

        private void CheckUpdate_Click(object sender, EventArgs e)
        {
            if (CheckForProgramUpdate())
            {
                MessageBox.Show("Hay updates como no\r\nNomas picale a descargar y asi");
                AutoUpdater.Start("https://raw.githubusercontent.com/Iojioji/OsurRefHelper/dev/AutoUpdater.xml");

            }
            else
            {
                MessageBox.Show("No hay updates pendientes chavo");
            }
        }

        private void OpenPreferences_Click(object sender, EventArgs e)
        {
            SettingsForm settForm = new SettingsForm();
            Console.WriteLine("Opening the thing");
            settForm.ShowDialog();

            Console.WriteLine("Closed the thing");

            Initialize();
        }
        private void OpenPoolEditor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SettingsManager.ApiKey))
            {
                PoolEditorForm editorForm = new PoolEditorForm();
                Console.WriteLine("Opening premium editor como no");
                editorForm.SetPool(poolManager);
                editorForm.ShowDialog();

            }
            else
            {

            }
        }
        #endregion

    }
}