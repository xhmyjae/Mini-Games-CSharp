using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Timers;

namespace MiniGames
{
    public partial class Platformer : Form
    {
        // Resize
        private Rectangle BlocSimple1Rectangle;
        private Rectangle BlocSimple2Rectangle;
        private Rectangle BlocSimple3Rectangle;
        private Rectangle BlocSimple4Rectangle;
        private Rectangle BlocSimple5Rectangle;
        private Rectangle BlocSimple6Rectangle;
        private Rectangle BlocSimple7Rectangle;
        private Rectangle BlocSimple8Rectangle;
        private Rectangle BlocSimple9Rectangle;
        private Rectangle BlocThin1Rectangle;
        private Rectangle BlocThin2Rectangle;
        private Rectangle BlocThin3Rectangle;
        private Rectangle BlocThin4Rectangle;
        private Rectangle BlocMoving1Rectangle;
        private Rectangle BlocMoving2Rectangle;
        private Rectangle BlocSpecial1Rectangle;
        private Rectangle BlocLeaveRectangle;
        private Rectangle Cheese1Rectangle;
        private Rectangle Cheese2Rectangle;
        private Rectangle Cheese3Rectangle;
        private Rectangle Cheese4Rectangle;
        private Rectangle Cheese5Rectangle;
        private Rectangle Cheese6Rectangle;
        private Rectangle Cheese7Rectangle;
        private Rectangle Cheese8Rectangle;
        private Rectangle Cheese9Rectangle;
        private Rectangle ScoreRectangle;

        private Rectangle GameTitleRectangle;
        private Rectangle ExitPlatformerButtonRectangle;
        private Rectangle StartPlatformerButtonRectangle;
        private Rectangle RatTitle1Rectangle;
        private Rectangle RatTitle2Rectangle;
        
        private Size OriginalFormSize;
        
        // Gameplay
        private bool PlayerGoRight;
        private bool PlayerGoLeft;
        private bool PlayerJump;
        private int Score;

        public Platformer()
        {
            InitializeComponent();
        }
        
