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
        public string Name;
        public Tournament(int amountOfRounds, int year, string name)
        {
            AmountOfRounds = amountOfRounds;
            Year = year;
            Games = new List<List<Game>>(amountOfRounds);
            Name = name;
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

        public void Save(string directory)
        {
            string infoFilePath = Path.Combine(directory, "tournament_info.txt");
            File.WriteAllLines(infoFilePath, new string[] { $"Name:{Name}", $"Year:{Year}", $"AmountOfRounds:{AmountOfRounds}" });
            for (int i = 0; i < Games.Count; i++)
            {
                string roundFilePath = Path.Combine(directory, $"games_rounf_{i + 1}.txt");
                List<string> gameLines = Games[i].Select(game => $"{game.PlayerW},{game.PlayerB},{game.Result}").ToList();
                File.WriteAllLines(roundFilePath, gameLines);
            }
        }

    }
}
