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

        private void Form1_Load(object sender, EventArgs e)
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
        
        private void Form1_Resize(object sender, EventArgs e)
        {
            // resizeButtons(HelpRectangle, helpBtn);
            // resizeButtons(ExitRectangle, exitBtn);
            // resizeButtons(MenuTitleRectangle, menuTitle);
            // resizeButtons(GameTitle1Rectangle, gameTitle1);
            // resizeButtons(GameTitle2Rectangle, gameTitle2);
            // resizeButtons(GameTitle3Rectangle, gameTitle3);
            // resizeButtons(GameTitle4Rectangle, gameTitle4);
            // resizeButtons(GameTitle5Rectangle, gameTitle5);
            // resizeButtons(GameTitle6Rectangle, gameTitle6);
            // resizeButtons(GameTitle7Rectangle, gameTitle7);
            ResizeButtons(GameTitle8Rectangle, gameTitle8);
        }
        
        private void ResizeButtons(Rectangle originalControlRect, Control control)
        {
            float xAxis = (float)(this.Width) / (float)(OriginalFormSize.Width);
            float yAxis = (float)(this.Height) / (float)(OriginalFormSize.Height);
            
            int newXPosition = (int)(originalControlRect.X * xAxis);
            int newYPosition = (int)(originalControlRect.Y * yAxis);
            
            
            int newWidth = (int)(originalControlRect.Width * xAxis);
            int newHeight = (int)(originalControlRect.Height * yAxis);
            
            control.Location = new Point(newXPosition, newYPosition);
            control.Size = new Size(newWidth, newHeight);
        }
    }
}