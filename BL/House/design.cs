using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public partial class BL_House
    {

        public void roundProgressBars(ref ProgressBar[] progressBars)
        {
            // Set rounded corners for progress bars
            foreach(ProgressBar progress in progressBars)
            {
                progress.Region = new Region(CreateRoundRect(0, 0, progress.Width, progress.Height, 20));
            } 
        }
        public static GraphicsPath CreateRoundRect(int x, int y, int width, int height, int radius) 
            // Method to create rounded corners for a control 
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(x, y, radius * 2, radius * 2, 180, 90);
            path.AddLine(x + radius, y, x + width - radius * 2, y);
            path.AddArc(x + width - radius * 2, y, radius * 2, radius * 2, 270, 90);
            path.AddLine(x + width, y + radius, x + width, y + height - radius * 2);
            path.AddArc(x + width - radius * 2, y + height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddLine(x + width - radius * 2, y + height, x + radius, y + height);
            path.AddArc(x, y + height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
