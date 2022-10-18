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
        private bool Player1IsLeft, Player1IsRight, Player1IsJumping, IsTouchingEnemies, Player1IsOnSpecial;
        private int Player1Speed = 5;
        private int Player1JumpSpeed = 17;
        private int Force;
        private int Player1Lives = 2;

        private int Enemy1Speed = 3;
        private int Enemy2Speed = 4;
        private int EnemiesTimer = 0;

        private int Bloc1Speed = 2;
        private int Bloc2Speed = 2;
        private int BlocSpecialSpeed = 2;

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
                    player1.Image = Properties.Resources.ratBrown;
                    break;
                case Keys.Left :
                    Player1IsLeft = true;
                    player1.Image = Properties.Resources.ratBrownReverse;
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
            }
        }

        private void timerGame_Elapsed(object sender, ElapsedEventArgs e)
        {
            player1.BringToFront();
            enemy1.BringToFront();
            enemy2.BringToFront();
            message.Text = "";

            // Sets scores and cheeses Count
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

            // Makes characters move
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
            
            // Interactions with other blocs
            foreach (Control control in this.Controls)
            {
                if (player1.Bounds.IntersectsWith(control.Bounds))
                {
                    // PLATFORM BLOCS
                    if (control.Tag == "bloc")
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
                                if (control == blocSpecial1)
                                {
                                    Player1IsOnSpecial = true;
                                }
                                else
                                {
                                    Player1IsOnSpecial = false;
                                }
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
                    }
                    
                    // ENEMIES
                    if (control.Tag == "enemy" && !IsTouchingEnemies)
                    {
                         EnemiesTimer = 0;
                         IsTouchingEnemies = true;
                         disableEnemies(enemy1);
                         disableEnemies(enemy2);
                         Player1Lives--;
                    }
                    
                    // CHEESES
                    if (control.Tag == "cheese")
                    {
                        this.Controls.Remove(control);
                        Score++;
                    }
                    
                    // SPECIAL PLATFORM
                }

            }
            
            // Makes enemies move
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
            
            // Makes platform move
            blocMoving1.Top += Bloc1Speed;
            if (blocMoving1.Top <= 140 || blocMoving1.Bottom >= 310)
            {
                Bloc1Speed = -Bloc1Speed;
            }

            blocMoving2.Top += Bloc2Speed;
            if (blocMoving2.Top <= 290 || blocMoving2.Bottom >= 425)
            {
                Bloc2Speed = -Bloc2Speed;
            }

            if (Player1IsOnSpecial)
            {
                blocSpecial1.Left += BlocSpecialSpeed;
                if (blocSpecial1.Left >= 720)
                {
                    BlocSpecialSpeed = 0;
                }
            }
            else
            {
                if (blocSpecial1.Left >= 443)
                {
                    blocSpecial1.Left -= BlocSpecialSpeed;
                }
            }

            // Checks lose
            if (Player1Lives == 0 || player1.Bottom == this.ClientSize.Height)
            {
                // End game with lose
            } 
            
            // Checks win
            if (player1.Bounds.IntersectsWith(exitDoor.Bounds))
            {
                if (Score == 9)
                {
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