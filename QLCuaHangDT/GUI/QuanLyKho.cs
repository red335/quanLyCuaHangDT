
using System;
using System.Drawing;

using System.Windows.Forms;
using QLCuaHangDT.Handler;

namespace QLCuaHangDT.GUI
{
    public enum MenuQuanLyKho
    {  
        DIEN_THOAI,
        LINH_KIEN
    }
    public partial class QuanLyKho : UserControl
    {
        private QuanLyKhoHandler quanLyKhoHandler;
        private MenuQuanLyKho trangThai = MenuQuanLyKho.DIEN_THOAI;
        private Button selectedButton = null;
      
        public MenuQuanLyKho TrangThaiMenu { get => trangThai; set => trangThai = value; }
        public Button SelectedButton { get => selectedButton; set => selectedButton = value; }

        public QuanLyKho(int x = -1, int y = -1)
        {
            InitializeComponent();
            if (x == -1 && y == -1)
            {
                this.Location = new Point(258, 52);
            }
            quanLyKhoHandler = new QuanLyKhoHandler(this);

       

            gangSuKien();
        }
        private void gangSuKien()
        {
           


            btnDT.Click += quanLyKhoHandler.Menu_OnClick;
            btnLK.Click += quanLyKhoHandler.Menu_OnClick;

            pbDelete.MouseClick += quanLyKhoHandler.PictureBox_Click;
            pbDelete.MouseHover += quanLyKhoHandler.PictureBox_Hover;
            pbDelete.MouseLeave += quanLyKhoHandler.PictureBox_Leave;

            pbFilter.MouseClick += quanLyKhoHandler.PictureBox_Click;
            pbFilter.MouseHover += quanLyKhoHandler.PictureBox_Hover;
            pbFilter.MouseLeave += quanLyKhoHandler.PictureBox_Leave;

            pbSearch.MouseClick += quanLyKhoHandler.PictureBox_Click;
            pbSearch.MouseHover += quanLyKhoHandler.PictureBox_Hover;
            pbSearch.MouseLeave += quanLyKhoHandler.PictureBox_Leave;

            pbSort.MouseClick += quanLyKhoHandler.PictureBox_Click;
            pbSort.MouseHover += quanLyKhoHandler.PictureBox_Hover;
            pbSort.MouseLeave += quanLyKhoHandler.PictureBox_Leave;
        }

       
    }


}
