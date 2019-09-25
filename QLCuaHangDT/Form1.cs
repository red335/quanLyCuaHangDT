using System;
using System.Drawing;
using System.Windows.Forms;
using QLCuaHangDT.GUI;

using QLCuaHangDT.Model;
using QLCuaHangDT.DAO;
using QLCuaHangDT.GiaoDien.SanPham;
using QLCuaHangDT.GiaoDien.NhanVienGiaoDien;

public enum MENU_TAG
{
    NONE,
    KHO_HANG,
    NHAN_VIEN
}
namespace QLCuaHangDT
{
    public delegate void batMoForm1();

    public partial class Form1 : Form
    {
        private Color colorMenuOnHover = Color.FromArgb(255, 171, 79);
        private Button currentButton = null;
        private MENU_TAG tag_menu;
        public Form1()
        {
            InitializeComponent();
            GangSuKienChoControl();
        }

        #region suKien
        private void GangSuKienChoControl()
        {
            //them su kien cho cac nut thoat, thu nho , username, thong bao
            this.btnExit.MouseLeave += this.OnLeaveControlsBox;
            this.btnExit.MouseHover += this.OnHoverControlsBox;
            this.pbMinisize.MouseHover += this.OnHoverControlsBox;
            this.pbMinisize.MouseLeave += this.OnLeaveControlsBox;
            this.pbNews.MouseLeave += this.OnLeaveControlsBox;
            this.pbNews.MouseHover += this.OnHoverControlsBox;
            this.pbUser.MouseLeave += this.OnLeaveControlsBox;
            this.pbUser.MouseHover += this.OnHoverControlsBox;

            //Them su kien cho menu ben trai cua ung dung
            this.btnKhoHang.Click += this.OnClickMenu;
            this.btnNhapHang.Click += this.OnClickMenu;
        
        }

      

        private void OnClickMenu(object sender, EventArgs e)
        {
            if(currentButton != null)
                currentButton.BackColor = flpMenu.BackColor;
            Button button = sender as Button;
            button.BackColor = colorMenuOnHover;
            currentButton = button;


            //Khong cho phep mo nhieu hon 1 menu cung luc
            if (tag_menu.ToString() == currentButton.Tag.ToString()) return;

            pnCenter.Controls.Clear();
            // Su kien nay dung de chuyen doi mang hinh
            if ( currentButton.Tag.ToString() == "KHO_HANG") {
                pnCenter.Controls.Add(new QLKho());
                tag_menu = MENU_TAG.KHO_HANG;   
            }
            // Su kien nay dung de chuyen doi mang hinh
            else if ( currentButton.Tag.ToString() == "NHAN_VIEN")
            {
                pnCenter.Controls.Add(new QuanLyNhanVien());
                tag_menu = MENU_TAG.NHAN_VIEN;
            }
            
        }

        private void OnHoverControlsBox(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.FromArgb(255, 173, 83);
        }
        private void OnLeaveControlsBox(object sender, EventArgs e)
        {
            (sender as Control).BackColor = panel1.BackColor;
        }
        

        #endregion

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
        public void LoadForm1()
        {
            this.Show();
        }


        #endregion


        private void HienDangNhap(object o, EventArgs e)
        {

            //FormDangNhap formDangNhap = new FormDangNhap(ths);
            this.Hide();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }


}
