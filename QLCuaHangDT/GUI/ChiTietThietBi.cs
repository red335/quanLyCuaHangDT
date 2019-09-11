using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangDT.Model;

namespace QLCuaHangDT.GUI
{
    public partial class ChiTietThietBi : UserControl
    {
        private ThietBi thietBi;
        public ChiTietThietBi()
        {
            InitializeComponent();
        }

     

        internal ThietBi ThietBi { get => thietBi; set => thietBi = value; }
    }
}
