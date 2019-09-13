-- Nhom N2: Nguyễn Phúc Hoài Linh, Nguyễn Đăng Khoa, Nguyễn Thanh Lộc
-- Tao co so du lieu nha hang
--create database QuanLyCuaHangDienThoai_1
--drop database QuanLyCuaHangDienThoai_1
-- su dung csdl cua hang dien thoai
use QuanLyCuaHangDienThoai_1
-- tao bang tai khoan dang nhap
create table TaiKhoan(
   MaID int identity constraint PK_MaID primary key,
   TenTaiKhoan varchar(24) Not Null,
   MatKhau varchar(18) Not Null,
   TenHienThi nvarchar(24) Not Null,
   LoaiTaiKhoan nvarchar(18) check( LoaiTaiKhoan in( N'Chủ cửa hàng', N'Quản lý', N'Nhân viên'))
)
-- tao bang NhanVien
create table NhanVien(
   MaNV int identity constraint PK_MaNV primary key,
   HoTen nvarchar(30) Not Null,
   SoCMND int Not Null,
   NgaySinh varchar(18) Not Null,
   GioiTinh nvarchar(9) check( GioiTinh in( 'Nam',N'Nữ')),
   QueQuan nvarchar(100) Not Null,
   Sdt varchar(10) Not Null,
   MaID int constraint FK_MaID foreign key (MaID) references TaiKhoan(MaID) on delete cascade on update cascade ,
   ChucVu nvarchar(18) check( Chucvu in( N'Chủ cửa hàng', N'Quản lý', N'Nhân viên'))
)
-- tao bang NhaSX
create table NhaSX(
   MaNSX int identity primary key,
   TenHSX varchar(30) Not Null,
   QuocGia nvarchar(30)
)
-- tao bang Kho dien thoai
create table SanPham(
   MaSP int identity constraint PK_MaDT primary key,
   TenSP nvarchar(50) Not Null,
   MaHSX int foreign key (MaHSX)
       references NhaSX (MaNSX) on delete cascade on update cascade, 
   GiaThanh int,
   HinhAnh varchar(500) Not Null,
   SoLuongConTrongCH int Not null,
   LoaiHang varchar(30) check (LoaiHang in ('Dien Thoai','Linh Kien'))
)
-- tao bang Kho linh kien
--create table KhoLinhKien(
--   MaLK int identity constraint PK_MaLK primary key,
--   TenLK nvarchar(100) Not Null,
--   MaHSX int foreign key (MaHSX)
--       references NhaSXLinhKien (MaHSX) on delete cascade on update cascade, 
--   GiaThanh int,
--   HinhAnh varchar(500) Not Null,
--   SoLuongConTrongCH int
--)
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
insert into TaiKhoan( TenTaiKhoan, MatKhau, TenHienThi, LoaiTaiKhoan)
values ('9989','toan12jjh34','chuanhtoan',N'Nhân viên')

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
insert into NhanVien( HoTen, SoCMND, NgaySinh, GioiTinh, QueQuan, Sdt, MaID, ChucVu)
values (N'uooio', 585103,'10/4/1994',N'Nữ',N'Kon Tum','012365428', 7, N'Nhân viên')

-- nhap du lieu bang NhaSX
insert into NhaSX( TenHSX, QuocGia)  -- 1
 values ('SamSung','Korean')
insert into NhaSX( TenHSX, QuocGia)  -- 2
 values ('Xiaomi','China')
insert into NhaSX( TenHSX, QuocGia)  -- 3
 values ('Oppo','China')
-- nhap du lieu bang NhaSXLinhKien

insert into NhaSX( TenHSX, QuocGia)  ---4  / 2
 values ('Xmobile','Korean')
insert into NhaSX( TenHSX, QuocGia) -- 5  / 3
 values ('Transcend','Korean')
insert into NhaSX( TenHSX, QuocGia) --- 6  /4
 values ('Lexar','USA')
insert into NhaSX( TenHSX, QuocGia) ---7  /5
 values ('eSaver','Korean')
insert into NhaSX( TenHSX, QuocGia) -- 8 /6
 values ('iCutes','Korean')



