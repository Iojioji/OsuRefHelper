using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OsuTourneyRefHelper.Data;
using OsuTourneyRefHelper.Data.Mappool;

namespace OsuTourneyRefHelper.Controls
{
    public class PoolSectionControls
    {
        public PoolSection assignedSection;
        public Panel backgroundPanel;
        public CheckBox nmMod, hdMod, hrMod, ezMod, dtMod, ncMod, htMod, flMod, fmMod;
        List<CheckBox> modList = new List<CheckBox>();
        public Panel parentPanel;
        public Button addMapButt;
        public TextBox sectionName;
        public GroupBox stageModsGroBox;
        public Label sectionNameLbl;
        public Button removeSectionButt;
        PoolEditorForm poolEditorForm;

        public PoolSectionControls(Panel parent, PoolSection section, PoolEditorForm form)
        {
            parentPanel = parent;
            assignedSection = section;
            poolEditorForm = form;
            Initialize();
        }
        void Initialize()
        {
            backgroundPanel = new Panel();
            backgroundPanel.SuspendLayout();

            backgroundPanel.BackColor = SystemColors.Control;
            backgroundPanel.Name = $"{assignedSection.Name}-backPanel";
            backgroundPanel.Margin = new Padding(0);
            backgroundPanel.Size = new Size(640, 94);
            backgroundPanel.Location = new Point(0, 300);
            backgroundPanel.BorderStyle = BorderStyle.FixedSingle;
            parentPanel.Controls.Add(backgroundPanel);

            sectionName = new TextBox();
            sectionName.Location = new Point(6, 19);
            sectionName.Name = $"sectionNameTexBox-{assignedSection.Name}";
            sectionName.Text = assignedSection.Name;
            sectionName.Size = new Size(120, 20);
            sectionName.KeyUp += StageName_Enter;
            backgroundPanel.Controls.Add(sectionName);

            sectionNameLbl = new Label();
            sectionNameLbl.AutoSize = true;
            sectionNameLbl.Location = new Point(3, 3);
            sectionNameLbl.Size = new Size(112, 13);
            sectionNameLbl.Text = "Nombre de la seccion";
            backgroundPanel.Controls.Add(sectionNameLbl);

            addMapButt = new Button();
            addMapButt.Location = new Point(6, 44);
            addMapButt.Size = new Size(120, 23);
            addMapButt.Name = $"addMapButt-{assignedSection.Name}";
            addMapButt.Text = "Agregar Mapa";
            addMapButt.UseVisualStyleBackColor = true;
            backgroundPanel.Controls.Add(addMapButt);

            stageModsGroBox = new GroupBox();
            stageModsGroBox.Location = new Point(132, 3);
            stageModsGroBox.Name = $"stageModGroBox-{assignedSection.Name}";
            stageModsGroBox.Size = new Size(321, 85);
            stageModsGroBox.Text = $"Mods del Stage '{assignedSection.Name}'";
            backgroundPanel.Controls.Add(stageModsGroBox);

            removeSectionButt = new Button();
            removeSectionButt.Location = new Point(500, 60);
            removeSectionButt.Size = new Size(60, 23);
            removeSectionButt.Name = $"removeSectionButt-{assignedSection.Name}";
            removeSectionButt.Text = "Remover Seccion";
            removeSectionButt.UseVisualStyleBackColor = true;
            backgroundPanel.Controls.Add(removeSectionButt);

            CreateCheckBoxes();
            SetupEvents();
        }

        void SetupEvents()
        {
            removeSectionButt.Click += RemoveSection_Click;
        }
        void RemoveEvents()
        {
            removeSectionButt.Click -= RemoveSection_Click;



            nmMod.CheckedChanged -= ModCheck_Changed;

            hdMod.CheckedChanged -= ModCheck_Changed;

            hrMod.CheckedChanged -= ModCheck_Changed;

            ezMod.CheckedChanged -= ModCheck_Changed;

            dtMod.CheckedChanged -= ModCheck_Changed;

            ncMod.CheckedChanged -= ModCheck_Changed;

            htMod.CheckedChanged -= ModCheck_Changed;

            flMod.CheckedChanged -= ModCheck_Changed;

            fmMod.CheckedChanged -= ModCheck_Changed;
        }

        public void RemoveSection()
        {
            RemoveEvents();
            poolEditorForm.RemoveSection(this);
        }

