using System;
using System.Drawing;
using System.Windows.Forms;

namespace BlackJackGroup4
{
    public partial class LaunchScreen : Form
    {
        private MusicPlayer musicPlayer;

        public LaunchScreen()
        {
            InitializeComponent();
            KeyPreview = true;
            this.Load += LaunchScreen_Load;
            this.KeyPress += LaunchScreen_KeyPress;
            musicPlayer = new MusicPlayer();
        }

        private void LaunchScreen_Load(object sender, EventArgs e)
        {
            // Load the image
            Image image = Properties.Resources.blackjack;

            // Resize the image to fit the pictureBox
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = ResizeImage(image, pictureBox.Size.Width, pictureBox.Size.Height);

            lblPrompt.Text = "Click any button to continue...";
            this.Show();
            musicPlayer.LoadMusic("blackjack.wav");
            musicPlayer.Play();
        }

        private void LaunchScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Hide the form and show the main menu form when any key is pressed.
            this.Hide();
            BlackJackWelcome mainMenu = new BlackJackWelcome();
            mainMenu.Show();
        }

        // Method to resize an image to a specified width and height.
        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(image, 0, 0, width, height);
            }
            return result;
        }
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
