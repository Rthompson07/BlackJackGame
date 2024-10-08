using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace BlackJackGroup4
{
    /// <summary>
    /// PlayerManager.cs handles the different user accounts within the game.
    /// 
    /// Player files are written to a local JSON file and then retreived when the game is started up.
    /// 
    /// 
    /// </summary>
    public class PlayerManager
    {
        private List<Player> players;

        public PlayerManager()
        {
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            if (File.Exists("players.json"))
            {
                string json = File.ReadAllText("players.json");
                players = JsonConvert.DeserializeObject<List<Player>>(json);
            }
            else
            {
                players = new List<Player>();
            }
        }
        public void SavePlayers()
        {
            string json = JsonConvert.SerializeObject(players, Formatting.Indented);
            File.WriteAllText("players.json", json);
        }
        public void AddPlayer(Player player)
        {
            players.Add(player);
            SavePlayers();
        }
        public Player GetOrMakePlayer(string username)
        {
            Player player = GetPlayerByUsername(username);
            if(player == null)
            {
                player = new Player(username, 20000);
            }
            
            AddPlayer(player);

            return player;
        }

        // Finally a chance to make use of C#'s best feature, LINQ.
        public Player GetPlayerByUsername(string username)
        {
            return players.FirstOrDefault(p=>p.username == username);
        }
        public Player GetBestPlayer()
        {
            return players.OrderByDescending(p => p.Stats.WinRate).FirstOrDefault();
        }

    }
}
