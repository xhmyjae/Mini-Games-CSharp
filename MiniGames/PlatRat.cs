using System.Diagnostics;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace MiniGames
{
    public partial class PlatRat : Form
    {
        private bool Player1GoLeft, Player1GoRight, Player1Jump;
        private int PlayerSpeed = 5;
        private int PlayerJumpSpeed = 10;
        private int Score;
        
        public PlatRat()
        {
            InitializeComponent();
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
                case Keys.Up :
                    Player1Jump = false;
                    break;
            }
        }

        private void timerGame_Elapsed(object sender, ElapsedEventArgs e)
        {
            player1.Top += PlayerSpeed;
            
            if (Player1GoLeft && player1.Left > 0)
            {
                player1.Left -= PlayerSpeed;
            }

            if (Player1GoRight && player1.Right < ClientSize.Width)
            {
                player1.Left += PlayerSpeed;
            }

            if (Player1Jump)
            {
                player1.Top -= PlayerJumpSpeed;
            }

            foreach (Control control in this.Controls)
            {
                if (control.Tag == "bloc")
                {
                    if (player1.Bounds.IntersectsWith(control.Bounds) && !Player1Jump && player1.Bottom < control.Bottom && player1.Right != control.Left && player1.Left != control.Right)
                    {
                        player1.Top = control.Top - player1.Height;
                        label1.Text = player1.Bottom.ToString();
                        label1.Text += control.Bounds.Y.ToString();
                        
                        if (player1.Bottom == control.Bounds.Y)
                        {
                            label1.Text += " test working";
                        }
                    }

                    if (player1.Bounds.IntersectsWith(control.Bounds) && player1.Right < control.Right && player1.Top < control.Bottom)
                    {
                        label1.Text = "going left";
                        player1.Left = control.Left - player1.Width;
                    }

                    if (player1.Bounds.IntersectsWith(control.Bounds) && player1.Left > control.Left && player1.Top != control.Bottom && player1.Bottom != control.Top)
                    {
                        player1.Left = control.Right;
                    }

                    if (player1.Bounds.IntersectsWith(control.Bounds) && player1.Top > control.Bottom)
                    {
                        player1.Top = control.Bottom;
                    }
                    
                }
            }
        }
    }
}