namespace BlackJackGroup4
{
    partial class BlackJackWelcome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJackWelcome));
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonSoundOn = new System.Windows.Forms.Button();
            this.buttonSoundOff = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.grpPlayers = new System.Windows.Forms.GroupBox();
            this.buttonMultiPlay = new System.Windows.Forms.Button();
            this.buttonSinglePlayer = new System.Windows.Forms.Button();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.btnClassic = new System.Windows.Forms.Button();
            this.btnJoker = new System.Windows.Forms.Button();
            this.pbTitle = new System.Windows.Forms.PictureBox();
            this.pnlMenuOptions = new System.Windows.Forms.Panel();
            this.btnTutorial = new System.Windows.Forms.Button();
            this.toolTipSettings = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMute = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipStart = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipQuit = new System.Windows.Forms.ToolTip(this.components);
            this.grpPlayers.SuspendLayout();
            this.grpMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
            this.pnlMenuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSettings.BackgroundImage = global::BlackJackGroup4.Properties.Resources.settings;
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
<<<<<<< HEAD
            this.buttonSettings.Location = new System.Drawing.Point(14, 14);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(62, 66);
=======
            this.buttonSettings.Location = new System.Drawing.Point(9, 9);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(41, 43);
>>>>>>> ccd427f9cc90d345429f06524c291371fec261fc
            this.buttonSettings.TabIndex = 1;
            this.toolTipSettings.SetToolTip(this.buttonSettings, "Game Settings");
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonSoundOn
            // 
            this.buttonSoundOn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSoundOn.BackgroundImage = global::BlackJackGroup4.Properties.Resources.sound_on;
            this.buttonSoundOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
<<<<<<< HEAD
            this.buttonSoundOn.Location = new System.Drawing.Point(82, 14);
            this.buttonSoundOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSoundOn.Name = "buttonSoundOn";
            this.buttonSoundOn.Size = new System.Drawing.Size(62, 66);
=======
            this.buttonSoundOn.Location = new System.Drawing.Point(55, 9);
            this.buttonSoundOn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSoundOn.Name = "buttonSoundOn";
            this.buttonSoundOn.Size = new System.Drawing.Size(41, 43);
>>>>>>> ccd427f9cc90d345429f06524c291371fec261fc
            this.buttonSoundOn.TabIndex = 2;
            this.toolTipMute.SetToolTip(this.buttonSoundOn, "Mute Music");
            this.buttonSoundOn.UseVisualStyleBackColor = false;
            this.buttonSoundOn.Click += new System.EventHandler(this.buttonSoundOn_Click);
            // 
            // buttonSoundOff
            // 
            this.buttonSoundOff.BackgroundImage = global::BlackJackGroup4.Properties.Resources.sound_off;
            this.buttonSoundOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
<<<<<<< HEAD
            this.buttonSoundOff.Location = new System.Drawing.Point(82, 14);
            this.buttonSoundOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSoundOff.Name = "buttonSoundOff";
            this.buttonSoundOff.Size = new System.Drawing.Size(62, 66);
=======
            this.buttonSoundOff.Location = new System.Drawing.Point(55, 9);
            this.buttonSoundOff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSoundOff.Name = "buttonSoundOff";
            this.buttonSoundOff.Size = new System.Drawing.Size(41, 43);
