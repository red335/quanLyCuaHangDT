using System;
using System.Collections.Generic;

using System.Data;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;
using QLCuaHangDT.DAO;
using QLCuaHangDT.GiaoDien.GiaoDienSanPham;
using QLCuaHangDT.Model;
using QLCuaHangDT.GiaoDien.Dialog;
using QLCuaHangDT.XuLy;
namespace QLCuaHangDT.GiaoDien.SanPham
{
  
    public partial class DanhSachSanPham : UserControl
    {
        private Model.Loai_San_Pham loaiSanPham = Model.Loai_San_Pham.DIEN_THOAI;
        SanPhamDAO spDAo = new SanPhamDAO();
        List<Model.SanPham> sanPhams = new List<Model.SanPham>();
        private string selectedID = "";

        //Color cho chi use chitietSanPham 
        private Color color_1 = Color.FromArgb(242, 242, 242);
        private Color color_2 = Color.White;
        private AnHienDanhSach hienBtnReset;
        public Loai_San_Pham LoaiSanPham { get => loaiSanPham; set => loaiSanPham = value; }
        public string SelectedID { get => selectedID; set => selectedID = value; }

        public DanhSachSanPham( AnHienDanhSach anHienDanhSach  )
        {
            InitializeComponent();
            this.hienBtnReset = anHienDanhSach;
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

        }

        public void khoiTaoDanhSach() {
            lapDanhSach();
            updateDanhSach();
        }
        public void lapDanhSach()
        {

            sanPhams = spDAo.layDanhSachSanPham();
            if (LoaiSanPham == Loai_San_Pham.DIEN_THOAI) {
                sanPhams = sanPhams.Where((sanPham) => { return sanPham.LoaiSanPham == Loai_San_Pham.DIEN_THOAI; })
                    .ToList();
            } else
                sanPhams = sanPhams.Where((sanPham) => { return sanPham.LoaiSanPham != Loai_San_Pham.DIEN_THOAI; })
                    .ToList();
        }
        public void updateDanhSach() {
            int i = 0;
            flpDS.Controls.Clear();
            foreach (var tmp in sanPhams) {
                Color c = Color.White;
                if (i % 2 == 1)
                    c = color_1;
                ChiTietSanPham chiTietSanPham = new ChiTietSanPham(tmp, c, (id) => { selectedID = id; },
                    ()=>{ return selectedID; });

                flpDS.Controls.Add(chiTietSanPham);
                i++;
            }
        }

        #region Cac Thao Tac voi danh sach
     

        private void Pb_ThayDoiKichThuocOnMouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.BackColor = Color.LightGray;
        }
        private void Pb_ThayDoiKichThuocOnMoueLeave(object sender, EventArgs e){
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.BackColor = Color.White;
        }

        //xoa
        private void PbDel_Click(object sender, EventArgs e)
        {
            if (sanPhams.Count == 0) {
                MessageBox.Show("Danh Sach Rong");
                return;
            }
            if (MessageBox.Show("Ban co chac xoa san pham nay khong??", "Delete", MessageBoxButtons.YesNo)
                == DialogResult.Yes) {
                //kiem tra id can xoa
                if (selectedID != "")
                {
                    Model.SanPham sanPham = sanPhams.Find((s) => { return s.MaSanPham == selectedID; });
                    sanPhams.Remove(sanPham);
                    selectedID = "";
                    updateDanhSach();
                }
                else {
                    MessageBox.Show("Ban can chon mot san pham de thao tac");
                }
            }
            
        }

        //Them
        private void pbAdd_Click_1(object sender, EventArgs e)
        {
            if (sanPhams.Count == 0)
            {
                MessageBox.Show("Danh Sach Rong");
                
            }
            else
            {
                Model.SanPham sanPham = sanPhams.Find((s) => { return s.MaSanPham == selectedID; });
                new ThongTinSanPham(sanPham, ThongTinSanPham.LoaiThucHien.THEM).ShowDialog();
            }
        }
        //CCLICK VAO BUTON SAP XEP
        private void PbSort_Click_1(object sender, EventArgs e)
        {
            if (sanPhams.Count == 0)
            {
                MessageBox.Show("Danh Sach Rong");
                return;
            }
            string thuocTinh = "Mã SP: ,Họ Tên: ,Giá Bán:,Tồn Kho: "; 
            Form_Sorting form_Sorting =
                new Form_Sorting(thuocTinh, new Sorting(Sorting_));

            form_Sorting.ShowDialog();
        }

        private void pbFitler_Click(object sender, EventArgs e)
        {
            if (sanPhams.Count == 0)
            {
                MessageBox.Show("Danh Sach Rong");
                return;
            }
            string dat = new Model.SanPham().toStringForFitler();
            Form_Fitler form_Fitler = new Form_Fitler(dat, fitler);
            form_Fitler.ShowDialog();
        }
        //Tim Kiem

