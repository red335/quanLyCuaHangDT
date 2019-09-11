using System;
using System.Collections.Generic;
using QLCuaHangDT.GUI;
using QLCuaHangDT.DAO;
using QLCuaHangDT.Model;
using System.Drawing;
using System.Windows.Forms;

namespace QLCuaHangDT.Handler
{

    class MainFormHandler
    {
        Form1 mainForm;
        NhanVienDAO nvDao = new NhanVienDAO();



        public MainFormHandler(Form1 form1)
        {
            mainForm = form1;

        }
     
        public void LoadEveryThing()
        {


        }
        public void loadAvatar(/*object sender, EventChangeColor e*/)
        {
            const string defaultAvatar = "Image/Avatar/defaultAvatar.jpg";
            const string tenHienThi = "Unknown";
            const string chucVu = "Unknown";
            //if (mainForm.NhanVien.Avatar == null)
            //    mainForm.PbAvatar.Image = Image.FromFile(defaultAvatar);
         
        }


        #region su kien voi cac controls
        public void ButtonMouse_Hover(object sender, EventArgs e)
        {

            (sender as Button).BackColor = Color.FromArgb(115, 115, 236/*68, 68, 230*/);

        }
        public void ButtonMouse_Leave(object sender, EventArgs e)
        {

            (sender as Button).BackColor = Color.FromArgb(19, 19, 19);
        }


        internal void PictureBoxMouse_Hover(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.FromArgb(152, 152, 241);
        }

        internal void PictureBoxMouse_Leave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.FromArgb(115, 115, 236);
        }

        public void btnExit_Click(object sender, EventArgs e)
        {
            mainForm.Close();
        }

        internal void btnHide_Click(object sender, EventArgs e)
        {
            mainForm.WindowState = FormWindowState.Minimized;
        }

        internal void BtnMenu_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string tag = button.Tag.ToString();
            if (tag == "Kho")
            {
                QuanLyKho qlKho = new QuanLyKho();
                mainForm.Controls.Add ( qlKho);
            }
        }
        #endregion
    }



}
