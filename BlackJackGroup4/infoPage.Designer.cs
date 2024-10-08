namespace BlackJackGroup4
{
    partial class frmInfoPage
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
            this.picTable = new System.Windows.Forms.PictureBox();
            this.btnBack = new BlackJackGroup4.CircularButton();
            this.circularButton3 = new BlackJackGroup4.CircularButton();
            this.circularButton2 = new BlackJackGroup4.CircularButton();
            this.btnAboutUs = new BlackJackGroup4.CircularButton();
            ((System.ComponentModel.ISupportInitialize)(this.picTable)).BeginInit();
            this.SuspendLayout();
            // 
            // picTable
            // 
            this.picTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picTable.Image = global::BlackJackGroup4.Properties.Resources.blackjack_table2;
            this.picTable.Location = new System.Drawing.Point(1, 28);
            this.picTable.Name = "picTable";
            this.picTable.Size = new System.Drawing.Size(827, 426);
            this.picTable.TabIndex = 1;
            this.picTable.TabStop = false;
            this.picTable.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::BlackJackGroup4.Properties.Resources.black_chip;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Font = new System.Drawing.Font("Bauhaus 93", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Orange;
            this.btnBack.Location = new System.Drawing.Point(69, 329);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 100);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // circularButton3
            // 
            this.circularButton3.BackColor = System.Drawing.Color.Transparent;
            this.circularButton3.BackgroundImage = global::BlackJackGroup4.Properties.Resources.yellow_chips;
            this.circularButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton3.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton3.Location = new System.Drawing.Point(580, 96);
            this.circularButton3.Name = "circularButton3";
            this.circularButton3.Size = new System.Drawing.Size(179, 179);
            this.circularButton3.TabIndex = 3;
            this.circularButton3.Text = "Tutorial";
            this.circularButton3.UseVisualStyleBackColor = false;
            this.circularButton3.Click += new System.EventHandler(this.circularButton3_Click);
            // 
            // circularButton2
            // 
            this.circularButton2.BackColor = System.Drawing.Color.Transparent;
            this.circularButton2.BackgroundImage = global::BlackJackGroup4.Properties.Resources.blue_chip;
            this.circularButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton2.ForeColor = System.Drawing.Color.Yellow;
            this.circularButton2.Location = new System.Drawing.Point(330, 96);
            this.circularButton2.Name = "circularButton2";
            this.circularButton2.Size = new System.Drawing.Size(179, 179);
            this.circularButton2.TabIndex = 2;
            this.circularButton2.Text = "Terms And Conditons";
            this.circularButton2.UseVisualStyleBackColor = false;
            this.circularButton2.Click += new System.EventHandler(this.circularButton2_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackColor = System.Drawing.Color.Transparent;
            this.btnAboutUs.BackgroundImage = global::BlackJackGroup4.Properties.Resources.white_chip;
            this.btnAboutUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAboutUs.Font = new System.Drawing.Font("Bauhaus 93", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.Color.Red;
            this.btnAboutUs.Location = new System.Drawing.Point(80, 96);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(179, 179);
            this.btnAboutUs.TabIndex = 0;
            this.btnAboutUs.Text = "About ";
            this.btnAboutUs.UseVisualStyleBackColor = false;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // frmInfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.circularButton3);
            this.Controls.Add(this.circularButton2);
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.picTable);
            this.Name = "frmInfoPage";
            this.Text = "BlackJack Information";
            this.Load += new System.EventHandler(this.infoPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CircularButton btnAboutUs;
        private System.Windows.Forms.PictureBox picTable;
        private CircularButton circularButton2;
        private CircularButton circularButton3;
        private CircularButton btnBack;
    }
}