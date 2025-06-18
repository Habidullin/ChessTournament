using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChessTournament
{
    // Клас, що представляє шаховий турнір з множиною ігор, організованих по турах.
    // Забезпечує функції створення, збереження та завантаження турнірів з файлової системи.
    public class Tournament
    {
        // Список турів, кожен з яких містить список ігор для цього туру
        public List<List<Game>> Games;
        // Загальна кількість турів в турнірі
        public int AmountOfRounds;
        // Рік проведення турніру
        public int Year;
        // Назва турніру
        public string Name { get; set; }
        // Базова директорія для зберігання всіх турнірів в системі
        public static string _baseTournamentDirectory;

        static Tournament()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            _baseTournamentDirectory
                 = Path.Combine(appDataPath, "ChessTournamentApp", "Tournaments");
            if (!Directory.Exists(_baseTournamentDirectory))
            {
                Directory.CreateDirectory(_baseTournamentDirectory);
            }
        }
        public Tournament(int amountOfRounds, int year, string name)
        {
            AmountOfRounds = amountOfRounds;
            Year = year;
            Games = new List<List<Game>>(amountOfRounds);
            for (int i = 0; i < amountOfRounds; i++)
            {
                Games.Add(new List<Game>());
            }
            Name = name;
        }
        public void AddGame(Game game, int Round)
        {
            if (Round >= 0 && Round < AmountOfRounds)
            {
                Games[Round].Add(game);
            }

        }

        public void Save()
        {
            string tournamentFolderName = $"{Name}-{AmountOfRounds}-{Year}";
            string tournamentDirectoryPath = Path.Combine(_baseTournamentDirectory, tournamentFolderName);
            Directory.CreateDirectory(tournamentDirectoryPath);

            for (int i = 0; i < Games.Count; i++)
            {
                string roundFilePath = Path.Combine(tournamentDirectoryPath, $"games_round_{i + 1}.txt");
                List<string> gameLines = Games[i].Select(game => $"{game.PlayerW}-{game.PlayerB}-{game.Result}").ToList();
                File.WriteAllLines(roundFilePath, gameLines);
            }
        }

        public static Tournament Load(string tournamentFolderName)
        {
            string tournamentDirectoryPath = Path.Combine(_baseTournamentDirectory, tournamentFolderName);
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
                        string[] parts = line.Split('-');
                        if (parts.Length == 3)
                        {
                            string playerW = parts[0];
                            string playerB = parts[1];
                            string result = parts[2];
                            float fresult = 0.5f;
                            if (result == "0" || result == "1")
                            {
                                fresult = float.Parse(result);
                            }
                            loadedTournament.AddGame(new Game(playerW, playerB, fresult), i);
                        }
                    }
                }
            }
            return loadedTournament;
        }
        public static List<string> ListAvailableTournaments()
        {
            if (!Directory.Exists(_baseTournamentDirectory))
            {
                return new List<string>(); 
            }

            return Directory.GetDirectories(_baseTournamentDirectory).Select(Path.GetFileName).ToList();
        }
    }
}
