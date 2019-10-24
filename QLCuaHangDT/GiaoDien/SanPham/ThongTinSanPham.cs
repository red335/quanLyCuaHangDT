using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDT.GiaoDien.SanPham
{
    public partial class ThongTinSanPham : Form
    {
        Model.SanPham sanPham;
        public ThongTinSanPham(Model.SanPham sanPham)
        {
            InitializeComponent();
            this.sanPham = sanPham;
        }
        public ThongTinSanPham()
        {
            InitializeComponent();
          
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
