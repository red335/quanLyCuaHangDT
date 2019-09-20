using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDT.Model
{
    public class HangSanXuat
    {
        private int maHangSX;
        private string tenHangSX;
        private string quocGia;
        public HangSanXuat()
        {

        }
        public HangSanXuat(int maHangSX, string tenHangSX, string quocGia)
        {
            this.maHangSX = maHangSX;
            this.tenHangSX = tenHangSX;
            this.quocGia = quocGia;
        }
        public HangSanXuat(string data)
        {
            string[] d = data.Split('/');
            maHangSX =Convert.ToInt32( d[0]);
            tenHangSX = d[1];
            quocGia = d[2];
        }
        public override string ToString()
        {
            string result = "";
            result += maHangSX + "/" + tenHangSX + "/" + quocGia;
            return result;
        }

        public int MaHangSX { get => maHangSX; set => maHangSX = value; }
        public string TenHangSX { get => tenHangSX; set => tenHangSX = value; }
        public string QuocGia { get => quocGia; set => quocGia = value; }
    }
}
