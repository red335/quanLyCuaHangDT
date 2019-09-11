using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDT.GUI
{
   public class PictureCircle:PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            pe.Graphics.DrawEllipse(new System.Drawing.Pen(new System.Drawing.SolidBrush(this.BackColor)), new
               System.Drawing.Rectangle(0, 0, this.Width - 2, this.Height - 2));
            GraphicsPath gp = new GraphicsPath();
            
           
            gp.AddEllipse (0,0, this.Width-1, this.Height-1);
            Region = new System.Drawing.Region(gp);
           
           

          
        }
    }
}
