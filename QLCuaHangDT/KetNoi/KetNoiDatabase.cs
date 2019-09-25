using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLCuaHangDT.DAO
{
    abstract class  KetNoiDatabase
    {
        private static string connString = ReadDataSource.layDuongDanSQl();
        public static SqlConnection ketNoiDatabase()
        {
            return new SqlConnection(connString);
        }

        #region Cac Ham Nonquery va co query
        public static bool thaoTacDuLieu(string query)
        {
            SqlConnection con = KetNoiDatabase.ketNoiDatabase();

            SqlCommand cmd = null;
            bool hopLe = true;
            try
            {   cmd= new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                hopLe = false;
            }
            
            con.Close();

            return hopLe;
        }
        public static DataTable docDuLieu(string query) {
            DataTable table = new DataTable();
            SqlConnection con = KetNoiDatabase.ketNoiDatabase();

            SqlDataAdapter adap;
            try
            {
            //    System.Windows.Forms.MessageBox.Show(query);
                con.Open();
            adap    = new SqlDataAdapter(query,con);
               
                adap.Fill(table);

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                table =  null;
            }
            
            con.Close();
           
            return table;
        }
        #endregion

        #region Them Xoa Sua
        abstract public void Them(string data);
        abstract public void Sua();
        abstract public void Xoa();
        #endregion

    }
}
