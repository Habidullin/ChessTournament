using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChessTournament
{
    public class Tournament
    {
        public List<List<Game>> Games;
        public int AmountOfRounds;
        public int Year;
        public string Name { get; set; }
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

        public void Save()
        {
            string tournamentFolderName = $"{Name}-{AmountOfRounds}-{Year}";
            string baseDataDirectory = "ChessTournamentsData";
            string tournamentDirectoryPath = Path.Combine(baseDataDirectory, tournamentFolderName);
            Directory.CreateDirectory(tournamentDirectoryPath);

            for (int i = 0; i < Games.Count; i++)
            {
                string roundFilePath = Path.Combine(tournamentDirectoryPath, $"games_round_{i + 1}.txt");
                List<string> gameLines = Games[i].Select(game => $"{game.PlayerW},{game.PlayerB},{game.Result}").ToList();
                File.WriteAllLines(roundFilePath, gameLines);
            }
        }

        public static Tournament Load(string tournamentFolderName)
        {
            string baseDataDirectory = "ChessTournamentsData";
            string tournamentDirectoryPath = Path.Combine(baseDataDirectory, tournamentFolderName);
            if (!Directory.Exists(tournamentDirectoryPath))
            {
                return null;
            }
            string name = "";
            int year = 0;
            int amountOfRounds = 0;
            string[] tournamentInfo = tournamentFolderName.Split("-");
            if (tournamentInfo.Length == 3)
            {
                name = tournamentInfo[0];
                amountOfRounds = Convert.ToInt32(tournamentInfo[1]);
                year = Convert.ToInt32(tournamentInfo[2]);
                
            }
            else
            {
                return null;
            }
            Tournament loadedTournament = new Tournament(amountOfRounds, year, name);

            for (int i = 0; i < amountOfRounds; i++)
            {
                string roundFilePath = Path.Combine(tournamentDirectoryPath, $"games_round_{i + 1}.txt");

                if (File.Exists(roundFilePath))
                {
                    string[] gameLines = File.ReadAllLines(roundFilePath);
                    foreach (string line in gameLines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            string playerW = parts[0];
                            string playerB = parts[1];
                            if (float.TryParse(parts[2], out float resultValue))
                            {
                                loadedTournament.AddGame(new Game(playerW, playerB, resultValue), i);
                            }
                        }
                    }
                }
            }
            return loadedTournament;
        }
        public static List<string> ListAvailableTournaments()
        {
            string baseDataDirectory = "ChessTournamentsData"; 
            if (!Directory.Exists(baseDataDirectory))
            {
                return new List<string>(); 
            }

            return Directory.GetDirectories(baseDataDirectory).Select(Path.GetFileName).ToList();
        }
    }
}
