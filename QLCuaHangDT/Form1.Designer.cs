namespace QLCuaHangDT
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myLabel1 = new QLCuaHangDT.GUI.MyLabel();
            this.pbNews = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbMinisize = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKhoHang = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinisize)).BeginInit();
            this.flpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(134)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.myLabel1);
            this.panel1.Controls.Add(this.pbNews);
            this.panel1.Controls.Add(this.pbUser);
            this.panel1.Controls.Add(this.pbMinisize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 57);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // myLabel1
            // 
            this.myLabel1.BackColor = System.Drawing.Color.Red;
            this.myLabel1.FlatAppearance.BorderSize = 0;
            this.myLabel1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.myLabel1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.myLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel1.Location = new System.Drawing.Point(671, 21);
            this.myLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.Size = new System.Drawing.Size(17, 17);
            this.myLabel1.TabIndex = 4;
            this.myLabel1.Text = "1";
            this.myLabel1.UseVisualStyleBackColor = false;
            this.myLabel1.Visible = false;
            // 
            // pbNews
            // 
            this.pbNews.Image = ((System.Drawing.Image)(resources.GetObject("pbNews.Image")));
            this.pbNews.Location = new System.Drawing.Point(659, 6);
            this.pbNews.Name = "pbNews";
            this.pbNews.Size = new System.Drawing.Size(25, 25);
            this.pbNews.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNews.TabIndex = 3;
            this.pbNews.TabStop = false;
            this.pbNews.Tag = "hover";
            // 
            // pbUser
            // 
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(690, 6);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(25, 25);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 2;
            this.pbUser.TabStop = false;
            this.pbUser.Tag = "hover";
            // 
            // pbMinisize
            // 
            this.pbMinisize.Image = ((System.Drawing.Image)(resources.GetObject("pbMinisize.Image")));
            this.pbMinisize.Location = new System.Drawing.Point(721, 6);
            this.pbMinisize.Name = "pbMinisize";
            this.pbMinisize.Size = new System.Drawing.Size(25, 25);
            this.pbMinisize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinisize.TabIndex = 1;
            this.pbMinisize.TabStop = false;
            this.pbMinisize.Tag = "hover";
            this.pbMinisize.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(752, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.Tag = "hover";
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // flpMenu
            // 
            this.flpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.flpMenu.Controls.Add(this.label1);
            this.flpMenu.Controls.Add(this.btnKhoHang);
            this.flpMenu.Controls.Add(this.btnNhapHang);
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMenu.Location = new System.Drawing.Point(0, 57);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(178, 559);
            this.flpMenu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(35, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // btnKhoHang
            // 
            this.btnKhoHang.FlatAppearance.BorderSize = 0;
            this.btnKhoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoHang.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnKhoHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoHang.Image")));
            this.btnKhoHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoHang.Location = new System.Drawing.Point(0, 48);
            this.btnKhoHang.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnKhoHang.Name = "btnKhoHang";
            this.btnKhoHang.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnKhoHang.Size = new System.Drawing.Size(178, 35);
            this.btnKhoHang.TabIndex = 2;
            this.btnKhoHang.Tag = "KHO_HANG";
            this.btnKhoHang.Text = "Kho Hàng";
            this.btnKhoHang.UseVisualStyleBackColor = true;
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.FlatAppearance.BorderSize = 0;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapHang.Image")));
            this.btnNhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapHang.Location = new System.Drawing.Point(0, 88);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnNhapHang.Size = new System.Drawing.Size(178, 35);
            this.btnNhapHang.TabIndex = 1;
            this.btnNhapHang.Tag = "NHAN_VIEN";
            this.btnNhapHang.Text = "Nhân Viên";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            // 
            // pnCenter
            // 
            this.pnCenter.Location = new System.Drawing.Point(178, 57);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(611, 559);
            this.pnCenter.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(789, 616);
            this.ControlBox = false;
            this.Controls.Add(this.pnCenter);
            this.Controls.Add(this.flpMenu);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinisize)).EndInit();
            this.flpMenu.ResumeLayout(false);
            this.flpMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbMinisize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbNews;
        private System.Windows.Forms.PictureBox pbUser;
        private GUI.MyLabel myLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKhoHang;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Panel pnCenter;
        //   private GiaoDien.SanPham.QLKho qlKho1;
        //     private GiaoDien.SanPham.QLKho qlKho1;

        #endregion

        //  public System.Windows.Forms.Panel PnBody { get => pnBody; set => pnBody = value; }


        //  public System.Windows.Forms.PictureBox PbAvatar { get => pbAvatar; set => pbAvatar = value; }

    }
}

