using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniGames
{
    public partial class Pong : Form
    {
        private Rectangle MidLineRectangle;
        private Rectangle BoxPlayer1Rectangle;
        private Rectangle BoxPlayer2Rectangle;
        private Rectangle BallRectangle;
        private Rectangle ScorePlayer1Rectangle;
        private Rectangle ScorePlayer2Rectangle;
        private Size OriginalFormSize;

        public Pong()
        {
            InitializeComponent();
        }

        private void Pong_Load(object sender, EventArgs e)
        {
            OriginalFormSize = this.Size;
            MidLineRectangle = new Rectangle(midLine.Location.X, midLine.Location.Y, midLine.Width, midLine.Height);
            BoxPlayer1Rectangle = new Rectangle(boxPlayer1.Location.X, boxPlayer1.Location.Y, boxPlayer1.Width, boxPlayer1.Height);
            BoxPlayer2Rectangle = new Rectangle(boxPLayer2.Location.X, boxPLayer2.Location.Y, boxPLayer2.Width, boxPLayer2.Height);
            BallRectangle = new Rectangle(ball.Location.X, ball.Location.Y, ball.Width, ball.Height);
            ScorePlayer1Rectangle = new Rectangle(scorePlayer1.Location.X, scorePlayer1.Location.Y, scorePlayer1.Width, scorePlayer1.Height);
            ScorePlayer2Rectangle = new Rectangle(scorePlayer2.Location.X, scorePlayer2.Location.Y, scorePlayer2.Width, scorePlayer2.Height);
            
            // Places ball at the center of the screen
            ball.Left = (this.ClientSize.Width - ball.Width) / 2;
            ball.Top = (this.ClientSize.Height - ball.Height) / 2;
            midLine.Left = (this.ClientSize.Height - midLine.Height) / 2;
        }
        
        private void Pong_Resize(object sender, EventArgs e)
        {
            Utils.ResizeButtons(MidLineRectangle, midLine, this, OriginalFormSize);
            Utils.ResizeButtons(BoxPlayer1Rectangle, boxPlayer1, this, OriginalFormSize);
            Utils.ResizeButtons(BoxPlayer2Rectangle, boxPLayer2, this, OriginalFormSize);
            Utils.ResizeButtons(BallRectangle, ball, this, OriginalFormSize);
            Utils.ResizeButtons(ScorePlayer1Rectangle, scorePlayer1, this, OriginalFormSize);
            Utils.ResizeButtons(ScorePlayer2Rectangle, scorePlayer2, this, OriginalFormSize);
        }

        private void Pong_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}