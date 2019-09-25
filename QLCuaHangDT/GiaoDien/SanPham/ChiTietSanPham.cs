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
namespace QLCuaHangDT.GiaoDien.GiaoDienSanPham
{
    public partial class ChiTietSanPham : UserControl
    {
        private Model.SanPham sanPham;
      //  private Color myColor;
        public ChiTietSanPham(Model.SanPham sanPham,Color color)
        {
            InitializeComponent();
            this.sanPham = sanPham;
            this.BackColor = color;
            hienThiThongTin();
        }

        private void hienThiThongTin() {
            btnMa.ForeColor = Color.Black;
            btnHSX.ForeColor = Color.Black;
            btnKM.ForeColor = Color.Black;
            btnTonKho.ForeColor = Color.Black;
            btnTen.ForeColor = Color.Black;
            btnGia.ForeColor = Color.Black;

            btnMa.FlatAppearance.MouseOverBackColor = this.BackColor;
            btnHSX.FlatAppearance.MouseOverBackColor = BackColor;
            btnKM.FlatAppearance.MouseOverBackColor = BackColor;
            btnTonKho.FlatAppearance.MouseOverBackColor = BackColor;
            btnTen.FlatAppearance.MouseOverBackColor = BackColor;
            btnGia.FlatAppearance.MouseOverBackColor = BackColor;

            btnMa.FlatAppearance.MouseDownBackColor = this.BackColor;
            btnHSX.FlatAppearance.MouseDownBackColor = BackColor;
            btnKM.FlatAppearance.MouseDownBackColor = BackColor;
            btnTonKho.FlatAppearance.MouseDownBackColor = BackColor;
            btnTen.FlatAppearance.MouseDownBackColor = BackColor;
            btnGia.FlatAppearance.MouseDownBackColor = BackColor;


            btnMa.Text = sanPham.MaSanPham.ToString();
            btnGia.Text = sanPham.Gia.ToString()+" Vnd";
            btnHSX.Text = sanPham.HangSanXuatSanPham.TenHangSX;
            btnKM.Text = sanPham.CoKhuyenMai == true ? "Có" : "Không";
            btnTonKho.Text = sanPham.SoLuongTonKho1 > 0 ? "Còn" : "Hết";
            btnTen.Text = sanPham.TenSanPham;

           
        }


    }
}
