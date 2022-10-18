using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace MiniGames
{
    public partial class PlatRat : Form
    {
        private bool Player1IsLeft, Player1IsRight, Player1IsJumping, IsTouchingEnemies, Player1IsOnGround;
        private int Player1Speed = 5;
        private int Player1JumpSpeed = 15;
        private int Force;
        private int Player1Lives = 3;

        private int Enemy1Speed = 3;
        private int Enemy2Speed = 4;
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
                    Player1IsRight = true;
                    player1.Image = Properties.Resources.cropRat;
                    break;
                case Keys.Left :
                    Player1IsLeft = true;
                    player1.Image = Properties.Resources.reverseCropRat;
                    break;
                case Keys.Up :
                    if (!Player1IsJumping)
                    {
                        Player1IsJumping = true;
                        Force = Player1JumpSpeed;
                    }
                    break;
            }
        }

        private void PlatRat_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right :
                    Player1IsRight = false;
                    break;
                case Keys.Left :
                    Player1IsLeft = false;
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
            
            // Set scores and cheeses Count
            livesCount.Text = Player1Lives.ToString();
            cheesesCount.Text = Score.ToString();
            
            // Checks if player touched enemies
            if (IsTouchingEnemies)
            {
                EnemiesTimer += 10;
                if (EnemiesTimer >= 700)
                {
                    enableEnemies(enemy1);
                    enableEnemies(enemy2);
                    IsTouchingEnemies = false;
                }
            }

            // Make characters move
            player1.Top += Player1Speed;
            
            if (Player1IsLeft && player1.Left > 0)
            {
                player1.Left -= Player1Speed;
            }

            if (Player1IsRight && player1.Right < ClientSize.Width)
            {
                player1.Left += Player1Speed;
            }

            if (Player1IsJumping)
            {
                player1.Top -= Force;
                Force--;
            }
            
            foreach (Control control in this.Controls)
            {
                if (control.Tag == "bloc" && player1.Bounds.IntersectsWith(control.Bounds))
                {
                    int[] values =
                    {
                        player1.Bottom - control.Top,
                        player1.Right - control.Left,
                        control.Bottom - player1.Top,
                        control.Right - player1.Left
                    };

                    int index = values.Min();
                    
                    switch (Array.IndexOf(values, index))
                    {
                        case 0 :
                            player1.Top = control.Top - player1.Height;
                            Force = 0;
                            Player1IsJumping = false;
                            break;
                        case 1 :
                            player1.Left = control.Left - player1.Width;
                            break;
                        case 2 :
                            player1.Top = control.Bottom;
                            break;
                        case 3 :
                            player1.Left = control.Right;
                            break;
                    }
                    
                    // Touching control Top side
                    // if (player1.Bottom >= control.Top &&  player1.Top < control.Top && player1.Left > control.Left - player1.Width && player1.Right < control.Right + player1.Width)
                    // {
                    //     player1.Top = control.Top - player1.Height;
                    //     Force = 0;
                    //     Player1IsJumping = false;
                    // }
                    //
                    // // Touching control Bottom side
                    // if (player1.Top <= control.Bottom && player1.Bottom > control.Bottom && player1.Left > control.Left - player1.Width && player1.Right < control.Right + player1.Width)
                    // {
                    //     player1.Top = control.Bottom;
                    // }
                    //
                    // // Touching control Right side
                    // if (player1.Left <= control.Right && player1.Right > control.Right && player1.Top > control.Top - player1.Height && player1.Bottom < control.Bottom + player1.Height)
                    // {
                    //     player1.Left = control.Right;
                    // }
                    //
                    // // Touching control Left side
                    // if (player1.Right >= control.Left && player1.Left < control.Left && player1.Top > control.Top - player1.Height && player1.Bottom < control.Bottom + player1.Height)
                    // {
                    //     player1.Left = control.Left - player1.Width;
                    // }
                }
            }
            
            // Make enemies move
            if (!IsTouchingEnemies)
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
                    if (player1.Bounds.IntersectsWith(control.Bounds) && !IsTouchingEnemies)
                    {
                        EnemiesTimer = 0;
                        IsTouchingEnemies = true;
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