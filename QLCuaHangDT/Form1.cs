using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangDT.GUI;
namespace QLCuaHangDT
{
    public delegate void exitForm1  (); 
    public partial class Form1 : Form
    {
        exitForm1 exitThis;
        public Form1()
        {
            InitializeComponent();
            exitThis += new exitForm1(ThoatForm);
            this.FormClosing += DialogThoat;
            this.Load += HienDangNhap;
           
        }

        private void DialogThoat(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ??", "Thoát chương trình", MessageBoxButtons.YesNo)
                == DialogResult.No)
                e.Cancel = true;
        }

        public void ThoatForm()
        {
           
            this.Close();
        }
        public void LoadForm1() {
            this.Show();
        }

        private void HienDangNhap(object o, EventArgs e)
        {

            FormDangNhap formDangNhap = new FormDangNhap(exitThis , new exitForm1(LoadForm1));
            this.Hide();
            formDangNhap.ShowDialog();
        }
    }
}
