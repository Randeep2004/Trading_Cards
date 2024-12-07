namespace TradingCards
{
    partial class AddPlayerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTeam = new System.Windows.Forms.Label();
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.txtPhotoPath = new System.Windows.Forms.TextBox();
            this.btnBrowsePhoto = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.lblAssists = new System.Windows.Forms.Label();
            this.txtAssists = new System.Windows.Forms.TextBox();
            this.lblRebounds = new System.Windows.Forms.Label();
            this.txtRebounds = new System.Windows.Forms.TextBox();
            this.lblMatches = new System.Windows.Forms.Label();
            this.txtMatches = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Name
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 15);
            this.lblName.Text = "Name:";
            this.txtName.Location = new System.Drawing.Point(100, 12);
            this.txtName.Size = new System.Drawing.Size(200, 23);

            // Team
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(12, 50);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(40, 15);
            this.lblTeam.Text = "Team:";
            this.txtTeam.Location = new System.Drawing.Point(100, 47);
            this.txtTeam.Size = new System.Drawing.Size(200, 23);

            // Photo Path
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(12, 85);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(76, 15);
            this.lblPhoto.Text = "Photo Path:";
            this.txtPhotoPath.Location = new System.Drawing.Point(100, 82);
            this.txtPhotoPath.Size = new System.Drawing.Size(200, 23);
            this.btnBrowsePhoto.Location = new System.Drawing.Point(310, 82);
            this.btnBrowsePhoto.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsePhoto.Text = "Browse";
            this.btnBrowsePhoto.Click += new System.EventHandler(this.btnBrowsePhoto_Click);

            // Points
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(12, 120);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(44, 15);
            this.lblPoints.Text = "Points:";
            this.txtPoints.Location = new System.Drawing.Point(100, 117);
            this.txtPoints.Size = new System.Drawing.Size(100, 23);

            // Assists
            this.lblAssists.AutoSize = true;
            this.lblAssists.Location = new System.Drawing.Point(12, 155);
            this.lblAssists.Name = "lblAssists";
            this.lblAssists.Size = new System.Drawing.Size(47, 15);
            this.lblAssists.Text = "Assists:";
            this.txtAssists.Location = new System.Drawing.Point(100, 152);
            this.txtAssists.Size = new System.Drawing.Size(100, 23);

            // Rebounds
            this.lblRebounds.AutoSize = true;
            this.lblRebounds.Location = new System.Drawing.Point(12, 190);
            this.lblRebounds.Name = "lblRebounds";
            this.lblRebounds.Size = new System.Drawing.Size(63, 15);
            this.lblRebounds.Text = "Rebounds:";
            this.txtRebounds.Location = new System.Drawing.Point(100, 187);
            this.txtRebounds.Size = new System.Drawing.Size(100, 23);

            // Matches
            this.lblMatches.AutoSize = true;
            this.lblMatches.Location = new System.Drawing.Point(12, 225);
            this.lblMatches.Name = "lblMatches";
            this.lblMatches.Size = new System.Drawing.Size(57, 15);
            this.lblMatches.Text = "Matches:";
            this.txtMatches.Location = new System.Drawing.Point(100, 222);
            this.txtMatches.Size = new System.Drawing.Size(100, 23);

            // Add Button
            this.btnAdd.Location = new System.Drawing.Point(100, 260);
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // Cancel Button
            this.btnCancel.Location = new System.Drawing.Point(200, 260);
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(400, 310);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.txtTeam);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.txtPhotoPath);
            this.Controls.Add(this.btnBrowsePhoto);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.lblAssists);
            this.Controls.Add(this.txtAssists);
            this.Controls.Add(this.lblRebounds);
            this.Controls.Add(this.txtRebounds);
            this.Controls.Add(this.lblMatches);
            this.Controls.Add(this.txtMatches);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddPlayerForm";
            this.Text = "Add New Player";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblName;
        private TextBox txtName;
        private Label lblTeam;
        private TextBox txtTeam;
        private Label lblPhoto;
        private TextBox txtPhotoPath;
        private Button btnBrowsePhoto;
        private Label lblPoints;
        private TextBox txtPoints;
        private Label lblAssists;
        private TextBox txtAssists;
        private Label lblRebounds;
        private TextBox txtRebounds;
        private Label lblMatches;
        private TextBox txtMatches;
        private Button btnAdd;
        private Button btnCancel;
    }
}
