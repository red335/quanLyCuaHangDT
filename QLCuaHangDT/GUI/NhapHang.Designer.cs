namespace QLCuaHangDT.GUI
{
    partial class NhapHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbSanPham = new System.Windows.Forms.ComboBox();
            this.grSP = new System.Windows.Forms.GroupBox();
            this.btnCauHinh = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNSXMoi = new System.Windows.Forms.Button();
            this.cbbNhaSX = new System.Windows.Forms.ComboBox();
            this.btnChiTietHinhAnh = new System.Windows.Forms.Button();
            this.pbHinhAnh = new System.Windows.Forms.PictureBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMaSP = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grLH = new System.Windows.Forms.GroupBox();
            this.cbTinhTrang = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtNgayNhap = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.grSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grLH.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbbSanPham);
            this.panel2.Controls.Add(this.grSP);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbbLoai);
            this.panel2.Controls.Add(this.cbbTinhTrang);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 434);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UVN Cat Bien", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Sản Phẩm";
            // 
            // cbbSanPham
            // 
            this.cbbSanPham.Enabled = false;
            this.cbbSanPham.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSanPham.FormattingEnabled = true;
            this.cbbSanPham.ItemHeight = 14;
            this.cbbSanPham.Items.AddRange(new object[] {
            "Điện Thoai",
            "Linh Kiện"});
            this.cbbSanPham.Location = new System.Drawing.Point(120, 117);
            this.cbbSanPham.Name = "cbbSanPham";
            this.cbbSanPham.Size = new System.Drawing.Size(187, 22);
            this.cbbSanPham.TabIndex = 38;
            this.cbbSanPham.SelectedValueChanged += new System.EventHandler(this.CBB_ListSanPhamChanged);
            // 
            // grSP
            // 
            this.grSP.Controls.Add(this.btnCauHinh);
            this.grSP.Controls.Add(this.label9);
            this.grSP.Controls.Add(this.btnNSXMoi);
            this.grSP.Controls.Add(this.cbbNhaSX);
            this.grSP.Controls.Add(this.btnChiTietHinhAnh);
            this.grSP.Controls.Add(this.pbHinhAnh);
            this.grSP.Controls.Add(this.txtGia);
            this.grSP.Controls.Add(this.txtTenSP);
            this.grSP.Controls.Add(this.txtMaSP);
            this.grSP.Controls.Add(this.label10);
            this.grSP.Controls.Add(this.label8);
            this.grSP.Controls.Add(this.label7);
            this.grSP.Controls.Add(this.lbMaSP);
            this.grSP.Enabled = false;
            this.grSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grSP.Location = new System.Drawing.Point(3, 145);
            this.grSP.Name = "grSP";
            this.grSP.Size = new System.Drawing.Size(372, 286);
            this.grSP.TabIndex = 24;
            this.grSP.TabStop = false;
            // 
            // btnCauHinh
            // 
            this.btnCauHinh.Location = new System.Drawing.Point(118, 227);
            this.btnCauHinh.Name = "btnCauHinh";
            this.btnCauHinh.Size = new System.Drawing.Size(40, 23);
            this.btnCauHinh.TabIndex = 35;
            this.btnCauHinh.Text = "...";
            this.btnCauHinh.UseCompatibleTextRendering = true;
            this.btnCauHinh.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("UVN Cat Bien", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(7, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Cấu Hình";
            // 
            // btnNSXMoi
            // 
            this.btnNSXMoi.Location = new System.Drawing.Point(228, 179);
            this.btnNSXMoi.Name = "btnNSXMoi";
            this.btnNSXMoi.Size = new System.Drawing.Size(46, 23);
            this.btnNSXMoi.TabIndex = 33;
            this.btnNSXMoi.Text = "Mới";
            this.btnNSXMoi.UseCompatibleTextRendering = true;
            this.btnNSXMoi.UseVisualStyleBackColor = true;
            this.btnNSXMoi.Click += new System.EventHandler(this.BtnNSXMoi_Click);
            // 
            // cbbNhaSX
            // 
            this.cbbNhaSX.FormattingEnabled = true;
            this.cbbNhaSX.Location = new System.Drawing.Point(118, 180);
            this.cbbNhaSX.Name = "cbbNhaSX";
            this.cbbNhaSX.Size = new System.Drawing.Size(104, 21);
            this.cbbNhaSX.TabIndex = 32;
            // 
            // btnChiTietHinhAnh
            // 
            this.btnChiTietHinhAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChiTietHinhAnh.Location = new System.Drawing.Point(348, 150);
            this.btnChiTietHinhAnh.Name = "btnChiTietHinhAnh";
            this.btnChiTietHinhAnh.Size = new System.Drawing.Size(24, 23);
            this.btnChiTietHinhAnh.TabIndex = 31;
            this.btnChiTietHinhAnh.Text = "...";
            this.btnChiTietHinhAnh.UseCompatibleTextRendering = true;
            this.btnChiTietHinhAnh.UseVisualStyleBackColor = true;
            this.btnChiTietHinhAnh.Click += new System.EventHandler(this.BtnChiTietHinhAnh_Click);
            // 
            // pbHinhAnh
            // 
            this.pbHinhAnh.BackColor = System.Drawing.Color.White;
            this.pbHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbHinhAnh.Location = new System.Drawing.Point(228, 29);
            this.pbHinhAnh.Name = "pbHinhAnh";
            this.pbHinhAnh.Size = new System.Drawing.Size(144, 144);
            this.pbHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinhAnh.TabIndex = 30;
            this.pbHinhAnh.TabStop = false;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(117, 128);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(105, 22);
            this.txtGia.TabIndex = 29;
            this.txtGia.Tag = "txt3";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(118, 83);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(104, 22);
            this.txtTenSP.TabIndex = 28;
            this.txtTenSP.Tag = "txt2";
            // 
            // txtMaSP
            // 
            this.txtMaSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(118, 31);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(103, 22);
            this.txtMaSP.TabIndex = 27;
            this.txtMaSP.Tag = "txt1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("UVN Cat Bien", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(7, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Nhà Sản Xuất";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UVN Cat Bien", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(9, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UVN Cat Bien", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tên Sản Phẩm";
            // 
            // lbMaSP
            // 
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.Font = new System.Drawing.Font("UVN Cat Bien", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSP.ForeColor = System.Drawing.Color.Black;
            this.lbMaSP.Location = new System.Drawing.Point(9, 34);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(87, 17);
            this.lbMaSP.TabIndex = 23;
            this.lbMaSP.Text = "Mã Sản Phẩm";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.label16);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 32);
            this.panel4.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("UTM Alberta Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(116, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(157, 27);
            this.label16.TabIndex = 1;
            this.label16.Text = "Thông Tin Sản Phẩm";
            this.label16.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UVN Cat Bien", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tình trạng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UVN Cat Bien", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(65, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loại";
            // 
            // cbbLoai
            // 
            this.cbbLoai.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Items.AddRange(new object[] {
            "None",
            "Linh Kiện",
            "Điện Thoai"});
            this.cbbLoai.Location = new System.Drawing.Point(121, 44);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(186, 26);
            this.cbbLoai.TabIndex = 1;
            this.cbbLoai.Tag = "cbb_loai";
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Items.AddRange(new object[] {
            "None",
            "Sản Phầm Mới",
            "Sản Phẩm Đã Có"});
            this.cbbTinhTrang.Location = new System.Drawing.Point(121, 76);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(186, 26);
            this.cbbTinhTrang.TabIndex = 0;
            this.cbbTinhTrang.Tag = "cbb_tinhtrang";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel3.Controls.Add(this.grLH);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(387, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 434);
            this.panel3.TabIndex = 2;
            // 
            // grLH
            // 
            this.grLH.Controls.Add(this.cbTinhTrang);
            this.grLH.Controls.Add(this.btnCancel);
            this.grLH.Controls.Add(this.btnOk);
            this.grLH.Controls.Add(this.txtTongTien);
            this.grLH.Controls.Add(this.txtSoLuong);
            this.grLH.Controls.Add(this.txtNgayNhap);
            this.grLH.Controls.Add(this.label14);
            this.grLH.Controls.Add(this.label13);
            this.grLH.Controls.Add(this.label12);
            this.grLH.Controls.Add(this.label11);
            this.grLH.Enabled = false;
            this.grLH.Location = new System.Drawing.Point(3, 44);
            this.grLH.Name = "grLH";
            this.grLH.Size = new System.Drawing.Size(361, 387);
            this.grLH.TabIndex = 34;
            this.grLH.TabStop = false;
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.AutoSize = true;
            this.cbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinhTrang.Location = new System.Drawing.Point(185, 104);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(15, 14);
            this.cbTinhTrang.TabIndex = 43;
            this.cbTinhTrang.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(194, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Xóa";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(87, 266);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 41;
            this.btnOk.Text = "Nhập hàng";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(185, 202);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(120, 20);
            this.txtTongTien.TabIndex = 40;
            this.txtTongTien.Tag = "txt6";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(185, 147);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(120, 20);
            this.txtSoLuong.TabIndex = 39;
            this.txtSoLuong.Tag = "txt5";
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.Location = new System.Drawing.Point(185, 43);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Size = new System.Drawing.Size(120, 20);
            this.txtNgayNhap.TabIndex = 37;
            this.txtNgayNhap.Tag = "txt4";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("UVN Cat Bien", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(48, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 17);
            this.label14.TabIndex = 36;
            this.label14.Text = "Tổng tiền";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("UVN Cat Bien", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(48, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "Số lượng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("UVN Cat Bien", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(48, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 17);
            this.label12.TabIndex = 34;
            this.label12.Text = "Đã Nhận Hết Hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("UVN Cat Bien", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(48, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Ngày Nhập Hàng";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Controls.Add(this.label15);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(367, 32);
            this.panel5.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("UTM Alberta Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(109, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(168, 27);
            this.label15.TabIndex = 0;
            this.label15.Text = "Thông Tin Nhập Hàng";
            this.label15.UseCompatibleTextRendering = true;
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NhapHang";
            this.Size = new System.Drawing.Size(754, 436);
            this.Load += new System.EventHandler(this.Form_OnLoad);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grSP.ResumeLayout(false);
            this.grSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.grLH.ResumeLayout(false);
            this.grLH.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox grSP;
        private System.Windows.Forms.Button btnCauHinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNSXMoi;
        private System.Windows.Forms.ComboBox cbbNhaSX;
        private System.Windows.Forms.Button btnChiTietHinhAnh;
        private System.Windows.Forms.PictureBox pbHinhAnh;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.GroupBox grLH;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtNgayNhap;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbTinhTrang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbSanPham;
    }
}
