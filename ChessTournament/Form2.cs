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
            comboBox1.DataSource = allLoadedTournaments;
            comboBox1.DisplayMember = "Name";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string playerW = textBox1.Text;
            string playerB = textBox2.Text;
            float result = float.Parse(textBox3.Text);
            int round = int.Parse(textBox4.Text) - 1;
            Game game = new Game(playerW, playerB, result);
            CurrentTournament.AddGame(game, round);
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
        }
    }
}