>>>>>>> ccd427f9cc90d345429f06524c291371fec261fc
            this.buttonSoundOff.TabIndex = 9;
            this.buttonSoundOff.UseVisualStyleBackColor = true;
            this.buttonSoundOff.Visible = false;
            this.buttonSoundOff.Click += new System.EventHandler(this.buttonSoundOff_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
<<<<<<< HEAD
            this.btnStart.Location = new System.Drawing.Point(44, 366);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(379, 66);
=======
            this.btnStart.Location = new System.Drawing.Point(29, 238);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(253, 43);
>>>>>>> ccd427f9cc90d345429f06524c291371fec261fc
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.toolTipStart.SetToolTip(this.btnStart, "Start the Game");
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.Enter += new System.EventHandler(this.Button_Enter);
            this.btnStart.Leave += new System.EventHandler(this.Button_Leave);
            this.btnStart.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.btnStart.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(86, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 20);
=======
            this.label1.Location = new System.Drawing.Point(57, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
>>>>>>> ccd427f9cc90d345429f06524c291371fec261fc
            this.label1.TabIndex = 14;
            this.label1.Text = "Tab over to change button selection";
            // 
            // buttonQuit
            // 
            this.buttonQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
<<<<<<< HEAD
            this.buttonQuit.Location = new System.Drawing.Point(143, 438);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(186, 66);
=======
            this.buttonQuit.Location = new System.Drawing.Point(95, 284);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(124, 43);
>>>>>>> ccd427f9cc90d345429f06524c291371fec261fc
            this.buttonQuit.TabIndex = 15;
            this.buttonQuit.Text = "Quit";
            this.toolTipQuit.SetToolTip(this.buttonQuit, "Quits the application");
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            this.buttonQuit.Enter += new System.EventHandler(this.Button_Enter);
            this.buttonQuit.Leave += new System.EventHandler(this.Button_Leave);
            this.buttonQuit.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.buttonQuit.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // grpPlayers
            // 
            this.grpPlayers.BackColor = System.Drawing.Color.Transparent;
            this.grpPlayers.Controls.Add(this.buttonMultiPlay);
            this.grpPlayers.Controls.Add(this.buttonSinglePlayer);
            this.grpPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlayers.ForeColor = System.Drawing.Color.Gainsboro;
<<<<<<< HEAD
            this.grpPlayers.Location = new System.Drawing.Point(24, 126);
            this.grpPlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPlayers.Name = "grpPlayers";
            this.grpPlayers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPlayers.Size = new System.Drawing.Size(423, 111);
=======
            this.grpPlayers.Location = new System.Drawing.Point(16, 82);
            this.grpPlayers.Name = "grpPlayers";
            this.grpPlayers.Size = new System.Drawing.Size(282, 72);
>>>>>>> ccd427f9cc90d345429f06524c291371fec261fc
            this.grpPlayers.TabIndex = 11;
            this.grpPlayers.TabStop = false;
            this.grpPlayers.Text = "Players";
            // 
            // buttonMultiPlay
            // 
            this.buttonMultiPlay.Enabled = false;
            this.buttonMultiPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiPlay.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.buttonMultiPlay.Location = new System.Drawing.Point(215, 28);
            this.buttonMultiPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMultiPlay.Name = "buttonMultiPlay";
            this.buttonMultiPlay.Size = new System.Drawing.Size(186, 66);
=======
            this.buttonMultiPlay.Location = new System.Drawing.Point(143, 18);
            this.buttonMultiPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMultiPlay.Name = "buttonMultiPlay";
            this.buttonMultiPlay.Size = new System.Drawing.Size(124, 43);
>>>>>>> ccd427f9cc90d345429f06524c291371fec261fc
            this.buttonMultiPlay.TabIndex = 1;
            this.buttonMultiPlay.Text = "Two Players";
            this.buttonMultiPlay.UseVisualStyleBackColor = true;
            this.buttonMultiPlay.Enter += new System.EventHandler(this.Button_Enter);
            this.buttonMultiPlay.Leave += new System.EventHandler(this.Button_Leave);
            this.buttonMultiPlay.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.buttonMultiPlay.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // buttonSinglePlayer
            // 
            this.buttonSinglePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSinglePlayer.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.buttonSinglePlayer.Location = new System.Drawing.Point(22, 28);
            this.buttonSinglePlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSinglePlayer.Name = "buttonSinglePlayer";
            this.buttonSinglePlayer.Size = new System.Drawing.Size(186, 66);
=======
            this.buttonSinglePlayer.Location = new System.Drawing.Point(15, 18);
            this.buttonSinglePlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSinglePlayer.Name = "buttonSinglePlayer";
            this.buttonSinglePlayer.Size = new System.Drawing.Size(124, 43);
>>>>>>> ccd427f9cc90d345429f06524c291371fec261fc
            this.buttonSinglePlayer.TabIndex = 0;
            this.buttonSinglePlayer.Text = "Single Player";
            this.buttonSinglePlayer.UseVisualStyleBackColor = true;
            this.buttonSinglePlayer.Click += new System.EventHandler(this.buttonSingle_Click);
            this.buttonSinglePlayer.Enter += new System.EventHandler(this.Button_Enter);
            this.buttonSinglePlayer.Leave += new System.EventHandler(this.Button_Leave);
            this.buttonSinglePlayer.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.buttonSinglePlayer.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // grpMode
            // 
            this.grpMode.BackColor = System.Drawing.Color.Transparent;
            this.grpMode.Controls.Add(this.btnClassic);
            this.grpMode.Controls.Add(this.btnJoker);
            this.grpMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMode.ForeColor = System.Drawing.Color.WhiteSmoke;
<<<<<<< HEAD
            this.grpMode.Location = new System.Drawing.Point(26, 248);
            this.grpMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMode.Name = "grpMode";
            this.grpMode.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMode.Size = new System.Drawing.Size(423, 111);
=======
            this.grpMode.Location = new System.Drawing.Point(17, 161);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(282, 72);
>>>>>>> ccd427f9cc90d345429f06524c291371fec261fc
            this.grpMode.TabIndex = 12;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "Mode";
            // 
            // btnClassic
            // 
            this.btnClassic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassic.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.btnClassic.Location = new System.Drawing.Point(24, 28);
            this.btnClassic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClassic.Name = "btnClassic";
            this.btnClassic.Size = new System.Drawing.Size(186, 66);
=======
            this.btnClassic.Location = new System.Drawing.Point(16, 18);
            this.btnClassic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClassic.Name = "btnClassic";
            this.btnClassic.Size = new System.Drawing.Size(124, 43);
>>>>>>> ccd427f9cc90d345429f06524c291371fec261fc
            this.btnClassic.TabIndex = 0;
            this.btnClassic.Text = "Classic";
            this.btnClassic.UseVisualStyleBackColor = true;
            this.btnClassic.Click += new System.EventHandler(this.btnClassic_Click);
            this.btnClassic.Enter += new System.EventHandler(this.Button_Enter);
            this.btnClassic.Leave += new System.EventHandler(this.Button_Leave);
            this.btnClassic.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.btnClassic.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // btnJoker
            // 
            this.btnJoker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoker.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.btnJoker.Location = new System.Drawing.Point(217, 28);
            this.btnJoker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJoker.Name = "btnJoker";
            this.btnJoker.Size = new System.Drawing.Size(186, 66);
=======
            this.btnJoker.Location = new System.Drawing.Point(145, 18);
            this.btnJoker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJoker.Name = "btnJoker";
            this.btnJoker.Size = new System.Drawing.Size(124, 43);
>>>>>>> ccd427f9cc90d345429f06524c291371fec261fc
            this.btnJoker.TabIndex = 1;
            this.btnJoker.Text = "Joker\'s Revenge";
            this.btnJoker.UseVisualStyleBackColor = true;
            this.btnJoker.Click += new System.EventHandler(this.btnJoker_Click);
            this.btnJoker.Enter += new System.EventHandler(this.Button_Enter);
            this.btnJoker.Leave += new System.EventHandler(this.Button_Leave);
            this.btnJoker.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.btnJoker.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // pbTitle
            // 
            this.pbTitle.BackColor = System.Drawing.Color.Transparent;
            this.pbTitle.Image = global::BlackJackGroup4.Properties.Resources.title3;
<<<<<<< HEAD
            this.pbTitle.Location = new System.Drawing.Point(32, 0);
            this.pbTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbTitle.Name = "pbTitle";
            this.pbTitle.Size = new System.Drawing.Size(414, 94);
=======
            this.pbTitle.Location = new System.Drawing.Point(21, 0);
            this.pbTitle.Name = "pbTitle";
            this.pbTitle.Size = new System.Drawing.Size(276, 61);
>>>>>>> ccd427f9cc90d345429f06524c291371fec261fc
            this.pbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTitle.TabIndex = 16;
            this.pbTitle.TabStop = false;
            // 
            // pnlMenuOptions
            // 
            this.pnlMenuOptions.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuOptions.Controls.Add(this.btnStart);
            this.pnlMenuOptions.Controls.Add(this.pbTitle);
            this.pnlMenuOptions.Controls.Add(this.grpPlayers);
            this.pnlMenuOptions.Controls.Add(this.buttonQuit);
            this.pnlMenuOptions.Controls.Add(this.label1);
            this.pnlMenuOptions.Controls.Add(this.grpMode);
<<<<<<< HEAD
            this.pnlMenuOptions.Location = new System.Drawing.Point(204, 138);
            this.pnlMenuOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenuOptions.Name = "pnlMenuOptions";
            this.pnlMenuOptions.Size = new System.Drawing.Size(474, 508);
=======
            this.pnlMenuOptions.Location = new System.Drawing.Point(136, 89);
            this.pnlMenuOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMenuOptions.Name = "pnlMenuOptions";
            this.pnlMenuOptions.Size = new System.Drawing.Size(316, 330);
>>>>>>> ccd427f9cc90d345429f06524c291371fec261fc
            this.pnlMenuOptions.TabIndex = 17;
            // 
            // btnTutorial
            // 
            this.btnTutorial.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTutorial.BackgroundImage = global::BlackJackGroup4.Properties.Resources.tutorial;
            this.btnTutorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTutorial.FlatAppearance.BorderSize = 0;
<<<<<<< HEAD
            this.btnTutorial.Location = new System.Drawing.Point(807, 14);
            this.btnTutorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(62, 66);
=======
            this.btnTutorial.Location = new System.Drawing.Point(538, 9);
            this.btnTutorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(41, 43);
>>>>>>> ccd427f9cc90d345429f06524c291371fec261fc
            this.btnTutorial.TabIndex = 18;
            this.btnTutorial.UseVisualStyleBackColor = false;
            this.btnTutorial.Click += new System.EventHandler(this.btnTutorial_Click);
            // 
            // BlackJackWelcome
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJackGroup4.Properties.Resources.vegas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 711);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJackGroup4.Properties.Resources.vegas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 476);
>>>>>>> ccd427f9cc90d345429f06524c291371fec261fc
            this.Controls.Add(this.btnTutorial);
            this.Controls.Add(this.buttonSoundOn);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonSoundOff);
            this.Controls.Add(this.pnlMenuOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
<<<<<<< HEAD
            this.MaximumSize = new System.Drawing.Size(900, 767);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 767);
