using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament
{
    public class Game
    {
        public string PlayerW;
        public string PlayerB;
        public float Result;
        public Game(string playerw, string playerb, float result)
        {
            PlayerW = playerw;
            PlayerB = playerb;
            Result = result;
        }

        public void Edit(string playerw, string playerb, float result)
        {
            PlayerW = playerw;
            PlayerB = playerb;
            Result = result;
        }

    }
}
