using System;
using System.Collections.Generic;
using System.Data;

namespace QLCuaHangDT.DAO
{
    class QuyenHanDAO
    {
        public static List<int> LayDanhSachPhanQuyen(int maNhanVien) {
            List<int> ds = new List<int>();
            string query = "select MaCN from PhanQuyenNhanVien where MaNV = " + maNhanVien;
            DataTable table = KetNoiDatabase.docDuLieu(query);
            foreach (DataRow row in table.Rows) 
                ds.Add((int)row[0]);
            

            return ds;
        }

    }
}
