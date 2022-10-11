using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace MiniGames
{
    public partial class Pong : Form
    {
        // Resize
        private Rectangle MidLineRectangle;
        private Rectangle BoxPlayer1Rectangle;
        private Rectangle BoxPlayer2Rectangle;
        private Rectangle BallRectangle;
        private Rectangle ScorePlayer1Rectangle;
        private Rectangle ScorePlayer2Rectangle;
        private Rectangle WinTextPlayer1Rectangle;
        private Rectangle WinTextPlayer2Rectangle;
        private Size OriginalFormSize;
        
        // Gameplay
        private bool Player1GoUp;
        private bool Player1GoDown;
        private bool PLayer2GoUp;
        private bool Player2GoDown;
        private int BallDirectionY = 7;
        private int BallDirectionX = 7;

        private int ScorePlayer1 = 0;
        private int ScorePlayer2 = 0;

        public Pong()
        {
            InitializeComponent();
        }

        private void Pong_Load(object sender, EventArgs e)
        {
            OriginalFormSize = this.Size;
            MidLineRectangle = new Rectangle(midLine.Location.X, midLine.Location.Y, midLine.Width, midLine.Height);
            BoxPlayer1Rectangle = new Rectangle(boxPlayer1.Location.X, boxPlayer1.Location.Y, boxPlayer1.Width, boxPlayer1.Height);
            BoxPlayer2Rectangle = new Rectangle(boxPlayer2.Location.X, boxPlayer2.Location.Y, boxPlayer2.Width, boxPlayer2.Height);
            BallRectangle = new Rectangle(ball.Location.X, ball.Location.Y, ball.Width, ball.Height);
            ScorePlayer1Rectangle = new Rectangle(scorePlayer1.Location.X, scorePlayer1.Location.Y, scorePlayer1.Width, scorePlayer1.Height);
            ScorePlayer2Rectangle = new Rectangle(scorePlayer2.Location.X, scorePlayer2.Location.Y, scorePlayer2.Width, scorePlayer2.Height);
            WinTextPlayer1Rectangle = new Rectangle(winTextPlayer1.Location.X, winTextPlayer1.Location.Y, winTextPlayer1.Width, winTextPlayer1.Height);
            WinTextPlayer2Rectangle = new Rectangle(winTextPlayer2.Location.X, winTextPlayer2.Location.Y, winTextPlayer2.Width, winTextPlayer2.Height);

            // Places ball at the center of the screen
            ball.Left = (this.ClientSize.Width - ball.Width) / 2;
            ball.Top = (this.ClientSize.Height - ball.Height) / 2;
            midLine.Left = (this.ClientSize.Width - ball.Width) / 2;
        }
        
        private void Pong_Resize(object sender, EventArgs e)
        {
            Utils.ResizeButtons(MidLineRectangle, midLine, this, OriginalFormSize);
            Utils.ResizeButtons(BoxPlayer1Rectangle, boxPlayer1, this, OriginalFormSize);
            Utils.ResizeButtons(BoxPlayer2Rectangle, boxPlayer2, this, OriginalFormSize);
            Utils.ResizeButtons(BallRectangle, ball, this, OriginalFormSize);
            Utils.ResizeButtons(ScorePlayer1Rectangle, scorePlayer1, this, OriginalFormSize);
            Utils.ResizeButtons(ScorePlayer2Rectangle, scorePlayer2, this, OriginalFormSize);
        }

        private void Pong_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W :
                    Player1GoUp = true;
                    break;
                case Keys.S :
                    Player1GoDown = true;
                    break;
                case Keys.Up :
                    PLayer2GoUp = true;
                    break;
                case Keys.Down :
                    Player2GoDown = true;
                    break;
            }
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W :
                    Player1GoUp = false;
                    break;
                case Keys.S :
                    Player1GoDown = false;
                    break;
                case Keys.Up :
                    PLayer2GoUp = false;
                    break;
                case Keys.Down :
                    Player2GoDown = false;
                    break;
            }
        }

        private void timeRepeat_Elapsed(object sender, ElapsedEventArgs e)
        {
             // Set scores
            scorePlayer1.Text = "" + ScorePlayer1;
            scorePlayer2.Text = "" + ScorePlayer2;

            winTextPlayer1.Visible = false;
            winTextPlayer2.Visible = false;

            ball.Top -= BallDirectionY;
            ball.Left -= BallDirectionX;

            // Check lose
            if (ball.Left < 0)
            {
                ball.Left = (this.ClientSize.Width - ball.Width) / 2;
                ball.Top = (this.ClientSize.Height - ball.Height) / 2;
                ScorePlayer2++;
            }

            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = (this.ClientSize.Width - ball.Width) / 2;
                ball.Top = (this.ClientSize.Height - ball.Height) / 2;
                ScorePlayer1++;
            }
            
            // Make ball rebound
            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                BallDirectionY = -BallDirectionY;
            }
            
            if (ball.Bounds.IntersectsWith(boxPlayer1.Bounds) || ball.Bounds.IntersectsWith(boxPlayer2.Bounds))
            {
                BallDirectionX = -BallDirectionX;
            }
            
            // Control the players box
            if (Player1GoDown && boxPlayer1.Bottom < ClientSize.Height)
            {
                boxPlayer1.Top += 7;
            }
            
            if (Player1GoUp && boxPlayer1.Top > 0)
            {
                boxPlayer1.Top -= 7;
            }
            
            if (PLayer2GoUp && boxPlayer2.Top > 0)
            {
                boxPlayer2.Top -= 7;
            }
            
            if (Player2GoDown && boxPlayer2.Bottom < ClientSize.Height)
            {
                boxPlayer2.Top += 7;
            }
            
            // Check scores
            if (ScorePlayer1 > 10)
            {
                timeRepeat.Stop();
                winTextPlayer1.Visible = true;
            }

            if (ScorePlayer2 > 10)
            {
                timeRepeat.Stop();
                winTextPlayer2.Visible = true;
            }
        }
    }
}