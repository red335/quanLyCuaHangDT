-- Nhom N2: Nguyễn Phúc Hoài Linh, Nguyễn Đăng Khoa, Nguyễn Thanh Lộc
-- Tao co so du lieu nha hang
-- create database QuanLyCuaHangDienThoai
-- su dung csdl cua hang dien thoai
use QuanLyCuaHangDienThoai
-- tao bang NhanVien
create table NhanVien(
   MaNV int identity constraint PK_MaNV primary key,
   HoTen nvarchar(30) Not Null,
   SoCMND int Not Null,
   NgaySinh varchar(18) Not Null,
   GioiTinh nvarchar(9) check( GioiTinh in( 'Nam',N'Nữ')),
   QueQuan nvarchar(100) Not Null,
   Sdt varchar(10) Not Null,
   MaID int constraint FK_MaID foreign key (MaID) references TaiKhoan(MaID) on delete cascade on update cascade,
   ChucVu nvarchar(18) check( Chucvu in( N'Chủ cửa hàng', N'Quản lý', N'Nhân viên'))
)
-- tao bang tai khoan dang nhap
create table TaiKhoan(
   MaID int identity constraint PK_MaID primary key,
   TenTaiKhoan varchar(24) Not Null,
   MatKhau varchar(18) Not Null,
   TenHienThi nvarchar(24) Not Null,
   LoaiTaiKhoan nvarchar(18) check( LoaiTaiKhoan in( N'Chủ cửa hàng', N'Quản lý', N'Nhân viên'))
)
-- tao bang Kho dien thoai
create table KhoDienThoai(
   MaDT int identity constraint PK_MaDT primary key,
   TenDT nvarchar(40) Not Null,
   HangSX nvarchar(40) Not Null,
   GiaThanh int,
   HinhAnh varbinary(max) Not Null,
   SoLuongConTrongCH bit
)
-- tao bang Kho linh kien
create table KhoLinhKien(
   MaLK int identity constraint PK_MaLK primary key,
   TenLK nvarchar(40) Not Null,
   HangSX nvarchar(40) Not Null,
   GiaThanh int,
   HinhAnh varbinary(max) Not Null,
   SoLuongConTrongCH bit
)
-- tao chuc nang 
create table ChucNang(
   MaCN int
   identity constraint PK_maCN primary key,
   tenCN nvarchar(30) Not Null
)
-- tao bang phan quyen
create table PhanQuyenNhanVien(
   MaPQ int identity primary key,
   MaNV int foreign key (MaNV)
       references NhanVien (MaNV) on delete cascade on update cascade, 
   MaCN int  foreign key (MaCN)
       references ChucNang (MaCN) on delete cascade  on update cascade
)

-- chen du lieu bang TaiKhoan
insert into TaiKhoan( TenTaiKhoan, MatKhau, TenHienThi, LoaiTaiKhoan)
values ('khongnhoten','linh1234','khongnhoten',N'Chủ cửa hàng')
insert into TaiKhoan( TenTaiKhoan, MatKhau, TenHienThi, LoaiTaiKhoan)
values ('nhoxsaker','khoa1234','pinksaker',N'Quản lý')
insert into TaiKhoan( TenTaiKhoan, MatKhau, TenHienThi, LoaiTaiKhoan)
values ('mikigamming','kien1234','kiennguyen',N'Nhân viên')
insert into TaiKhoan( TenTaiKhoan, MatKhau, TenHienThi, LoaiTaiKhoan)
values ('locthanh','loc1234','thanhloc',N'Nhân viên')
insert into TaiKhoan( TenTaiKhoan, MatKhau, TenHienThi, LoaiTaiKhoan)
values ('anhtuan','anh1234','tuananh',N'Nhân viên')
insert into TaiKhoan( TenTaiKhoan, MatKhau, TenHienThi, LoaiTaiKhoan)
values ('toananhchu','toan1234','chuanhtoan',N'Nhân viên')


