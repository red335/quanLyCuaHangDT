using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using QLCuaHangDT.DAO;
using System.Windows.Forms;
using System.Threading;

namespace QLCuaHangDT.GUI
{
    public partial class FormDangNhap : Form
    {
        Form1 mainForm = null;
        int id = 0;
        bool MoForm = false;

        Thread thread = null;

        public FormDangNhap(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
            thread = new Thread(loadForm1);
        }

        #region chay luong (Thread)
        public void loadForm1()
        {
            Thread.Sleep(2000);         
            mainForm.Invoke(new MethodInvoker(() =>
            {
                mainForm.NhanVien.IdTaiKhoan = id;
                mainForm.LoadForm1();
            }));
            this.Invoke(new MethodInvoker(Close));
            thread.Abort();
        }
        private void LapThoiGian(object sender, EventArgs e)
        {
            pnProcess.Left += 5;
            if (pnProcess.Left >= 600)
            {
                pnProcess.Left = 0;
            }
        }
        #endregion

        #region Thao tac Button Login
        private void lbLogin_Click(object sender, EventArgs e)
        {
            lbWarning.Visible = false;
            int a;
            if ((a = layID(txtLoggin.Text, txtPass.Text)) >= 0)
            {
                id = a;
                txtLoggin.Enabled = false;
                txtPass.Enabled = false;
                MoForm = true;
                pnBackgroundProcess.Visible = true;
                timer1.Start();

                thread.Start();

            }
            else
                MoForm = false;
        }
        private void lbLogin_MouseHover(object sender, EventArgs e)
        {
            if (!MoForm)
                (sender as Label).ForeColor = Color.Green;
        }

        private void lbLogin_MouseLeave(object sender, EventArgs e)
        {
            if (!MoForm)
                (sender as Label).ForeColor = Color.FromArgb(192, 192, 255);
        }
        #endregion

        #region Thao Tac Button Exit
        private void lbExit_Clickr(object sender, EventArgs e)
        {
            if (!MoForm)
                mainForm.Close();
        }

        private void lbExit_MiuseHover(object sender, EventArgs e)
        {
            if (!MoForm)
                (sender as Label).ForeColor = Color.FromArgb(255, 192, 192);
        }

        private void lbExit_MouseLeave(object sender, EventArgs e)
        {
            if (!MoForm)
                (sender as Label).ForeColor = Color.Red;
        }
        #endregion


        private int layID(string user, string pass)
        {
            int id = 0;
            user = "BHYT1234";
            pass = "NTK12345";
            // string query = "select userID from TaiKhoan where tenUser = '"+user+"' and matKhau = '"+pass+"'";
            string query =
                string.Format("select userID from TaiKhoan where tenUser = '{0}' and matKhau = '{1}'", user, pass);

          
            DataTable table = KetNoiDatabase.docDuLieu(query);

            if (table == null || table.Rows.Count == 0)
            {
                lbWarning.Visible = true;
                return -1;
            }
            else
            {
                DataRow row = table.Rows[0];
                id = Convert.ToInt32(row["userID"]);


            }
            return id;
        }


    }
}
