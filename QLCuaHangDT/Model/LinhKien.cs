using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace QLCuaHangDT.Model
{
   public class LinhKien : SanPham
    {
        private Image hinhAnh;
        public Image HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public LinhKien():base() {
        }
        public LinhKien(SanPham sanPham) : base(sanPham) {
           // HinhAnh = Image.FromFile(DuongDanHinhAnh);
        }
    }
}
