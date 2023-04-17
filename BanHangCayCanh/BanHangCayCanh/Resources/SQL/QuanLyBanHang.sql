use master
go
create database BHCC
go
use BHCC
go
create table NhanVien (
	idNhanVien nvarchar(10) Not Null constraint pk_NV_MNV primary key,
	tenNV nvarchar(100),
	gioiTinh nvarchar(5) check (GioiTinh in(N'Nam',N'Nữ',N'Khác')),
	diaChi nvarchar(1000),
	sdtNV nvarchar(15),
	namSinh datetime
)
go
create table KhachHang(
	idKH nvarchar(10) constraint pk_K_MK primary key,
	tenKH nvarchar(100),
	tuoiKH int,
	diaChiKH nvarchar(1000),
	sdtKH nvarchar(15)
)
go
create table LoaiCay(
	idLoaiCay nvarchar(10) constraint pk_LC_MLC primary key,
	tenLoaiCay nvarchar(100),
	moTa nvarchar(1000)
)
go
create table CayCanh(
	idCayCanh nvarchar(10) constraint pk_CC_MCC primary key,
	tenCay nvarchar(100),
	idLoaiCay nvarchar(10) constraint fk_CC_MLC foreign key references LoaiCay(idLoaiCay),
	soLuong int,
	gia float,
	tuoi int,
	mausac nvarchar(200),
	kichThuoc nvarchar(200),
	anh nvarchar(2000),
	moTa nvarchar(2000),
)
go

create table HoaDon(
	idHoaDon nvarchar(10) 
	constraint pk_HD primary key(idHoaDon),
	idNhanVien nvarchar(10) constraint fk_HD_MaNV foreign key references NhanVien(idNhanVien),
	ngayLap datetime,
	idKH nvarchar(10) constraint fk_HD_MK foreign key references KhachHang(idKH),
	chietKhau float,
	tongTien float,
	trangThai nvarchar(50)
)
go
create table ChiTietHoaDon(
	idCTHD nvarchar(10) constraint pk_CTHD primary key ,
	idCayCanh nvarchar(10) constraint fk_CTHD_CC foreign key references CayCanh(idCayCanh),
	idHoaDon nvarchar(10) constraint fk_CTHD_HD foreign key references HoaDon(idHoaDon),
	soLuong int,
	donGia float
)
go
create table TaiKhoan(

	idNhanVien nvarchar(10) constraint fk_TK_NV foreign key references NhanVien(idNhanVien),
	matKhau nvarchar(100),
	constraint pk_TK primary key(idNhanVien)
)
go

--Fake Data
--LoaiCay
Insert into LoaiCay values (N'lc_00', N'Cây phong thủy', N'Cây hợp phong thủy với chủ sở hữu mang lại vận khí, may mắn, tài lộc...')
Insert into LoaiCay values (N'lc_02', N'Cây trang trí', N'Cây cảnh treo tường, hàng rào, khuôn viên, nhà hàng')
Insert into LoaiCay values (N'lc_03', N'Cây sưu tầm', N'Cây có giá trị sưu tâm, có giá trị kinh tế cao, được nhiêu người ưa thích, mang lại lợi ích kinh tế cho chủ sở hưu, có thể trao đổi trong và ngoài nước...')
Insert into LoaiCay values (N'lc_04', N'Cây nghệ thuật', N'Cây được cắt tỉa, trang trí nghệ thuật')
Insert into LoaiCay values (N'lc_05', N'Cây để bàn', N'Cây có kích thước nhỏ để bàn làm việc, góc học tập')
--CayCanh
Insert into CayCanh values (N'cc_00',N'Cây kim tiền',N'lc_02',12,123456,1,N'xanh',N'C:\Users\linhl\source\repos\BanHangCayCanh\BanHangCayCanh\Resources\anh_cay_canh\cay-kim-tien-van-phong.jpg',N'Đây là cây phong thủy được nhiều người nghĩ đến đầu tiên. Ngoài tên gọi là cây kim tiền thì người ta còn hay gọi nó là cây phát tài. Cũng vì tên gọi này mà nó được rất nhiều người yêu thích. Đặc điểm của cây phát tài là có những tán lá mọc dày đặc. Đây như 1 biểu tượng cho của cải, kinh tế, tiền bạc luôn dồi dào. Ngoài ý nghĩa đó thì về mặt hình thức đây cũng là cây rất đẹp. Với lá xanh bóng, mượt mà. Tán cây cân đối dễ trưng bày.',N'15x15')
Insert into CayCanh values (N'cc_01',N'Cây lưỡi hổ',N'lc_04',2,123215,1,N'xanh',N'C:\Users\linhl\source\repos\BanHangCayCanh\BanHangCayCanh\Resources\anh_cay_canh\cay-luoi-ho-1.jpg',N'Cây lưỡi hổ là 1 trong những cây phát triển cực tốt ở điều kiện thiếu ánh sáng. Cũng chính vì thế mà chúng trở thành cây cảnh được nhiều người lựa chọn. Hơn nữa cây lưỡi hổ rất dễ chăm sóc. Bạn chỉ cần 1 tuần cho cây uống nước 2 lần là được.',N'20x15')
Insert into CayCanh values (N'cc_02',N'Cây phát tài',N'lc_03',2,200000,2,N'xanh',N'C:\Users\linhl\source\repos\BanHangCayCanh\BanHangCayCanh\Resources\anh_cay_canh\cay-phat-tai-1.jpg',N'Cây đem lại may mắn',N'12x10')
Insert into CayCanh values (N'cc_03',N'Cây ngũ gia bì',N'lc_00',2,200000,2,N'xanh',N'C:\Users\linhl\source\repos\BanHangCayCanh\BanHangCayCanh\Resources\anh_cay_canh\ngu-gia-bi-1.jpg',N'Cây đem lại may mắn',N'12x10')
--KhachHang
Insert into KhachHang values (N'kh_00',N'Nguyễn Thái Anh',22,N'Hà Nội',N'0321314824')
Insert into KhachHang values (N'kh_01',N'Trần Bảo Khang',24,N'Bắc Ninh',N'0928134514')
--NhanVien
Insert into NhanVien values (N'nv_00', N'Nguyễn Thị Loan', N'nữ', N'Bắc Ninh', N'0379421334', N'1/22/2000 12:00:00 AM')
Insert into NhanVien values (N'nv_01', N'Hoàng Thu Quỳnh', N'nữ', N'Hà Nam', N'0394812831', N'11/2/2001 12:00:00 AM')
