using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDT.GUI
{
    public  class MyLabel:Button
    {
        public MyLabel()
        {
            this.FlatAppearance.MouseOverBackColor = this.BackColor;
            //  this.ForeColor = this.ForeColor;
            this.BackColorChanged += (s, e) =>
            {
                //   this.ForeColor = this.ForeColor;
                this.FlatAppearance.MouseOverBackColor = this.BackColor;
            };


            this.FlatAppearance.MouseDownBackColor = this.BackColor;
            // this.ForeColor = this.ForeColor;
            this.BackColorChanged += (s, e) =>
            {
                // this.ForeColor = this.ForeColor;
                this.FlatAppearance.MouseDownBackColor = this.BackColor;
            };
        }
    }
}
