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

namespace QLCuaHangDT.GUI
{
    public partial class ChiTietThietBi : UserControl
    {
        private ThietBi thietBi;
        private Color myColor_;
        private Color changedColor;

        public ChiTietThietBi()
        {
            InitializeComponent();
            myColor_ = this.BackColor;
            changedColor = Color.FromArgb(255, 128, 0);
            cpExpand.Click += cpExpand_ObClick;
            ganeSuKien();
        }

        private void ganeSuKien() {
            mlMa.MouseHover += MyLabel_OnMouseHover;
            mlMa.MouseLeave += MyLabel_OnMouseLeave;
            mlMa.MouseClick += MyLabel_OnMouseClick;

            mlTen.MouseHover += MyLabel_OnMouseHover;
            mlTen.MouseLeave += MyLabel_OnMouseLeave;
            mlTen.MouseClick += MyLabel_OnMouseClick;

            mlGia.MouseHover += MyLabel_OnMouseHover;
            mlGia.MouseLeave += MyLabel_OnMouseLeave;
            mlGia.MouseClick += MyLabel_OnMouseClick;

            mlHangSX.MouseHover += MyLabel_OnMouseHover;
            mlHangSX.MouseLeave += MyLabel_OnMouseLeave;
            mlHangSX.MouseClick += MyLabel_OnMouseClick;

            mlConHang.MouseHover += MyLabel_OnMouseHover;
            mlConHang.MouseLeave += MyLabel_OnMouseLeave;
            mlConHang.MouseClick += MyLabel_OnMouseClick;

            mlKM.MouseHover += MyLabel_OnMouseHover;
            mlKM.MouseLeave += MyLabel_OnMouseLeave;
            mlKM.MouseClick += MyLabel_OnMouseClick;


        }

        private void MyLabel_OnMouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MyLabel_OnMouseLeave(object sender, EventArgs e)
        {
            (sender as MyLabel).BackColor = myColor_;
            this.BackColor = myColor_;
        }

        private void MyLabel_OnMouseHover(object sender, EventArgs e)
        {
            (sender as MyLabel).BackColor = changedColor ;
            this.BackColor = changedColor;
        }

        private void cpExpand_ObClick(object sender, EventArgs e)
        {
           
            this.BackColor = Color.FromArgb(255, 128, 0);
            new DienThoaiChiTiet().ShowDialog();
          
        }

        


        internal ThietBi ThietBi { get => thietBi; set => thietBi = value; }


        Color myColor = Color.Gray;
    }
}
