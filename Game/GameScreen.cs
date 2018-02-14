using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class GameScreen : Form
    {
        bool right, left;
        bool jump;
        int Force, G = 30;
        int life = 3;
        Random random = new Random();

        public GameScreen()
        {
            InitializeComponent();
            player.Top = screen.Height - player.Height;
        }

        private void stoneTimer_Tick(object sender, EventArgs e)
        {
            int randomPosition = random.Next(20, 580);
            int choice = random.Next(40, 80);

            if (stone3.Top < screen.Height || stone4.Top < screen.Height)
            {
                stone3.Top += 3;
                stone4.Top += 4;
            }
            else
            {
                stone3.Left = randomPosition;
                stone4.Left = randomPosition - choice;
                stone3.Top = 0;
                stone4.Top = 0;
            }

            if (player.Right > stone3.Left && player.Left < stone3.Right && player.Top < stone3.Bottom && player.Bottom > stone3.Top)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"Resources/hit.wav");
                simpleSound.Play();
                lblhit.Text = (Convert.ToInt32(lblhit.Text) + 1).ToString();
                lblScore.Text = (Convert.ToInt32(lblScore.Text) + 100).ToString(); 
                stone3.Left = randomPosition;
                stone3.Top = 0;
            }

            if (player.Right > stone4.Left && player.Left < stone4.Right && player.Top < stone4.Bottom && player.Bottom > stone4.Top)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"Resources/hit.wav");
                simpleSound.Play();
                lblhit.Text = (Convert.ToInt32(lblhit.Text) + 1).ToString();
                lblScore.Text = (Convert.ToInt32(lblScore.Text) + 100).ToString(); 
                stone4.Left = randomPosition;
                stone4.Top = 0;
            }
        }

        private void stoneTimer2_Tick(object sender, EventArgs e)
        {
            int randomPosition = random.Next(20, 580);
            int choice = random.Next(40, 60);


            if (stone1.Top < screen.Height || stone2.Top < screen.Height)
            {
                stone1.Top += 2;
                stone2.Top += 3;
            }
            else
            {
                stone1.Left = randomPosition;
                stone2.Left = randomPosition - choice;
                stone2.Top = 0;
                stone1.Top = 0;
            }

            if (player.Right > stone2.Left && player.Left < stone2.Right && player.Top < stone2.Bottom && player.Bottom > stone2.Top)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"Resources\hit.wav");
                simpleSound.Play();
                lblhit.Text = (Convert.ToInt32(lblhit.Text) + 1).ToString();
                lblScore.Text = (Convert.ToInt32(lblScore.Text) + 100).ToString();
                stone2.Left = randomPosition;
                stone2.Top = 0;
                if (life < 3)
                {
                    life++;
                }  
                if (life == 3)
                {
                    this.player.Height = 60;
                }
                if (life == 2)
                {
                    this.player.Height = 50;
                }
                if (life == 1)
                {
                    this.player.Height = 40;
                }
                if (life == 0)
                {
                    this.player.Height = 30;
                }
            }

            if (player.Right > stone1.Left && player.Left < stone1.Right && player.Top < stone1.Bottom && player.Bottom > stone1.Top)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"Resources/hit.wav");
                simpleSound.Play();
                lblhit.Text = (Convert.ToInt32(lblhit.Text) + 1).ToString();
                lblScore.Text = (Convert.ToInt32(lblScore.Text) + 100).ToString();
                stone1.Left = randomPosition;
                stone1.Top = 0;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            int randomPosition = random.Next(20, 580);
            lblLifeCount.Text = life.ToString();
            if (stone5.Top < screen.Height)
            {
                stone5.Top += 4;
            }
            else
            {
                stone5.Left = randomPosition;
                stone5.Top = 0;
            }

            if (player.Right > stone5.Left && player.Left < stone5.Right && player.Top < stone5.Bottom && player.Bottom > stone5.Top)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"Resources\dead.wav");
                simpleSound.Play();
                lblScore.Text = (Convert.ToInt32(lblScore.Text) - 100).ToString();
                stone5.Left = randomPosition;
                stone5.Top = 0;     
                life--;
                if (life == 2)
                {
                    this.player.Height = 50;
                }
                if (life == 1)
                {
                    this.player.Height = 40;
                }
                if (life == 0)
                {
                    gameTimer.Stop();
                    stoneTimer.Stop();
                    stoneTimer2.Stop();
                    scoreTimer.Stop();
                    panelGameOver.BringToFront();
                    panelGameOver.Visible = true;
                }
            }

            if (right == true)
            {
                player.Left += 5;
            }
            if (left == true)
            {
                player.Left -= 5;
            }

            if (jump == true)
            {
                player.Top -= Force;
                Force -= 1;
            }

            if (player.Top + player.Height >= screen.Height)
            {
                player.Top = screen.Height - player.Height;
                jump = false;
            }
            else
            {
                player.Top += 5;
            }
  
            if (player.Left <= 0)
            {
                left = false;
            }

            if (player.Left + player.Width >= 575)
            {
                right = false;
            }

        }

        private void soreTimer_Tick(object sender, EventArgs e)
        {
            lblScore.Text = (Convert.ToInt32(lblScore.Text) + 1).ToString();             
        }

        private void Screen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                player.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (jump != true)
            {
                if (e.KeyCode == Keys.Up)
                {
                    SoundPlayer simpleSound = new SoundPlayer();
                    simpleSound.SoundLocation = @"Resources/jump.wav";
                    simpleSound.Play();
                    jump = true;
                    Force = G;
                }
            }
        }

        private void Screen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                player.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void block_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void lblhit_Click(object sender, EventArgs e)
        {

        }

        private void screen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLife_Click(object sender, EventArgs e)
        {

        }
    }
}
