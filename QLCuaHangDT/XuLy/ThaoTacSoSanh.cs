using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuaHangDT.GiaoDien.Dialog;
namespace QLCuaHangDT.XuLy
{
    public  class ThaoTacSoSanh
    {

        // Kieu So
        public static bool SoSanhChoThaoTacLoc(int thaoTac, int a, int b) {
            const int LON_HON = 1;
            const int NHO_HON = 2;
            const int BANG_NHAU = 3;
            const int KHONG_BANG = 4;

            if (thaoTac == BANG_NHAU)
                return a == b;
            else if (thaoTac == LON_HON)
                return a > b;
            else if (thaoTac == KHONG_BANG)
                return a != b;
            else if (thaoTac == NHO_HON)
                return a < b;

            return true;
        }
      //  Kieu Date
        public static bool SoSanhChoThaoTacLoc(int thaoTac, DateTime a, DateTime b)
        {
            const int LON_HON = 1;
            const int NHO_HON = 2;
            const int BANG_NHAU = 3;
            const int KHONG_BANG = 4;
            if (thaoTac == BANG_NHAU)
                return a.CompareTo(b) == 0 ? true:false;
            else if (thaoTac == LON_HON)
                return a > b;
            else if (thaoTac == KHONG_BANG)
                return a.CompareTo(b) == 0 ? false : true;
            else if (thaoTac == NHO_HON)
                return a < b;

            return true;
        }
        public static bool SoSanhChoThaoTacLoc(int thaoTac, string a, string b) {
            const int CHUA_DUNG = 1;
            const int KHONG_CHUA = 2;
            const int BANG_NHAU = 3;
            const int KHONG_BANG = 4;
            if (thaoTac == CHUA_DUNG)
            {
                return a.Contains(b);
            }
            else if (thaoTac == KHONG_CHUA)
            {
                return !a.Contains(b);
            }
            else if (thaoTac == BANG_NHAU)
            {
                return a.CompareTo(b) == 0 ? true : false ;
            }
            else if (thaoTac == KHONG_BANG) {
                return a.CompareTo(b) == 0 ? false : true;
            }

            return true;
        }

        public static bool SoSanhChoThaoTacLoc(int thaoTac, bool a, bool b)
        {
            const int BANG_NHAU = 1;
            const int KHONG_BANG = 2;
            if (thaoTac ==BANG_NHAU)
            {
                return a == b;
            }
            else if (thaoTac == KHONG_BANG)
            {
                return a != b;
            }

            return true;
        }
    }
}
