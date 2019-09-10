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
   HangSX varchar(40) Not Null,
   GiaThanh int,
   HinhAnh varchar(500) Not Null,
   SoLuongConTrongCH bit
)
-- tao bang Kho linh kien
create table KhoLinhKien(
   MaLK int identity constraint PK_MaLK primary key,
   TenLK nvarchar(100) Not Null,
   HangSX nvarchar(40) Not Null,
   GiaThanh int,
   HinhAnh varchar(500) Not Null,
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
-- tao bang NhaSX
create table NhaSX(
   MaHSX int identity primary key,
   HangSX varchar(30) check( HangSX in('Xiaomi','SamSung','Oppo'))
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
 values ('Xiaomi Redmi Note 7 64GB','Xiaomi', 4590000, 1, 'Image/HinhAnh/xiaomi-redmi-note-7-400x460 (1).png')
insert into KhoDienThoai( TenDT, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
 values ('Xiaomi Mi 9T','Xiaomi', 7590000, 1, 'Image/HinhAnh/mi-9t-red.jpg')  
insert into KhoDienThoai( TenDT, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
 values ('Xiaomi Mi 8 Lite','Xiaomi', 5590000, 1, 'Image/HinhAnh/xiaomi-mi-8-lite-6-26-inch-6gb-64gb-smartphone-blue-736638-.jpg')
insert into KhoDienThoai( TenDT, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
 values ('SamSung Galaxy Note 10+','SamSung', 26690000, 1, 'Image/HinhAnh/1567837410-782-hot-samsung-gioi-thieu-klaytn-blockchain-galaxy-note-10-5g-004_galaxy_note10_note10plu-1567827282-width660height371.jpg')
insert into KhoDienThoai( TenDT, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
 values ('SamSung Galaxy Note 8','SamSung', 11690000, 1, 'Image/HinhAnh/samsung-galaxy-note8-gold-1-400x460.png')
insert into KhoDienThoai( TenDT, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
 values ('SamSung Galaxy A30','SamSung', 5690000, 1, 'Image/HinhAnh/13583846408222.jpg')
insert into KhoDienThoai( TenDT, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
 values ('Oppo A7','Oppo', 4990000, 1, 'Image/HinhAnh/oppo-a7-green-600x600.jpg')
insert into KhoDienThoai( TenDT, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
 values ('Oppo F9','Oppo', 5490000, 1, 'Image/HinhAnh/oppo-f9-tim-400x400.jpg')
insert into KhoDienThoai( TenDT, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
 values ('Oppo Reno','Oppo', 11490000, 1, 'Image/HinhAnh/636946624392368184_oppo-reno-den-1.jpg')
-- chen du lieu bang KhoLinhKien
insert into KhoLinhKien( TenLK, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
 values (N'Thẻ nhớ Micro SD 16 GB Class 10', 'Transcend', 220000, 1, 'Image\HinhAnh\the-nho-microsd-16gb-class-10--1.jpg')
insert into KhoLinhKien( TenLK, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
 values (N'Thẻ nhớ Micro SD 32 GB Class 10', 'Transcend', 320000, 1, 'Image\HinhAnh\the-nho-microsd-32gb-class-102.jpg')
insert into KhoLinhKien( TenLK, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
 values (N'Thẻ nhớ Micro SD 64 GB Class 10', 'Lexar', 550000, 1, 'Image\HinhAnh\the-nho-microsd-64gb-lexar-class-10-uhs-i-1-600x600.jpg')
insert into KhoLinhKien( TenLK, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
 values (N'Pin sạc dự phòng 10000mAh Lightning Xmobile LJ JP90S', 'Xmobile', 550000, 1, 'Image\HinhAnh\10000mah-lightning-xmobile-lj-jp90s-nhom-xam-2-org.jpg')
insert into KhoLinhKien( TenLK, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
 values (N'Pin sạc dự phòng 15000mAh Xmobile LA Y615N', 'Xmobile', 750000, 1, 'Image\HinhAnh\pin-sac-du-phong-15000mah-xmobile-la-y615n-anh-dai-dien-600x600.jpg')
insert into KhoLinhKien( TenLK, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
 values (N'Tai nghe nhét trong Samsung EG920B', 'SamSung', 280000, 1, 'Image\HinhAnh\tai-nghe-nhet-trong-samsung-eg920b-2-1-600x600.jpg')
insert into KhoLinhKien( TenLK, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
 values (N'Tai nghe Bluetooth Samsung MG900E', 'SamSung', 750000, 1, 'Image\HinhAnh\tai-nghe-bluetooth-samsung-mg900e--1-1.jpg')
insert into KhoLinhKien( TenLK, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
 values (N'Cáp Micro 1m Xmobile Paladin', 'Xmobile', 80000, 1, 'Image\HinhAnh\cap-micro-1m-xmobile-paladin-bac-23.jpg')
insert into KhoLinhKien( TenLK, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
 values (N'Dây cáp Type C 1m Xmobile MU09-1000', 'Xmobile', 100000, 1, 'Image\HinhAnh\cap-type-c-1m-x-mobile-mu09-1000-1-8-org.jpg')
insert into KhoLinhKien( TenLK, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
 values (N'Gậy chụp ảnh Osmia OW4', 'Osmia', 70000, 1, 'Image\HinhAnh\gay-chup-anh-osmia-ow4-ava-400x400.jpg')
insert into KhoLinhKien( TenLK, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
 values (N'Đế điện thoại xe hơi eSaver JHD-16HD79', 'eSaver', 100000, 1, 'Image\HinhAnh\de-dien-thoai-tren-xe-esaver-jhd-16hd79-ava-600x600.jpg')
insert into KhoLinhKien( TenLK, HangSX, GiaThanh, SoLuongConTrongCH, HinhAnh)
 values (N'Loa Bluetooth iCutes MB-M916 Cú Đen', 'iCutes', 400000, 1, 'Image\HinhAnh\loa-bluetooth-icutes-mb-m916-cu-den-2-1.jpg')





