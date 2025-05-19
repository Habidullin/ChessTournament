namespace ChessTournament
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tournament myTournament = new Tournament(3, 2025, "TestTournament");
            myTournament.AddGame(new Game("Alice", "Bob", 0), 0);
            myTournament.AddGame(new Game("Charlie", "David", 1), 1);
            string saveDirectory = "tournament_data";
            Directory.CreateDirectory(saveDirectory);
            myTournament.Save(saveDirectory);
        }
    }
}
