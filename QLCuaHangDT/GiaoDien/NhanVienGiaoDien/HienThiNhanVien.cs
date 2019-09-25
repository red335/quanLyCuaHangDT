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
namespace QLCuaHangDT.GiaoDien.NhanVienGiaoDien
{
    public partial class HienThiNhanVien : UserControl
    {
        private Color backColor_;
        NhanVien nhanVien;
        public HienThiNhanVien(NhanVien nhanVien)
        {
            InitializeComponent();
         
            this.nhanVien = nhanVien;
            caiDat();
          
        }
        private void caiDat() {
            HoTen.Text = nhanVien.HoTen;
            Ma.Text = nhanVien.IdNhanVien.ToString();
            namSinh.Text = nhanVien.NamSinh.ToString("dd/MM/yyyy");
            quQuan.Text = nhanVien.QueQuan;
            gioiTinh.Text = nhanVien.GioiTinh == true ? "Nam" : "Nữ";
            chucVu.Text = nhanVien.ChucVu;
           
            
           BackColor_ = chucVu.BackColor;
        }

        public Color BackColor_ { get => backColor_;
            set {
                backColor_ = value;
                for (int i = 0; i < this.Controls.Count - 1; i++) {
                    if (this.Controls[i].GetType() == typeof(Button)) {
                        Button button = Controls[i] as Button;
                        button.FlatAppearance.MouseDownBackColor = BackColor_;
                        button.FlatAppearance.MouseOverBackColor = BackColor_;
                        button.ForeColor = Color.Black;
                        this.BackColor = BackColor_;
                    }
                }
               }
        }
    }
}
