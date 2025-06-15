using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessTournament
{
    public partial class Form2 : Form
    {
        private List<Tournament> allLoadedTournaments;
        private Tournament CurrentTournament;
        public Form2()
        {
            InitializeComponent();
            allLoadedTournaments = new List<Tournament>();

        }

        private void Form2_Load(object sender, EventArgs e)
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
            BindingSource source = new BindingSource();
            source.DataSource = allLoadedTournaments;
            comboBox1.DataSource = source;
            comboBox1.DisplayMember = "Name";
            comboBoxResult.Items.Add("0 (Black wins)");
            comboBoxResult.Items.Add("0.5 (Draw)");
            comboBoxResult.Items.Add("1 (White wins)");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (CurrentTournament == null)
            {
                MessageBox.Show("Please select a tournament first.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter white player name.");
                label1.ForeColor = Color.Red;
                return;
            }
            string playerW = textBox1.Text;
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter white player name.");
                label2.ForeColor = Color.Red;
                return;
            }
            string playerB = textBox2.Text;
            if (comboBoxResult.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a game result.");
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
            int round;
            if (!int.TryParse(textBox4.Text, out round))
            {
                MessageBox.Show("Please enter a valid round number.");
                label4.ForeColor = Color.Red;
                return;
            }
            else
            {
                round--;
                if (round < 0 || round >= CurrentTournament.AmountOfRounds)
                {
                    MessageBox.Show($"Round number must be between 1 and {CurrentTournament.AmountOfRounds}.");
                    label4.ForeColor = Color.Red;
                    return;
                }
            }
            Game game = new Game(playerW, playerB, result);
            CurrentTournament.AddGame(game, round);
            MessageBox.Show("Game sdded successfuly");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CurrentTournament = comboBox1.SelectedItem as Tournament;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var tournament in allLoadedTournaments)
            {
                tournament.Save();
            }
            MessageBox.Show("Game saved successfully");
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Please enter a tournament name.");
                label5.ForeColor = Color.Red;
                return;
            }
            string tournamentName = textBox5.Text;
            int amountOfRounds;
            if (!int.TryParse(textBox6.Text, out amountOfRounds))
            {
                MessageBox.Show("Please enter a valid number of rounds.", "Validation Error");
                label6.ForeColor = Color.Red;
                return;
            }
            else if (amountOfRounds < 1)
            {
                MessageBox.Show("Number of rounds must be grater than 1");
                label6.ForeColor = Color.Red;
                return;
            }
            int year;
            if (!int.TryParse(textBox7.Text, out year))
            {
                MessageBox.Show("Please enter a valid year.");
                label7.ForeColor = Color.Red;
                return;
            }
            else if (year < 1900 || year > 2100)
            {
                MessageBox.Show("Year must be between 1900 and 2100.");
                label7.ForeColor = Color.Red;
                return;
            }
            Tournament tournament = new Tournament(amountOfRounds, year, tournamentName);
            allLoadedTournaments.Add(tournament);
            comboBox1.DataSource = allLoadedTournaments;
            comboBox1.DisplayMember = "Name";
            allLoadedTournaments.Add(tournament);
            MessageBox.Show("Tournament added successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var tournament in allLoadedTournaments)
            {
                tournament.Save();
            }
            MessageBox.Show("Tournament saved successfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Form1 = new Form1();
            Form1.Show();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Black;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void comboBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }
    }
}
