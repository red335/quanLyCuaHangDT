using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLCuaHangDT.DAO
{
    class KetNoiDatabase
    {
        private static string connString = @"Data Source=LAPTOP-V4KO1KOV\SQLEXPRESS;Initial Catalog=QuanLyCuaHangDienThoai;Integrated Security=True";

        public static  SqlConnection ketNoiDatabase() {
            return new SqlConnection(connString);
        }
    }
}
