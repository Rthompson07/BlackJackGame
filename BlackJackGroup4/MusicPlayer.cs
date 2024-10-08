using System;
using System.Media;

namespace BlackJackGroup4
{
    public class MusicPlayer
    {
        private SoundPlayer player;

        public MusicPlayer()
        {
            player = new SoundPlayer();
        }

        public void LoadMusic(string musicFilePath)
        {
            player.SoundLocation = musicFilePath;
        }

        public void Play()
        {
            player.PlayLooping();
        }

        public void Pause()
        {
            player.Stop();
        }

        public void Stop()
        {
            player.Stop();
        }
    }
}
