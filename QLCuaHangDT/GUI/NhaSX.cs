using System;
using System.Collections.Generic;
using QLCuaHangDT.DAO;
using System.Windows.Forms;
using QLCuaHangDT.Model;
namespace QLCuaHangDT.GUI
{
    public partial class NhaSX : Form
    {

        private HangSanXuat hangSX;
        public NhaSX(HangSanXuat hang)
        {
            InitializeComponent();
            this.hangSX = hang;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
           // hangSXDAO.Them(hangSX.ToString());
            this.Close();
        }
    }
}
