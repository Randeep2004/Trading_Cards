using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace TradingCards
{
    public partial class Form1 : Form
    {
        private List<Player> players;
        private Dictionary<string, Color> teamColors;

        public Form1()
        {
            InitializeComponent();
            teamColors = InitializeTeamColors();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPlayers();
            BindPlayerList();
        }

        private void LoadPlayers()
        {
            players = new List<Player>
            {
                
                new Player { Name = "LeBron James", Team = "Lakers", Photo = "lebronjames.jpeg", Points = 27, Assists = 7, Rebounds = 7, Matches = 1300 },
                new Player { Name = "Anthony Davis", Team = "Lakers", Photo = "anthonydavis.jpeg", Points = 23, Assists = 3, Rebounds = 9, Matches = 750 },
                new Player { Name = "Russell Westbrook", Team = "Lakers", Photo = "russellwestbrook.jpeg", Points = 18, Assists = 9, Rebounds = 5, Matches = 1200 },
                new Player { Name = "Carmelo Anthony", Team = "Lakers", Photo = "carmeloanthony.jpeg", Points = 22, Assists = 3, Rebounds = 6, Matches = 1100 },

               
                new Player { Name = "Kevin Durant", Team = "Suns", Photo = "kevindurant.jpeg", Points = 27, Assists = 5, Rebounds = 7, Matches = 1100 },
                new Player { Name = "Chris Paul", Team = "Suns", Photo = "chrispaul.jpeg", Points = 16, Assists = 9, Rebounds = 5, Matches = 1200 },
                new Player { Name = "Devin Booker", Team = "Suns", Photo = "devinbooker.jpeg", Points = 27, Assists = 5, Rebounds = 5, Matches = 550 },

               
                new Player { Name = "Stephen Curry", Team = "Warriors", Photo = "stephencurry.jpeg", Points = 30, Assists = 6, Rebounds = 6, Matches = 850 },
                new Player { Name = "Klay Thompson", Team = "Warriors", Photo = "klaythompson.jpeg", Points = 20, Assists = 3, Rebounds = 4, Matches = 650 },
                new Player { Name = "Draymond Green", Team = "Warriors", Photo = "draymondgreen.jpeg", Points = 10, Assists = 8, Rebounds = 6, Matches = 1000 }
            };
        }

        private void BindPlayerList()
        {
            lstPlayers.DataSource = null;
            lstPlayers.DataSource = players.Select(p => p.Name).ToList();
        }

        private void lstPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex == -1) return;

            var selectedPlayer = players.FirstOrDefault(p => p.Name == lstPlayers.SelectedItem.ToString());
            if (selectedPlayer == null) return;

            lblName.Text = $"Name: {selectedPlayer.Name}";
            lblTeam.Text = $"Team: {selectedPlayer.Team}";
            picPlayer.ImageLocation = System.IO.File.Exists(selectedPlayer.Photo) ? selectedPlayer.Photo : "default.jpeg";
            pnlCardView.BackColor = teamColors.TryGetValue(selectedPlayer.Team, out var color) ? color : Color.White;

            rtbStats.Clear();
            AppendStat("Points", selectedPlayer.Points, 25);
            AppendStat("Assists", selectedPlayer.Assists, 5);
            AppendStat("Rebounds", selectedPlayer.Rebounds, 7);
            AppendStat("Matches", selectedPlayer.Matches, 500);
        }

        private void AppendStat(string statName, int value, int threshold)
        {
            rtbStats.SelectionStart = rtbStats.TextLength;
            rtbStats.SelectionLength = 0;

            rtbStats.SelectionColor = value > threshold ? Color.Green : Color.Red;
            rtbStats.AppendText($"{statName}: {value}\n");

            rtbStats.SelectionColor = rtbStats.ForeColor;
        }

        private Dictionary<string, Color> InitializeTeamColors()
        {
            return new Dictionary<string, Color>
            {
                { "Lakers", Color.FromArgb(85, 37, 130) },
                { "Suns", Color.FromArgb(255, 85, 0) },
                { "Warriors", Color.FromArgb(255, 221, 51) }
            };
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            var addPlayerForm = new AddPlayerForm();
            if (addPlayerForm.ShowDialog() == DialogResult.OK)
            {
                players.Add(addPlayerForm.NewPlayer);
                BindPlayerList();
            }
        }
        
        


       
    }
}
