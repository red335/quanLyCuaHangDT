
using System.Drawing;

using System.Windows.Forms;
using QLCuaHangDT.Handler;

namespace QLCuaHangDT.GUI
{
    public enum MenuQuanLyKho
    {   NONE,
        DIEN_THOAI,
        LINH_KIEN,
        NHAP_HANG
    }
    public partial class QuanLyKho : UserControl
    {
        private QuanLyKhoHandler quanLyKhoHandler;
        private MenuQuanLyKho trangThai = MenuQuanLyKho.NONE;
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
            btnDT.MouseHover += quanLyKhoHandler.Menu_OnMouseHover;
            btnDT.MouseLeave += quanLyKhoHandler.Menu_OnMouseLeave;

            btnLK.MouseHover += quanLyKhoHandler.Menu_OnMouseHover; 
            btnLK.MouseLeave += quanLyKhoHandler.Menu_OnMouseLeave;

            btnNH.MouseHover += quanLyKhoHandler.Menu_OnMouseHover;
            btnNH.MouseLeave += quanLyKhoHandler.Menu_OnMouseLeave;

            btnDT.Click += quanLyKhoHandler.Menu_OnClick;
            btnLK.Click += quanLyKhoHandler.Menu_OnClick;
            btnNH.Click += quanLyKhoHandler.Menu_OnClick;
        }
    }


}
