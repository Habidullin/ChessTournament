namespace ChessTournament
{
    public partial class Form1 : Form
    {
        private List<Tournament> allLoadedTournaments;
        public Form1()
        {
            InitializeComponent();
            allLoadedTournaments = new List<Tournament>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> availableTournamentFolders = Tournament.ListAvailableTournaments();
            if (availableTournamentFolders != null)
            {
                foreach (string folderName in availableTournamentFolders)
                {
                    Tournament loadedTournament = Tournament.Load(folderName);
                    if (loadedTournament != null)
                    {
                        allLoadedTournaments.Add(loadedTournament);
                    }
                }
            }
            foreach (Tournament tournament in allLoadedTournaments)
            {
                listBox1.Items.Add(tournament.Name);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tournament chosenTournament = null;
            textBox1.Clear();
            foreach (var tournament in allLoadedTournaments)
            {
                if (tournament.Name == listBox1.SelectedItem.ToString())
                {
                    chosenTournament = tournament;
                    break;
                }
            }
            if (chosenTournament.Games.Count != 0)
            {
                for (int i = 0; i < chosenTournament.AmountOfRounds; i++)
                {
                    foreach (var game in chosenTournament.Games[i])
                    {
                        textBox1.Text += $"{game.PlayerW}-{game.PlayerB} {game.Result}{Environment.NewLine}";
                    }
                }
            }
            else
            {
                textBox1.Text = $"there are no games";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
