using QLCuaHangDT.GUI;
using System;
using QLCuaHangDT.DAO;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using QLCuaHangDT.Model;

namespace QLCuaHangDT.Handler
{

    class QuanLyKhoHandler
    {
        SanPhamDAO spDAO = new SanPhamDAO();
        private QuanLyKho quanLyKho;

        public QuanLyKhoHandler(QuanLyKho quanLyKho)
        {
            this.quanLyKho = quanLyKho;
        }

        #region Cac Su Kien 
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

        }
        #endregion

        #region Cac thao tac voi du lieu

        public void LoadDanhSachhangHoa()
        {
            List<SanPham> ds = spDAO.layDanhSachSanPham();
           ds = ds.Where((sanPham) =>
           {
               return sanPham.LoaiSanPham == Loai_San_Pham.DIEN_THOAI;
           }).ToList();
            
           

            for (int i  =0; i< ds.Count;i++) {
                quanLyKho.DsDT.Add( new DienThoai(ds[i]));
                ChiTietThietBi chiTiet = new ChiTietThietBi(quanLyKho.DsDT[i]);
                chiTiet.Tag = quanLyKho.DsDT[i].MaSanPham.ToString();
                quanLyKho.FlowList.Controls.Add(chiTiet);
            }

        }
        #endregion
    }
}
