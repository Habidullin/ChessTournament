using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament
{
    public class Game
    {
        public Player playerW;
        public Player playerB;
        public float Result;
        Game(Player playerw, Player playerb, float result) {
            playerB = playerb;
            playerW = playerw;
            Result = result;
        }

    }
}
