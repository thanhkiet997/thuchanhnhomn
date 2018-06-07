create database sinhvien
use sinhvien
create table nguoidung(
	taikhoan nchar(10) primary key,
	matKhau nchar(20) NOT NULL,
);
INSERT [dbo].[nguoidung] ([taikhoan], [matKhau] ) VALUES (N'admin', N'123' );
INSERT [dbo].[nguoidung] ([taikhoan], [matKhau] ) VALUES (N'kiet', N'321' );