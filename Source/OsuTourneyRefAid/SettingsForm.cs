using Newtonsoft.Json;
using OsuTourneyRefHelper.Data.Settings;
using OsuTourneyRefHelper.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuTourneyRefHelper
{
    public partial class SettingsForm : Form
    {
        string appPath = AppDomain.CurrentDomain.BaseDirectory;


        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            InitializeSettings();
            settingsTabControl.Appearance = TabAppearance.FlatButtons;
            settingsTabControl.ItemSize = new Size(0, 1);
            settingsTabControl.SizeMode = TabSizeMode.Fixed;

            LoadSettings();
        }
        void InitializeSettings()
        {
            //CreateDummyPool();
            settingsSection.SelectedIndex = 0;
        }
        void ApplySettings()
        {
            SettingsManager.Settings.Program.DebuggingToNotepad = notepadCheBox.Checked;
            SettingsManager.Settings.Program.PoolURL = poolUrlTexBox.Text;

            SettingsManager.Settings.Tournament.TourneyAcronym = tourneyAcronymTexBox.Text;
            SettingsManager.Settings.Tournament.TeamMode = (TeamMode)tourneyTMComBox.SelectedIndex;
            SettingsManager.Settings.Tournament.Scoring = (ScoreMode)tourneySMComBox.SelectedIndex;
            SettingsManager.Settings.Tournament.TeamSize = (int)tourneyPlayersNumUpDow.Value;
            SettingsManager.Settings.Tournament.ForceNF = ForceNFCheBox.Checked;
        }
        void LoadSettings()
        {
            notepadCheBox.Checked = SettingsManager.Settings.Program.DebuggingToNotepad;
            poolUrlTexBox.Text = SettingsManager.Settings.Program.PoolURL;

            tourneyAcronymTexBox.Text = SettingsManager.Settings.Tournament.TourneyAcronym;
            tourneyTMComBox.SelectedIndex = (int)SettingsManager.Settings.Tournament.TeamMode;
            tourneySMComBox.SelectedIndex = (int)SettingsManager.Settings.Tournament.Scoring;
            tourneyPlayersNumUpDow.Value = SettingsManager.Settings.Tournament.TeamSize;
            ForceNFCheBox.Checked = SettingsManager.Settings.Tournament.ForceNF;
        }
        void SaveSettings()
        {
            string output = JsonConvert.SerializeObject(SettingsManager.Settings);
            File.WriteAllText($"{appPath}/Data/Settings.json", JsonPrettify(output));
            MessageBox.Show("Se ha guardado exitosamente");
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
        private void ChangeSettingsSection(object sender, EventArgs e)
        {
            Console.WriteLine(settingsSection.SelectedIndex);
            Console.WriteLine(settingsTabControl.TabPages[settingsSection.SelectedIndex].Focus());
            settingsTabControl.SelectTab(settingsSection.SelectedIndex);
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            ApplySettings();
            SaveSettings();
        }
    }
}
