using System.Timers;
using System.Windows.Forms;

namespace MiniGames
{
    public partial class PlatRat : Form
    {
        private bool Player1GoLeft, Player1GoRight, Player1Jump;
        private int PlayerSpeed = 5;
        private int PlayerJumpSpeed = 8;
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
                    break;
                case Keys.Left :
                    Player1GoLeft = true;
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
            if (Player1GoLeft)
            {
                blocSimple1.Left -= PlayerSpeed;
            }
        }
    }
}