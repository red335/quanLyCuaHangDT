using System;
using System.Drawing;
using System.Windows.Forms;
using QLCuaHangDT.GUI;
using QLCuaHangDT.Handler;
using QLCuaHangDT.Model;
using QLCuaHangDT.DAO;
namespace QLCuaHangDT
{
    public delegate void batMoForm1  ();
    public partial class Form1 : Form
    {
        private NhanVienDAO nvDao = new NhanVienDAO();
        private MainFormHandler mainHandler ;
        private NhanVien nhanVien;
  
        internal NhanVien NhanVien { get => nhanVien; set => nhanVien = value; }
      
        public Form1()
        {
            InitializeComponent();
            mainHandler = new MainFormHandler(this); 
            this.FormClosing += DialogThoat;
            NhanVien = new NhanVien();
            //   this.Load += HienDangNhap;
            PnBody.Controls.Add(new NhapHang());
            gangSuKien();
        }
       
       

        #region Dong Va Mo Form
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
            gangSuKien();
            NhanVien = nvDao.layMotNhanVien(NhanVien.IdTaiKhoan);
            mainHandler.loadAvatar();
        }
        public void gangSuKien()
        {
            mainHandler.loadAvatar();
            pbExit.Click +=mainHandler.btnExit_Click;
            pbExit.MouseHover += mainHandler.PictureBoxMouse_Hover;
            pbExit.MouseLeave += mainHandler.PictureBoxMouse_Leave;
           
            pbHide.MouseHover += mainHandler.PictureBoxMouse_Hover;
            pbHide.MouseLeave += mainHandler.PictureBoxMouse_Leave;
            pbHide.Click += mainHandler.btnHide_Click;


            btnKho.MouseHover += mainHandler.ButtonMouse_Hover;
            btnKho.MouseLeave += mainHandler.ButtonMouse_Leave;
            btnNV.MouseHover += mainHandler.ButtonMouse_Hover;
            btnNV.MouseLeave += mainHandler.ButtonMouse_Leave;
            btnNH.MouseHover += mainHandler.ButtonMouse_Hover;
            btnNH.MouseLeave += mainHandler.ButtonMouse_Leave;
            btnTK.MouseHover += mainHandler.ButtonMouse_Hover;
            btnTK.MouseLeave += mainHandler.ButtonMouse_Leave;

            //Click Cac button;
            btnKho.Click += mainHandler.BtnMenu_Click;
            btnNH.Click += mainHandler.BtnMenu_Click;
        }

        #endregion


        private void HienDangNhap(object o, EventArgs e)
        {

            FormDangNhap formDangNhap = new FormDangNhap(this);
            this.Hide();
            formDangNhap.ShowDialog();
        }

        private void BtnTC_Click(object sender, EventArgs e)
        {

        }
    }

  
}
