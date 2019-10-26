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
            pbAdd.MouseHover += Pb_ThayDoiKichThuocOnMouseHover;
            pbAdd.MouseLeave += Pb_ThayDoiKichThuocOnMoueLeave;

            pbDel.MouseHover += Pb_ThayDoiKichThuocOnMouseHover;
            pbDel.MouseLeave += Pb_ThayDoiKichThuocOnMoueLeave;
            pbSort.MouseHover += Pb_ThayDoiKichThuocOnMouseHover;
            pbSort.MouseLeave += Pb_ThayDoiKichThuocOnMoueLeave;
            pbFitler.MouseHover += Pb_ThayDoiKichThuocOnMouseHover;
            pbFitler.MouseLeave += Pb_ThayDoiKichThuocOnMoueLeave;
            pbSearch.MouseHover += Pb_ThayDoiKichThuocOnMouseHover;
            pbSearch.MouseLeave += Pb_ThayDoiKichThuocOnMoueLeave;
            UpdateDanhSachNhanVien();
        }

        private void UpdateDanhSachNhanVien() {
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
        private void Pb_ThayDoiKichThuocOnMouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.BackColor = Color.LightGray;
        }
        private void Pb_ThayDoiKichThuocOnMoueLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.BackColor = Color.White;
        }

    }
}
