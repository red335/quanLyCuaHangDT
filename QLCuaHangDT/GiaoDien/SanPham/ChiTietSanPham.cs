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
namespace QLCuaHangDT.GiaoDien.GiaoDienSanPham
{
    public delegate void SetSelectedID(string id);
    public delegate string GetSelectedID();
    public partial class ChiTietSanPham : UserControl
    {
        private Model.SanPham sanPham;
        //  private Color myColor;
        private Color BackColor_;
        private Color hoverColor = Color.FromArgb(255, 224, 192);
        private Color selectedColor = Color.FromArgb(255, 192, 192);
        private Color normalColor;
        private bool selected = false;
        private SetSelectedID selectedID;
        private GetSelectedID getSelectedID;

        public ChiTietSanPham(Model.SanPham sanPham,Color color,SetSelectedID selectedID, GetSelectedID getSelectedID)
        {
            InitializeComponent();
            this.selectedID = selectedID;
            this.getSelectedID = getSelectedID;
            this.sanPham = sanPham;
            this.BackColor = color;
            normalColor = this.BackColor;
            BackColor_1 = this.BackColor;
            hienThiThongTin();
            
        }

        public Color BackColor_1 { get => BackColor_;
            set{ BackColor_ = value;
              
                for (int i = 0; i < this.Controls.Count - 1; i++)
                {
                    if (this.Controls[i].GetType() == typeof(Button))
                    {
                        Button button = Controls[i] as Button;
                        button.FlatAppearance.MouseDownBackColor = BackColor_;
                        button.FlatAppearance.MouseOverBackColor = BackColor_;
                        button.ForeColor = Color.Black;
                        this.BackColor = BackColor_;
                    }
                }
            }
        }

        private void hienThiThongTin() {
            btnMa.ForeColor = Color.Black;
            btnHSX.ForeColor = Color.Black;
            btnKM.ForeColor = Color.Black;
            btnTonKho.ForeColor = Color.Black;
            btnTen.ForeColor = Color.Black;
            btnGia.ForeColor = Color.Black;

            btnMa.FlatAppearance.MouseOverBackColor = this.BackColor;
            btnHSX.FlatAppearance.MouseOverBackColor = BackColor;
            btnKM.FlatAppearance.MouseOverBackColor = BackColor;
            btnTonKho.FlatAppearance.MouseOverBackColor = BackColor;
            btnTen.FlatAppearance.MouseOverBackColor = BackColor;
            btnGia.FlatAppearance.MouseOverBackColor = BackColor;

            btnMa.FlatAppearance.MouseDownBackColor = this.BackColor;
            btnHSX.FlatAppearance.MouseDownBackColor = BackColor;
            btnKM.FlatAppearance.MouseDownBackColor = BackColor;
            btnTonKho.FlatAppearance.MouseDownBackColor = BackColor;
            btnTen.FlatAppearance.MouseDownBackColor = BackColor;
            btnGia.FlatAppearance.MouseDownBackColor = BackColor;


            btnMa.Text = sanPham.MaSanPham.ToString();
            btnGia.Text = sanPham.Gia.ToString("#,###")+" Vnd";
            btnHSX.Text = sanPham.HangSanXuatSanPham.TenHangSX;
            btnKM.Text = sanPham.CoKhuyenMai == true ? "Có" : "Không";
            btnTonKho.Text = sanPham.SoLuongTonKho1.ToString();
            btnTen.Text = sanPham.TenSanPham;

           
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            if (!selected)
                BackColor_1 = normalColor;
        }

        private void MouseHover(object sender, EventArgs e)
        {
            if (!selected)
                BackColor_1 = hoverColor;
        }

        private void pbChiTiet_Click(object sender, EventArgs e)
        {
            if (getSelectedID() == "")
            {
                BackColor_1 = selectedColor;
                selected = true;
                
                selectedID(sanPham.MaSanPham);

              //  MessageBox.Show("Test");
            }
            else if (getSelectedID() == sanPham.MaSanPham) {
                selected = false;
                selectedID("");
                BackColor_1 = normalColor;
            }
        }

        private void HienThongTinSanPham(object sender, EventArgs e)
        {
            new GiaoDien.SanPham.ThongTinSanPham(sanPham).ShowDialog();
        }
    }
}
