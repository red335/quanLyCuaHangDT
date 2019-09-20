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
using System.IO;

namespace QLCuaHangDT.GUI
{

    public partial class NhapHang : UserControl
    {
        HangSXDAO hsxDAO = new HangSXDAO();
        SanPhamDAO spDAO = new SanPhamDAO();
        List<HangSanXuat> listHSX = new List<HangSanXuat>();
        //    List<SanPham> listSP = new List<SanPham>();
        //   SanPham[] sanPhams = null;
        public NhapHang()
        {
            InitializeComponent();
            listHSX = hsxDAO.layDanhSachHangSX();
            cbbNhaSX.DataSource = listHSX;
            cbbNhaSX.DisplayMember = "TenHangSX";
        }

        private void CBB_KiemTraMucChon(object sender, EventArgs e)
        {
            if (cbbTinhTrang.SelectedIndex != 0 && cbbLoai.SelectedIndex != 0) {
                ChonTinhTrang();
                ChonLoaiSanPham();
            }

        }

        private void ChonTinhTrang()
        {
            //Chon Nhan Hang da co
            if (cbbTinhTrang.SelectedIndex != 1)
            {

                cbbSanPham.Enabled = true;
                grSP.Enabled = false;
            }
            //Nhap Hang Moi

            else
            {
            
                cbbSanPham.Enabled = false;
                grSP.Enabled = true;
                pbHinhAnh.Image = null;
                xoaDuLieuNhap();
            }
            grLH.Enabled = true;
            txtMaSP.Enabled = false;
        }
        private void ChonLoaiSanPham()
        {
            

            List<SanPham> listSP = spDAO.layDanhSachSanPham();
            if (cbbLoai.SelectedIndex == 1)
            {
                btnCauHinh.Enabled = false;

                listSP = listSP.Where((sanPham) => { return sanPham.LoaiSanPham == Loai_San_Pham.LINH_KIEN; }).ToList();
            }
            else
            {
                btnCauHinh.Enabled = true;
                listSP = listSP.Where((sanPham) => { return sanPham.LoaiSanPham == Loai_San_Pham.DIEN_THOAI; }).ToList();
            }
            cbbSanPham.DataSource = listSP;
            cbbSanPham.DisplayMember = "TenSanPham";

            // Neu nhap hang moi vao thi xoa danh sach san pham va cho cbbSanPham co datasource = null
            if (cbbTinhTrang.SelectedIndex == 1)
                cbbSanPham.DataSource = null;
               
            

        }

        private void xoaDuLieuNhap()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGia.Text = "";
            txtNgayNhap.Text = "";
            txtSoLuong.Text = "";
            txtTongTien.Text = "";
            cbTinhTrang.Checked = false;

        }

        private void Form_OnLoad(object sender, EventArgs e)
        {
            cbbLoai.SelectedIndex = 0;
            cbbTinhTrang.SelectedIndex = 0;

            cbbTinhTrang.SelectedValueChanged += CBB_KiemTraMucChon;
            cbbLoai.SelectedValueChanged += CBB_KiemTraMucChon;

        }

        private void HienThiThongTinSanPham(SanPham sanPham)
        {
            txtGia.Text = sanPham.Gia.ToString() + "vnd";
            txtMaSP.Text = "DT" + sanPham.MaSanPham.ToString();
            txtTenSP.Text = sanPham.TenSanPham;
            pbHinhAnh.Image = Image.FromFile(sanPham.DuongDanHinhAnh);
            int i = 0;
            for (i = 0; i < listHSX.Count; i++)
            {
                if (listHSX[i].MaHangSX == sanPham.HangSanXuatSanPham.MaHangSX) break;
            }
            cbbNhaSX.SelectedIndex = i;

        }


        #region Event cho cac controls

        private void CBB_ListSanPhamChanged(object sender, EventArgs e)
        {
            if (cbbTinhTrang.SelectedIndex != 1)
                HienThiThongTinSanPham(cbbSanPham.SelectedValue as SanPham);
        }

        private void BtnNSXMoi_Click(object sender, EventArgs e)
        {
            HangSanXuat hang = new HangSanXuat();
            new NhaSX(hang).ShowDialog();
        }

        private void BtnChiTietHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileSave = new OpenFileDialog();
            fileSave.Filter = "PNG|*.png|JPG|*.jpg|JPE|*.jpe";
            fileSave.FilterIndex = 1;
            if (fileSave.ShowDialog() == DialogResult.OK) {
                string path = fileSave.FileName;
                CopyHinhAnh(path);
            }
          
        }
        private void CopyHinhAnh(string p) {
           const string path = "Image/HinhAnh/";
            string currentImagePaht = path;
            if (cbbLoai.SelectedIndex == 1)
                currentImagePaht += "LinhKien/";
            else
                currentImagePaht += "DienThoai/";
            string[] array = p.Split('\\');
         //   MessageBox.Show(currentImagePaht + array[array.Length - 1]);
              File.Copy(p,currentImagePaht+array[array.Length-1]);

            pbHinhAnh.Image = Image.FromFile(currentImagePaht + array[array.Length - 1]);
        }


        #endregion

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (!kiemTraDuKieu()) {
                MessageBox.Show("NhapKhongThanhCong");
            }
        }

        private bool kiemTraDuKieu()
        {
            bool hopLe = true;
           
            for (int i = 0; i < grSP.Controls.Count;i++) {

                if (grSP.Controls[i].GetType() == typeof(TextBox)) {
                    TextBox textBox = (grSP.Controls[i] as TextBox);
                    if (textBox.Tag.ToString() != "txt1"&&textBox.Text == "")
                    {
                        hopLe = false;
                        break;
                    }
                }
            } 
            

            return hopLe;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            xoaDuLieuNhap();
        }
    }



}
