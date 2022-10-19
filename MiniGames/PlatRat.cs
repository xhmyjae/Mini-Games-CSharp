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
        private bool player1IsLeft, player1IsRight, player1IsJumping, isTouchingEnemies, player1IsOnSpecial;
        private int player1Speed = 5;
        private int player1JumpSpeed = 17;
        private int force;
        private int player1Lives = 3;

        private int enemy1Speed = 2;
        private int enemy2Speed = 3;
        private int enemiesTimer = 0;

        private int bloc1Speed = 2;
        private int bloc2Speed = 2;
        private int blocSpecialSpeed = 1;

        private int score;

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
                    player1IsRight = true;
                    player1.Image = Properties.Resources.ratBrown;
                    break;
                case Keys.Left :
                    player1IsLeft = true;
                    player1.Image = Properties.Resources.ratBrownReverse;
                    break;
                case Keys.Up :
                    if (!player1IsJumping)
                    {
                        player1IsJumping = true;
                        force = player1JumpSpeed;
                    }
                    break;
            }
        }

        private void PlatRat_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right :
                    player1IsRight = false;
                    break;
                case Keys.Left :
                    player1IsLeft = false;
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
            livesCount.Text = player1Lives.ToString();
            cheesesCount.Text = score.ToString();
            
            // Checks if player touched enemies
            if (isTouchingEnemies)
            {
                enemiesTimer += 10;
                if (enemiesTimer >= 700)
                {
                    enableEnemies(enemy1);
                    enableEnemies(enemy2);
                    isTouchingEnemies = false;
                }
            }

            // Makes characters move
            player1.Top += player1Speed;
            
            if (player1IsLeft && player1.Left > 0)
            {
                player1.Left -= player1Speed;
            }

            if (player1IsRight && player1.Right < ClientSize.Width)
            {
                player1.Left += player1Speed;
            }

            if (player1IsJumping)
            {
                player1.Top -= force;
                force--;
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
                                force = 0;
                                player1IsJumping = false;
                                player1IsOnSpecial = control == blocSpecial1;
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
                    if (control.Tag == "enemy" && !isTouchingEnemies)
                    {
                         enemiesTimer = 0;
                         isTouchingEnemies = true;
                         disableEnemies(enemy1);
                         disableEnemies(enemy2);
                         player1Lives--;
                    }
                    
                    // CHEESES
                    if (control.Tag == "cheese")
                    {
                        this.Controls.Remove(control);
                        score++;
                    }
                }

            }
            
            // Makes enemies move
            if (!isTouchingEnemies)
            {
                enemy1.Left += enemy1Speed;
                if (enemy1.Right >= blocSimple6.Right || enemy1.Left <= blocSimple5.Left)
                {
                    enemy1Speed = -enemy1Speed;
                }

                enemy2.Left += enemy2Speed;
                if (enemy2.Right >= blocThin2.Right || enemy2.Left <= blocSimple3.Left)
                {
                    enemy2Speed = -enemy2Speed;
                }
            }
            
            // Makes platform move
            blocMoving1.Top += bloc1Speed;
            if (blocMoving1.Top <= 140 || blocMoving1.Bottom >= 310) bloc1Speed = -bloc1Speed;

                blocMoving2.Top += bloc2Speed;
            if (blocMoving2.Top <= 290 || blocMoving2.Bottom >= 435) bloc2Speed = -bloc2Speed;

            if (player1IsOnSpecial)
            {
                blocSpecial1.Left += blocSpecialSpeed;
                if (blocSpecial1.Left >= 720) blocSpecialSpeed = 0;
            }
            else
            {
                if (blocSpecial1.Left >= 443)
                {
                    blocSpecial1.Left -= blocSpecialSpeed;
                }
            }

            // Checks lose
            if (player1Lives == 0 || player1.Bottom == this.ClientSize.Height)
            {
                // End game with lose
            } 
            
            // Checks win
            if (player1.Bounds.IntersectsWith(exitDoor.Bounds))
            {
                if (score == 9)
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