using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGroup4
{
    public class PlayerStats
    {
        public int wins;
        public int loses;
        public int ties;
        public int gamesPlayed;
        public double WinRate => gamesPlayed == 0 ? 0:(double)wins/gamesPlayed;

    }
}
