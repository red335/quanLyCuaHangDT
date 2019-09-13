using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDT.Model
{
    public class DienThoai : SanPham
    {
        private Image HinhAnh;
        public DienThoai(): base()
        {

            
        }
        public DienThoai(SanPham sanPham) : base(sanPham) {
            HinhAnh = Image.FromFile(DuongDanHinhAnh);
        }
    }
}
