using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDT.GUI
{
    public  class MyLabel:Button
    {
        private Color myColor ;
        public MyLabel()
        {
            MyColor = this.BackColor;
            this.FlatAppearance.MouseOverBackColor = this.BackColor;
            this.BackColorChanged += (s, e) =>
      {
          this.FlatAppearance.MouseOverBackColor = MyColor;
      };


            this.FlatAppearance.MouseDownBackColor = this.BackColor;


            this.BackColorChanged += (s, e) =>
            {
                // this.ForeColor = this.ForeColor;
                this.FlatAppearance.MouseDownBackColor = MyColor;
            };


        }

        internal Color MyColor { get => myColor; set => myColor = value; }
    }
}