        private void Platformer_Load(object sender, EventArgs e)
        {
            IEnumerable<Control> controls = new List<Control>();
            controls = Utils.GetAllControls(this);
            OriginalFormSize = this.Size;
            BlocSimple1Rectangle = new Rectangle(blocSimple1.Location.X, blocSimple1.Location.Y, blocSimple1.Width, blocSimple1.Height);
            BlocSimple2Rectangle = new Rectangle(blocSimple2.Location.X, blocSimple2.Location.Y, blocSimple2.Width, blocSimple2.Height);
            BlocSimple3Rectangle = new Rectangle(blocSimple3.Location.X, blocSimple3.Location.Y, blocSimple3.Width, blocSimple3.Height);
            BlocSimple4Rectangle = new Rectangle(blocSimple4.Location.X, blocSimple4.Location.Y, blocSimple4.Width, blocSimple4.Height);
            BlocSimple5Rectangle = new Rectangle(blocSimple5.Location.X, blocSimple5.Location.Y, blocSimple5.Width, blocSimple5.Height);
            BlocSimple6Rectangle = new Rectangle(blocSimple6.Location.X, blocSimple6.Location.Y, blocSimple6.Width, blocSimple6.Height);
            BlocSimple7Rectangle = new Rectangle(blocSimple7.Location.X, blocSimple7.Location.Y, blocSimple7.Width, blocSimple7.Height);
            BlocSimple8Rectangle = new Rectangle(blocSimple8.Location.X, blocSimple8.Location.Y, blocSimple8.Width, blocSimple8.Height);
            BlocSimple9Rectangle = new Rectangle(blocSimple9.Location.X, blocSimple9.Location.Y, blocSimple9.Width, blocSimple9.Height);
            BlocThin1Rectangle = new Rectangle(blocThin1.Location.X, blocThin1.Location.Y, blocThin1.Width, blocThin1.Height);
            BlocThin2Rectangle = new Rectangle(blocThin2.Location.X, blocThin2.Location.Y, blocThin2.Width, blocThin2.Height);
            BlocThin3Rectangle = new Rectangle(blocThin3.Location.X, blocThin3.Location.Y, blocThin3.Width, blocThin3.Height);
            BlocThin4Rectangle = new Rectangle(blocThin4.Location.X, blocThin4.Location.Y, blocThin4.Width, blocThin4.Height);
            BlocMoving1Rectangle = new Rectangle(blocMoving1.Location.X, blocMoving1.Location.Y, blocMoving1.Width, blocMoving1.Height);
            BlocMoving2Rectangle = new Rectangle(blocMoving2.Location.X, blocMoving2.Location.Y, blocMoving2.Width, blocMoving2.Height);
            BlocSpecial1Rectangle = new Rectangle(blocSpecial1.Location.X, blocSpecial1.Location.Y, blocSpecial1.Width, blocSpecial1.Height);
            BlocLeaveRectangle = new Rectangle(blocLeave.Location.X, blocLeave.Location.Y, blocLeave.Width, blocLeave.Height);
            Cheese1Rectangle = new Rectangle(cheese1.Location.X, cheese1.Location.Y, cheese1.Width, cheese1.Height);
            Cheese2Rectangle = new Rectangle(cheese2.Location.X, cheese2.Location.Y, cheese2.Width, cheese2.Height);
            Cheese3Rectangle = new Rectangle(cheese3.Location.X, cheese3.Location.Y, cheese3.Width, cheese3.Height);
            Cheese4Rectangle = new Rectangle(cheese4.Location.X, cheese4.Location.Y, cheese4.Width, cheese4.Height);
            Cheese5Rectangle = new Rectangle(cheese5.Location.X, cheese5.Location.Y, cheese5.Width, cheese5.Height);
            Cheese6Rectangle = new Rectangle(cheese6.Location.X, cheese6.Location.Y, cheese6.Width, cheese6.Height);
            Cheese7Rectangle = new Rectangle(cheese7.Location.X, cheese7.Location.Y, cheese7.Width, cheese7.Height);
            Cheese8Rectangle = new Rectangle(cheese8.Location.X, cheese8.Location.Y, cheese8.Width, cheese8.Height);
            Cheese9Rectangle = new Rectangle(cheese9.Location.X, cheese9.Location.Y, cheese9.Width, cheese9.Height);
            ScoreRectangle = new Rectangle(score.Location.X, score.Location.Y, score.Width, score.Height);
            GameTitleRectangle = new Rectangle(gameTitle.Location.X, gameTitle.Location.Y, gameTitle.Width, gameTitle.Height);
            ExitPlatformerButtonRectangle = new Rectangle(exitPlatformerButton.Location.X, exitPlatformerButton.Location.Y, exitPlatformerButton.Width, exitPlatformerButton.Height);
            StartPlatformerButtonRectangle = new Rectangle(startPlatformerButton.Location.X, startPlatformerButton.Location.Y, startPlatformerButton.Width, startPlatformerButton.Height);
            RatTitle1Rectangle = new Rectangle(ratTitle1.Location.X, ratTitle1.Location.Y, ratTitle1.Width, ratTitle1.Height);
            RatTitle2Rectangle = new Rectangle(ratTitle2.Location.X, ratTitle2.Location.Y, ratTitle2.Width, ratTitle2.Height);
        }
        
