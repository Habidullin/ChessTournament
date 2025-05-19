using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament
{
    public class Tournament
    {
        public List<List<Game>> Games;
        public int AmountOfRounds;
        public int Year;
        public Tournament(int amountOfRounds, int year)
        {
            AmountOfRounds = amountOfRounds;
            Year = year;
            Games = new List<List<Game>>(amountOfRounds);
        }
        public void AddGame(Game game, int Round)
        {
            if (Round >= 0 && Round < AmountOfRounds)
            {
                if (Games.Count <= Round)
                {
                    Games.Add(new List<Game>());
                }
                Games[Round].Add(game);
            }

        }

    }
}
