using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDT.Model
{
    class NhanVien
    {
        private int iDNhanVien;
        private string hoTen;
        private string namSinh;
        private string queQuan;
        private string SDT;
        private bool gioiTinh;
        private int idTaiKhoan;
        private string chucVu;
        private string avatar;
        private string tenHienThi;
        List<int> quyenHanNhanVien = new List<int>();
        public NhanVien(int iDNhanVien, string hoTen, string namSinh, string queQuan, string sDT, bool gioiTinh, int idTaiKhoan, string chucVu)
        {
            this.iDNhanVien = iDNhanVien;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.queQuan = queQuan;
            SDT = sDT;
            this.gioiTinh = gioiTinh;
            this.idTaiKhoan = idTaiKhoan;
            this.chucVu = chucVu;
        }

        public int IdNhanVien { get => iDNhanVien; set => iDNhanVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NamSinh { get => namSinh; set => namSinh = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int IdTaiKhoan { get => idTaiKhoan; set => idTaiKhoan = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public List<int> QuyenHanNhanVien { get => quyenHanNhanVien; set => quyenHanNhanVien = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public string TenHienThi { get => tenHienThi; set => tenHienThi = value; }

        public NhanVien()
        {

        }

        public NhanVien(int iDNhanVien, string hoTen, string namSinh, string queQuan, string sDT, bool gioiTinh, int idTaiKhoan, string chucVu, string avatar, string tenHienThi)
        {
            this.iDNhanVien = iDNhanVien;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.queQuan = queQuan;
            SDT = sDT;
            this.gioiTinh = gioiTinh;
            this.idTaiKhoan = idTaiKhoan;
            this.chucVu = chucVu;
            this.avatar = avatar;
            this.tenHienThi = tenHienThi;
        }
    }
}
