namespace Game
{
    partial class GameScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblhit = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.stoneTimer = new System.Windows.Forms.Timer(this.components);
            this.stoneTimer2 = new System.Windows.Forms.Timer(this.components);
            this.Hit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreTimer = new System.Windows.Forms.Timer(this.components);
            this.lblLife = new System.Windows.Forms.Label();
            this.lblLifeCount = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.screen = new System.Windows.Forms.Panel();
            this.player = new System.Windows.Forms.Panel();
            this.stone5 = new System.Windows.Forms.Panel();
            this.stone2 = new System.Windows.Forms.Panel();
            this.stone4 = new System.Windows.Forms.Panel();
            this.stone3 = new System.Windows.Forms.Panel();
            this.stone1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelGameOver = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lblhit
            // 
            this.lblhit.AutoSize = true;
            this.lblhit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhit.Location = new System.Drawing.Point(703, 129);
            this.lblhit.Name = "lblhit";
            this.lblhit.Size = new System.Drawing.Size(19, 20);
            this.lblhit.TabIndex = 5;
            this.lblhit.Text = "0";
            this.lblhit.Click += new System.EventHandler(this.lblhit_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(703, 79);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(19, 20);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // stoneTimer
            // 
            this.stoneTimer.Enabled = true;
            this.stoneTimer.Interval = 1;
            this.stoneTimer.Tick += new System.EventHandler(this.stoneTimer_Tick);
            // 
            // stoneTimer2
            // 
            this.stoneTimer2.Enabled = true;
            this.stoneTimer2.Interval = 1;
            this.stoneTimer2.Tick += new System.EventHandler(this.stoneTimer2_Tick);
            // 
            // Hit
            // 
            this.Hit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hit.Location = new System.Drawing.Point(624, 129);
            this.Hit.Name = "Hit";
            this.Hit.Size = new System.Drawing.Size(62, 29);
            this.Hit.TabIndex = 6;
            this.Hit.Text = "Hits: ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(624, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Score:";
            // 
            // scoreTimer
            // 
            this.scoreTimer.Enabled = true;
            this.scoreTimer.Interval = 500;
            this.scoreTimer.Tick += new System.EventHandler(this.soreTimer_Tick);
            // 
            // lblLife
            // 
            this.lblLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLife.Location = new System.Drawing.Point(624, 179);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(62, 29);
            this.lblLife.TabIndex = 8;
            this.lblLife.Text = "Life:";
            this.lblLife.Click += new System.EventHandler(this.lblLife_Click);
            // 
            // lblLifeCount
            // 
            this.lblLifeCount.AutoSize = true;
            this.lblLifeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLifeCount.Location = new System.Drawing.Point(736, 182);
            this.lblLifeCount.Name = "lblLifeCount";
            this.lblLifeCount.Size = new System.Drawing.Size(19, 20);
            this.lblLifeCount.TabIndex = 9;
            this.lblLifeCount.Text = "0";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Red;
            this.lblExit.Location = new System.Drawing.Point(641, 500);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(95, 20);
            this.lblExit.TabIndex = 10;
            this.lblExit.Text = "Esc to Exit";
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.Transparent;
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.screen.Controls.Add(this.player);
            this.screen.Controls.Add(this.stone5);
            this.screen.Controls.Add(this.stone2);
            this.screen.Controls.Add(this.stone4);
            this.screen.Controls.Add(this.stone3);
            this.screen.Controls.Add(this.stone1);
            this.screen.Controls.Add(this.pictureBox1);
            this.screen.Controls.Add(this.panelGameOver);
            this.screen.ForeColor = System.Drawing.Color.Transparent;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(600, 560);
            this.screen.TabIndex = 2;
            this.screen.Paint += new System.Windows.Forms.PaintEventHandler(this.screen_Paint);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = global::Game.Properties.Resources.playerBoy;
            this.player.ForeColor = System.Drawing.Color.Transparent;
            this.player.Location = new System.Drawing.Point(99, 498);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(30, 60);
            this.player.TabIndex = 0;
            // 
            // stone5
            // 
            this.stone5.BackColor = System.Drawing.Color.Transparent;
            this.stone5.BackgroundImage = global::Game.Properties.Resources.redFace;
            this.stone5.ForeColor = System.Drawing.Color.Transparent;
            this.stone5.Location = new System.Drawing.Point(546, 3);
            this.stone5.Name = "stone5";
            this.stone5.Size = new System.Drawing.Size(30, 30);
            this.stone5.TabIndex = 3;
            // 
            // stone2
            // 
            this.stone2.BackColor = System.Drawing.Color.Transparent;
            this.stone2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stone2.BackgroundImage")));
            this.stone2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stone2.ForeColor = System.Drawing.Color.Transparent;
            this.stone2.Location = new System.Drawing.Point(324, 3);
            this.stone2.Name = "stone2";
            this.stone2.Size = new System.Drawing.Size(30, 30);
            this.stone2.TabIndex = 3;
            // 
            // stone4
            // 
            this.stone4.BackColor = System.Drawing.Color.Transparent;
            this.stone4.BackgroundImage = global::Game.Properties.Resources.star;
            this.stone4.Location = new System.Drawing.Point(427, 3);
            this.stone4.Name = "stone4";
            this.stone4.Size = new System.Drawing.Size(30, 30);
            this.stone4.TabIndex = 3;
            // 
            // stone3
            // 
            this.stone3.BackColor = System.Drawing.Color.Transparent;
            this.stone3.BackgroundImage = global::Game.Properties.Resources.star;
            this.stone3.Location = new System.Drawing.Point(193, 3);
            this.stone3.Name = "stone3";
            this.stone3.Size = new System.Drawing.Size(30, 30);
            this.stone3.TabIndex = 3;
            // 
            // stone1
            // 
            this.stone1.BackColor = System.Drawing.Color.Transparent;
            this.stone1.BackgroundImage = global::Game.Properties.Resources.face;
            this.stone1.Location = new System.Drawing.Point(52, 3);
            this.stone1.Name = "stone1";
            this.stone1.Size = new System.Drawing.Size(25, 25);
            this.stone1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Game.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 560);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panelGameOver
            // 
            this.panelGameOver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGameOver.BackgroundImage")));
            this.panelGameOver.Location = new System.Drawing.Point(3, 3);
            this.panelGameOver.Name = "panelGameOver";
            this.panelGameOver.Size = new System.Drawing.Size(590, 560);
            this.panelGameOver.TabIndex = 5;
            this.panelGameOver.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(682, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(718, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "X";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblLifeCount);
            this.Controls.Add(this.lblLife);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hit);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblhit);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Screen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Screen_KeyUp);
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.Panel stone1;
        private System.Windows.Forms.Timer stoneTimer;
        private System.Windows.Forms.Panel stone5;
        private System.Windows.Forms.Panel stone2;
        private System.Windows.Forms.Panel stone4;
        private System.Windows.Forms.Panel stone3;
        private System.Windows.Forms.Timer stoneTimer2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblhit;
        private System.Windows.Forms.Label Hit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer scoreTimer;
        private System.Windows.Forms.Label lblLife;
        private System.Windows.Forms.Label lblLifeCount;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelGameOver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}