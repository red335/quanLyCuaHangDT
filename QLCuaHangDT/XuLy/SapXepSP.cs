using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuaHangDT.Model;
namespace QLCuaHangDT.XuLy
{
    class SapXepSP
    {
         private List<int> ListSX;
        SapXepTheoGia sapXepTheoGia;
        SapXepTheoMaSo sapXepTheoMa;
        SapXepTheoTenSanPham sapXepTheoTenSanPham;
        SapXepTheoTonKho sapXepTheoTon;

        public SapXepSP(List<int>li)
        {
            ListSX1 = li;

            SapXepTheoMa = new SapXepTheoMaSo(ListSX1[0]);
            SapXepTheoTenSanPham1 = new SapXepTheoTenSanPham(ListSX1[1]);
            SapXepTheoGia1 = new SapXepTheoGia(ListSX1[2]);
            sapXepTheoTon = new SapXepTheoTonKho(ListSX1[3]);
        }

        public List<int> ListSX1 { get => ListSX; set => ListSX = value; }
        internal SapXepTheoGia SapXepTheoGia1 { get => sapXepTheoGia; set => sapXepTheoGia = value; }
        internal SapXepTheoMaSo SapXepTheoMa { get => sapXepTheoMa; set => sapXepTheoMa = value; }
        internal SapXepTheoTenSanPham SapXepTheoTenSanPham1 { get => sapXepTheoTenSanPham; set => sapXepTheoTenSanPham = value; }
        internal SapXepTheoTonKho SapXepTheoTon { get => sapXepTheoTon; set => sapXepTheoTon = value; }

        public class SapXepTheoGia : Comparer<SanPham>
        {
            int i = 1;
            public SapXepTheoGia(int i) { this.i = i; }
            
            public override int Compare(SanPham x, SanPham y)
            {
                if (x.Gia > y.Gia) return 1 *i;
                else if (x.Gia < y.Gia) return -1*i;
                else return 0;
            }
        }
        public class SapXepTheoMaSo : Comparer<SanPham> {
            int i = 1;
            public SapXepTheoMaSo(int i)
            {
                this.i = i;
            }
            public override int Compare(SanPham x, SanPham y)
            {  
                
                if (x.MaSanPham > y.MaSanPham) return 1 * i;
                else if (x.MaSanPham < y.MaSanPham) return -1 * i;
                else return 0;
            }
        }

        public class SapXepTheoTenSanPham : Comparer<SanPham>
        {
            int i = 1;
            public SapXepTheoTenSanPham(int i)
            {
                this.i = i;
            }
            public override int Compare(SanPham x, SanPham y)
            {
                return string.Compare(x.TenSanPham, y.TenSanPham) * i;
            }
        }

        public class SapXepTheoTonKho : Comparer<SanPham>
        {
            int i = 1;
            public SapXepTheoTonKho(int i)
            {
                this.i = i;
            }
            public override int Compare(SanPham x, SanPham y)
            {
                if (x.SoLuongTonKho1 > y.SoLuongTonKho1) return 1 * i;
                else if (x.SoLuongTonKho1 < y.SoLuongTonKho1) return -1 * i;
                else return 0;
            }
        }
    }
}
