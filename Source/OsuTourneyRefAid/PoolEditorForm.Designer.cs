namespace OsuTourneyRefHelper.Data
{
    partial class PoolEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.poolStageSelection = new System.Windows.Forms.ListBox();
            this.addStageLbl = new System.Windows.Forms.Label();
            this.addStageButton = new System.Windows.Forms.Button();
            this.poolMainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.stageBackPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.stageInfoPanel = new System.Windows.Forms.Panel();
            this.stageNameTexBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sectionInfoPanel = new System.Windows.Forms.Panel();
            this.addMapButt = new System.Windows.Forms.Button();
            this.stageModGroBox = new System.Windows.Forms.GroupBox();
            this.fmModCheBox = new System.Windows.Forms.CheckBox();
            this.flModCheBox = new System.Windows.Forms.CheckBox();
            this.htModCheBox = new System.Windows.Forms.CheckBox();
            this.ncModCheBox = new System.Windows.Forms.CheckBox();
            this.dtModCheBox = new System.Windows.Forms.CheckBox();
            this.ezModCheBox = new System.Windows.Forms.CheckBox();
            this.hrModCheBox = new System.Windows.Forms.CheckBox();
            this.hdModCheBox = new System.Windows.Forms.CheckBox();
            this.nmModCheBox = new System.Windows.Forms.CheckBox();
            this.sectionNameTexBox = new System.Windows.Forms.TextBox();
            this.sectionNameLbl = new System.Windows.Forms.Label();
            this.addSectionPanel = new System.Windows.Forms.Panel();
            this.addSectionButt = new System.Windows.Forms.Button();
            this.savePoolButt = new System.Windows.Forms.Button();
            this.sectionGeneralPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.poolMainPanel.SuspendLayout();
            this.stageBackPanel.SuspendLayout();
            this.stageInfoPanel.SuspendLayout();
            this.sectionInfoPanel.SuspendLayout();
            this.stageModGroBox.SuspendLayout();
            this.addSectionPanel.SuspendLayout();
            this.sectionGeneralPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // poolStageSelection
            // 
            this.poolStageSelection.FormattingEnabled = true;
            this.poolStageSelection.Location = new System.Drawing.Point(12, 25);
            this.poolStageSelection.Name = "poolStageSelection";
            this.poolStageSelection.Size = new System.Drawing.Size(110, 199);
            this.poolStageSelection.TabIndex = 1;
            this.poolStageSelection.SelectedIndexChanged += new System.EventHandler(this.SwitchStage_Changed);
            // 
            // addStageLbl
            // 
            this.addStageLbl.AutoSize = true;
            this.addStageLbl.Location = new System.Drawing.Point(12, 9);
            this.addStageLbl.Name = "addStageLbl";
            this.addStageLbl.Size = new System.Drawing.Size(40, 13);
            this.addStageLbl.TabIndex = 3;
            this.addStageLbl.Text = "Stages";
            // 
            // addStageButton
            // 
            this.addStageButton.Location = new System.Drawing.Point(12, 230);
            this.addStageButton.Name = "addStageButton";
            this.addStageButton.Size = new System.Drawing.Size(110, 23);
            this.addStageButton.TabIndex = 4;
            this.addStageButton.Text = "Agregar Stage";
            this.addStageButton.UseVisualStyleBackColor = true;
            this.addStageButton.Click += new System.EventHandler(this.AddStage_Click);
            // 
            // poolMainPanel
            // 
            this.poolMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poolMainPanel.AutoScroll = true;
            this.poolMainPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.poolMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.poolMainPanel.Controls.Add(this.stageBackPanel);
            this.poolMainPanel.Controls.Add(this.addSectionPanel);
            this.poolMainPanel.Location = new System.Drawing.Point(128, 25);
            this.poolMainPanel.Name = "poolMainPanel";
            this.poolMainPanel.Size = new System.Drawing.Size(660, 384);
            this.poolMainPanel.TabIndex = 5;
            // 
            // stageBackPanel
            // 
            this.stageBackPanel.AutoScroll = true;
            this.stageBackPanel.AutoSize = true;
            this.stageBackPanel.Controls.Add(this.stageInfoPanel);
            this.stageBackPanel.Controls.Add(this.sectionGeneralPanel);
            this.stageBackPanel.Location = new System.Drawing.Point(0, 0);
            this.stageBackPanel.Margin = new System.Windows.Forms.Padding(0);
            this.stageBackPanel.Name = "stageBackPanel";
            this.stageBackPanel.Size = new System.Drawing.Size(640, 293);
            this.stageBackPanel.TabIndex = 5;
            // 
            // stageInfoPanel
            // 
            this.stageInfoPanel.BackColor = System.Drawing.SystemColors.Control;
            this.stageInfoPanel.Controls.Add(this.stageNameTexBox);
            this.stageInfoPanel.Controls.Add(this.label1);
            this.stageInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.stageInfoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.stageInfoPanel.Name = "stageInfoPanel";
            this.stageInfoPanel.Size = new System.Drawing.Size(640, 45);
            this.stageInfoPanel.TabIndex = 4;
            // 
            // stageNameTexBox
            // 
            this.stageNameTexBox.Location = new System.Drawing.Point(6, 19);
            this.stageNameTexBox.Name = "stageNameTexBox";
            this.stageNameTexBox.Size = new System.Drawing.Size(223, 20);
            this.stageNameTexBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Stage";
            // 
            // sectionInfoPanel
            // 
            this.sectionInfoPanel.BackColor = System.Drawing.SystemColors.Control;
            this.sectionInfoPanel.Controls.Add(this.addMapButt);
            this.sectionInfoPanel.Controls.Add(this.stageModGroBox);
            this.sectionInfoPanel.Controls.Add(this.sectionNameTexBox);
            this.sectionInfoPanel.Controls.Add(this.sectionNameLbl);
            this.sectionInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.sectionInfoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sectionInfoPanel.Name = "sectionInfoPanel";
            this.sectionInfoPanel.Size = new System.Drawing.Size(640, 94);
            this.sectionInfoPanel.TabIndex = 0;
            // 
            // addMapButt
            // 
            this.addMapButt.Location = new System.Drawing.Point(6, 44);
            this.addMapButt.Name = "addMapButt";
            this.addMapButt.Size = new System.Drawing.Size(120, 23);
            this.addMapButt.TabIndex = 4;
            this.addMapButt.Text = "Agregar Mapa";
            this.addMapButt.UseVisualStyleBackColor = true;
            // 
            // stageModGroBox
            // 
            this.stageModGroBox.Controls.Add(this.fmModCheBox);
            this.stageModGroBox.Controls.Add(this.flModCheBox);
            this.stageModGroBox.Controls.Add(this.htModCheBox);
            this.stageModGroBox.Controls.Add(this.ncModCheBox);
            this.stageModGroBox.Controls.Add(this.dtModCheBox);
            this.stageModGroBox.Controls.Add(this.ezModCheBox);
            this.stageModGroBox.Controls.Add(this.hrModCheBox);
            this.stageModGroBox.Controls.Add(this.hdModCheBox);
            this.stageModGroBox.Controls.Add(this.nmModCheBox);
            this.stageModGroBox.Location = new System.Drawing.Point(132, 3);
            this.stageModGroBox.Name = "stageModGroBox";
            this.stageModGroBox.Size = new System.Drawing.Size(321, 85);
            this.stageModGroBox.TabIndex = 3;
            this.stageModGroBox.TabStop = false;
            this.stageModGroBox.Text = "Mods del Stage";
            // 
            // fmModCheBox
            // 
            this.fmModCheBox.AutoSize = true;
            this.fmModCheBox.Location = new System.Drawing.Point(242, 18);
            this.fmModCheBox.Name = "fmModCheBox";
            this.fmModCheBox.Size = new System.Drawing.Size(73, 17);
            this.fmModCheBox.TabIndex = 8;
            this.fmModCheBox.Text = "FreeMods";
            this.fmModCheBox.UseVisualStyleBackColor = true;
            this.fmModCheBox.CheckedChanged += new System.EventHandler(this.ModCheck_Changed);
            // 
            // flModCheBox
            // 
            this.flModCheBox.AutoSize = true;
            this.flModCheBox.Location = new System.Drawing.Point(198, 18);
            this.flModCheBox.Name = "flModCheBox";
            this.flModCheBox.Size = new System.Drawing.Size(38, 17);
            this.flModCheBox.TabIndex = 7;
            this.flModCheBox.Text = "FL";
            this.flModCheBox.UseVisualStyleBackColor = true;
            this.flModCheBox.CheckedChanged += new System.EventHandler(this.ModCheck_Changed);
            // 
            // htModCheBox
            // 
            this.htModCheBox.AutoSize = true;
            this.htModCheBox.Location = new System.Drawing.Point(151, 63);
            this.htModCheBox.Name = "htModCheBox";
            this.htModCheBox.Size = new System.Drawing.Size(41, 17);
            this.htModCheBox.TabIndex = 6;
            this.htModCheBox.Text = "HT";
            this.htModCheBox.UseVisualStyleBackColor = true;
            this.htModCheBox.CheckedChanged += new System.EventHandler(this.ModCheck_Changed);
            // 
            // ncModCheBox
            // 
            this.ncModCheBox.AutoSize = true;
            this.ncModCheBox.Location = new System.Drawing.Point(151, 41);
            this.ncModCheBox.Name = "ncModCheBox";
            this.ncModCheBox.Size = new System.Drawing.Size(41, 17);
            this.ncModCheBox.TabIndex = 5;
            this.ncModCheBox.Text = "NC";
            this.ncModCheBox.UseVisualStyleBackColor = true;
            this.ncModCheBox.CheckedChanged += new System.EventHandler(this.ModCheck_Changed);
            // 
            // dtModCheBox
            // 
            this.dtModCheBox.AutoSize = true;
            this.dtModCheBox.Location = new System.Drawing.Point(151, 18);
            this.dtModCheBox.Name = "dtModCheBox";
            this.dtModCheBox.Size = new System.Drawing.Size(41, 17);
            this.dtModCheBox.TabIndex = 4;
            this.dtModCheBox.Text = "DT";
            this.dtModCheBox.UseVisualStyleBackColor = true;
            this.dtModCheBox.CheckedChanged += new System.EventHandler(this.ModCheck_Changed);
            // 
            // ezModCheBox
            // 
            this.ezModCheBox.AutoSize = true;
            this.ezModCheBox.Location = new System.Drawing.Point(103, 41);
            this.ezModCheBox.Name = "ezModCheBox";
            this.ezModCheBox.Size = new System.Drawing.Size(40, 17);
            this.ezModCheBox.TabIndex = 3;
            this.ezModCheBox.Text = "EZ";
            this.ezModCheBox.UseVisualStyleBackColor = true;
            this.ezModCheBox.CheckedChanged += new System.EventHandler(this.ModCheck_Changed);
            // 
            // hrModCheBox
            // 
            this.hrModCheBox.AutoSize = true;
            this.hrModCheBox.Location = new System.Drawing.Point(103, 18);
            this.hrModCheBox.Name = "hrModCheBox";
            this.hrModCheBox.Size = new System.Drawing.Size(42, 17);
            this.hrModCheBox.TabIndex = 2;
            this.hrModCheBox.Text = "HR";
            this.hrModCheBox.UseVisualStyleBackColor = true;
            this.hrModCheBox.CheckedChanged += new System.EventHandler(this.ModCheck_Changed);
            // 
            // hdModCheBox
            // 
            this.hdModCheBox.AutoSize = true;
            this.hdModCheBox.Location = new System.Drawing.Point(55, 18);
            this.hdModCheBox.Name = "hdModCheBox";
            this.hdModCheBox.Size = new System.Drawing.Size(42, 17);
            this.hdModCheBox.TabIndex = 1;
            this.hdModCheBox.Text = "HD";
            this.hdModCheBox.UseVisualStyleBackColor = true;
            this.hdModCheBox.CheckedChanged += new System.EventHandler(this.ModCheck_Changed);
            // 
            // nmModCheBox
            // 
            this.nmModCheBox.AutoSize = true;
            this.nmModCheBox.Location = new System.Drawing.Point(6, 18);
            this.nmModCheBox.Name = "nmModCheBox";
            this.nmModCheBox.Size = new System.Drawing.Size(43, 17);
            this.nmModCheBox.TabIndex = 0;
            this.nmModCheBox.Text = "NM";
            this.nmModCheBox.UseVisualStyleBackColor = true;
            this.nmModCheBox.CheckedChanged += new System.EventHandler(this.ModCheck_Changed);
            // 
            // sectionNameTexBox
            // 
            this.sectionNameTexBox.Location = new System.Drawing.Point(6, 19);
            this.sectionNameTexBox.Name = "sectionNameTexBox";
            this.sectionNameTexBox.Size = new System.Drawing.Size(120, 20);
            this.sectionNameTexBox.TabIndex = 1;
            // 
            // sectionNameLbl
            // 
            this.sectionNameLbl.AutoSize = true;
            this.sectionNameLbl.Location = new System.Drawing.Point(3, 3);
            this.sectionNameLbl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.sectionNameLbl.Name = "sectionNameLbl";
            this.sectionNameLbl.Size = new System.Drawing.Size(112, 13);
            this.sectionNameLbl.TabIndex = 0;
            this.sectionNameLbl.Text = "Nombre de la Seccion";
            // 
            // addSectionPanel
            // 
            this.addSectionPanel.BackColor = System.Drawing.SystemColors.Control;
            this.addSectionPanel.Controls.Add(this.addSectionButt);
            this.addSectionPanel.Location = new System.Drawing.Point(0, 293);
            this.addSectionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.addSectionPanel.Name = "addSectionPanel";
            this.addSectionPanel.Size = new System.Drawing.Size(640, 42);
            this.addSectionPanel.TabIndex = 4;
            // 
            // addSectionButt
            // 
            this.addSectionButt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addSectionButt.Location = new System.Drawing.Point(3, 3);
            this.addSectionButt.Name = "addSectionButt";
            this.addSectionButt.Size = new System.Drawing.Size(634, 36);
            this.addSectionButt.TabIndex = 0;
            this.addSectionButt.Text = "Agregar Seccion";
            this.addSectionButt.UseVisualStyleBackColor = true;
            this.addSectionButt.Click += new System.EventHandler(this.AddSection_Click);
            // 
            // savePoolButt
            // 
            this.savePoolButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savePoolButt.Location = new System.Drawing.Point(700, 415);
            this.savePoolButt.Name = "savePoolButt";
            this.savePoolButt.Size = new System.Drawing.Size(90, 23);
            this.savePoolButt.TabIndex = 0;
            this.savePoolButt.Text = "Guardar Pool";
            this.savePoolButt.UseVisualStyleBackColor = true;
            // 
            // sectionGeneralPanel
            // 
            this.sectionGeneralPanel.BackColor = System.Drawing.Color.Coral;
            this.sectionGeneralPanel.Controls.Add(this.sectionInfoPanel);
            this.sectionGeneralPanel.Location = new System.Drawing.Point(0, 45);
            this.sectionGeneralPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sectionGeneralPanel.Name = "sectionGeneralPanel";
            this.sectionGeneralPanel.Size = new System.Drawing.Size(640, 248);
            this.sectionGeneralPanel.TabIndex = 5;
            // 
            // PoolEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.savePoolButt);
            this.Controls.Add(this.poolMainPanel);
            this.Controls.Add(this.addStageButton);
            this.Controls.Add(this.addStageLbl);
            this.Controls.Add(this.poolStageSelection);
            this.Name = "PoolEditorForm";
            this.Text = "Editor de Pools";
            this.poolMainPanel.ResumeLayout(false);
            this.poolMainPanel.PerformLayout();
            this.stageBackPanel.ResumeLayout(false);
            this.stageInfoPanel.ResumeLayout(false);
            this.stageInfoPanel.PerformLayout();
            this.sectionInfoPanel.ResumeLayout(false);
            this.sectionInfoPanel.PerformLayout();
            this.stageModGroBox.ResumeLayout(false);
            this.stageModGroBox.PerformLayout();
            this.addSectionPanel.ResumeLayout(false);
            this.sectionGeneralPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox poolStageSelection;
        private System.Windows.Forms.Label addStageLbl;
        private System.Windows.Forms.Button addStageButton;
        private System.Windows.Forms.FlowLayoutPanel poolMainPanel;
        private System.Windows.Forms.Button savePoolButt;
        private System.Windows.Forms.Panel sectionInfoPanel;
        private System.Windows.Forms.Label sectionNameLbl;
        private System.Windows.Forms.TextBox sectionNameTexBox;
        private System.Windows.Forms.GroupBox stageModGroBox;
        private System.Windows.Forms.CheckBox nmModCheBox;
        private System.Windows.Forms.CheckBox hrModCheBox;
        private System.Windows.Forms.CheckBox hdModCheBox;
        private System.Windows.Forms.CheckBox ezModCheBox;
        private System.Windows.Forms.CheckBox fmModCheBox;
        private System.Windows.Forms.CheckBox flModCheBox;
        private System.Windows.Forms.CheckBox htModCheBox;
        private System.Windows.Forms.CheckBox ncModCheBox;
        private System.Windows.Forms.CheckBox dtModCheBox;
        private System.Windows.Forms.Panel addSectionPanel;
        private System.Windows.Forms.Button addSectionButt;
        private System.Windows.Forms.FlowLayoutPanel stageBackPanel;
        private System.Windows.Forms.Panel stageInfoPanel;
        private System.Windows.Forms.TextBox stageNameTexBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addMapButt;
        private System.Windows.Forms.FlowLayoutPanel sectionGeneralPanel;
    }
}