        private void pbSearch_Click_1(object sender, EventArgs e)
        {
            if (sanPhams.Count == 0)
            {
                MessageBox.Show("Danh Sach Rong");
                return;
            }
            new Form_Search(searching).ShowDialog();
        }
        // ==================HAM XU LY CAC THAO TAC ==========================\\


        // HAM XU LY LOC
        private void fitler(int [] predicate, string[] values) {

            bool hienNutRS = false;
            if (predicate[0] != 0 || values[0] != " ")//Loc ma SP
            {
                sanPhams = sanPhams.Where(s =>
                {
                    return XuLy.ThaoTacSoSanh.SoSanhChoThaoTacLoc(predicate[0],
                    s.MaSanPham, values[0]);
                }).ToList();
                hienNutRS = true; 
            }
            if (predicate[1] != 0 || values[1] != " ") { // Loc theo ten san pham
                sanPhams = sanPhams.Where(s =>
                {
                    return XuLy.ThaoTacSoSanh.SoSanhChoThaoTacLoc(predicate[1],
                    s.TenSanPham, values[1]);
                }).ToList();
                hienNutRS = true;
            }
            if (predicate[2] != 0 || values[2] != " ") // Loc theo loai san pham
            {
                sanPhams = sanPhams.Where(s =>
                {
                    return XuLy.ThaoTacSoSanh.SoSanhChoThaoTacLoc(predicate[2],
                    s.LoaiSanPham.ToString(), values[2]);
                }).ToList();
                hienNutRS = true;

            }
            if (predicate[3] != 0 || values[3] != " ")  // loc theo gia san pham
            {
                sanPhams = sanPhams.Where(s =>
                {
                    return XuLy.ThaoTacSoSanh.SoSanhChoThaoTacLoc(predicate[3],
                    s.Gia, Int32.Parse(values[3]));
                }).ToList();
                hienNutRS = true;
            }
            if (predicate[4] != 0 || values[4] != " ")  //loc theo ten hang sx
            {
                sanPhams = sanPhams.Where(s =>
                {
                    return XuLy.ThaoTacSoSanh.SoSanhChoThaoTacLoc(predicate[4],
                    s.HangSanXuatSanPham.TenHangSX, values[4]);
                }).ToList();
                hienNutRS = true;
            }
            if (predicate[5] != 0 || values[5] != " ") // So uluong ton kho
            {
                sanPhams = sanPhams.Where(s =>
                {
                    return XuLy.ThaoTacSoSanh.SoSanhChoThaoTacLoc(predicate[5],
                    s.SoLuongTonKho1, Int32.Parse(values[5]));
                }).ToList();
                hienNutRS = true;

            }
            if (predicate[6] != 0 || values[6] != " ")
            {
                sanPhams = sanPhams.Where(s =>
                {
                    return XuLy.ThaoTacSoSanh.SoSanhChoThaoTacLoc(predicate[6],
                    s.CoKhuyenMai, Boolean.Parse(values[6]));
                }).ToList();
                hienNutRS = true;
            }
            if (hienNutRS)
            {
                hienBtnReset();
                updateDanhSach();
            }
        }

        //Ham xu ly sap xep
        public void Sorting_(string str) {
        //    MessageBox.Show(str);
            string[] sort = str.Split(',');
            List<int> sxep = new List<int>();
            foreach (string s in sort) 
                sxep.Add(int.Parse(s));
            bool hienNutRS = false;
            SapXepSP sxSanPham = new SapXepSP(sxep);
            if (sxep[0] != 0)
            {
                sanPhams.Sort(sxSanPham.SapXepTheoMa);
                hienNutRS = true;
            }
            if (sxep[1] != 0)
            {
                sanPhams.Sort(sxSanPham.SapXepTheoTenSanPham1);
                hienNutRS = true;
            }
            if (sxep[2] != 0)
            {
                sanPhams.Sort(sxSanPham.SapXepTheoGia1);
                hienNutRS = true;
            }
            if (sxep[3] != 0)
            {
                sanPhams.Sort(sxSanPham.SapXepTheoTon);
                hienNutRS = true;
            }
            if (hienNutRS)
            {
                hienBtnReset();
                updateDanhSach();
            }
          
        }
        //HAM XU LY TIM KIEM
        private void searching(string maSo) {
            sanPhams = sanPhams.Where((s) => { return s.MaSanPham.ToString() == maSo; }).ToList();
            updateDanhSach(); 
            if(sanPhams.Count == 0)
            {
              
                Label label = new Label();
                label.Font = new Font("Tahoma", 9F);
                label.Text = "Khong co ket qua";
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.ForeColor = Color.Black;
                label.AutoSize = false;
                label.Size = new Size(flpDS.Size.Width - 10, 30);
                flpDS.Controls.Add(label);
                 
            }
            hienBtnReset();
        }







        #endregion

      
    }
}
