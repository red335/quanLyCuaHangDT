using QLCuaHangDT.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDT.DAO
{
    class HangSXDAO : KetNoiDatabase
    {
        public override void Sua()
        {
            
        }

        public override void Them(string data)
        {
            HangSanXuat hang = new HangSanXuat(data);
            string query = "Insert into NhaSanXuat (MaNSX,TenHSX,QuocGia) values("+hang.MaHangSX+", " +
                hang.TenHangSX+", "+hang.QuocGia;
            thaoTacDuLieu(query);
        }

        public override void Xoa()
        {
            
        }

        public List<HangSanXuat> layDanhSachHangSX() {
            List<HangSanXuat> list = new List<HangSanXuat>();
            string query = "select * from NhaSX";
            DataTable table = docDuLieu(query);

            if (table == null || table.Rows.Count == 0) return null;
            foreach (DataRow row in table.Rows) {
                int ma =Convert.ToInt32( row["MaNSX"]);
                string ten = row["TenHSX"].ToString();
                string quocGia = row["QuocGia"].ToString();
                list.Add(new HangSanXuat(ma,ten,quocGia));
            }
            return list;
        }
        public HangSanXuat layMotHangSanXuat( int maSP) {
            HangSanXuat hangSanXuat = null;
            string query = "select MaNSX, TenHSX, QuocGia from SanPham , NhaSX where " +
                " MaNSX = MaHSX and MaSP = "+maSP;

            DataRow row = docDuLieu(query).Rows[0];
            if (row != null) {
                int ma = Convert.ToInt32(row["MaNSX"]);
                string ten = row["TenHSX"].ToString();
                string quocGia = row["QuocGia"].ToString();
                hangSanXuat = new HangSanXuat(ma, ten, quocGia);
            }

            return hangSanXuat;
        }
    }
}
