using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MiniGames
{
    public partial class Form1 : Form
    {
        private Rectangle HelpRectangle;
        private Rectangle ExitRectangle;
        private Rectangle MenuTitleRectangle;
        private Rectangle GameTitle1Rectangle;
        private Rectangle GameTitle2Rectangle;
        private Rectangle GameTitle3Rectangle;
        private Rectangle GameTitle4Rectangle;
        private Rectangle GameTitle5Rectangle;
        private Rectangle GameTitle6Rectangle;
        private Rectangle GameTitle7Rectangle;
        private Rectangle GameTitle8Rectangle;
        private Size OriginalFormSize;
        
        public Form1()  
        {
            InitializeComponent();
        }

        private void GamesMenu_Load(object sender, EventArgs e)
        {
            OriginalFormSize = this.Size;
            HelpRectangle = new Rectangle(helpBtn.Location.X, helpBtn.Location.Y, helpBtn.Width, helpBtn.Height);
            ExitRectangle = new Rectangle(exitBtn.Location.X, exitBtn.Location.Y, exitBtn.Width, exitBtn.Height);
            MenuTitleRectangle = new Rectangle(menuTitle.Location.X, menuTitle.Location.Y, menuTitle.Width,
                menuTitle.Height);
            GameTitle1Rectangle = new Rectangle(gameTitle1.Location.X, gameTitle1.Location.Y, gameTitle1.Width, gameTitle1.Height);
            GameTitle2Rectangle = new Rectangle(gameTitle2.Location.X, gameTitle2.Location.Y, gameTitle2.Width, gameTitle2.Height);
            GameTitle3Rectangle = new Rectangle(gameTitle3.Location.X, gameTitle3.Location.Y, gameTitle3.Width, gameTitle3.Height);
            GameTitle4Rectangle = new Rectangle(gameTitle4.Location.X, gameTitle4.Location.Y, gameTitle4.Width, gameTitle4.Height);
            GameTitle5Rectangle = new Rectangle(gameTitle5.Location.X, gameTitle5.Location.Y, gameTitle5.Width, gameTitle5.Height);
            GameTitle6Rectangle = new Rectangle(gameTitle6.Location.X, gameTitle6.Location.Y, gameTitle6.Width, gameTitle6.Height);
            GameTitle7Rectangle = new Rectangle(gameTitle7.Location.X, gameTitle7.Location.Y, gameTitle7.Width, gameTitle7.Height);
            GameTitle8Rectangle = new Rectangle(gameTitle8.Location.X, gameTitle8.Location.Y, gameTitle8.Width, gameTitle8.Height);
        }
        
        private void GamesMenu_Resize(object sender, EventArgs e)
        {
            Utils.ResizeButtons(HelpRectangle, helpBtn, this, OriginalFormSize);
            Utils.ResizeButtons(ExitRectangle, exitBtn, this, OriginalFormSize);
            Utils.ResizeButtons(MenuTitleRectangle, menuTitle, this, OriginalFormSize);
            Utils.ResizeButtons(GameTitle1Rectangle, gameTitle1, this, OriginalFormSize);
            Utils.ResizeButtons(GameTitle2Rectangle, gameTitle2, this, OriginalFormSize);
            Utils.ResizeButtons(GameTitle3Rectangle, gameTitle3, this, OriginalFormSize);
            Utils.ResizeButtons(GameTitle4Rectangle, gameTitle4, this, OriginalFormSize);
            Utils.ResizeButtons(GameTitle5Rectangle, gameTitle5, this, OriginalFormSize);
            Utils.ResizeButtons(GameTitle6Rectangle, gameTitle6, this, OriginalFormSize);
            Utils.ResizeButtons(GameTitle7Rectangle, gameTitle7, this, OriginalFormSize);
            Utils.ResizeButtons(GameTitle8Rectangle, gameTitle8, this, OriginalFormSize);
        }

        private void gameTitle1_MouseEnter(object sender, EventArgs e)
        {
            gameTitle1.BackColor = Color.Ivory;
            gameTitle1.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
        }
        private void gameTitle1_MouseLeave(object sender, EventArgs e)
        {
            gameTitle1.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            gameTitle1.ForeColor = Color.Ivory;
        }
        private void gameTitle2_MouseEnter(object sender, EventArgs e)
        {
            gameTitle2.BackColor = Color.Ivory;
            gameTitle2.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
        }
        private void gameTitle2_MouseLeave(object sender, EventArgs e)
        {
            gameTitle2.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            gameTitle2.ForeColor = Color.Ivory;
        }
        private void gameTitle3_MouseEnter(object sender, EventArgs e)
        {
            gameTitle3.BackColor = Color.Ivory;
            gameTitle3.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
        }
        private void gameTitle3_MouseLeave(object sender, EventArgs e)
        {
            gameTitle3.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            gameTitle3.ForeColor = Color.Ivory;
        }
        private void gameTitle4_MouseEnter(object sender, EventArgs e)
        {
            gameTitle4.BackColor = Color.Ivory;
            gameTitle4.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
        }
        private void gameTitle4_MouseLeave(object sender, EventArgs e)
        {
            gameTitle4.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            gameTitle4.ForeColor = Color.Ivory;
        }
        private void gameTitle5_MouseEnter(object sender, EventArgs e)
        {
            gameTitle5.BackColor = Color.Ivory;
            gameTitle5.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
        }
        private void gameTitle5_MouseLeave(object sender, EventArgs e)
        {
            gameTitle5.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            gameTitle5.ForeColor = Color.Ivory;
        }
        private void gameTitle6_MouseEnter(object sender, EventArgs e)
        {
            gameTitle6.BackColor = Color.Ivory;
            gameTitle6.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
        }
        private void gameTitle6_MouseLeave(object sender, EventArgs e)
        {
            gameTitle6.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            gameTitle6.ForeColor = Color.Ivory;
        }
        private void gameTitle7_MouseEnter(object sender, EventArgs e)
        {
            gameTitle7.BackColor = Color.Ivory;
            gameTitle7.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
        }
        private void gameTitle7_MouseLeave(object sender, EventArgs e)
        {
            gameTitle7.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            gameTitle7.ForeColor = Color.Ivory;
        }
        private void gameTitle8_MouseEnter(object sender, EventArgs e)
        {
            gameTitle8.BackColor = Color.Ivory;
            gameTitle8.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
        }
        private void gameTitle8_MouseLeave(object sender, EventArgs e)
        {
            gameTitle8.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            gameTitle8.ForeColor = Color.Ivory;
        }
        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.Ivory;
            exitBtn.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
        }
        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            exitBtn.ForeColor = Color.Ivory;
        }
        private void helpBtn_MouseEnter(object sender, EventArgs e)
        {
            helpBtn.BackColor = Color.Ivory;
            helpBtn.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
        }
        private void helpBtn_MouseLeave(object sender, EventArgs e)
        {
            helpBtn.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            helpBtn.ForeColor = Color.Ivory;
        }

        private void LoadPong(object sender, EventArgs e)
        {
            Pong pongWindow = new Pong();
            pongWindow.Show();
            this.Hide();
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void LoadPlatformer(object sender, EventArgs e)
        {
            Platformer platformerWindow = new Platformer();
            platformerWindow.Show();
            this.Hide();
        }
    }
}