=======
            this.MaximumSize = new System.Drawing.Size(606, 515);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(606, 515);
>>>>>>> ccd427f9cc90d345429f06524c291371fec261fc
            this.Name = "BlackJackWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Welcome!";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.BlackJackWelcome_Load);
            this.Enter += new System.EventHandler(this.BlackJackWelcome_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BlackJackWelcome_Load);
            this.grpPlayers.ResumeLayout(false);
            this.grpMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
            this.pnlMenuOptions.ResumeLayout(false);
            this.pnlMenuOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonSoundOn;
        private System.Windows.Forms.Button buttonSoundOff;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.GroupBox grpPlayers;
        private System.Windows.Forms.Button buttonMultiPlay;
        private System.Windows.Forms.Button buttonSinglePlayer;
        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.Button btnClassic;
        private System.Windows.Forms.Button btnJoker;
        private System.Windows.Forms.PictureBox pbTitle;
        private System.Windows.Forms.Panel pnlMenuOptions;
        private System.Windows.Forms.Button btnTutorial;
        private System.Windows.Forms.ToolTip toolTipSettings;
        private System.Windows.Forms.ToolTip toolTipMute;
        private System.Windows.Forms.ToolTip toolTipStart;
        private System.Windows.Forms.ToolTip toolTipQuit;
    }
}

