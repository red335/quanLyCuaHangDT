
using System;
using System.Collections.Generic;
using System.Drawing;

using System.Windows.Forms;
using QLCuaHangDT.Handler;
using QLCuaHangDT.Model;
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
        List<DienThoai> dsDT = new List<DienThoai>();
        List<LinhKien> dsLK = new List<LinhKien>();

        public MenuQuanLyKho TrangThaiMenu { get => trangThai; set => trangThai = value; }
        public Button SelectedButton { get => selectedButton; set => selectedButton = value; }
        public List<DienThoai> DsDT { get => dsDT; set => dsDT = value; }
        public FlowLayoutPanel FlowList { get => flowList; set => flowList = value; }
        public List<LinhKien> DsLK { get => dsLK; set => dsLK = value; }

        public QuanLyKho(int x = -1, int y = -1)
        {
            InitializeComponent();
            //if (x == -1 && y == -1)
            //{
            //    this.Location = new Point(258, 52);
            //}
            quanLyKhoHandler = new QuanLyKhoHandler(this);

       

            gangSuKien();
            quanLyKhoHandler.LoadDanhSachhangHoa();

            quanLyKhoHandler.Menu_OnClick(btnDT,EventArgs.Empty);
           
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
