using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangDT.DAO;
using System.IO;

namespace QLCuaHangDT.GiaoDien.SanPham
{
    public partial class NhapSanPham : UserControl
    {
        List<Model.SanPham> sanPhams = new List<Model.SanPham>();
        List<Model.SanPham> hienThi = new List<Model.SanPham>();
        List<Model.HangSanXuat> hangSanXuats = new List<Model.HangSanXuat>();

        SanPhamDAO sanPhamDAO = new SanPhamDAO();
        HangSXDAO hangSXDAO = new HangSXDAO();

        private string duongdanHinhAnh = ""; 
        public NhapSanPham()
        {
            InitializeComponent();

            cbbtinhTrang.SelectedValueChanged += CBB_ChangeValue;
            cbbLoai.SelectedValueChanged += CBB_ChangeValue;

            cbbLoai.SelectedIndex = 0;
            cbbtinhTrang.SelectedIndex = 0;


            hangSanXuats = hangSXDAO.layDanhSachHangSX();
            cbbNhaSX.DisplayMember = "TenHangSX";
            cbbNhaSX.DataSource = hangSanXuats;
           
            sanPhams = sanPhamDAO.layDanhSachSanPham();

            txtGia.Leave += txtTienTe_OnLeave;
            txtTongTien.Leave += txtTienTe_OnLeave;
            
        }

      

        private void CBB_ChangeValue(object sender, EventArgs e)
        {

            if (cbbtinhTrang.SelectedIndex != 0 && cbbLoai.SelectedIndex != 0)
            {
                HienThiThongTinNhapHang(true);
                HienThiThongTinSP(true);
                ChonLoaiSanPham();
                ChonTinhTrang();

                //  cbbNhaSX.DataSource = hangSanXuats;
            }
            else
            {
                //cbbNhaSX.DataSource = null;
                HienThiThongTinNhapHang(false);
                HienThiThongTinSP(false);

            }


        }
        private void HienThiThongTinSP(bool ht)
        {
            txtGia.ReadOnly = !ht;
            txtTenSP.ReadOnly = !ht;
            txtTenSP.BackColor = Color.White;
            txtGia.BackColor = Color.White;

            //FontStyle style = (ht == false ? FontStyle.Italic : FontStyle.Regular);

            //txtGia.Font = new Font(txtGia.Font.Name, txtGia.Font.Size, style);
            //txtTenSP.Font = new Font(txtGia.Font.Name, txtGia.Font.Size, style);


            pnAnhDaiDien.Enabled = ht;



        }
        private void HienThiThongTinNhapHang(bool ht)
        {
            txtSoLuong.ReadOnly = !ht;
            txtTongTien.ReadOnly = !ht;
            mTxtNgayNhap.ReadOnly = !ht;

            txtSoLuong.BackColor = Color.White;
            txtTongTien.BackColor = Color.White;
            mTxtNgayNhap.BackColor = Color.White;

            //FontStyle style = (ht == false ? FontStyle.Italic : FontStyle.Regular);
            //txtSoLuong.Font = new Font(txtSoLuong.Font.Name, txtSoLuong.Font.Size, style);
            //txtTongTien.Font = new Font(txtSoLuong.Font.Name, txtSoLuong.Font.Size, style);
            //txtNgayNhap.Font = new Font(txtSoLuong.Font.Name, txtSoLuong.Font.Size, style);

        }
        private void LoadSanPham(Model.Loai_San_Pham loai_San_Pham)
        {
            hienThi = sanPhams.Where((s) => { return s.LoaiSanPham == loai_San_Pham; }).ToList();

        }
        private void ChonLoaiSanPham()
        {
            if (cbbLoai.SelectedIndex == 2)
            {
                btnCauHinh.Enabled = false;
                LoadSanPham(Model.Loai_San_Pham.LINH_KIEN);
            }
            else
            {
                btnCauHinh.Enabled = true;
                LoadSanPham(Model.Loai_San_Pham.DIEN_THOAI);
                

            }

        }
        private void ChonTinhTrang()
        {
            if (cbbtinhTrang.SelectedIndex == 1) // Co roi
            {
                HienThiThongTinSP(false);

                cbbSanPham.DataSource = hienThi;
                cbbSanPham.Enabled = true;

                pnNSX.Enabled = false;
                cbbSanPham.DisplayMember = "TenSanPham";
            }
            else // chua co
            {
                HienThiThongTinSP(true);
                pnNSX.Enabled = true;
                cbbSanPham.DataSource = null;
                cbbSanPham.Enabled = false;
                cbbSanPham.DisplayMember = "TenSanPham";
                XoaToanBoThongTin();
                
            }
        }
        //Xoa du lieu thong tin dang hien thi

