using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament
{
    public class Player
    {
        public string Name;
        public string SurName;
        public int ELO;
        public Player(string name, string surname, int elo)
        {
            Name = name;
            SurName = surname;
            ELO = elo;
        }
    }
}
