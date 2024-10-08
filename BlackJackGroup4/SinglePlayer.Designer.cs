namespace BlackJackGroup4
{
    partial class frmSinglePlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinglePlayer));
            this.btnHit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnFiveDollars = new System.Windows.Forms.Button();
            this.btnOneDollar = new System.Windows.Forms.Button();
            this.btnFiftyDollars = new System.Windows.Forms.Button();
            this.btnTwentyDollars = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblBet = new System.Windows.Forms.Label();
            this.panelPlayerCards = new System.Windows.Forms.Panel();
            this.panelDealerCards = new System.Windows.Forms.Panel();
            this.pbGameTable = new System.Windows.Forms.PictureBox();
            this.panelBet = new System.Windows.Forms.Panel();
            this.lblPlayerWallet = new System.Windows.Forms.Label();
            this.btnDoubleDown = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.lblHandValue = new System.Windows.Forms.Label();
            this.lblDealerHandValue = new System.Windows.Forms.Label();
            this.toolTipBalance = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBet = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipReset = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipHandValue = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDealerHand = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipHit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipStand = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDoubleDown = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSplit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMenu = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameTable)).BeginInit();
            this.panelBet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.Transparent;
            this.btnHit.Enabled = false;
            this.btnHit.FlatAppearance.BorderSize = 0;
            this.btnHit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(479, 67);
            this.btnHit.Margin = new System.Windows.Forms.Padding(2);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(82, 51);
            this.btnHit.TabIndex = 1;
            this.btnHit.Text = "Hit";
            this.toolTipHit.SetToolTip(this.btnHit, "Adds 1 Card to your hand");
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            this.btnHit.Enter += new System.EventHandler(this.Button_MouseEnter);
            this.btnHit.Leave += new System.EventHandler(this.Button_MouseLeave);
            this.btnHit.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnHit.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Main Menu";
            this.toolTipMenu.SetToolTip(this.button2, "Return to Main Menu");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.Color.Transparent;
            this.btnStand.Enabled = false;
            this.btnStand.FlatAppearance.BorderSize = 0;
            this.btnStand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStand.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.Location = new System.Drawing.Point(568, 67);
            this.btnStand.Margin = new System.Windows.Forms.Padding(2);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(86, 51);
            this.btnStand.TabIndex = 4;
            this.btnStand.Text = "Stand";
            this.toolTipStand.SetToolTip(this.btnStand, "Stays on current hand");
            this.btnStand.UseVisualStyleBackColor = false;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            this.btnStand.Enter += new System.EventHandler(this.Button_MouseEnter);
            this.btnStand.Leave += new System.EventHandler(this.Button_MouseLeave);
            this.btnStand.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnStand.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnDeal
            // 
            this.btnDeal.BackColor = System.Drawing.Color.Transparent;
            this.btnDeal.Enabled = false;
            this.btnDeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeal.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDeal.Location = new System.Drawing.Point(479, 9);
            this.btnDeal.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(174, 51);
            this.btnDeal.TabIndex = 5;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = false;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            this.btnDeal.Enter += new System.EventHandler(this.Button_MouseEnter);
            this.btnDeal.Leave += new System.EventHandler(this.Button_MouseLeave);
            this.btnDeal.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnDeal.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnFiveDollars
            // 
            this.btnFiveDollars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFiveDollars.BackColor = System.Drawing.Color.Transparent;
            this.btnFiveDollars.Enabled = false;
            this.btnFiveDollars.FlatAppearance.BorderSize = 0;
            this.btnFiveDollars.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFiveDollars.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiveDollars.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiveDollars.Location = new System.Drawing.Point(92, 124);
            this.btnFiveDollars.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiveDollars.Name = "btnFiveDollars";
            this.btnFiveDollars.Size = new System.Drawing.Size(86, 51);
            this.btnFiveDollars.TabIndex = 7;
            this.btnFiveDollars.Text = "$5";
            this.btnFiveDollars.UseVisualStyleBackColor = false;
            this.btnFiveDollars.Click += new System.EventHandler(this.btnFiveDollars_Click);
            this.btnFiveDollars.Enter += new System.EventHandler(this.Button_MouseEnter);
            this.btnFiveDollars.Leave += new System.EventHandler(this.Button_MouseLeave);
            this.btnFiveDollars.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnFiveDollars.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnOneDollar
            // 
            this.btnOneDollar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOneDollar.BackColor = System.Drawing.Color.Transparent;
            this.btnOneDollar.Enabled = false;
            this.btnOneDollar.FlatAppearance.BorderSize = 0;
            this.btnOneDollar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOneDollar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOneDollar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneDollar.Location = new System.Drawing.Point(4, 124);
            this.btnOneDollar.Margin = new System.Windows.Forms.Padding(2);
            this.btnOneDollar.Name = "btnOneDollar";
            this.btnOneDollar.Size = new System.Drawing.Size(82, 51);
            this.btnOneDollar.TabIndex = 6;
            this.btnOneDollar.Text = "$1";
            this.btnOneDollar.UseVisualStyleBackColor = false;
            this.btnOneDollar.Click += new System.EventHandler(this.btnOneDollar_Click);
            this.btnOneDollar.Enter += new System.EventHandler(this.Button_MouseEnter);
            this.btnOneDollar.Leave += new System.EventHandler(this.Button_MouseLeave);
            this.btnOneDollar.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnOneDollar.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnFiftyDollars
            // 
            this.btnFiftyDollars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFiftyDollars.BackColor = System.Drawing.Color.Transparent;
            this.btnFiftyDollars.Enabled = false;
            this.btnFiftyDollars.FlatAppearance.BorderSize = 0;
            this.btnFiftyDollars.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFiftyDollars.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiftyDollars.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiftyDollars.Location = new System.Drawing.Point(92, 187);
            this.btnFiftyDollars.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiftyDollars.Name = "btnFiftyDollars";
            this.btnFiftyDollars.Size = new System.Drawing.Size(86, 51);
            this.btnFiftyDollars.TabIndex = 9;
            this.btnFiftyDollars.Text = "$50";
            this.btnFiftyDollars.UseVisualStyleBackColor = false;
            this.btnFiftyDollars.Click += new System.EventHandler(this.btnFiftyDollars_Click);
            this.btnFiftyDollars.Enter += new System.EventHandler(this.Button_MouseEnter);
            this.btnFiftyDollars.Leave += new System.EventHandler(this.Button_MouseLeave);
            this.btnFiftyDollars.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnFiftyDollars.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnTwentyDollars
            // 
            this.btnTwentyDollars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTwentyDollars.BackColor = System.Drawing.Color.Transparent;
            this.btnTwentyDollars.Enabled = false;
            this.btnTwentyDollars.FlatAppearance.BorderSize = 0;
            this.btnTwentyDollars.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTwentyDollars.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTwentyDollars.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwentyDollars.Location = new System.Drawing.Point(4, 187);
            this.btnTwentyDollars.Margin = new System.Windows.Forms.Padding(2);
            this.btnTwentyDollars.Name = "btnTwentyDollars";
            this.btnTwentyDollars.Size = new System.Drawing.Size(82, 51);
            this.btnTwentyDollars.TabIndex = 8;
            this.btnTwentyDollars.Text = "$20";
            this.btnTwentyDollars.UseVisualStyleBackColor = false;
            this.btnTwentyDollars.Click += new System.EventHandler(this.btnTwentyDollars_Click);
            this.btnTwentyDollars.Enter += new System.EventHandler(this.Button_MouseEnter);
            this.btnTwentyDollars.Leave += new System.EventHandler(this.Button_MouseLeave);
            this.btnTwentyDollars.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnTwentyDollars.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Enabled = false;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(4, 247);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(174, 51);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.toolTipReset.SetToolTip(this.btnReset, "Reset all bets to 0");
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.Enter += new System.EventHandler(this.Button_MouseEnter);
            this.btnReset.Leave += new System.EventHandler(this.Button_MouseLeave);
            this.btnReset.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // lblBet
            // 
            this.lblBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblBet.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblBet.Location = new System.Drawing.Point(4, 64);
            this.lblBet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(174, 52);
            this.lblBet.TabIndex = 11;
            this.lblBet.Text = "Bet: $0.00";
            this.lblBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipBet.SetToolTip(this.lblBet, "Your Current Bet");
            // 
            // panelPlayerCards
            // 
            this.panelPlayerCards.BackColor = System.Drawing.Color.Transparent;
            this.panelPlayerCards.Location = new System.Drawing.Point(194, 275);
            this.panelPlayerCards.Margin = new System.Windows.Forms.Padding(2);
            this.panelPlayerCards.Name = "panelPlayerCards";
            this.panelPlayerCards.Size = new System.Drawing.Size(295, 102);
            this.panelPlayerCards.TabIndex = 12;
            // 
            // panelDealerCards
            // 
            this.panelDealerCards.BackColor = System.Drawing.Color.Transparent;
            this.panelDealerCards.Location = new System.Drawing.Point(192, 67);
            this.panelDealerCards.Margin = new System.Windows.Forms.Padding(2);
            this.panelDealerCards.Name = "panelDealerCards";
            this.panelDealerCards.Size = new System.Drawing.Size(295, 102);
            this.panelDealerCards.TabIndex = 13;
            // 
            // pbGameTable
            // 
            this.pbGameTable.BackColor = System.Drawing.Color.Transparent;
            this.pbGameTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbGameTable.Image = global::BlackJackGroup4.Properties.Resources.blackj_w_cards;
            this.pbGameTable.Location = new System.Drawing.Point(2, 40);
            this.pbGameTable.Margin = new System.Windows.Forms.Padding(2);
            this.pbGameTable.Name = "pbGameTable";
            this.pbGameTable.Size = new System.Drawing.Size(658, 370);
            this.pbGameTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGameTable.TabIndex = 0;
            this.pbGameTable.TabStop = false;
            // 
            // panelBet
            // 
            this.panelBet.BackColor = System.Drawing.Color.Transparent;
            this.panelBet.Controls.Add(this.lblPlayerWallet);
            this.panelBet.Controls.Add(this.lblBet);
            this.panelBet.Controls.Add(this.btnReset);
            this.panelBet.Controls.Add(this.btnTwentyDollars);
            this.panelBet.Controls.Add(this.btnFiveDollars);
            this.panelBet.Controls.Add(this.btnOneDollar);
            this.panelBet.Controls.Add(this.btnFiftyDollars);
            this.panelBet.Location = new System.Drawing.Point(2, 97);
            this.panelBet.Margin = new System.Windows.Forms.Padding(2);
            this.panelBet.Name = "panelBet";
            this.panelBet.Size = new System.Drawing.Size(186, 301);
            this.panelBet.TabIndex = 11;
            // 
            // lblPlayerWallet
            // 
            this.lblPlayerWallet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerWallet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPlayerWallet.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblPlayerWallet.Location = new System.Drawing.Point(4, 5);
            this.lblPlayerWallet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerWallet.Name = "lblPlayerWallet";
            this.lblPlayerWallet.Size = new System.Drawing.Size(174, 52);
            this.lblPlayerWallet.TabIndex = 15;
            this.lblPlayerWallet.Text = "Your Balance: ";
            this.lblPlayerWallet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipBalance.SetToolTip(this.lblPlayerWallet, "Your money and earnings");
            // 
            // btnDoubleDown
            // 
            this.btnDoubleDown.BackColor = System.Drawing.Color.Transparent;
            this.btnDoubleDown.FlatAppearance.BorderSize = 0;
            this.btnDoubleDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDoubleDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDoubleDown.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoubleDown.Location = new System.Drawing.Point(568, 122);
            this.btnDoubleDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoubleDown.Name = "btnDoubleDown";
            this.btnDoubleDown.Size = new System.Drawing.Size(86, 51);
            this.btnDoubleDown.TabIndex = 14;
            this.btnDoubleDown.Text = "Double Down?";
            this.toolTipDoubleDown.SetToolTip(this.btnDoubleDown, "Doubles bet and adds one card");
            this.btnDoubleDown.UseVisualStyleBackColor = false;
            this.btnDoubleDown.Click += new System.EventHandler(this.btnDoubleDown_Click);
            this.btnDoubleDown.Enter += new System.EventHandler(this.Button_MouseEnter);
            this.btnDoubleDown.Leave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnSplit
            // 
            this.btnSplit.BackColor = System.Drawing.Color.Transparent;
            this.btnSplit.Enabled = false;
            this.btnSplit.FlatAppearance.BorderSize = 0;
            this.btnSplit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSplit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSplit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplit.Location = new System.Drawing.Point(476, 122);
            this.btnSplit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(86, 51);
            this.btnSplit.TabIndex = 15;
            this.btnSplit.Text = "Split";
            this.toolTipSplit.SetToolTip(this.btnSplit, "Splits pair and doubles bet");
            this.btnSplit.UseVisualStyleBackColor = false;
            this.btnSplit.Enter += new System.EventHandler(this.Button_MouseEnter);
            this.btnSplit.Leave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // lblHandValue
            // 
            this.lblHandValue.AutoSize = true;
            this.lblHandValue.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandValue.Location = new System.Drawing.Point(219, 383);
            this.lblHandValue.Name = "lblHandValue";
            this.lblHandValue.Size = new System.Drawing.Size(85, 21);
            this.lblHandValue.TabIndex = 16;
            this.lblHandValue.Text = "HandValue";
            this.toolTipHandValue.SetToolTip(this.lblHandValue, "Current Value of your hand");
            // 
            // lblDealerHandValue
            // 
            this.lblDealerHandValue.AutoSize = true;
            this.lblDealerHandValue.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerHandValue.Location = new System.Drawing.Point(219, 44);
            this.lblDealerHandValue.Name = "lblDealerHandValue";
            this.lblDealerHandValue.Size = new System.Drawing.Size(92, 21);
            this.lblDealerHandValue.TabIndex = 17;
            this.lblDealerHandValue.Text = "DealerHand";
            this.toolTipDealerHand.SetToolTip(this.lblDealerHandValue, "Current Value of Dealers hand");
            // 
            // frmSinglePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 430);
            this.Controls.Add(this.lblDealerHandValue);
            this.Controls.Add(this.lblHandValue);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnDoubleDown);
            this.Controls.Add(this.panelDealerCards);
            this.Controls.Add(this.panelPlayerCards);
            this.Controls.Add(this.panelBet);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.pbGameTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 469);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(680, 469);
            this.Name = "frmSinglePlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Single Player - Classic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameTable)).EndInit();
            this.panelBet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGameTable;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnFiveDollars;
        private System.Windows.Forms.Button btnOneDollar;
        private System.Windows.Forms.Button btnFiftyDollars;
        private System.Windows.Forms.Button btnTwentyDollars;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Panel panelPlayerCards;
        private System.Windows.Forms.Panel panelDealerCards;
        private System.Windows.Forms.Panel panelBet;
        private System.Windows.Forms.Label lblPlayerWallet;
        private System.Windows.Forms.Button btnDoubleDown;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Label lblHandValue;
        private System.Windows.Forms.Label lblDealerHandValue;
        private System.Windows.Forms.ToolTip toolTipBalance;
        private System.Windows.Forms.ToolTip toolTipBet;
        private System.Windows.Forms.ToolTip toolTipHit;
        private System.Windows.Forms.ToolTip toolTipReset;
        private System.Windows.Forms.ToolTip toolTipHandValue;
        private System.Windows.Forms.ToolTip toolTipDealerHand;
        private System.Windows.Forms.ToolTip toolTipStand;
        private System.Windows.Forms.ToolTip toolTipDoubleDown;
        private System.Windows.Forms.ToolTip toolTipSplit;
        private System.Windows.Forms.ToolTip toolTipMenu;
    }
}