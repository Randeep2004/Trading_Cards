using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TradingCards
{
    public partial class AddPlayerForm : Form
    {
        public Player NewPlayer { get; private set; }

        public AddPlayerForm()
        {
            InitializeComponent();
        }

        private void btnBrowsePhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpeg;*.jpg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPhotoPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtTeam.Text) ||
                string.IsNullOrWhiteSpace(txtPhotoPath.Text) ||
                !int.TryParse(txtPoints.Text, out int points) ||
                !int.TryParse(txtAssists.Text, out int assists) ||
                !int.TryParse(txtRebounds.Text, out int rebounds) ||
                !int.TryParse(txtMatches.Text, out int matches) ||
                !File.Exists(txtPhotoPath.Text))
            {
                MessageBox.Show("Please fill in all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create new player
            NewPlayer = new Player
            {
                Name = txtName.Text,
                Team = txtTeam.Text,
                Photo = txtPhotoPath.Text,
                Points = points,
                Assists = assists,
                Rebounds = rebounds,
                Matches = matches
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
