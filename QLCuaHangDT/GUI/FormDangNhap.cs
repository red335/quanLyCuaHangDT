using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using QLCuaHangDT.DAO;
using System.Windows.Forms;
namespace QLCuaHangDT.GUI
{
    public partial class FormDangNhap : Form
    {
        exitForm1 exit;
        exitForm1 load;
        public FormDangNhap(exitForm1 exit, exitForm1 load)
        {
            InitializeComponent(); 
            this.exit = exit;
            this.load = load;
            
        }
       
        private void lbLogin_Click(object sender, EventArgs e)
        {
            load();
            this.Close();
        }

        private void lbLogin_MouseHover(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.Green;
        }

        private void lbLogin_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.FromArgb(192, 192, 255);
        }

        private void lbExit_Clickr(object sender, EventArgs e)
        {
             exit();
        }

        private void lbExit_MiuseHover(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.FromArgb(255, 192, 192);
        }

        private void lbExit_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.Red;
        }

        private int layID(string user, string pass) {
            int id = 0;
            SqlConnection con = KetNoiDatabase.ketNoiDatabase();
            string query = "select userID from TaiKhoan where tenUser = " + user + " and matKhau = " + pass;
            SqlCommand cmd = new SqlCommand(query, con);

            return id;
        }

    }
}
