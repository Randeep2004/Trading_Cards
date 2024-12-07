namespace TradingCards
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private ListBox lstPlayers;
        private Label lblName;
        private Label lblTeam;
        private PictureBox picPlayer;
        private RichTextBox rtbStats;
        private Button btnAddPlayer;
        private Panel pnlCardView;

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
            lstPlayers = new ListBox();
            lblName = new Label();
            lblTeam = new Label();
            picPlayer = new PictureBox();
            rtbStats = new RichTextBox();
            btnAddPlayer = new Button();
            pnlCardView = new Panel();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            pnlCardView.SuspendLayout();
            SuspendLayout();
            // 
            // lstPlayers
            // 
            lstPlayers.FormattingEnabled = true;
            lstPlayers.Location = new Point(12, 12);
            lstPlayers.Name = "lstPlayers";
            lstPlayers.Size = new Size(200, 284);
            lstPlayers.TabIndex = 0;
            lstPlayers.SelectedIndexChanged += lstPlayers_SelectedIndexChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name: ";
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Location = new Point(0, 20);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(52, 20);
            lblTeam.TabIndex = 2;
            lblTeam.Text = "Team: ";
            // 
            // picPlayer
            // 
            picPlayer.Location = new Point(0, 55);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(245, 184);
            picPlayer.TabIndex = 3;
            picPlayer.TabStop = false;
            // 
            // rtbStats
            // 
            rtbStats.Location = new Point(230, 257);
            rtbStats.Name = "rtbStats";
            rtbStats.Size = new Size(150, 100);
            rtbStats.TabIndex = 4;
            rtbStats.Text = "";
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.Location = new Point(12, 302);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(200, 33);
            btnAddPlayer.TabIndex = 5;
            btnAddPlayer.Text = "Add Player";
            btnAddPlayer.UseVisualStyleBackColor = true;
            btnAddPlayer.Click += btnAddPlayer_Click;
            // 
            // pnlCardView
            // 
            pnlCardView.BackColor = Color.White;
            pnlCardView.Controls.Add(picPlayer);
            pnlCardView.Controls.Add(lblTeam);
            pnlCardView.Controls.Add(lblName);
            pnlCardView.Location = new Point(230, 12);
            pnlCardView.Name = "pnlCardView";
            pnlCardView.Size = new Size(245, 239);
            pnlCardView.TabIndex = 6;
            // 
            // Form1
            // 
            ClientSize = new Size(515, 376);
            Controls.Add(btnAddPlayer);
            Controls.Add(rtbStats);
            Controls.Add(lstPlayers);
            Controls.Add(pnlCardView);
            Name = "Form1";
            Text = "Trading Cards";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            pnlCardView.ResumeLayout(false);
            pnlCardView.PerformLayout();
            ResumeLayout(false);
        }
    }
}
