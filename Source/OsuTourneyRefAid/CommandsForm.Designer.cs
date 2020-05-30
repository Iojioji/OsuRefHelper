namespace OsuTourneyRefAid
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.generalButtFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.mpmakeButt = new System.Windows.Forms.Button();
            this.mppasswordButt = new System.Windows.Forms.Button();
            this.mpsetupButt = new System.Windows.Forms.Button();
            this.mpinviteButt = new System.Windows.Forms.Button();
            this.mpmoveButt = new System.Windows.Forms.Button();
            this.mpteamButt = new System.Windows.Forms.Button();
            this.mplockButt = new System.Windows.Forms.Button();
            this.mpunlockButt = new System.Windows.Forms.Button();
            this.extraButt = new System.Windows.Forms.Button();
            this.mpcloseButt = new System.Windows.Forms.Button();
            this.nomodTabPage = new System.Windows.Forms.TabPage();
            this.nomodButtFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.hiddenTabPage = new System.Windows.Forms.TabPage();
            this.hiddenButtFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.hardrockTabPage = new System.Windows.Forms.TabPage();
            this.hardrockButtFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.doubletimeTabPage = new System.Windows.Forms.TabPage();
            this.doubletimeButtFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.freemodTabPage = new System.Windows.Forms.TabPage();
            this.freemodButtFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.tiebreakerTabPage = new System.Windows.Forms.TabPage();
            this.tiebreakerButtFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.stageComBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.mpsettingsButt = new System.Windows.Forms.Button();
            this.mpstart10Butt = new System.Windows.Forms.Button();
            this.mpabortButt = new System.Windows.Forms.Button();
            this.mpaborttimerButt = new System.Windows.Forms.Button();
            this.mptimer = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabMenu.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.generalButtFlowLayout.SuspendLayout();
            this.nomodTabPage.SuspendLayout();
            this.hiddenTabPage.SuspendLayout();
            this.hardrockTabPage.SuspendLayout();
            this.doubletimeTabPage.SuspendLayout();
            this.freemodTabPage.SuspendLayout();
            this.tiebreakerTabPage.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.generalTabPage);
            this.tabMenu.Controls.Add(this.nomodTabPage);
            this.tabMenu.Controls.Add(this.hiddenTabPage);
            this.tabMenu.Controls.Add(this.hardrockTabPage);
            this.tabMenu.Controls.Add(this.doubletimeTabPage);
            this.tabMenu.Controls.Add(this.freemodTabPage);
            this.tabMenu.Controls.Add(this.tiebreakerTabPage);
            this.tabMenu.Location = new System.Drawing.Point(12, 64);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(538, 289);
            this.tabMenu.TabIndex = 0;
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.generalButtFlowLayout);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalTabPage.Size = new System.Drawing.Size(530, 263);
            this.generalTabPage.TabIndex = 0;
            this.generalTabPage.Text = "General";
            this.generalTabPage.UseVisualStyleBackColor = true;
            // 
            // generalButtFlowLayout
            // 
            this.generalButtFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalButtFlowLayout.AutoScroll = true;
            this.generalButtFlowLayout.Controls.Add(this.mpmakeButt);
            this.generalButtFlowLayout.Controls.Add(this.mppasswordButt);
            this.generalButtFlowLayout.Controls.Add(this.mpsetupButt);
            this.generalButtFlowLayout.Controls.Add(this.mpinviteButt);
            this.generalButtFlowLayout.Controls.Add(this.mpmoveButt);
            this.generalButtFlowLayout.Controls.Add(this.mpteamButt);
            this.generalButtFlowLayout.Controls.Add(this.mplockButt);
            this.generalButtFlowLayout.Controls.Add(this.mpunlockButt);
            this.generalButtFlowLayout.Controls.Add(this.extraButt);
            this.generalButtFlowLayout.Controls.Add(this.mpcloseButt);
            this.generalButtFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.generalButtFlowLayout.Name = "generalButtFlowLayout";
            this.generalButtFlowLayout.Size = new System.Drawing.Size(530, 263);
            this.generalButtFlowLayout.TabIndex = 0;
            // 
            // mpmakeButt
            // 
            this.mpmakeButt.Location = new System.Drawing.Point(3, 3);
            this.mpmakeButt.Name = "mpmakeButt";
            this.mpmakeButt.Size = new System.Drawing.Size(165, 60);
            this.mpmakeButt.TabIndex = 0;
            this.mpmakeButt.Text = "1.- Make MP Room";
            this.mpmakeButt.UseVisualStyleBackColor = true;
            this.mpmakeButt.Click += new System.EventHandler(this.mpmakeBtn_Click);
            // 
            // mppasswordButt
            // 
            this.mppasswordButt.Location = new System.Drawing.Point(174, 3);
            this.mppasswordButt.Name = "mppasswordButt";
            this.mppasswordButt.Size = new System.Drawing.Size(165, 60);
            this.mppasswordButt.TabIndex = 1;
            this.mppasswordButt.Text = "2.- Set Password";
            this.mppasswordButt.UseVisualStyleBackColor = true;
            this.mppasswordButt.Click += new System.EventHandler(this.mppasswordButt_Click);
            // 
            // mpsetupButt
            // 
            this.mpsetupButt.Location = new System.Drawing.Point(345, 3);
            this.mpsetupButt.Name = "mpsetupButt";
            this.mpsetupButt.Size = new System.Drawing.Size(165, 60);
            this.mpsetupButt.TabIndex = 2;
            this.mpsetupButt.Text = "3.- Setup  Room";
            this.mpsetupButt.UseVisualStyleBackColor = true;
            this.mpsetupButt.Click += new System.EventHandler(this.mpsetupButt_Click);
            // 
            // mpinviteButt
            // 
            this.mpinviteButt.Location = new System.Drawing.Point(3, 69);
            this.mpinviteButt.Name = "mpinviteButt";
            this.mpinviteButt.Size = new System.Drawing.Size(165, 60);
            this.mpinviteButt.TabIndex = 3;
            this.mpinviteButt.Text = "4.- Invite <Player>";
            this.mpinviteButt.UseVisualStyleBackColor = true;
            this.mpinviteButt.Click += new System.EventHandler(this.mpinviteButt_Click);
            // 
            // mpmoveButt
            // 
            this.mpmoveButt.Location = new System.Drawing.Point(174, 69);
            this.mpmoveButt.Name = "mpmoveButt";
            this.mpmoveButt.Size = new System.Drawing.Size(165, 60);
            this.mpmoveButt.TabIndex = 4;
            this.mpmoveButt.Text = "Move <player> to <slot>";
            this.mpmoveButt.UseVisualStyleBackColor = true;
            this.mpmoveButt.Click += new System.EventHandler(this.mpmoveButt_Click);
            // 
            // mpteamButt
            // 
            this.mpteamButt.Location = new System.Drawing.Point(345, 69);
            this.mpteamButt.Name = "mpteamButt";
            this.mpteamButt.Size = new System.Drawing.Size(165, 60);
            this.mpteamButt.TabIndex = 5;
            this.mpteamButt.Text = "Set <team> to <player>";
            this.mpteamButt.UseVisualStyleBackColor = true;
            this.mpteamButt.Click += new System.EventHandler(this.mpteamButt_Click);
            // 
            // mplockButt
            // 
            this.mplockButt.Location = new System.Drawing.Point(3, 135);
            this.mplockButt.Name = "mplockButt";
            this.mplockButt.Size = new System.Drawing.Size(165, 60);
            this.mplockButt.TabIndex = 6;
            this.mplockButt.Text = "Lock Room";
            this.mplockButt.UseVisualStyleBackColor = true;
            this.mplockButt.Click += new System.EventHandler(this.mplockButt_Click);
            // 
            // mpunlockButt
            // 
            this.mpunlockButt.Location = new System.Drawing.Point(174, 135);
            this.mpunlockButt.Name = "mpunlockButt";
            this.mpunlockButt.Size = new System.Drawing.Size(165, 60);
            this.mpunlockButt.TabIndex = 8;
            this.mpunlockButt.Text = "Unlock Room";
            this.mpunlockButt.UseVisualStyleBackColor = true;
            this.mpunlockButt.Click += new System.EventHandler(this.mpunlockButt_Click);
            // 
            // extraButt
            // 
            this.extraButt.Location = new System.Drawing.Point(345, 135);
            this.extraButt.Name = "extraButt";
            this.extraButt.Size = new System.Drawing.Size(165, 60);
            this.extraButt.TabIndex = 9;
            this.extraButt.Text = "(´◉◞౪◟◉)";
            this.extraButt.UseVisualStyleBackColor = true;
            this.extraButt.Click += new System.EventHandler(this.extraButt_Click);
            // 
            // mpcloseButt
            // 
            this.mpcloseButt.ForeColor = System.Drawing.Color.Red;
            this.mpcloseButt.Location = new System.Drawing.Point(3, 201);
            this.mpcloseButt.Name = "mpcloseButt";
            this.mpcloseButt.Size = new System.Drawing.Size(165, 60);
            this.mpcloseButt.TabIndex = 7;
            this.mpcloseButt.Text = "!! Close Room !!";
            this.mpcloseButt.UseVisualStyleBackColor = true;
            this.mpcloseButt.Click += new System.EventHandler(this.mpcloseButt_Click);
            // 
            // nomodTabPage
            // 
            this.nomodTabPage.Controls.Add(this.nomodButtFlowLayout);
            this.nomodTabPage.Location = new System.Drawing.Point(4, 22);
            this.nomodTabPage.Name = "nomodTabPage";
            this.nomodTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.nomodTabPage.Size = new System.Drawing.Size(530, 263);
            this.nomodTabPage.TabIndex = 1;
            this.nomodTabPage.Text = "No Mod";
            this.nomodTabPage.UseVisualStyleBackColor = true;
            // 
            // nomodButtFlowLayout
            // 
            this.nomodButtFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomodButtFlowLayout.AutoScroll = true;
            this.nomodButtFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.nomodButtFlowLayout.Name = "nomodButtFlowLayout";
            this.nomodButtFlowLayout.Size = new System.Drawing.Size(530, 263);
            this.nomodButtFlowLayout.TabIndex = 1;
            // 
            // hiddenTabPage
            // 
            this.hiddenTabPage.Controls.Add(this.hiddenButtFlowLayout);
            this.hiddenTabPage.Location = new System.Drawing.Point(4, 22);
            this.hiddenTabPage.Name = "hiddenTabPage";
            this.hiddenTabPage.Size = new System.Drawing.Size(530, 263);
            this.hiddenTabPage.TabIndex = 2;
            this.hiddenTabPage.Text = "Hidden";
            this.hiddenTabPage.UseVisualStyleBackColor = true;
            // 
            // hiddenButtFlowLayout
            // 
            this.hiddenButtFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hiddenButtFlowLayout.AutoScroll = true;
            this.hiddenButtFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.hiddenButtFlowLayout.Name = "hiddenButtFlowLayout";
            this.hiddenButtFlowLayout.Size = new System.Drawing.Size(530, 263);
            this.hiddenButtFlowLayout.TabIndex = 2;
            // 
            // hardrockTabPage
            // 
            this.hardrockTabPage.Controls.Add(this.hardrockButtFlowLayout);
            this.hardrockTabPage.Location = new System.Drawing.Point(4, 22);
            this.hardrockTabPage.Name = "hardrockTabPage";
            this.hardrockTabPage.Size = new System.Drawing.Size(530, 263);
            this.hardrockTabPage.TabIndex = 3;
            this.hardrockTabPage.Text = "Hard Rock";
            this.hardrockTabPage.UseVisualStyleBackColor = true;
            // 
            // hardrockButtFlowLayout
            // 
            this.hardrockButtFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hardrockButtFlowLayout.AutoScroll = true;
            this.hardrockButtFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.hardrockButtFlowLayout.Name = "hardrockButtFlowLayout";
            this.hardrockButtFlowLayout.Size = new System.Drawing.Size(530, 263);
            this.hardrockButtFlowLayout.TabIndex = 3;
            // 
            // doubletimeTabPage
            // 
            this.doubletimeTabPage.Controls.Add(this.doubletimeButtFlowLayout);
            this.doubletimeTabPage.Location = new System.Drawing.Point(4, 22);
            this.doubletimeTabPage.Name = "doubletimeTabPage";
            this.doubletimeTabPage.Size = new System.Drawing.Size(530, 263);
            this.doubletimeTabPage.TabIndex = 4;
            this.doubletimeTabPage.Text = "Double Time";
            this.doubletimeTabPage.UseVisualStyleBackColor = true;
            // 
            // doubletimeButtFlowLayout
            // 
            this.doubletimeButtFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doubletimeButtFlowLayout.AutoScroll = true;
            this.doubletimeButtFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.doubletimeButtFlowLayout.Name = "doubletimeButtFlowLayout";
            this.doubletimeButtFlowLayout.Size = new System.Drawing.Size(530, 263);
            this.doubletimeButtFlowLayout.TabIndex = 3;
            // 
            // freemodTabPage
            // 
            this.freemodTabPage.Controls.Add(this.freemodButtFlowLayout);
            this.freemodTabPage.Location = new System.Drawing.Point(4, 22);
            this.freemodTabPage.Name = "freemodTabPage";
            this.freemodTabPage.Size = new System.Drawing.Size(530, 263);
            this.freemodTabPage.TabIndex = 5;
            this.freemodTabPage.Text = "Free Mod";
            this.freemodTabPage.UseVisualStyleBackColor = true;
            // 
            // freemodButtFlowLayout
            // 
            this.freemodButtFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.freemodButtFlowLayout.AutoScroll = true;
            this.freemodButtFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.freemodButtFlowLayout.Name = "freemodButtFlowLayout";
            this.freemodButtFlowLayout.Size = new System.Drawing.Size(530, 263);
            this.freemodButtFlowLayout.TabIndex = 3;
            // 
            // tiebreakerTabPage
            // 
            this.tiebreakerTabPage.Controls.Add(this.tiebreakerButtFlowLayout);
            this.tiebreakerTabPage.Location = new System.Drawing.Point(4, 22);
            this.tiebreakerTabPage.Name = "tiebreakerTabPage";
            this.tiebreakerTabPage.Size = new System.Drawing.Size(530, 263);
            this.tiebreakerTabPage.TabIndex = 6;
            this.tiebreakerTabPage.Text = "Tie Breaker alv";
            this.tiebreakerTabPage.UseVisualStyleBackColor = true;
            // 
            // tiebreakerButtFlowLayout
            // 
            this.tiebreakerButtFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tiebreakerButtFlowLayout.AutoScroll = true;
            this.tiebreakerButtFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.tiebreakerButtFlowLayout.Name = "tiebreakerButtFlowLayout";
            this.tiebreakerButtFlowLayout.Size = new System.Drawing.Size(530, 263);
            this.tiebreakerButtFlowLayout.TabIndex = 3;
            // 
            // stageComBox
            // 
            this.stageComBox.FormattingEnabled = true;
            this.stageComBox.Location = new System.Drawing.Point(50, 37);
            this.stageComBox.Name = "stageComBox";
            this.stageComBox.Size = new System.Drawing.Size(121, 21);
            this.stageComBox.TabIndex = 1;
            this.stageComBox.SelectedIndexChanged += new System.EventHandler(this.SwitchStage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stage";
            // 
            // errorLbl
            // 
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(174, 25);
            this.errorLbl.Margin = new System.Windows.Forms.Padding(0);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(388, 40);
            this.errorLbl.TabIndex = 0;
            this.errorLbl.Text = "Ventana chat4osu no fue encontrada\r\nPicale aqui para volver a buscarla";
            this.errorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLbl.Click += new System.EventHandler(this.errorLblClick);
            // 
            // mpsettingsButt
            // 
            this.mpsettingsButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpsettingsButt.Location = new System.Drawing.Point(177, 28);
            this.mpsettingsButt.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.mpsettingsButt.Name = "mpsettingsButt";
            this.mpsettingsButt.Size = new System.Drawing.Size(60, 35);
            this.mpsettingsButt.TabIndex = 3;
            this.mpsettingsButt.Text = "Room Settings";
            this.mpsettingsButt.UseVisualStyleBackColor = true;
            this.mpsettingsButt.Click += new System.EventHandler(this.mpsettingsButt_Click);
            // 
            // mpstart10Butt
            // 
            this.mpstart10Butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpstart10Butt.Location = new System.Drawing.Point(243, 28);
            this.mpstart10Butt.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.mpstart10Butt.Name = "mpstart10Butt";
            this.mpstart10Butt.Size = new System.Drawing.Size(50, 35);
            this.mpstart10Butt.TabIndex = 4;
            this.mpstart10Butt.Text = "Start\r\n10 seg";
            this.mpstart10Butt.UseVisualStyleBackColor = true;
            this.mpstart10Butt.Click += new System.EventHandler(this.mpstart10Butt_Click);
            // 
            // mpabortButt
            // 
            this.mpabortButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpabortButt.Location = new System.Drawing.Point(293, 28);
            this.mpabortButt.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.mpabortButt.Name = "mpabortButt";
            this.mpabortButt.Size = new System.Drawing.Size(50, 35);
            this.mpabortButt.TabIndex = 5;
            this.mpabortButt.Text = "Abort Start";
            this.mpabortButt.UseVisualStyleBackColor = true;
            this.mpabortButt.Click += new System.EventHandler(this.mpabortButt_Click);
            // 
            // mpaborttimerButt
            // 
            this.mpaborttimerButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpaborttimerButt.Location = new System.Drawing.Point(404, 28);
            this.mpaborttimerButt.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.mpaborttimerButt.Name = "mpaborttimerButt";
            this.mpaborttimerButt.Size = new System.Drawing.Size(55, 35);
            this.mpaborttimerButt.TabIndex = 7;
            this.mpaborttimerButt.Text = "Abort\r\nTimer";
            this.mpaborttimerButt.UseVisualStyleBackColor = true;
            this.mpaborttimerButt.Click += new System.EventHandler(this.mpaborttimerButt_Click);
            // 
            // mptimer
            // 
            this.mptimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mptimer.Location = new System.Drawing.Point(349, 28);
            this.mptimer.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.mptimer.Name = "mptimer";
            this.mptimer.Size = new System.Drawing.Size(55, 35);
            this.mptimer.TabIndex = 6;
            this.mptimer.Text = "Timer\r\n120 seg";
            this.mptimer.UseVisualStyleBackColor = true;
            this.mptimer.Click += new System.EventHandler(this.mptimer_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(562, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(50, 22);
            this.toolStripButton1.Text = "tool";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 365);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.mpaborttimerButt);
            this.Controls.Add(this.mptimer);
            this.Controls.Add(this.mpabortButt);
            this.Controls.Add(this.mpstart10Butt);
            this.Controls.Add(this.mpsettingsButt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stageComBox);
            this.Controls.Add(this.tabMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabMenu.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.generalButtFlowLayout.ResumeLayout(false);
            this.nomodTabPage.ResumeLayout(false);
            this.hiddenTabPage.ResumeLayout(false);
            this.hardrockTabPage.ResumeLayout(false);
            this.doubletimeTabPage.ResumeLayout(false);
            this.freemodTabPage.ResumeLayout(false);
            this.tiebreakerTabPage.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.TabPage nomodTabPage;
        private System.Windows.Forms.TabPage hiddenTabPage;
        private System.Windows.Forms.TabPage hardrockTabPage;
        private System.Windows.Forms.TabPage doubletimeTabPage;
        private System.Windows.Forms.TabPage freemodTabPage;
        private System.Windows.Forms.TabPage tiebreakerTabPage;
        private System.Windows.Forms.ComboBox stageComBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel generalButtFlowLayout;
        private System.Windows.Forms.Button mpmakeButt;
        private System.Windows.Forms.Button mppasswordButt;
        private System.Windows.Forms.Button mpsetupButt;
        private System.Windows.Forms.Button mpinviteButt;
        private System.Windows.Forms.Button mpmoveButt;
        private System.Windows.Forms.Button mpteamButt;
        private System.Windows.Forms.Button mplockButt;
        private System.Windows.Forms.Button mpcloseButt;
        private System.Windows.Forms.Button mpunlockButt;
        private System.Windows.Forms.Button extraButt;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.FlowLayoutPanel nomodButtFlowLayout;
        private System.Windows.Forms.FlowLayoutPanel hiddenButtFlowLayout;
        private System.Windows.Forms.FlowLayoutPanel hardrockButtFlowLayout;
        private System.Windows.Forms.FlowLayoutPanel doubletimeButtFlowLayout;
        private System.Windows.Forms.FlowLayoutPanel freemodButtFlowLayout;
        private System.Windows.Forms.FlowLayoutPanel tiebreakerButtFlowLayout;
        private System.Windows.Forms.Button mpsettingsButt;
        private System.Windows.Forms.Button mpstart10Butt;
        private System.Windows.Forms.Button mpabortButt;
        private System.Windows.Forms.Button mpaborttimerButt;
        private System.Windows.Forms.Button mptimer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

