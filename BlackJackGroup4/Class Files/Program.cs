﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Console
{
    internal class Program
    {
        static void Kay(string[] args)
        {
            Game game = new Game();
            game.PlayGame();
        }
    }
}
