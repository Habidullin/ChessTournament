using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChessTournament
{
    public partial class Form3 : Form
    {
        private List<Tournament> allLoadedTournaments;
        private List<(Game game, int round, int gameIndex)> allGames;
        private Tournament selectedTournament;
        private Game selectedGame;
        private int selectedRound;
        private int selectedGameIndex;

        public Form3()
        {
            InitializeComponent();
            allLoadedTournaments = new List<Tournament>();
            allGames = new List<(Game game, int round, int gameIndex)>();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadTouraments();
            comboBoxTournaments.DataSource = allLoadedTournaments;
            comboBoxTournaments.DisplayMember = "Name";
            comboBoxResult.Items.Add("0 (Black wins)");
            comboBoxResult.Items.Add("0.5 (Draw)");
            comboBoxResult.Items.Add("1 (White wins)");
        }

        private void LoadTouraments()
        {
            allLoadedTournaments.Clear();
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
        }

        private void comboBoxTournaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTournaments.SelectedItem != null)
            {
                selectedTournament = (Tournament)comboBoxTournaments.SelectedItem;
                ClearSelection();
                LoadGames();
            }
            else
            {
                selectedTournament = null;
                ClearSelection();
            }
        }

        private void LoadGames()
        {
            comboBoxGames.Items.Clear();
            allGames.Clear();
            if (selectedTournament != null)
            {
                for (int round = 0; round < selectedTournament.Games.Count; round++)
                {
                    for (int i = 0; i < selectedTournament.Games[round].Count; i++)
                    {
                        Game game = selectedTournament.Games[round][i];
                        string resultText = game.Result == 1 ? "1-0" : game.Result == 0 ? "0-1" : "0.5-0.5";
                        comboBoxGames.Items.Add($"Round {round + 1}: {game.PlayerW} vs {game.PlayerB} ({resultText})");

                        allGames.Add((game, round, i));
                    }
                }
            }

        }

        private void comboBoxGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGames.SelectedIndex < 0 || selectedTournament == null)
            {
                ClearSelection();
                return;
            }
            var gameInfo = allGames[comboBoxGames.SelectedIndex];
            selectedGame = gameInfo.game;
            selectedRound = gameInfo.round;
            selectedGameIndex = gameInfo.gameIndex;

            textBoxWhite.Text = selectedGame.PlayerW;
            textBoxBlack.Text = selectedGame.PlayerB;
            if (selectedGame.Result == 0)
            {
                comboBoxResult.SelectedIndex = 0;
            }
            else if (selectedGame.Result == 0.5f)
            {
                comboBoxResult.SelectedIndex = 1;
            }
            else if (selectedGame.Result == 1)
            {
                comboBoxResult.SelectedIndex = 2;
            }
            else
            {
                comboBoxResult.SelectedIndex = -1;
            }

        }

        private void ClearSelection()
        {
            selectedGame = null;
            selectedGameIndex = -1;
            selectedRound = -1;
            textBoxWhite.Text = "";
            textBoxBlack.Text = "";
            comboBoxResult.SelectedIndex = -1;
            comboBoxGames.SelectedIndex = -1;
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            ClearSelection();
            LoadTouraments();
            comboBoxTournaments.DataSource = null;
            comboBoxTournaments.DataSource = allLoadedTournaments;
            comboBoxTournaments.DisplayMember = "Name";
            LoadGames();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxGames.SelectedIndex == -1)
            {
                MessageBox.Show("No game selected");
                return;
            }
            if (string.IsNullOrEmpty(textBoxWhite.Text))
            {
                MessageBox.Show("Please enter white player");
                label1.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrEmpty(textBoxBlack.Text))
            {
                MessageBox.Show("Please enter black player");
                label2.ForeColor = Color.Red;
                return;
            }
            if (comboBoxResult.SelectedIndex == -1)
            {
                MessageBox.Show("Please select result");
                label3.ForeColor = Color.Red;
                return;
            }
            float result;
            switch (comboBoxResult.SelectedIndex)
            {
                case 0: result = 0; break;
                case 1: result = 0.5f; break;
                case 2: result = 1; break;
                default:
                    MessageBox.Show("Invalid result selection");
                    return;
            }
            selectedGame.Edit(textBoxWhite.Text, textBoxBlack.Text, result);

            LoadGames();
            ClearSelection();
            MessageBox.Show("Game edited successfully");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            foreach (var tournament in allLoadedTournaments)
            {
                tournament.Save();
            }
            MessageBox.Show("Games saved successfully");
        }

        private void textBoxWhite_TextChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void textBoxBlack_TextChanged(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void comboBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedGame == null)
            {
                MessageBox.Show("No game selected");
                return;
            }
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the game between {selectedGame.PlayerW} and {selectedGame.PlayerB}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                selectedTournament.Games[selectedRound].RemoveAt(selectedGameIndex);
                LoadGames();
                ClearSelection();
            }
        }

        private void buttonBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Form1 = new Form1();
            Form1.Show();

        }
    }
}
