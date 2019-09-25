using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangDT.Model;
using QLCuaHangDT.DAO;
namespace QLCuaHangDT.GiaoDien.NhanVienGiaoDien
{
    public partial class QuanLyNhanVien : UserControl
    {
        private NhanVienDAO nvDAO = new NhanVienDAO();
        private List<NhanVien> listNhanVien = new List<NhanVien>();

        private Color color_1 = Color.FromArgb(242, 242, 242);
        private Color color_2 = Color.White;


        public QuanLyNhanVien()
        {
            InitializeComponent();
            LoadNhanVien();
        }

        private void LoadNhanVien() {
            listNhanVien = nvDAO.layDanhSachNhanVien();
            int i = 0;
            foreach (var nhanVien in listNhanVien) {
                HienThiNhanVien hienThiNhanVien = new HienThiNhanVien(nhanVien);
                hienThiNhanVien.BackColor_ = color_2;
                if (i % 2 == 0)
                    hienThiNhanVien.BackColor_ = color_1;
                flList.Controls.Add(hienThiNhanVien);
                i++;
            }
         }
    }
}
