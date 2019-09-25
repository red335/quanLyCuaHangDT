using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDT.GiaoDien.SanPham
{
    public enum Loai_Quan_Ly {
        DIEN_THOAI,
        LINH_KIEN,
        NHAP_HANG
    }
    public partial class QLKho : UserControl
    {
        private Loai_Quan_Ly loaiMenu = Loai_Quan_Ly.DIEN_THOAI;
        private Color colorChanged = Color.FromArgb(0, 103, 172);//(0, 122, 204);
        private Color colorHover = Color.FromArgb(26, 164, 255);
        private Button currentSelectButton = null;
        private Size parentSize;
        public QLKho()
        {
            InitializeComponent();
        
            this.Location = Point.Empty;
            gangSukIen();
            KhoiTaoMenu();
        }
        public Size ParentSize { get => parentSize; set => parentSize = value; }
        private void gangSukIen() {


            btnDT.ForeColor = Color.Black;
            btnLK.ForeColor = Color.Black;
            btnNH.ForeColor = Color.Black;

            btnLK.MouseHover += OnHoverQuanLyMenu;
            btnLK.MouseLeave += OnLeaveQuanLyMenu;

            btnDT.MouseHover += OnHoverQuanLyMenu;
            btnDT.MouseLeave += OnLeaveQuanLyMenu;

            btnNH.MouseHover += OnHoverQuanLyMenu;
            btnNH.MouseLeave += OnLeaveQuanLyMenu;

            btnDT.MouseClick += OnMouseClickMenu;
            btnLK.MouseClick += OnMouseClickMenu;
            btnNH.MouseClick += OnMouseClickMenu;

            OnMouseClickMenu(btnDT, EventArgs.Empty);
        }

        private void OnMouseClickMenu(object sender, EventArgs e)
        {
            if (currentSelectButton != null) {
                currentSelectButton.ForeColor = Color.Black;
                currentSelectButton.BackColor = pnMenuQuanLy.BackColor;
            }
               

            currentSelectButton = sender as Button;
            currentSelectButton.BackColor = colorChanged;
            if (currentSelectButton.Tag.ToString() == "LK")
                loaiMenu = Loai_Quan_Ly.LINH_KIEN;
            else if (currentSelectButton.Tag.ToString() == "DT")
                loaiMenu = Loai_Quan_Ly.DIEN_THOAI;
            else
                loaiMenu = Loai_Quan_Ly.NHAP_HANG;
            KhoiTaoMenu();
            
        }

        private void OnLeaveQuanLyMenu(object sender, EventArgs e)
        {
            if (currentSelectButton != null&& (sender as Button).Tag.ToString() == currentSelectButton.Tag.ToString())
                return;
            Button button = (sender as Button);
            button.ForeColor = Color.Black;
            button.BackColor = pnMenuQuanLy.BackColor;
           
        }

        private void OnHoverQuanLyMenu(object sender, EventArgs e)
        {
            if (currentSelectButton != null && (sender as Button).Tag.ToString() == currentSelectButton.Tag.ToString())
                return;
            Button button = (sender as Button);
            button.ForeColor = Color.White;
            button.BackColor = colorHover;
           
        }

        private void KhoiTaoMenu()
        {
            this.pnCenter.Controls.Clear();
            if (loaiMenu == Loai_Quan_Ly.DIEN_THOAI)
            {
                DanhSachSanPham danhSachSanPham = new DanhSachSanPham();
                danhSachSanPham.LoaiSanPham = Model.Loai_San_Pham.DIEN_THOAI;

                danhSachSanPham.LoadDanhSach();
                this.pnCenter.Controls.Add(danhSachSanPham);
            }
            else if (loaiMenu == Loai_Quan_Ly.LINH_KIEN)
            {
                DanhSachSanPham danhSachSanPham = new DanhSachSanPham();
                danhSachSanPham.LoaiSanPham = Model.Loai_San_Pham.LINH_KIEN;

                danhSachSanPham.LoadDanhSach();
                this.pnCenter.Controls.Add(danhSachSanPham);
            }
            else if (loaiMenu == Loai_Quan_Ly.NHAP_HANG)
            {
                this.pnCenter.Controls.Add(new NhapSanPham());
            }
        }
    }
}