        private void Platformer_Resize(object sender, EventArgs e)
        {
            Utils.ResizeButtons(BlocSimple1Rectangle, blocSimple1, this, OriginalFormSize);
            Utils.ResizeButtons(BlocSimple2Rectangle, blocSimple2, this, OriginalFormSize);
            Utils.ResizeButtons(BlocSimple3Rectangle, blocSimple3, this, OriginalFormSize);
            Utils.ResizeButtons(BlocSimple4Rectangle, blocSimple4, this, OriginalFormSize);
            Utils.ResizeButtons(BlocSimple5Rectangle, blocSimple5, this, OriginalFormSize);
            Utils.ResizeButtons(BlocSimple6Rectangle, blocSimple6, this, OriginalFormSize);
            Utils.ResizeButtons(BlocSimple7Rectangle, blocSimple7, this, OriginalFormSize);
            Utils.ResizeButtons(BlocSimple8Rectangle, blocSimple8, this, OriginalFormSize);
            Utils.ResizeButtons(BlocSimple9Rectangle, blocSimple9, this, OriginalFormSize);
            Utils.ResizeButtons(BlocThin1Rectangle, blocSimple1, this, OriginalFormSize);
            Utils.ResizeButtons(BlocThin2Rectangle, blocThin2, this, OriginalFormSize);
            Utils.ResizeButtons(BlocThin3Rectangle, blocThin3, this, OriginalFormSize);
            Utils.ResizeButtons(BlocThin4Rectangle, blocThin4, this, OriginalFormSize);
            Utils.ResizeButtons(BlocMoving1Rectangle, blocMoving1, this, OriginalFormSize);
            Utils.ResizeButtons(BlocMoving2Rectangle, blocMoving2, this, OriginalFormSize);
            Utils.ResizeButtons(BlocSpecial1Rectangle, blocSpecial1, this, OriginalFormSize);
            Utils.ResizeButtons(BlocLeaveRectangle, blocLeave, this, OriginalFormSize);
            Utils.ResizeButtons(Cheese1Rectangle, cheese1, this, OriginalFormSize);
            Utils.ResizeButtons(Cheese2Rectangle, cheese2, this, OriginalFormSize);
            Utils.ResizeButtons(Cheese3Rectangle, cheese3, this, OriginalFormSize);
            Utils.ResizeButtons(Cheese4Rectangle, cheese4, this, OriginalFormSize);
            Utils.ResizeButtons(Cheese5Rectangle, cheese5, this, OriginalFormSize);
            Utils.ResizeButtons(Cheese6Rectangle, cheese6, this, OriginalFormSize);
            Utils.ResizeButtons(Cheese7Rectangle, cheese7, this, OriginalFormSize);
            Utils.ResizeButtons(Cheese8Rectangle, cheese8, this, OriginalFormSize);
            Utils.ResizeButtons(Cheese9Rectangle, cheese9, this, OriginalFormSize);
            Utils.ResizeButtons(ScoreRectangle, score, this, OriginalFormSize);
            Utils.ResizeButtons(GameTitleRectangle, gameTitle, this, OriginalFormSize);
            Utils.ResizeButtons(ExitPlatformerButtonRectangle, exitPlatformerButton, this, OriginalFormSize);
            Utils.ResizeButtons(StartPlatformerButtonRectangle, startPlatformerButton, this, OriginalFormSize);
            Utils.ResizeButtons(RatTitle1Rectangle, ratTitle1, this, OriginalFormSize);
            Utils.ResizeButtons(RatTitle2Rectangle, ratTitle2, this, OriginalFormSize);
        }
        
        private void Platformer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
        }
        
        private void exitPlatformerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startPlatformerButton_Click(object sender, EventArgs e)
        {
            KeyPreview = true;
            startPlatformerButton.Visible = false;
            exitPlatformerButton.Visible = false;
            ratTitle1.Visible = false;
            ratTitle2.Visible = false;
            gameTitle.Visible = false;

            timeRepeat.Enabled = true;

            Score = 0;
        }

        private void Platformer_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D :
                    PlayerGoRight = true;
                    break;
                case Keys.A :
                    PlayerGoLeft = true;
                    break;
                case Keys.Space :
                    PlayerJump = true;
                    break;
            }
        }
        
        private void Platformer_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D :
                    PlayerGoRight = false;
                    break;
                case Keys.A :
                    PlayerGoLeft = false;
                    break;
                case Keys.Space :
                    PlayerJump = false;
                    break;
            }
        }
        
        private void timeRepeat_Elapsed(object sender, ElapsedEventArgs e)
        {
            // score.Text = "" + Score;

            if (PlayerGoLeft && player.Left > 0)
            {
                player.Left -= 7;
            }

            if (PlayerGoRight && player.Right < ClientSize.Width)
            {
                player.Left += 7;
                debug.Text = player.Right.ToString();
            }
            //
            // if (Score == 9)
            // {
            //     timeRepeat.Stop();
            // }
        }
    }
}