-- chen du lieu bang Nhanvien
insert into NhanVien( HoTen, SoCMND, NgaySinh, GioiTinh, QueQuan, Sdt, MaID, ChucVu)
values (N'Nguyễn Phúc Hoài Linh', 585107,'10/2/1994','Nam',N'Đồng Tháp','012365478', 1, N'Chủ cửa hàng')
insert into NhanVien( HoTen, SoCMND, NgaySinh, GioiTinh, QueQuan, Sdt, MaID, ChucVu)
values (N'Nguyễn Đăng Khoa', 585108,'18/9/1994','Nam',N'Tiền Giang','012358745', 2, N'Quản lý')
insert into NhanVien( HoTen, SoCMND, NgaySinh, GioiTinh, QueQuan, Sdt, MaID, ChucVu)
values (N'Nguyễn Trung Kiên', 585109,'10/4/1994','Nam',N'Đồng Tháp','012485475', 3, N'Nhân viên')
insert into NhanVien( HoTen, SoCMND, NgaySinh, GioiTinh, QueQuan, Sdt, MaID, ChucVu)
values (N'Nguyễn Thanh Lộc', 585101,'10/5/1994',N'Nữ',N'Đồng Nai','012365478', 4, N'Nhân viên')
insert into NhanVien( HoTen, SoCMND, NgaySinh, GioiTinh, QueQuan, Sdt, MaID, ChucVu)
values (N'Huỳnh Tuấn Anh', 585102,'10/6/1994','Nam',N'Đồng Nai','012365418', 5, N'Nhân viên')
insert into NhanVien( HoTen, SoCMND, NgaySinh, GioiTinh, QueQuan, Sdt, MaID, ChucVu)
values (N'Chu Anh Toàn', 585103,'10/4/1994',N'Nữ',N'Kon Tum','012365428', 6, N'Nhân viên')

-- chen du lieu bang KhoDienThoai
insert into KhoDienThoai( TenDT, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
select 'Xiaomi Redmi Note 7 64GB','Xiaomi', 4590000, 1,
   BulkColumn from openrowset(
   Bulk 'D:\2019-2020\LTtrucquan\HinhAnh\xiaomi-redmi-note-7-400x460 (1).png', single_blob) as Picture
insert into KhoDienThoai( TenDT, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
select 'Xiaomi Mi 9T','Xiaomi', 7590000, 1,
   BulkColumn from openrowset(
   Bulk 'D:\2019-2020\LTtrucquan\HinhAnh\mi-9t-red.jpg', single_blob) as Picture
insert into KhoDienThoai( TenDT, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
select 'Xiaomi Mi 8 Lite','Xiaomi', 5590000, 1,
   BulkColumn from openrowset(
   Bulk 'D:\2019-2020\LTtrucquan\HinhAnh\xiaomi-mi-8-lite-6-26-inch-6gb-64gb-smartphone-blue-736638-.jpg', single_blob) as Picture
insert into KhoDienThoai( TenDT, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
select 'SamSung Galaxy Note 10+','SamSung', 26690000, 1,
   BulkColumn from openrowset(
   Bulk 'D:\2019-2020\LTtrucquan\HinhAnh\1567837410-782-hot-samsung-gioi-thieu-klaytn-blockchain-galaxy-note-10-5g-004_galaxy_note10_note10plu-1567827282-width660height371.jpg', single_blob) as Picture
insert into KhoDienThoai( TenDT, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
select 'SamSung Galaxy Note 8','SamSung', 11690000, 1,
   BulkColumn from openrowset(
   Bulk 'D:\2019-2020\LTtrucquan\HinhAnh\samsung-galaxy-note8-gold-1-400x460.png', single_blob) as Picture
insert into KhoDienThoai( TenDT, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
select 'SamSung Galaxy A30','SamSung', 5690000, 1,
   BulkColumn from openrowset(
   Bulk 'D:\2019-2020\LTtrucquan\HinhAnh\13583846408222.jpg', single_blob) as Picture
insert into KhoDienThoai( TenDT, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
select 'Oppo A7','Oppo', 4990000, 1,
   BulkColumn from openrowset(
   Bulk 'D:\2019-2020\LTtrucquan\HinhAnh\oppo-a7-green-600x600.jpg', single_blob) as Picture
insert into KhoDienThoai( TenDT, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
select 'Oppo F9','Oppo', 5490000, 1,
   BulkColumn from openrowset(
   Bulk 'D:\2019-2020\LTtrucquan\HinhAnh\oppo-f9-tim-400x400.jpg', single_blob) as Picture
insert into KhoDienThoai( TenDT, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
select 'Oppo Reno','Oppo', 11490000, 1,
   BulkColumn from openrowset(
   Bulk 'D:\2019-2020\LTtrucquan\HinhAnh\636946624392368184_oppo-reno-den-1.jpg', single_blob) as Picture

-- chen du lieu bang KhoLinhKien
insert into KhoLinhKien( TenLK, HangSX, GiaThanh, SoLuongConTrongCH, 
select 'Oppo Reno','Oppo', 11490000, 1,
   BulkColumn from openrowset(
   Bulk 'D:\2019-2020\LTtrucquan\HinhAnh\636946624392368184_oppo-reno-den-1.jpg', single_blob) as Picture