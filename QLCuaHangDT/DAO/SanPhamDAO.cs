using QLCuaHangDT.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDT.DAO
{
    class SanPhamDAO : KetNoiDatabase
    {
        protected override void Sua()
        {
           
        }

        protected override void Them(string data)
        {
            
        }

        protected override void Xoa()
        {

        }

        public List<SanPham> layDanhSachSanPham() {
            List<SanPham> ds = new List<SanPham>();
            string query = "select MaSP, TenSP ,MaHSX, GiaThanh, HinhAnh, SoLuongConTrongCH, LoaiHang, TenHSX, QuocGia" +
" from SanPham , NhaSX   where LoaiHang = 'Dien Thoai' and MaHSX = MaNSX";
            DataTable table = docDuLieu(query);
            if (table == null || table.Rows.Count <= 0) return null;

            foreach (DataRow row in table.Rows) {
                int maHangSX = Convert.ToInt32(row["MaHSX"]);
                string tenHangSX = Convert.ToString(row["TenHSX"]);
                string quocGia = Convert.ToString(row["QuocGia"]);

                HangSanXuat hsx = new HangSanXuat(maHangSX, tenHangSX, quocGia);

                int maSP = Convert.ToInt32(row["MaSP"]);
                string tenSP = Convert.ToString(row["TenSP"]);
                int gia = Convert.ToInt32(row["GiaThanh"]);
                int soLuongTonKho = Convert.ToInt32(row["SoLuongConTrongCH"]);
                string image = Convert.ToString(row["HinhAnh"]);
                string l = Convert.ToString(row["LoaiHang"]);
                Loai_San_Pham loai = Loai_San_Pham.LINH_KIEN;
                if (l == "Dien Thoai")
                    loai = Loai_San_Pham.DIEN_THOAI;
                SanPham sp = new SanPham(maSP, tenSP, loai, gia, hsx, soLuongTonKho, false, image);
                ds.Add(sp);

            }

            return ds;
        }
    }
}
