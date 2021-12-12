using OsuTourneyRefHelper.Data.Mappool;
using OsuTourneyRefHelper.Data.Settings;
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
using OsuTourneyRefHelper.Controls;

namespace OsuTourneyRefHelper.Data
{
    public partial class PoolEditorForm : Form
    {
        string appPath = AppDomain.CurrentDomain.BaseDirectory;

        bool isPremium;
        MapPoolManager poolManager = new MapPoolManager();
        List<PoolSectionControls> currentSections = new List<PoolSectionControls>();

        int currentlySelectedStage = -1;
        public PoolEditorForm()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            isPremium = !string.IsNullOrEmpty(SettingsManager.ApiKey);
            //LoadPools();
            sectionInfoPanel.Visible = false;
        }
        public void SetPool(MapPoolManager toUse)
        {
            poolManager = toUse;
            SetupStageComBox();
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
                //UpdateMappool();
                //MessageBox.Show($"No se encontro el archivo de pools\r\nAsegurate que se encuentre en '{appPath}/Data' un archivo llamado Pools.json", "No pude cargar el pool :'c", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void FillInfoData()
        {
            PoolStage auxStage = poolManager.stages[poolStageSelection.SelectedIndex];
            stageNameTexBox.Text = auxStage.Name;
            //Fill sections
            LoadSections();
        }
        void LoadSections()
        {
            for (int i = 0; i < poolManager.stages[poolStageSelection.SelectedIndex].Sections.Count; i++)
            {
                CreateSection(sectionGeneralPanel, poolManager.stages[poolStageSelection.SelectedIndex].Sections[i]);
                //sectionGeneralPanel.Controls.Add(poolManager.stages[poolStageSelection.SelectedIndex].Sections[i]);
            }
        }
        void AddStage()
        {
            poolManager.stages.Add(new PoolStage()
            {
                Name = "Stage_" + (poolManager.stages.Count + 1),
            });
            SetupStageComBox();
        }

        void SetupStageComBox()
        {
            if (poolManager.stages.Count > 0)
            {
                List<string> stages = new List<string>();
                for (int i = 0; i < poolManager.stages.Count; i++)
                {
                    stages.Add(poolManager.stages[i].Name);
                }
                poolStageSelection.DataSource = stages;
                //stageComBox.DataSource = poolManager.GetStageNames();
            }
            else
            {
                Console.WriteLine("New Pools is empty dude");
            }
        }
        //Forgive me lord, for I have sinned
        List<MapMod> GetModString()
        {
            List<MapMod> aux = new List<MapMod>();

            if (hdModCheBox.Checked)
            {
                aux.Add(MapMod.NM);
            }
            else
            {
                if (fmModCheBox.Checked)
                {
                    aux.Add(MapMod.FM);
                }
                else
                {
                    if (hdModCheBox.Checked)
                    {
                        aux.Add(MapMod.HD);
                    }
                    if (hrModCheBox.Checked)
                    {
                        aux.Add(MapMod.HR);
                    }
                    else if (ezModCheBox.Checked)
                    {
                        aux.Add(MapMod.EZ);
                    }
                    if (flModCheBox.Checked)
                    {
                        aux.Add(MapMod.FL);
                    }
                    if (dtModCheBox.Checked)
                    {
                        aux.Add(MapMod.DT);
                    }
                    else if (ncModCheBox.Checked)
                    {
                        aux.Add(MapMod.NC);
                    }
                    else if (htModCheBox.Checked)
                    {
                        aux.Add(MapMod.HT);
                    }
                }
            }

            if (aux.Count == 0)
            {
                aux.Add(MapMod.FM);
            }
            return aux;
        }
        void setModCheckBox(CheckBox toSet, bool isChecked)
        {
            if (toSet.Checked != isChecked)
            {
                toSet.Checked = isChecked;
            }
        }
        void NMDisableAllCheckBoxes()
        {
            setModCheckBox(hdModCheBox, false);
            setModCheckBox(hrModCheBox, false);
            setModCheckBox(ezModCheBox, false);
            setModCheckBox(dtModCheBox, false);
            setModCheckBox(ncModCheBox, false);
            setModCheckBox(htModCheBox, false);
            setModCheckBox(flModCheBox, false);
            setModCheckBox(fmModCheBox, false);
        }
        void FMDisableAllCheckBoxes()
        {
            setModCheckBox(nmModCheBox, false);
            setModCheckBox(hdModCheBox, false);
            setModCheckBox(hrModCheBox, false);
            setModCheckBox(ezModCheBox, false);
            setModCheckBox(dtModCheBox, false);
            setModCheckBox(ncModCheBox, false);
            setModCheckBox(htModCheBox, false);
            setModCheckBox(flModCheBox, false);
        }
        void CreateSection(FlowLayoutPanel toAddTo, PoolSection toCreate)
        {
            PoolSectionControls auxPSC = new PoolSectionControls(toAddTo, toCreate, this);
        }
        void CreateSection()
        {
            PoolSectionControls auxPSC = new PoolSectionControls(sectionGeneralPanel, new PoolSection() { Name = $"Section{currentSections.Count + 1}" }, this);
            currentSections.Add(auxPSC);
            poolManager.stages[poolStageSelection.SelectedIndex].Sections.Add(auxPSC.assignedSection);
            Console.WriteLine($"Controls in panel: {sectionGeneralPanel.Controls.Count}");
        }
        public void RemoveSection(PoolSectionControls controls)
        {
            //if (sectionGeneralPanel.Controls.Contains())
        }
        void ClearSections()
        {
            int objectsToRemove = sectionGeneralPanel.Controls.Count;
            for (int i = 0; i < objectsToRemove; i++)
            {
                sectionGeneralPanel.Controls.RemoveAt(0);
                Console.WriteLine($"Controls in panel: {sectionGeneralPanel.Controls.Count}");
            }
        }

        #region events
        private void AddStage_Click(object sender, EventArgs e)
        {
            AddStage();
        }
        private void AddSection_Click(object sender, EventArgs e)
        {
            CreateSection();
        }

        private void SwitchStage_Changed(object sender, EventArgs e)
        {
            ListBox newStage = sender as ListBox;
            addSectionButt.Enabled = newStage.SelectedIndex != -1;
            if (newStage.SelectedIndex != currentlySelectedStage)
            {
                currentlySelectedStage = newStage.SelectedIndex;
                ClearSections();
                FillInfoData();
                Console.WriteLine(poolManager.ToString());
            }
        }

        //God, forgive me for what I'm about to do
        private void ModCheck_Changed(object sender, EventArgs e)
        {
            CheckBox clickedObject = sender as CheckBox;
            string name = clickedObject.Name.Substring(0, 2);
            bool isChecked = clickedObject.Checked;
            Console.WriteLine(name);
            if (isChecked)
            {
                switch (name)
                {
                    case "nm":
                        NMDisableAllCheckBoxes();
                        break;
                    case "hr":
                        setModCheckBox(ezModCheBox, false);
                        setModCheckBox(fmModCheBox, false);
                        setModCheckBox(nmModCheBox, false);
                        break;
                    case "ez":
                        setModCheckBox(hrModCheBox, false);
                        setModCheckBox(fmModCheBox, false);
                        setModCheckBox(nmModCheBox, false);
                        break;
                    case "dt":
                        setModCheckBox(ncModCheBox, false);
                        setModCheckBox(htModCheBox, false);
                        setModCheckBox(fmModCheBox, false);
                        setModCheckBox(nmModCheBox, false);
                        break;
                    case "nc":
                        setModCheckBox(dtModCheBox, false);
                        setModCheckBox(htModCheBox, false);
                        setModCheckBox(fmModCheBox, false);
                        setModCheckBox(nmModCheBox, false);
                        break;
                    case "ht":
                        setModCheckBox(dtModCheBox, false);
                        setModCheckBox(ncModCheBox, false);
                        setModCheckBox(fmModCheBox, false);
                        setModCheckBox(nmModCheBox, false);
                        break;
                    case "fm":
                        FMDisableAllCheckBoxes();
                        break;
                }
            }
        }
        #endregion

    }
}