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

        internal void Menu_OnMouseHover(object sender, EventArgs e)
        {
            if (quanLyKho.TrangThaiMenu == MenuQuanLyKho.NONE)
                (sender as Button).BackColor = Color.FromArgb(115, 115, 236);
        }

        internal void Menu_OnMouseLeave(object sender, EventArgs e)
        {
            if (quanLyKho.TrangThaiMenu == MenuQuanLyKho.NONE)
                (sender as Button).BackColor = Color.FromArgb(34, 34, 34);

        }

        internal void Menu_OnClick(object sender, EventArgs e)
        {

            if (quanLyKho.SelectedButton != null)
            {
                quanLyKho.SelectedButton.BackColor = Color.FromArgb(34, 34, 34);
                if (quanLyKho.SelectedButton.Tag == (sender as Button).Tag)
                    quanLyKho.TrangThaiMenu = MenuQuanLyKho.NONE;
            }
            else
            {
                string tag = (sender as Button).Tag.ToString();
                switch (tag)
                {
                    case "DT":
                        quanLyKho.TrangThaiMenu = MenuQuanLyKho.DIEN_THOAI;
                        break;
                    case "LK":
                        quanLyKho.TrangThaiMenu = MenuQuanLyKho.DIEN_THOAI;
                        break;
                    case "NH":
                        quanLyKho.TrangThaiMenu = MenuQuanLyKho.DIEN_THOAI;
                        break;
                }
                
            }
            quanLyKho.SelectedButton = (sender as Button);
            quanLyKho.SelectedButton.BackColor = Color.FromArgb(115, 115, 236);

        }
    }
}
