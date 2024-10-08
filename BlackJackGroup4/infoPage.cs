using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackGroup4
{
    public partial class frmInfoPage : Form
    {
        public frmInfoPage()
        {
            InitializeComponent();
        }

        private void infoPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            string message = "BlackJack Classic™\"\n\nTeam" + "\n\n" + "\nIsaac Wiscox\nJohn France\nRamiyan Gangtharanm\nRhys Thompson\nSarah Masrie";
            MessageBox.Show(message, "About Us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void circularButton2_Click(object sender, EventArgs e)
        {                                                                                                                                
            string message = "These Terms and Conditions govern your use of the Black Jack Classic ™ game developed by Group 4. By accessing or playing the game, you agree to be bound by these Terms and Conditions. If you do not agree with any part of these Terms and Conditions, you may not use or play the game.";
            MessageBox.Show(message, "Terms & Conditions ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void circularButton3_Click(object sender, EventArgs e)
        {
            string youtubeLink = "https://www.youtube.com/watch?v=BUh7jauOeF8";
            Process.Start(youtubeLink);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmInfoPage InfoPage = new frmInfoPage();
            InfoPage.Hide();
            InfoPage.Close();
            BlackJackWelcome BlackJackWelcomePage = new BlackJackWelcome();
            BlackJackWelcomePage.Show();
        }
    }
}
