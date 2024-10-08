using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace BlackJackGroup4
{
    public class Theme
    {
        private Form form; // Instance variable to hold the form
        private SoundPlayer musicPlayer; // Instance variable to hold the music player
        private string musicPath; // Instance variable to hold the path of the music file

        public Theme(Form form)
        {
            this.form = form;
            ApplyDefaultTheme(); // Apply default theme when instantiated
        }

        public Theme(Form form, Image backgroundImage, string musicPath)
        {
            this.form = form;
            ApplyTheme(backgroundImage, musicPath); // Allow user to set custom theme
        }

        public void ApplyTheme(Image backgroundImage, string musicPath)
        {
            // Set background image
            if (backgroundImage != null)
            {
                form.BackgroundImage = backgroundImage;
                form.BackgroundImageLayout = ImageLayout.Stretch;
            }

            // Initialize or change the background music
            if (!string.IsNullOrEmpty(musicPath) && System.IO.File.Exists(musicPath))
            {
                this.musicPath = musicPath;
                InitializeMusicPlayer();
            }
        }

        public void ApplyDefaultTheme()
        {
            // Set default image and music paths here
            Image defaultBackground = Properties.Resources.vegas; // Default background image
            string defaultMusicPath = "blackjack.wav"; // Default music path
            ApplyTheme(defaultBackground, defaultMusicPath);
        }

        // Initialize the music player
        private void InitializeMusicPlayer()
        {
            if (musicPlayer != null)
            {
                musicPlayer.Dispose(); // Dispose the existing music player
            }
            musicPlayer = new SoundPlayer(musicPath);
        }

        // Play the background music
        public void PlayBackgroundMusic()
        {
            if (musicPlayer != null)
            {
                musicPlayer.PlayLooping();
            }
        }

        // Stop the background music
        public void StopBackgroundMusic()
        {
            if (musicPlayer != null)
            {
                musicPlayer.Stop();
            }
        }
    }
}