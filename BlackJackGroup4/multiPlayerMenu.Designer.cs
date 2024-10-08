namespace BlackJackGroup4
{
    partial class multiPlayerMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnJRMultiOption = new System.Windows.Forms.Button();
            this.btnBJMultiOption = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose a mode";
            // 
            // btnJRMultiOption
            // 
            this.btnJRMultiOption.Location = new System.Drawing.Point(409, 227);
            this.btnJRMultiOption.Name = "btnJRMultiOption";
            this.btnJRMultiOption.Size = new System.Drawing.Size(199, 81);
            this.btnJRMultiOption.TabIndex = 4;
            this.btnJRMultiOption.Text = "Jokers Revenge";
            this.btnJRMultiOption.UseVisualStyleBackColor = true;
            // 
            // btnBJMultiOption
            // 
            this.btnBJMultiOption.Location = new System.Drawing.Point(192, 227);
            this.btnBJMultiOption.Name = "btnBJMultiOption";
            this.btnBJMultiOption.Size = new System.Drawing.Size(199, 81);
            this.btnBJMultiOption.TabIndex = 3;
            this.btnBJMultiOption.Text = "Black Jack";
            this.btnBJMultiOption.UseVisualStyleBackColor = true;
            // 
            // multiPlayerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJRMultiOption);
            this.Controls.Add(this.btnBJMultiOption);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "multiPlayerMenu";
            this.Text = "multiPlayerMenu";
            this.Load += new System.EventHandler(this.multiPlayerMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJRMultiOption;
        private System.Windows.Forms.Button btnBJMultiOption;
    }
}