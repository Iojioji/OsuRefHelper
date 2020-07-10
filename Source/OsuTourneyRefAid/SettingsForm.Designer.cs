namespace OsuTourneyRefHelper
{
    partial class SettingsForm
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
            this.settingsSection = new System.Windows.Forms.ListBox();
            this.settingsTabControl = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.poolUrlTexBox = new System.Windows.Forms.TextBox();
            this.notepadCheBox = new System.Windows.Forms.CheckBox();
            this.poolUrlLabel = new System.Windows.Forms.Label();
            this.tournamentTabPage = new System.Windows.Forms.TabPage();
            this.tourneyPlayersNumUpDow = new System.Windows.Forms.NumericUpDown();
            this.tourneyPlayersLbl = new System.Windows.Forms.Label();
            this.tourneySMComBox = new System.Windows.Forms.ComboBox();
            this.tourneySMLbl = new System.Windows.Forms.Label();
            this.tourneyTMComBox = new System.Windows.Forms.ComboBox();
            this.tourneyTMLbl = new System.Windows.Forms.Label();
            this.tourneyAcronymTexBox = new System.Windows.Forms.TextBox();
            this.tourneyAcronymLbl = new System.Windows.Forms.Label();
            this.saveSettingsButt = new System.Windows.Forms.Button();
            this.importSettingsButt = new System.Windows.Forms.Button();
            this.settingsTabControl.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.tournamentTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourneyPlayersNumUpDow)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsSection
            // 
            this.settingsSection.FormattingEnabled = true;
            this.settingsSection.Items.AddRange(new object[] {
            "General",
            "Tournament"});
            this.settingsSection.Location = new System.Drawing.Point(12, 12);
            this.settingsSection.Name = "settingsSection";
            this.settingsSection.Size = new System.Drawing.Size(100, 199);
            this.settingsSection.TabIndex = 0;
            this.settingsSection.SelectedIndexChanged += new System.EventHandler(this.ChangeSettingsSection);
            // 
            // settingsTabControl
            // 
            this.settingsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsTabControl.Controls.Add(this.generalTabPage);
            this.settingsTabControl.Controls.Add(this.tournamentTabPage);
            this.settingsTabControl.Location = new System.Drawing.Point(118, 7);
            this.settingsTabControl.Name = "settingsTabControl";
            this.settingsTabControl.SelectedIndex = 0;
            this.settingsTabControl.Size = new System.Drawing.Size(462, 205);
            this.settingsTabControl.TabIndex = 1;
            // 
            // generalTabPage
            // 
            this.generalTabPage.AutoScroll = true;
            this.generalTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.generalTabPage.Controls.Add(this.poolUrlTexBox);
            this.generalTabPage.Controls.Add(this.notepadCheBox);
            this.generalTabPage.Controls.Add(this.poolUrlLabel);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalTabPage.Size = new System.Drawing.Size(454, 179);
            this.generalTabPage.TabIndex = 0;
            this.generalTabPage.Text = "General";
            // 
            // poolUrlTexBox
            // 
            this.poolUrlTexBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poolUrlTexBox.Location = new System.Drawing.Point(6, 19);
            this.poolUrlTexBox.Name = "poolUrlTexBox";
            this.poolUrlTexBox.Size = new System.Drawing.Size(442, 20);
            this.poolUrlTexBox.TabIndex = 3;
            // 
            // notepadCheBox
            // 
            this.notepadCheBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.notepadCheBox.AutoSize = true;
            this.notepadCheBox.Location = new System.Drawing.Point(310, 123);
            this.notepadCheBox.Name = "notepadCheBox";
            this.notepadCheBox.Size = new System.Drawing.Size(118, 17);
            this.notepadCheBox.TabIndex = 2;
            this.notepadCheBox.Text = "Debug To Notepad";
            this.notepadCheBox.UseVisualStyleBackColor = true;
            // 
            // poolUrlLabel
            // 
            this.poolUrlLabel.AutoSize = true;
            this.poolUrlLabel.BackColor = System.Drawing.Color.Transparent;
            this.poolUrlLabel.Location = new System.Drawing.Point(6, 3);
            this.poolUrlLabel.Name = "poolUrlLabel";
            this.poolUrlLabel.Size = new System.Drawing.Size(60, 13);
            this.poolUrlLabel.TabIndex = 1;
            this.poolUrlLabel.Text = "Url del pool";
            // 
            // tournamentTabPage
            // 
            this.tournamentTabPage.AutoScroll = true;
            this.tournamentTabPage.Controls.Add(this.tourneyPlayersNumUpDow);
            this.tournamentTabPage.Controls.Add(this.tourneyPlayersLbl);
            this.tournamentTabPage.Controls.Add(this.tourneySMComBox);
            this.tournamentTabPage.Controls.Add(this.tourneySMLbl);
            this.tournamentTabPage.Controls.Add(this.tourneyTMComBox);
            this.tournamentTabPage.Controls.Add(this.tourneyTMLbl);
            this.tournamentTabPage.Controls.Add(this.tourneyAcronymTexBox);
            this.tournamentTabPage.Controls.Add(this.tourneyAcronymLbl);
            this.tournamentTabPage.Location = new System.Drawing.Point(4, 22);
            this.tournamentTabPage.Name = "tournamentTabPage";
            this.tournamentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tournamentTabPage.Size = new System.Drawing.Size(454, 179);
            this.tournamentTabPage.TabIndex = 1;
            this.tournamentTabPage.Text = "Tournament";
            this.tournamentTabPage.UseVisualStyleBackColor = true;
            // 
            // tourneyPlayersNumUpDow
            // 
            this.tourneyPlayersNumUpDow.Location = new System.Drawing.Point(260, 69);
            this.tourneyPlayersNumUpDow.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.tourneyPlayersNumUpDow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tourneyPlayersNumUpDow.Name = "tourneyPlayersNumUpDow";
            this.tourneyPlayersNumUpDow.ReadOnly = true;
            this.tourneyPlayersNumUpDow.Size = new System.Drawing.Size(56, 20);
            this.tourneyPlayersNumUpDow.TabIndex = 7;
            this.tourneyPlayersNumUpDow.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // tourneyPlayersLbl
            // 
            this.tourneyPlayersLbl.AutoSize = true;
            this.tourneyPlayersLbl.Location = new System.Drawing.Point(260, 53);
            this.tourneyPlayersLbl.Name = "tourneyPlayersLbl";
            this.tourneyPlayersLbl.Size = new System.Drawing.Size(57, 13);
            this.tourneyPlayersLbl.TabIndex = 6;
            this.tourneyPlayersLbl.Text = "Team Size";
            // 
            // tourneySMComBox
            // 
            this.tourneySMComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tourneySMComBox.FormattingEnabled = true;
            this.tourneySMComBox.Items.AddRange(new object[] {
            "Score",
            "Accuracy",
            "Combo",
            "Score V2"});
            this.tourneySMComBox.Location = new System.Drawing.Point(133, 69);
            this.tourneySMComBox.Name = "tourneySMComBox";
            this.tourneySMComBox.Size = new System.Drawing.Size(121, 21);
            this.tourneySMComBox.TabIndex = 5;
            // 
            // tourneySMLbl
            // 
            this.tourneySMLbl.AutoSize = true;
            this.tourneySMLbl.Location = new System.Drawing.Point(133, 53);
            this.tourneySMLbl.Name = "tourneySMLbl";
            this.tourneySMLbl.Size = new System.Drawing.Size(73, 13);
            this.tourneySMLbl.TabIndex = 4;
            this.tourneySMLbl.Text = "Scoring Mode";
            // 
            // tourneyTMComBox
            // 
            this.tourneyTMComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tourneyTMComBox.FormattingEnabled = true;
            this.tourneyTMComBox.Items.AddRange(new object[] {
            "Head To Head",
            "Tag Coop",
            "Team Vs",
            "Tag Team Vs"});
            this.tourneyTMComBox.Location = new System.Drawing.Point(6, 69);
            this.tourneyTMComBox.Name = "tourneyTMComBox";
            this.tourneyTMComBox.Size = new System.Drawing.Size(121, 21);
            this.tourneyTMComBox.TabIndex = 3;
            // 
            // tourneyTMLbl
            // 
            this.tourneyTMLbl.AutoSize = true;
            this.tourneyTMLbl.Location = new System.Drawing.Point(6, 53);
            this.tourneyTMLbl.Name = "tourneyTMLbl";
            this.tourneyTMLbl.Size = new System.Drawing.Size(64, 13);
            this.tourneyTMLbl.TabIndex = 2;
            this.tourneyTMLbl.Text = "Team Mode";
            // 
            // tourneyAcronymTexBox
            // 
            this.tourneyAcronymTexBox.Location = new System.Drawing.Point(6, 19);
            this.tourneyAcronymTexBox.Name = "tourneyAcronymTexBox";
            this.tourneyAcronymTexBox.Size = new System.Drawing.Size(64, 20);
            this.tourneyAcronymTexBox.TabIndex = 1;
            // 
            // tourneyAcronymLbl
            // 
            this.tourneyAcronymLbl.AutoSize = true;
            this.tourneyAcronymLbl.Location = new System.Drawing.Point(6, 3);
            this.tourneyAcronymLbl.Name = "tourneyAcronymLbl";
            this.tourneyAcronymLbl.Size = new System.Drawing.Size(51, 13);
            this.tourneyAcronymLbl.TabIndex = 0;
            this.tourneyAcronymLbl.Text = "Acronimo";
            // 
            // saveSettingsButt
            // 
            this.saveSettingsButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSettingsButt.Location = new System.Drawing.Point(505, 218);
            this.saveSettingsButt.Name = "saveSettingsButt";
            this.saveSettingsButt.Size = new System.Drawing.Size(75, 23);
            this.saveSettingsButt.TabIndex = 3;
            this.saveSettingsButt.Text = "Guardars";
            this.saveSettingsButt.UseVisualStyleBackColor = true;
            this.saveSettingsButt.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // importSettingsButt
            // 
            this.importSettingsButt.Location = new System.Drawing.Point(424, 218);
            this.importSettingsButt.Name = "importSettingsButt";
            this.importSettingsButt.Size = new System.Drawing.Size(75, 23);
            this.importSettingsButt.TabIndex = 4;
            this.importSettingsButt.Text = "Importars";
            this.importSettingsButt.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(592, 253);
            this.Controls.Add(this.importSettingsButt);
            this.Controls.Add(this.saveSettingsButt);
            this.Controls.Add(this.settingsTabControl);
            this.Controls.Add(this.settingsSection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.settingsTabControl.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.generalTabPage.PerformLayout();
            this.tournamentTabPage.ResumeLayout(false);
            this.tournamentTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourneyPlayersNumUpDow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox settingsSection;
        private System.Windows.Forms.TabControl settingsTabControl;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.TabPage tournamentTabPage;
        private System.Windows.Forms.CheckBox notepadCheBox;
        private System.Windows.Forms.Label poolUrlLabel;
        private System.Windows.Forms.Button saveSettingsButt;
        private System.Windows.Forms.TextBox poolUrlTexBox;
        private System.Windows.Forms.Label tourneyAcronymLbl;
        private System.Windows.Forms.TextBox tourneyAcronymTexBox;
        private System.Windows.Forms.Label tourneyTMLbl;
        private System.Windows.Forms.ComboBox tourneyTMComBox;
        private System.Windows.Forms.ComboBox tourneySMComBox;
        private System.Windows.Forms.Label tourneySMLbl;
        private System.Windows.Forms.NumericUpDown tourneyPlayersNumUpDow;
        private System.Windows.Forms.Label tourneyPlayersLbl;
        private System.Windows.Forms.Button importSettingsButt;
    }
}