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

        public PoolSectionControls(Panel parent, PoolSection section)
        {
            parentPanel = parent;
            assignedSection = section;
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

            CreateCheckBoxes();
        }
        
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

            for (int  i = 0; i < modList.Count; i++)
            {
                modList[i].AutoSize = true;
                modList[i].Size = new Size(73, 17);
                modList[i].UseVisualStyleBackColor = true;
                modList[i].CheckedChanged += new EventHandler(ModCheck_Changed);
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
        }
        #endregion
    }
}
