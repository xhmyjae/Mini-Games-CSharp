using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace MiniGames
{
    public partial class PlatRat : Form
    {
        private bool Player1GoLeft, Player1GoRight, Player1Jump, TouchedEnemies, Player1OnGround;
        private int PlayerSpeed = 5;
        private int Enemy1Speed = 3;
        private int Enemy2Speed = 4;
        private int PlayerJumpSpeed = 100;
        private int Player1Lives = 3;
        private int EnemiesTimer = 0;
        private int Score;

        public PlatRat()
        {
            InitializeComponent();
        }
        
        private void PlatRat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
        }

        private void PlatRat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right :
                    Player1GoRight = true;
                    player1.Image = Properties.Resources.cropRat;
                    break;
                case Keys.Left :
                    Player1GoLeft = true;
                    player1.Image = Properties.Resources.reverseCropRat;
                    break;
                case Keys.Up :
                    if (!Player1Jump)
                    {
                        Player1Jump = true;
                    }
                    break;
            }
        }

        private void PlatRat_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right :
                    Player1GoRight = false;
                    break;
                case Keys.Left :
                    Player1GoLeft = false;
                    break;
                // case Keys.Up :
                //     Player1Jump = false;
                //     break;
            }
        }

        private void timerGame_Elapsed(object sender, ElapsedEventArgs e)
        {
            player1.BringToFront();
            enemy1.BringToFront();
            enemy2.BringToFront();
            message.Text = "";
            if (TouchedEnemies)
            {
                EnemiesTimer += 10;
                if (EnemiesTimer >= 700)
                {
                    enableEnemies(enemy1);
                    enableEnemies(enemy2);
                    TouchedEnemies = false;
                }
            }

            // Set scores and cheeses Count
            livesCount.Text = Player1Lives.ToString();
            cheesesCount.Text = Score.ToString();
            
            // Make characters move
            player1.Top += PlayerSpeed;
            
            if (Player1GoLeft && player1.Left > 0)
            {
                player1.Left -= PlayerSpeed;
            }

            if (Player1GoRight && player1.Right < ClientSize.Width)
            {
                player1.Left += PlayerSpeed;
            }

            if (Player1Jump && Player1OnGround)
            {
                player1.Top -= PlayerJumpSpeed;
                Player1OnGround = false;
            }

            foreach (Control control in this.Controls)
            {

                if (control.Tag == "bloc")
                {
                    if (player1.Bounds.IntersectsWith(control.Bounds) && !Player1Jump && player1.Bottom < control.Bottom && player1.Right != control.Left && player1.Left != control.Right)
                    {
                        player1.Top = control.Top - player1.Height;
                    }
                    
                    if (player1.Bounds.IntersectsWith(control.Bounds) && player1.Top > control.Top && player1.Right != control.Left && player1.Left != control.Right)
                    {
                        player1.Top = control.Bottom;
                    }

                    if (player1.Bounds.IntersectsWith(control.Bounds) && player1.Right < control.Right && player1.Left < control.Left)
                    {
                        player1.Left = control.Left - player1.Width;
                    }
                    
                    if (player1.Bounds.IntersectsWith(control.Bounds) && player1.Left > control.Left && player1.Right > control.Right)
                    {
                        player1.Left = control.Right;
                    }
                    
                    // Makes player jump
                    if (player1.Bottom == control.Top)
                    {
                        Player1OnGround = true;
                        Player1Jump = false;
                    }

                }
            }
            
            // Make enemies move
            if (!TouchedEnemies)
            {
                enemy1.Left += Enemy1Speed;
                if (enemy1.Right >= blocSimple6.Right || enemy1.Left <= blocSimple5.Left)
                {
                    Enemy1Speed = -Enemy1Speed;
                }

                enemy2.Left += Enemy2Speed;
                if (enemy2.Right >= blocThin2.Right || enemy2.Left <= blocSimple3.Left)
                {
                    Enemy2Speed = -Enemy2Speed;
                }
            }
            
            // Hit enemies
            foreach (Control control in this.Controls)
            {
                if (control.Tag == "enemy")
                {
                    if (player1.Bounds.IntersectsWith(control.Bounds) && !TouchedEnemies)
                    {
                        EnemiesTimer = 0;
                        TouchedEnemies = true;
                        disableEnemies(enemy1);
                        disableEnemies(enemy2);
                        Player1Lives--;
                    }
                }
                
                // Grab cheeses
                if (control.Tag == "cheese")
                {
                    if (player1.Bounds.IntersectsWith(control.Bounds))
                    {
                        this.Controls.Remove(control);
                        Score++;
                    }
                }
            }
            

            // Check lose
            if (Player1Lives == 0 || player1.Bottom == this.ClientSize.Height)
            {
                label1.Text = "Lose";
                // End game with lose
            } 
            
            // Check win
            if (player1.Bounds.IntersectsWith(exitDoor.Bounds))
            {
                if (Score == 9)
                {
                    label1.Text = "Win";
                    // End game with win
                }
                else
                {
                    message.Text = "I need more cheese for my family.";
                }
            }
        }

        private void disableEnemies(PictureBox box)
        {
            box.Enabled = false;
            box.Image = Properties.Resources._572_5727123_bread_cat_pixel_art_clipart_png_download_overwatch;
        }

        private void enableEnemies(PictureBox box)
        {
            box.Enabled = true;
            box.Image = Properties.Resources._542_5427076_colors_download_settings_cat_pixel_art;
        }
        
    }
}