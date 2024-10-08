using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGroup4
{
    public class User
    {
        public string username;
        
        public User() 
        { 
            username = string.Empty;
        }
        public User(string username)
        {
            this.username = username;
        }   
    }
}
