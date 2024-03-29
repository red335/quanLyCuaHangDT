﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLCuaHangDT.Model
{
    public enum Loai_San_Pham
    {
        DIEN_THOAI,
        LINH_KIEN
    }

    public class SanPham
    {
        private string maSanPham;
        private string tenSanPham;
        private Loai_San_Pham loaiSanPham;
        private int gia;
        private HangSanXuat hangSanXuatSanPham;
        private int SoLuongTonKho;
        private bool coKhuyenMai;
        private string duongDanHinhAnh;

        public SanPham()
        {
            this.HangSanXuatSanPham = new HangSanXuat();
        }

        public SanPham(string maSanPham, string tenSanPham, Loai_San_Pham loaiSanPham, int gia, HangSanXuat hangSanXuatSanPham, int soLuongTonKho, bool coKhuyenMai, string hinhAnh)
        {
            this.MaSanPham = maSanPham;
            this.TenSanPham = tenSanPham;
            this.LoaiSanPham = loaiSanPham;
            this.Gia = gia;
            this.HangSanXuatSanPham = hangSanXuatSanPham;
            SoLuongTonKho1 = soLuongTonKho;
            this.CoKhuyenMai = coKhuyenMai;
            this.DuongDanHinhAnh = hinhAnh;
        }

        public SanPham(int maSanPham, string tenSanPham, Loai_San_Pham loaiSanPham, int gia, HangSanXuat hangSanXuatSanPham, int soLuongTonKho, bool coKhuyenMai, string hinhAnh)
        {
            
            this.TenSanPham = tenSanPham;
            this.LoaiSanPham = loaiSanPham;
            this.Gia = gia;
            this.HangSanXuatSanPham = hangSanXuatSanPham;
            SoLuongTonKho1 = soLuongTonKho;
            this.CoKhuyenMai = coKhuyenMai;
            this.DuongDanHinhAnh = hinhAnh;
            string kiTuDau = "";
            if (loaiSanPham == Loai_San_Pham.DIEN_THOAI)
                kiTuDau = "D";
            else
                kiTuDau = "L";
            this.MaSanPham =kiTuDau+ maSanPham.ToString();
        }

        public SanPham(SanPham sanPham) {
            this.Clone(sanPham);


        }
        public void Clone( SanPham sanPham) {
            this.MaSanPham = sanPham.MaSanPham;
            
            this.TenSanPham = sanPham.tenSanPham;
            this.LoaiSanPham = sanPham.loaiSanPham;
            this.Gia = sanPham.gia;
            this.HangSanXuatSanPham = new HangSanXuat(sanPham.HangSanXuatSanPham.MaHangSX,sanPham.HangSanXuatSanPham.TenHangSX
                ,sanPham.HangSanXuatSanPham.QuocGia);
            SoLuongTonKho1 = sanPham.SoLuongTonKho;
            this.CoKhuyenMai = sanPham.coKhuyenMai;
            DuongDanHinhAnh = sanPham.DuongDanHinhAnh;
        }

        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public Loai_San_Pham LoaiSanPham { get => loaiSanPham; set => loaiSanPham = value; }
        public int Gia { get => gia; set => gia = value; }
        public int SoLuongTonKho1 { get => SoLuongTonKho; set => SoLuongTonKho = value; }
        public bool CoKhuyenMai { get => coKhuyenMai; set => coKhuyenMai = value; }
        public string DuongDanHinhAnh { get => duongDanHinhAnh; set => duongDanHinhAnh = value; }
        internal HangSanXuat HangSanXuatSanPham { get => hangSanXuatSanPham; set => hangSanXuatSanPham = value; }

        public string toStringForFitler()
        {
            string dat = "";
            dat +="Ma SP: "+ MaSanPham + ";";
            dat += "Ten SP: " + TenSanPham + ";";
            dat += "Loai SP: " + LoaiSanPham.ToString() + ";";
            dat += "Gia: " + Gia.ToString().ToString() + ";";
            dat += "Hang SX: " + HangSanXuatSanPham.TenHangSX + ";";
            dat += "So Ton Kho: " + SoLuongTonKho1.ToString() + ";";
            dat += "Co KM: " + CoKhuyenMai.ToString() ;
          

            return dat;
        }
    }
}