        //private void RemoveSection_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //Forgive me lord for I have sinned
        void CreateCheckBoxes()
        {
            //modList = new List<CheckBox>() { new CheckBox(), new CheckBox(), new CheckBox(), new CheckBox(), new CheckBox(), new CheckBox(), new CheckBox(), new CheckBox(), new CheckBox() };

            nmMod = new CheckBox();
            nmMod.Name = $"nmModCheBox-{assignedSection.Name}";
            nmMod.Location = new Point(6, 18);
            nmMod.Text = "NM";

            hdMod = new CheckBox();
            hdMod.Name = $"hdModCheBox-{assignedSection.Name}";
            hdMod.Location = new Point(55, 18);
            hdMod.Text = "HD";

            hrMod = new CheckBox();
            hrMod.Name = $"hrModCheBox-{assignedSection.Name}";
            hrMod.Location = new Point(103, 18);
            hrMod.Text = "HR";

            ezMod = new CheckBox();
            ezMod.Name = $"ezModCheBox-{assignedSection.Name}";
            ezMod.Location = new Point(103, 41);
            ezMod.Text = "EZ";

            dtMod = new CheckBox();
            dtMod.Name = $"dtModCheBox-{assignedSection.Name}";
            dtMod.Location = new Point(151, 18);
            dtMod.Text = "DT";

            ncMod = new CheckBox();
            ncMod.Name = $"ncModCheBox-{assignedSection.Name}";
            ncMod.Location = new Point(151, 41);
            ncMod.Text = "NC";

            htMod = new CheckBox();
            htMod.Name = $"htModCheBox-{assignedSection.Name}";
            htMod.Location = new Point(151, 63);
            htMod.Text = "HT";

            flMod = new CheckBox();
            flMod.Name = $"flModCheBox-{assignedSection.Name}";
            flMod.Location = new Point(198, 18);
            flMod.Text = "FL";

            fmMod = new CheckBox();
            fmMod.Name = $"fmModCheBox-{assignedSection.Name}";
            fmMod.Location = new Point(242, 18);
            fmMod.Text = "FM";

            modList = new List<CheckBox>() { nmMod, hdMod, hrMod, ezMod, dtMod, ncMod, htMod, flMod, fmMod };

            for (int i = 0; i < modList.Count; i++)
            {
                modList[i].AutoSize = true;
                modList[i].Size = new Size(73, 17);
                modList[i].UseVisualStyleBackColor = true;
                modList[i].CheckedChanged += ModCheck_Changed;
                stageModsGroBox.Controls.Add(modList[i]);
            }
        }

        void SetModCheckBox(CheckBox toSet, bool isChecked)
        {
            if (toSet.Checked != isChecked)
            {
                toSet.Checked = isChecked;
            }
        }
        void NMDisableAllCheckBoxes()
        {
            SetModCheckBox(hdMod, false);
            SetModCheckBox(hrMod, false);
            SetModCheckBox(ezMod, false);
            SetModCheckBox(dtMod, false);
            SetModCheckBox(ncMod, false);
            SetModCheckBox(htMod, false);
            SetModCheckBox(flMod, false);
            SetModCheckBox(fmMod, false);
        }
        void FMDisableAllCheckBoxes()
        {
            SetModCheckBox(nmMod, false);
            SetModCheckBox(hdMod, false);
            SetModCheckBox(hrMod, false);
            SetModCheckBox(ezMod, false);
            SetModCheckBox(dtMod, false);
            SetModCheckBox(ncMod, false);
            SetModCheckBox(htMod, false);
            SetModCheckBox(flMod, false);
        }

        //Lmao forgive lord once again
        void AssignSelectedMods()
        {
            assignedSection.Mods.Clear();
            if (nmMod.Checked)
                assignedSection.Mods.Add(MapMod.NM);
            if (hdMod.Checked)
                assignedSection.Mods.Add(MapMod.HD);
            if (hrMod.Checked)
                assignedSection.Mods.Add(MapMod.HR);
            if (ezMod.Checked)
                assignedSection.Mods.Add(MapMod.EZ);
            if (dtMod.Checked)
                assignedSection.Mods.Add(MapMod.DT);
            if (ncMod.Checked)
                assignedSection.Mods.Add(MapMod.NC);
            if (htMod.Checked)
                assignedSection.Mods.Add(MapMod.HT);
            if (flMod.Checked)
                assignedSection.Mods.Add(MapMod.FL);
            if (fmMod.Checked)
                assignedSection.Mods.Add(MapMod.FM);
        }

        #region controlEvents
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
                        SetModCheckBox(ezMod, false);
                        SetModCheckBox(fmMod, false);
                        SetModCheckBox(nmMod, false);
                        break;
                    case "ez":
                        SetModCheckBox(hrMod, false);
                        SetModCheckBox(fmMod, false);
                        SetModCheckBox(nmMod, false);
                        break;
                    case "dt":
                        SetModCheckBox(ncMod, false);
                        SetModCheckBox(htMod, false);
                        SetModCheckBox(fmMod, false);
                        SetModCheckBox(nmMod, false);
                        break;
                    case "nc":
                        SetModCheckBox(dtMod, false);
                        SetModCheckBox(htMod, false);
                        SetModCheckBox(fmMod, false);
                        SetModCheckBox(nmMod, false);
                        break;
                    case "ht":
                        SetModCheckBox(dtMod, false);
                        SetModCheckBox(ncMod, false);
                        SetModCheckBox(fmMod, false);
                        SetModCheckBox(nmMod, false);
                        break;
                    case "fm":
                        FMDisableAllCheckBoxes();
                        break;
                }
            }
            Console.WriteLine($"Before assigning: {assignedSection}");
            AssignSelectedMods();
            Console.WriteLine($"After assigning: {assignedSection}");
        }
        private void StageName_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                assignedSection.Name = sectionName.Text;
                e.Handled = true;
            }
        }

        private void RemoveSection_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"Ayy me van a quitar unu");
        }
        #endregion
    }
}
