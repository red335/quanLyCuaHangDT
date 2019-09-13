using QLCuaHangDT.GUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDT.Handler
{

    class QuanLyKhoHandler
    {
        private QuanLyKho quanLyKho;

        public QuanLyKhoHandler(QuanLyKho quanLyKho)
        {
            this.quanLyKho = quanLyKho;
        }


        internal void Menu_OnClick(object sender, EventArgs e)
        {
            if (quanLyKho.SelectedButton != null)
                quanLyKho.SelectedButton.BackColor = Color.FromArgb(34, 34, 34);
            quanLyKho.SelectedButton = (sender as Button);
            string tag = (sender as Button).Tag.ToString();
            switch (tag)
            {
                case "DT":
                    quanLyKho.TrangThaiMenu = MenuQuanLyKho.DIEN_THOAI;
                    break;
                case "LK":
                    quanLyKho.TrangThaiMenu = MenuQuanLyKho.DIEN_THOAI;
                    break;

            }
            quanLyKho.SelectedButton.BackColor = Color.FromArgb(115, 115, 236);



        }



        internal void PictureBox_Leave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.FromArgb(224, 224, 224);
        }

        internal void PictureBox_Hover(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.FromArgb(255, 192, 128);
        }

        internal void PictureBox_Click(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