        private void XoaToanBoThongTin() {
            txtMaSP.Text = "";
            txtGia.Text ="";
            txtTenSP.Text = "";
            mTxtNgayNhap.Text = "";
            txtSoLuong.Text = "";
            txtTongTien.Text = "";


            pbAnhDaiDien.Image = null;
        }

        //Dua Cac du lieu co san cua san pham ra xem
        private void HienThiToanBoThongTin(Model.SanPham sanPham)
        {
            txtMaSP.Text = sanPham.MaSanPham.ToString();
            txtGia.Text = sanPham.Gia.ToString();
            txtTenSP.Text = sanPham.TenSanPham.ToString();

            pbAnhDaiDien.Image = Image.FromFile(sanPham.DuongDanHinhAnh);

            int i = 0;
            for (i = 0; i < hangSanXuats.Count; i++)
                if (hangSanXuats[i].MaHangSX == sanPham.HangSanXuatSanPham.MaHangSX)
                    break;
           cbbNhaSX.SelectedIndex = i;
            // cbbNhaSX.SelectedIndex = 1;
        }

        private void CBBSanPhamValueChanged(object sender, EventArgs e)
        {
            if (cbbtinhTrang.SelectedIndex != 2)
                HienThiToanBoThongTin((sender as ComboBox).SelectedValue as Model.SanPham);
        }

        //Tao Moi Hinh Anh Co tu May Tinh
        private void BtnNewHinhAnh_Click(object sender, EventArgs e)
        {
            string pathDes = "";
            const string dd = "Image/HinhAnh/";
            string loai = "DienThoai/";
            if (cbbLoai.SelectedIndex == 2)
                loai = "LinhKien/";

            OpenFileDialog open = new OpenFileDialog();
            if (DialogResult.OK == open.ShowDialog()) {
                string [] tenFile = open.FileName.Split('\\');
                pathDes = tenFile[tenFile.Length - 1];
                pathDes = dd + loai + pathDes;


               
                pbAnhDaiDien.Image = Image.FromFile(open.FileName);
                duongdanHinhAnh = pathDes;
               
            }
        }
        //An Button xoa ->xoa du lieu vua nhap
        private void Button3_Click(object sender, EventArgs e)
        {
            XoaToanBoThongTin();
        }

        //Chuyen doi thanh dang tien te
        private void txtTienTe_OnLeave(object sender, EventArgs e)
        {
            
            TextBox textBox = sender as TextBox;
            //Neu la rong thi return
            if (textBox.Text == "") return;

            float soTien = 0;
            bool hopLe = float.TryParse(textBox.Text,out soTien);
            if (hopLe)
            {
                textBox.ForeColor = Color.Black;
                textBox.Text = soTien.ToString("#,###");
            }
            else {
                textBox.ForeColor = Color.DarkRed;
                textBox.Text = "Không Hợp Lệ";
            }

        }
        //Kiem tra so luong nhap vao co hop le hay khong
        private void txtSoLuong_OnLeave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            //Neu la rong thi return
            if (textBox.Text == "") return;
            int soTien = 0;
            bool hopLe = int.TryParse(textBox.Text, out soTien);
            if (!hopLe)
            {
                textBox.ForeColor = Color.DarkRed;
                textBox.Text = "Không Hợp Lệ";
            }
            else {
                textBox.ForeColor = Color.Black;
            }
        }

       
        //Xoa Hinh Anh Import vao
      

        private void XoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbAnhDaiDien.Image = null;
            if (duongdanHinhAnh != "")
            {
               // File.Delete(duongdanHinhAnh);
                duongdanHinhAnh = "";
            }
        }
    }


}
