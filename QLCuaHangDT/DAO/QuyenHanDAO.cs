using System;
using System.Collections.Generic;
using System.Data;

namespace QLCuaHangDT.DAO
{
    class QuyenHanDAO
    {
        public static List<int> LayDanhSachPhanQuyen(int maNhanVien) {
            List<int> ds = new List<int>();
            string query = "select maChucNang from PhanQuyenNhanVien where maNhanVien = " + maNhanVien;
            DataTable table = KetNoiDatabase.docDuLieu(query);
            foreach (DataRow row in table.Rows) 
                ds.Add((int)row[0]);
            

            return ds;
        }

    }
}
