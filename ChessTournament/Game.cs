using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament
{
    public class Game
    {
        public string playerW;
        public string playerB;
        public float Result;
        Game(string playerw, string playerb, float result) {
            playerB = playerb;
            playerW = playerw;
            Result = result;
        }

    }
}
