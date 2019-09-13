using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDT.GUI
{
    public partial class DienThoaiChiTiet : Form
    {
        public DienThoaiChiTiet()
        {
            InitializeComponent();
            pbExit.Click += (s, e) =>
            {
                this.Close();
            };
            pbExit.MouseHover += (s, e) =>
            {
                pbExit.BackColor = Color.FromArgb(152, 152, 241);
            };
            pbExit.MouseLeave += (s, e) =>
            {
                pbExit.BackColor = Color.FromArgb(115, 115, 236);
            };

        }
    }
}
