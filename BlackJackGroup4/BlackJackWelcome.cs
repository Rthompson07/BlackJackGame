using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BlackJackGroup4
{
    public partial class BlackJackWelcome : Form
    {
        Theme theme;
        int numPlayers = 0;
        String mode = "";
        private MusicPlayer musicPlayer;
        bool joker = false;
        private Dictionary<Button, Size> originalButtonSizes = new Dictionary<Button, Size>();
        private Dictionary<Button, Point> originalButtonLocations = new Dictionary<Button, Point>();

        public BlackJackWelcome()
        {
            InitializeComponent();
            UpdateStartButtonEnabledState();
            pnlMenuOptions.BackColor = Color.FromArgb(130, Color.DimGray);
            musicPlayer = new MusicPlayer();
           

        }

        private void Menu_Refresh()
        {
            mode = "";
            numPlayers = 0;
            btnStart.Enabled = false;
            foreach (Control control in this.Controls)
            {
                if (control is Panel panel)
                {
                    foreach (Control ctrl in panel.Controls)
                    {
                        if (ctrl is GroupBox grpBox)
                        {
                            foreach (Control cntrl in grpBox.Controls)
                            {
                                if (cntrl is Button btn)
                                {                                    
                                    btn.Enabled = true;
                                }
                            }
                        }
                    }
                }
            }
            // Keeping multiplayer disabled since it doesn't work.
            buttonMultiPlay.Enabled = false;
        }
        private void Button_Enter(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Store the original size and location of the button if not already stored
            if (!originalButtonSizes.ContainsKey(button))
            {
                originalButtonSizes.Add(button, button.Size);
                originalButtonLocations.Add(button, button.Location);
            }

            // Calculate the increased size as a percentage of the original size
            float zoomFactor = 1.1f; // 10% increase
            Size newSize = new Size((int)(originalButtonSizes[button].Width * zoomFactor), (int)(originalButtonSizes[button].Height * zoomFactor));

            // Adjust the size of the button to create a zoom effect
            button.BackColor = Color.LightYellow;
            button.Size = newSize;
            // Adjust the location to keep the button centered
            button.Location = new Point(originalButtonLocations[button].X - (newSize.Width - originalButtonSizes[button].Width) / 2,
                                        originalButtonLocations[button].Y - (newSize.Height - originalButtonSizes[button].Height) / 2);
        }

        // Event handler for mouse leaving the button
        private void Button_Leave(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Restore the original size and location of the button
            button.BackColor = Color.FromArgb(128, Color.WhiteSmoke);
            button.Size = originalButtonSizes[button];
            button.Location = originalButtonLocations[button];
        }
       
        private void BlackJackWelcome_Load(object sender, EventArgs e)
        {
            theme = new Theme(this);
        }

        private void buttonMultiPlay_Click(object sender, EventArgs e)
        {
            numPlayers = 2;
            buttonSinglePlayer.Enabled = true;
            buttonMultiPlay.Enabled = false;
            UpdateStartButtonEnabledState();
        }


        private void buttonSingle_Click(object sender, EventArgs e)
        {
            numPlayers = 1;
            buttonSinglePlayer.Enabled = false;
            //buttonMultiPlay.Enabled = true;
            UpdateStartButtonEnabledState();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void buttonSoundOff_Click(object sender, EventArgs e)
        {
            theme.PlayBackgroundMusic();
            buttonSoundOn.Visible = true;
            buttonSoundOff.Visible = false;
        }

        private void buttonSoundOn_Click(object sender, EventArgs e)
        {

            theme.StopBackgroundMusic();
            buttonSoundOn.Visible = false;
            buttonSoundOff.Visible = true;

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            gameSettings settingsMenuForm = new gameSettings(this, theme);
            settingsMenuForm.Show();
            Menu_Refresh();
            this.Hide();
        }

        private void btnJoker_Click(object sender, EventArgs e)
        {
            mode = "j";
            btnClassic.Enabled = true;
            btnJoker.Enabled = false;
            UpdateStartButtonEnabledState();
            joker = true;
        }

        private void btnClassic_Click(object sender, EventArgs e)
        {
            mode = "c";
            btnClassic.Enabled = false;
            btnJoker.Enabled = true;
            UpdateStartButtonEnabledState();
            joker = false;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
           // if (numPlayers == 1 && mode == "c")
            //{
                string selectedMusicFilePath = gameSettings.GetSelectedMusicFilePath();
                frmSinglePlayer singlePlayer = new frmSinglePlayer(this, this.BackgroundImage, selectedMusicFilePath, joker);
                singlePlayer.Show();
                Menu_Refresh();
                this.Hide();
            //}
        }

        private void UpdateStartButtonEnabledState()
        {
            if(numPlayers != 0 && !string.IsNullOrEmpty(mode)){
                btnStart.Enabled = true;
            }
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
                Application.Exit(); 
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            frmInfoPage InfoPage = new frmInfoPage();
            InfoPage.Show();
        }

    }
}
