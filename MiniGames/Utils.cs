using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

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
        
        public static IEnumerable<Control> GetAllControls(Control root)
        {
            var stack = new Stack<Control>();
            stack.Push(root);

            while (stack.Any())
            {
                var next = stack.Pop();
                foreach (Control child in next.Controls)
                    stack.Push(child);

                yield return next;
            }
        }
        
    }
}