-- chen du lieu bang SanPham
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values ('Xiaomi Redmi Note 7 64GB', 2, 4590000, 10, 'Image/HinhAnh/xiaomi-redmi-note-7.png','Dien Thoai')
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values ('Xiaomi Mi 9T', 2, 7590000, 10, 'Image/HinhAnh/mi-9t-red.jpg','Dien Thoai')  
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values ('Xiaomi Mi 8 Lite', 2, 5590000, 9, 'Image/HinhAnh/xiaomi-mi-8-lite.jpg','Dien Thoai')
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values ('SamSung Galaxy Note 10+', 1, 26690000, 5, 'Image/HinhAnh/SamSung-Galaxy-Note-10.jpg','Dien Thoai')
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values ('SamSung Galaxy Note 8', 1, 11690000, 10, 'Image/HinhAnh/samsung-galaxy-note8-gold.png','Dien Thoai')
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values ('SamSung Galaxy A30', 1, 5690000, 10, 'Image/HinhAnh/SamSungGalaxyA30.jpg','Dien Thoai')
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values ('Oppo A7', 3, 4990000, 10, 'Image/HinhAnh/oppo-a7-green.jpg','Dien Thoai')
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values ('Oppo F9',3, 5490000, 10, 'Image/HinhAnh/oppo-f9-tim.jpg','Dien Thoai')
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values ('Oppo Reno',3, 11490000, 10, 'Image/HinhAnh/oppo-reno-den-1.jpg','Dien Thoai')
-- chen du lieu bang KhoLinhKien
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values (N'Thẻ nhớ Micro SD 16 GB Class 10', 5  , 220000, 10, 'Image\HinhAnh\the-nho-microsd-16gb.jpg','Linh Kien')
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values (N'Thẻ nhớ Micro SD 32 GB Class 10', 5  , 320000, 10, 'Image\HinhAnh\the-nho-microsd-32gb2.jpg','Linh Kien')
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values (N'Thẻ nhớ Micro SD 64 GB Class 10', 1, 550000, 10, 'Image\HinhAnh\the-nho-microsd-64gb-lexar.jpg','Linh Kien')
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values (N'Sạc dự phòng Lightning Xmobile', 4  , 550000, 12, 'Image\HinhAnh\lightning-xmobile.jpg','Linh Kien')
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values (N'Pin sạc dự phòngXmobile LA ', 4  , 750000, 10, 'Image\HinhAnh\pin-sac-du-phong-xmobile.jpg','Linh Kien')
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values (N'Tai nghe nhét trong Samsung ', 1, 280000, 11, 'Image\HinhAnh\tai-nghe-nhet-trong-samsung0.jpg','Linh Kien')
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values (N'Tai nghe Bluetooth Samsung ', 1, 750000, 13, 'Image\HinhAnh\tai-nghe-bluetooth-samsung.jpg','Linh Kien')
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values (N'Cáp Micro 1m Xmobile Paladin', 4  , 80000, 14, 'Image\HinhAnh\cap-micro-1m-xmobile-paladin-bac-23.jpg','Linh Kien')
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values (N'Dây cáp Type C 1m Xmobile', 1, 100000, 14, 'Image\HinhAnh\cap-type-c-1m-x-mobilesg.jpg','Linh Kien')
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values (N'Gậy chụp ảnh Osmia OW4', 6  , 70000, 1, 'Image\HinhAnh\gay-chup-anh-osmia-ow4-ava-400x400.jpg','Linh Kien')
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values (N'Đế điện thoại xe hơi eSaver JHD-16HD79', 7  , 100000, 15, 'Image\HinhAnh\de-dien-thoai-tren-xe-esaver.jpg','Linh Kien')
insert into SanPham( TenSP, MaHSX, GiaThanh, SoLuongConTrongCH, HinhAnh,LoaiHang)
 values (N'Loa Bluetooth iCutes MB-M916 Cú Đen', 8  , 400000, 18, 'Image\HinhAnh\loa-bluetooth-icutes.jpg','Linh Kien')




