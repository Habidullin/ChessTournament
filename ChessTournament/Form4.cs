using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChessTournament
{
    public partial class Form4 : Form
    {
        private List<Tournament> allLoadedTournaments;
        private Tournament selectedTournament;
        private List<string> tournamentNames;

        public Form4()
        {
            InitializeComponent();
            allLoadedTournaments = new List<Tournament>();
            this.numericUpDownYear.Minimum = 1900;
            this.numericUpDownYear.Maximum = 2100;
        }

        private void buttonBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Form1 = new Form1();
            Form1.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadTouraments();
            comboBoxTournaments.DataSource = allLoadedTournaments;
            comboBoxTournaments.DisplayMember = "Name";
            tournamentNames = new List<string>();
            foreach (Tournament tournament in allLoadedTournaments)
            {
                tournamentNames.Add(tournament.Name);
            }
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
            selectedTournament = (Tournament)comboBoxTournaments.SelectedItem;
            if (selectedTournament != null) 
            {
                textBoxName.Text = selectedTournament.Name;
                numericUpDownYear.Value = selectedTournament.Year;
                numericUpDownAmountOfRounds.Value = selectedTournament.AmountOfRounds;
            }
            else
            {
                textBoxName.Text = string.Empty;
                numericUpDownYear.Value = numericUpDownYear.Minimum;
                numericUpDownAmountOfRounds.Value = numericUpDownAmountOfRounds.Minimum;
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == null)
            {
                MessageBox.Show("Please enter tournament name");
                label1.ForeColor = Color.Red;
                return;
            }
            if (tournamentNames.Contains(textBoxName.Text))
            {
                MessageBox.Show("Such tournament already exists");
                label1.ForeColor = Color.Red;
                return;
            }
            if (numericUpDownYear.Value < 1900 || numericUpDownYear.Value > 2100)
            {
                MessageBox.Show("Year must be more than 1900 and less than 2100");
                label2.ForeColor = Color.Red;
                return;
            }
            string originalFolderPath = Path.Combine(Tournament._baseTournamentDirectory,
                    $"{selectedTournament.Name}-{selectedTournament.AmountOfRounds}-{selectedTournament.Year}");
            selectedTournament.Name = textBoxName.Text;
            selectedTournament.Year = (int)numericUpDownYear.Value;

            int newAmountOfRounds = (int)numericUpDownAmountOfRounds.Value;
            if (newAmountOfRounds < selectedTournament.AmountOfRounds)
            {
                DialogResult result = MessageBox.Show($"Reducing rounds from {selectedTournament.AmountOfRounds} to {newAmountOfRounds} will delete games in rounds {newAmountOfRounds + 1}-{selectedTournament.AmountOfRounds}.\nAre you sure you want to continue?",
                    "Warning, data loss",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            if (newAmountOfRounds != selectedTournament.AmountOfRounds)
            {
                if (newAmountOfRounds > selectedTournament.AmountOfRounds)
                {
                    for (int i = selectedTournament.AmountOfRounds; i < newAmountOfRounds; i++)
                    {
                        selectedTournament.Games.Add(new List<Game>());
                    }

                }
                else
                {
                    for (int i = selectedTournament.AmountOfRounds; i >= newAmountOfRounds; i--)
                    {
                        selectedTournament.Games.RemoveAt(i);
                    }
                }
                selectedTournament.AmountOfRounds = newAmountOfRounds;
            }
            string newFolderPath = Path.Combine(Tournament._baseTournamentDirectory,
                    $"{textBoxName.Text}-{newAmountOfRounds}-{numericUpDownYear.Value}");
            if (originalFolderPath != newFolderPath)
            {
                if (Directory.Exists(originalFolderPath))
                {
                    if (Directory.Exists(newFolderPath))
                    {
                        MessageBox.Show("A tournament with these details already exists.");
                        return;
                    }
                }
                Directory.Move(originalFolderPath, newFolderPath);
            }
            selectedTournament.Save();
            MessageBox.Show("Tournament saved successfully");
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void numericUpDownYear_ValueChanged(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedTournament == null)
            {
                MessageBox.Show("No tournament chosen");
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete the tournament '{selectedTournament.Name}'?\nThis action cannot be undone and will delete all games and data for this tournament.",
                "Confirm Delete Tournament",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string folderPath = Path.Combine(Tournament._baseTournamentDirectory,
                                            $"{selectedTournament.Name}-{selectedTournament.AmountOfRounds}-{selectedTournament.Year}");
                    if (Directory.Exists(folderPath))
                    {
                        Directory.Delete(folderPath, true);
                    }
                    MessageBox.Show("Deleted successfully");
                    LoadTouraments();
                    comboBoxTournaments.DataSource = null;
                    comboBoxTournaments.DataSource = allLoadedTournaments;
                    comboBoxTournaments.DisplayMember = "Name";
                    tournamentNames.Clear();
                    foreach (Tournament tournament in allLoadedTournaments)
                    {
                        tournamentNames.Add(tournament.Name);
                    }
                    selectedTournament = null;
                    textBoxName.Clear();
                    numericUpDownYear.Value = numericUpDownYear.Minimum;
                    numericUpDownAmountOfRounds.Value = numericUpDownAmountOfRounds.Minimum;
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Cannot delete tournament folder.\nError: {ex.Message}");
                }
            }

        }
    }
}
