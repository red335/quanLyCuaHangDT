using System;
using System.Collections.Generic;

using System.Data;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;
using QLCuaHangDT.DAO;
using QLCuaHangDT.GiaoDien.GiaoDienSanPham;
using QLCuaHangDT.Model;
namespace QLCuaHangDT.GiaoDien.SanPham
{
   
    public partial class DanhSachSanPham : UserControl
    {
        private Model.Loai_San_Pham loaiSanPham = Model.Loai_San_Pham.DIEN_THOAI;
        SanPhamDAO spDAo = new SanPhamDAO();
        List<Model.SanPham> sanPhams = new List<Model.SanPham>();


        //Color cho chi use chitietSanPham 
        private Color color_1 = Color.FromArgb(242, 242, 242);
        private Color color_2 = Color.White;
        public Loai_San_Pham LoaiSanPham { get => loaiSanPham; set => loaiSanPham = value; }

        public DanhSachSanPham()
        {
            InitializeComponent();
            
        }

        public void LoadDanhSach() {
            lapDanhSach();
            hienThiDanhSach();
        }
        public void lapDanhSach()
        {
            sanPhams = spDAo.layDanhSachSanPham();
            if (LoaiSanPham == Loai_San_Pham.DIEN_THOAI) {
                sanPhams = sanPhams.Where((sanPham) => { return sanPham.LoaiSanPham == Loai_San_Pham.DIEN_THOAI; })
                    .ToList();
            }else
                sanPhams = sanPhams.Where((sanPham) => { return sanPham.LoaiSanPham != Loai_San_Pham.DIEN_THOAI; })
                    .ToList();
        }

        public void hienThiDanhSach() {
            int i = 0;
            foreach (var tmp in sanPhams) {
                Color c = Color.White;
                if (i % 2 == 1)
                    c = color_1;
                ChiTietSanPham chiTietSanPham = new ChiTietSanPham(tmp,c);
               
                flpDS.Controls.Add(chiTietSanPham);
                i++;
            }
        }
    }
}
