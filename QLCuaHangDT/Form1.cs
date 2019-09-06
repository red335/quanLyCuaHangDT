using System;
using System.Windows.Forms;
using QLCuaHangDT.GUI;
using QLCuaHangDT.DAO;
namespace QLCuaHangDT
{
    public delegate void batMoForm1  ();
 
    public partial class Form1 : Form
    {
        private int id_NhanVien = 0;
        public int Id_NhanVien { get => id_NhanVien; set => id_NhanVien = value; }

        public Form1()
        {
            InitializeComponent();
           
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

            FormDangNhap formDangNhap = new FormDangNhap(this);
            this.Hide();
            formDangNhap.ShowDialog();
        }
    }
}
