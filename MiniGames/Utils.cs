using System;
using System.Windows.Forms;
using System.Drawing;

namespace MiniGames
{
    public class Utils
    {
        
        public static void ResizeButtons(Rectangle originalControlRect, Control control, Form resized, Size originalFormSize)
        {
            float xAxis = (float)(resized.Width) / (float)(originalFormSize.Width);
            float yAxis = (float)(resized.Height) / (float)(originalFormSize.Height);
            
            int newXPosition = (int)(originalControlRect.X * xAxis);
            int newYPosition = (int)(originalControlRect.Y * yAxis);
            
            
            int newWidth = (int)(originalControlRect.Width * xAxis);
            int newHeight = (int)(originalControlRect.Height * yAxis);
            
            control.Location = new Point(newXPosition, newYPosition);
            control.Size = new Size(newWidth, newHeight);
        }
    }
}