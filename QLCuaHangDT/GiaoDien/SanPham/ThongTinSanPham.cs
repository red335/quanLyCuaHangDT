using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDT.GiaoDien.SanPham
{
    public partial class ThongTinSanPham : Form
    {
        public enum LoaiThucHien {
            NONE, THEM, XOA, SUA
        }
        private LoaiThucHien loaiThucHien = LoaiThucHien.NONE;

        Model.SanPham sanPham;

        string chiTiet = "";
        List<Panel> ThongTinChiTiet = new List<Panel>();
        //  Button btnChiTiet = null;

        const bool AN_THONG_TIN = false;
        const bool HIEN_THONG_TIN = true;

        public ThongTinSanPham(Model.SanPham sanPham, LoaiThucHien loaiThucHien = LoaiThucHien.NONE)
        {
            InitializeComponent();
            this.loaiThucHien = loaiThucHien;
            this.sanPham = sanPham;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            chiaChuoiThongTin();
            HienThongTin();
            TrinhBayCacChucNang();
        }
        private void TrinhBayCacChucNang(){
            if (loaiThucHien == LoaiThucHien.THEM) 
                btnThem_Click(btnThem, EventArgs.Empty);
            else if (loaiThucHien == LoaiThucHien.SUA)
                btnSua_Click(btnSua, EventArgs.Empty);
        }

        public ThongTinSanPham()
        {
            InitializeComponent();
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            chiaChuoiThongTin();
            HienThongTin();
        }
        private void update()
        {
            HienThongTin();
          
            chiaChuoiThongTin();
        }
        //hien thong tin
        private void HienThongTin()
        {
            if (chiTiet == "") return;
            maskGia.Text = sanPham.Gia.ToString("#,###") + " VND";
            maskHSX.Text = sanPham.HangSanXuatSanPham.TenHangSX;
            maskKM.Text = sanPham.CoKhuyenMai == true ? "Co" : "Khong";
            maskTenSP.Text = sanPham.TenSanPham;
            maskMaSP.Text = sanPham.MaSanPham.ToString();
            maskLoaiSP.Text = sanPham.LoaiSanPham.ToString();
            maskTonKho.Text = sanPham.SoLuongTonKho1.ToString();
            pbAnhDaiDien.Image = Image.FromFile(sanPham.DuongDanHinhAnh);

           
        }
        // Cat chuoi thong tin
        private void chiaChuoiThongTin()
        {
            if (chiTiet == "")
            {
                lbChiTiet.Visible = false;
            }
            else
            {
                string[] element = chiTiet.Split(';');
                int i = 0;
                for (i = 0; i < element.Length; i++)
                {
                    string info = element[i];
                    string[] dat = info.Split(':');
                    Label label = createLabel(dat[0]);
                    MaskedTextBox maskedTextBox = createTextBox(dat[1]);
                    Panel line = createLine(286);
                    Panel panel = createPanel();
                    panel.Controls.Add(line);
                    panel.Controls.Add(label);
                    panel.Controls.Add(maskedTextBox);
                    panel.Tag = "CT";
                    Flist.Controls.Add(panel);
                    ThongTinChiTiet.Add(panel);

                }
               
            }

            ButtonChiTiet();
           // MessageBox.Show(btnChiTiet.Visible.ToString());
        }
        private void ButtonChiTiet() {
            if (btnChiTiet != null) Flist.Controls.Remove(btnChiTiet);

            btnChiTiet = new Button();
            btnChiTiet.Text = "Chi tiet";
            btnChiTiet.BackColor = Color.White;
            btnChiTiet.ForeColor = Color.Red;
            btnChiTiet.Font = new Font("Tahoma", 9F);
            btnChiTiet.FlatStyle = FlatStyle.Flat;
            btnChiTiet.FlatAppearance.BorderSize = 0;
            btnChiTiet.Margin = new Padding(Flist.Size.Width / 2 - btnChiTiet.Width / 2, 7, 0, 5);


            btnChiTiet.Click += MoFormChiTiet;
            Flist.Controls.Add(btnChiTiet);

            if (loaiThucHien == LoaiThucHien.NONE)
                btnChiTiet.Visible = false;
        }
        private Panel createPanel()
        {
            Panel panel = new Panel();
            //panel.Controls.Add(this.maskedTextBox1);
            //panel.Controls.Add(this.lbTitle);
            //panel.Controls.Add(this.panel3);
            panel.Location = new System.Drawing.Point(20, 277);
            panel.Margin = new System.Windows.Forms.Padding(20, 1, 3, 5);
            panel.Size = new System.Drawing.Size(286, 23);



            return panel;
        }
        private Panel createLine(int width)
        { // 286
            Panel line = new Panel();
            line.BackColor = System.Drawing.Color.Gainsboro;
            line.Dock = System.Windows.Forms.DockStyle.Bottom;
            line.Location = new System.Drawing.Point(0, 22);
            //   this.panel7.Name = "panel7";
            line.Size = new System.Drawing.Size(width, 1);

            return line;
        }
        private Label createLabel(string title)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(3, 3);
            //   label.Name = "lbTitle";
            label.Size = new System.Drawing.Size(40, 14);
            label.TabIndex = 1;
            label.Text = title;
            return label;
        }
        private MaskedTextBox createTextBox(string dat)
        {
            MaskedTextBox maskedTextBox = new MaskedTextBox();
            maskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            maskedTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maskedTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            maskedTextBox.Location = new System.Drawing.Point(119, 3);
            maskedTextBox.Margin = new System.Windows.Forms.Padding(0);

            maskedTextBox.Size = new System.Drawing.Size(142, 15);
            maskedTextBox.Text = dat;

            maskedTextBox.ReadOnly = true;
            maskedTextBox.BackColor = Color.White;
            return maskedTextBox;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //====================THEM XOA SUA================\\
        //SU KIEN NHAN BUTTON
        private void btnThem_Click(object sender, EventArgs e)
        {
            loaiThucHien = LoaiThucHien.THEM;
            Them();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            loaiThucHien = LoaiThucHien.SUA;
            Sua();

        }
        private void btnOK_Click(object sender, EventArgs e)
        {
        
            Ok();
        }

        

        private void AnHienCacThongTin(bool show)
        {
            pnMaSP.Visible = !show;
            btnSua.Visible = !show;
            btnThem.Visible = show;
            btnXoa.Visible = !show;
            btnOK.Visible = show;
            btnCauHinh.Enabled = show;
            maskGia.ReadOnly = !show;
            maskLoaiSP.ReadOnly = !show;
            maskHSX.ReadOnly = !show;
            maskTonKho.ReadOnly = !show;
            maskTenSP.ReadOnly = !show;
            maskKM.ReadOnly = !show;
            foreach (Control control in ThongTinChiTiet)
                (control.Controls[2] as MaskedTextBox).ReadOnly = !show;

        }
        private void ResetInfo()
        {
            maskGia.Text = "";
            maskLoaiSP.Text = "";
            maskHSX.Text = "";
            maskTonKho.Text = "";
            maskTenSP.Text = "";
            maskKM.Text = "";
            lbChiTiet.Visible = true;
            foreach (Control control in Flist.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "CT")
                    Flist.Controls.Remove(control);
            }

        }
        // HAM XU LY 
        private void Them()
        {
            btnChiTiet.Visible = true;
            AnHienCacThongTin(HIEN_THONG_TIN);
            ResetInfo();
        }
        private void Xoa()
        {
            //MessageBox.Show("Ban co chac se xoa sna pham nay khong");
            if (MessageBox.Show("Ban co chac chan xoa san pham nay khong?", "Xoa san pham", MessageBoxButtons.YesNo)
                == DialogResult.Yes) {
                //code in here

                MessageBox.Show("Xoa thanh cong !!");
            
            }

            this.Close();
        }
        private void Sua()
        {
            AnHienCacThongTin(HIEN_THONG_TIN);
            btnChiTiet.Visible = true;
            lbChiTiet.Visible = true;
        }

        private void Ok()
        {
            if (loaiThucHien == LoaiThucHien.SUA)
            {
                AnHienCacThongTin(AN_THONG_TIN);
                loaiThucHien = LoaiThucHien.NONE;
                //  update();
                ButtonChiTiet();
            }
            else if (loaiThucHien == LoaiThucHien.THEM) {

                this.Close();
            }
        }
        //==========MO FORM THONG TIN CHI TIET=============\\

        private void MoFormChiTiet(object sender, EventArgs eventArgs)
        {

            new CauHinh((s) =>
            {
                chiTiet = s;
                foreach (Panel panel in ThongTinChiTiet) 
                    Flist.Controls.Remove(panel);
                update();
            }, chiTiet).ShowDialog();
        }

        
    }
}
