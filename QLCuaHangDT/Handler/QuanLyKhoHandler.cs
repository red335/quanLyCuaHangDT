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
                    quanLyKho.TrangThaiMenu = MenuQuanLyKho.LINH_KIEN;
                    break;

            }
            quanLyKho.SelectedButton.BackColor = Color.FromArgb(115, 115, 236);
          //   MessageBox.Show(quanLyKho.TrangThaiMenu.ToString());
            chonLoaiSanPham();

        }



        internal void PictureBox_Leave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.White;
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
          

            List<SanPham> list_1 = ds.Where((sanPham) =>
            {
                return sanPham.LoaiSanPham == Loai_San_Pham.DIEN_THOAI;
            }).ToList();

            List<SanPham> list_2 = ds.Where((sanPham) =>
            {
                return sanPham.LoaiSanPham == Loai_San_Pham.LINH_KIEN;
            }).ToList();
            for (int i = 0; i < list_1.Count; i++)
                quanLyKho.DsDT.Add(new DienThoai(list_1[i]));
           
            for (int i = 0; i < list_2.Count; i++)
                quanLyKho.DsLK.Add(new LinhKien(list_2[i]));
        }

       

            public void hienThiKho(SanPham[] array)
        {
            quanLyKho.FlowList.Visible = false;
            quanLyKho.FlowList.Controls.Clear();
            foreach (SanPham sanPham in array)
            {
                ChiTietThietBi chiTiet = new ChiTietThietBi(sanPham);
                chiTiet.Tag = sanPham.MaSanPham.ToString();
                quanLyKho.FlowList.Controls.Add(chiTiet);
            }
            quanLyKho.FlowList.Visible = true;
        }
        public void chonLoaiSanPham()
        {
            if (quanLyKho.TrangThaiMenu == MenuQuanLyKho.DIEN_THOAI)
            {
                hienThiKho(quanLyKho.DsDT.ToArray());
            }
            else {
                hienThiKho(quanLyKho.DsLK.ToArray());
            }
        }
        #endregion
    }
}
