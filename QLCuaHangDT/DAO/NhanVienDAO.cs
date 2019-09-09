using System;
using System.Collections.Generic;
using QLCuaHangDT.Model;
using System.Data;
namespace QLCuaHangDT.DAO
{
    class NhanVienDAO : KetNoiDatabase
    {
        #region Doc Du Lieu
        public List<NhanVien> layDanhSachNhanVien() {
            List<NhanVien> ds = new List<NhanVien>();
            string query = "select * from NhanVien";
            DataTable table = docDuLieu(query);
            
            //Mot lan nua Kiem tra xem id co ton tai hay khong de cho chac chan
            if (table == null || table.Rows.Count == 0) return null;

            foreach (DataRow row in table.Rows) {
                int id = (int)row["maNhanVien"];
                string hoTen =Convert.ToString(row["hoTen"]);
                string namSinh = Convert.ToString(row["namSinh"]);
                string queQuan = Convert.ToString(row["queQuan"]);
                string sdt = Convert.ToString(row["SDT"]);
                bool gioiTinh = Convert.ToBoolean (row["gioiTinh"]);
                int idTaiKhoan = (int)row["taiKhoanID"];
                string tenChucVu = Convert.ToString(row["tenChucVu"]);
                NhanVien nv = new NhanVien(id, hoTen, namSinh, queQuan, sdt, gioiTinh,idTaiKhoan,tenChucVu);
                nv.QuyenHanNhanVien = QuyenHanDAO.LayDanhSachPhanQuyen(nv.IdNhanVien);
                ds.Add(nv);
            }



            return ds;
        }
        public NhanVien layMotNhanVien(int idDangNhap) {
            NhanVien nv = new NhanVien();
            string query = "select * from NhanVien where taiKhoanID = "+idDangNhap;
            DataTable table = docDuLieu(query);

            //Mot lan nua Kiem tra xem id co ton tai hay khong de cho chac chan
            if (table == null || table.Rows.Count == 0) return null;

            foreach (DataRow row in table.Rows)
            {
                int id = (int)row["maNhanVien"];
                string hoTen = Convert.ToString(row["hoTen"]);
                string namSinh = Convert.ToString(row["namSinh"]);
                string queQuan = Convert.ToString(row["queQuan"]);
                string sdt = Convert.ToString(row["SDT"]);
                bool gioiTinh = Convert.ToBoolean(row["gioiTinh"]);
                int idTaiKhoan = (int)row["taiKhoanID"];
                string tenChucVu = Convert.ToString(row["tenChucVu"]);
                nv = new NhanVien(id, hoTen, namSinh, queQuan, sdt, gioiTinh, idTaiKhoan, tenChucVu);
                nv.QuyenHanNhanVien = QuyenHanDAO.LayDanhSachPhanQuyen(nv.IdNhanVien);
            }
            return nv;
        }
        #endregion
        #region Them xoa sua nhan vien
        protected override void Sua()
        {
            
        }

        protected override void Them(string data)
        {
           
        }

        protected override void Xoa()
        {
            
        }

        #endregion
    }
}
