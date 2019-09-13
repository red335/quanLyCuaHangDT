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
        private SanPham sanPham;
        private Color myColor_;
        private Color changedColor;

        public ChiTietThietBi()
        {
            InitializeComponent();
            myColor_ = this.BackColor;
            changedColor = Color.FromArgb(255, 128, 0);
          
            ganeSuKien();
        }
        public ChiTietThietBi(SanPham sanPham) {
            InitializeComponent();
            this.sanPham = sanPham;
            myColor_ = this.BackColor;
            changedColor = Color.FromArgb(255, 128, 0);

            ganeSuKien();
            caiDat();
        }

        private void ganeSuKien() {
            cpExpand.Click += cpExpand_ObClick;
            cpExpand.MouseHover += cpExpand_OnMouseHover;
            cpExpand.MouseLeave += cpExpand_OnMouseLeave;
        }

        private void caiDat() {
            mlMa.Text ="DT"+ sanPham.MaSanPham.ToString();
            mlTen.Text = sanPham.TenSanPham;
            mlGia.Text = sanPham.Gia.ToString()+" D";
            mlHangSX.Text = sanPham.HangSanXuatSanPham.TenHangSX;
            mlConHang.Text = sanPham.SoLuongTonKho1 > 0 ? "Còn" : "Hết";
            mlKM.Text = sanPham.CoKhuyenMai == true ? "Có" : "Không";
        }

        private void cpExpand_OnMouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = myColor_;
            this.BackColor = myColor_;
        }

        private void cpExpand_OnMouseHover(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = changedColor ;
            this.BackColor = changedColor;
        }

        private void cpExpand_ObClick(object sender, EventArgs e)
        {
           
            this.BackColor = Color.FromArgb(255, 128, 0);
            new DienThoaiChiTiet().ShowDialog();
          
        }

        


        internal SanPham ThietBi { get => sanPham; set => sanPham = value; }


        
    }
}
