create database qlcafe
go
use qlcafe

create table nhan_vien
(
	ID_user varchar(10) primary key,
	ho_ten nvarchar(50),
	gioitinh nvarchar(5),
	diachi nvarchar(30),
	ngaysinh datetime,
	ngaylam datetime
)
create table roles
(
	ID_role varchar(10) primary key,
	roles nvarchar(30)
)
create table role_nhanvien
(
	ID_role varchar(10),
	ID_user varchar(10),
	foreign key (ID_user) references nhan_vien(ID_user),
	foreign key (ID_role) references roles(ID_role)
)
create table users
(
	usernames nvarchar(50),
	passwords nvarchar(50)
)
create table thuc_uong 
(
	ID_thuc_uong varchar(10) primary key,
	ten_thuc_uong nvarchar(10)
)
create table nguyen_lieu 
(
	ID_nguyen_lieu varchar(10) primary key,
	ten_nguyen_lieu nvarchar(10),
	don_vi varchar(5),
	so_luong float
)
create table cong_thuc 
(
	ID_thuc_uong varchar(10),
	ID_nguyen_lieu varchar(10),
	so_luong float,
	foreign key (ID_thuc_uong) references thuc_uong(ID_thuc_uong),
	foreign key (ID_nguyen_lieu) references nguyen_lieu(ID_nguyen_lieu)
)
create table hdn 
(
	ID_hdn varchar(10) primary key,
	ngay_nhap datetime
)
create table chitiet_hdn 
(
	ID_hdn varchar(10),
	ID_nguyen_lieu varchar(10),
	don_gia float,
	so_luong int,
	foreign key (ID_hdn) references hdn(ID_hdn),
	foreign key (ID_nguyen_lieu) references nguyen_lieu(ID_nguyen_lieu)
)
create table hd 
(
	ID_hd varchar(10) primary key,
	STT varchar(5),
	ngay_lap datetime,
	tong_tien float
)
create table chitiet_hd 
(
	ID_hd varchar(10),
	ID_thuc_uong varchar(10),
	don_gia float,
	so_luong int,
	foreign key (ID_hd) references hd(ID_hd),
	foreign key (ID_thuc_uong) references thuc_uong(ID_thuc_uong)
)
--Add admin
INSERT INTO users (usernames, passwords) VALUES ('admin','admin') 

--Sample data
set dateformat dmy

INSERT INTO nhan_vien (ID_user,	ho_ten,	gioitinh, diachi, ngaysinh,	ngaylam) VALUES ('01', N'Nguyen Thi Hoai Thu', N'Nu', 'Q7, tp.HCM', '16-8-1994', '13-5-2020') 
INSERT INTO nhan_vien (ID_user,	ho_ten,	gioitinh, diachi, ngaysinh,	ngaylam) VALUES ('02', N'Tran Ba Trung', N'Nam', 'Q4, tp.HCM', '17-2-1995', '20-7-2020') 
INSERT INTO nhan_vien (ID_user,	ho_ten,	gioitinh, diachi, ngaysinh,	ngaylam) VALUES ('03', N'Nguyen Thi Cong Tuoc', N'Nam', 'Q1, tp.HCM', '08-5-2000', '15/8/2020') 

INSERT INTO roles (ID_role,	roles) VALUES ('TN', N'thu ngan') 
INSERT INTO roles (ID_role,	roles) VALUES ('PC', N'pha che') 

INSERT INTO role_nhanvien (ID_role, ID_user) VALUES ('TN','01') 
INSERT INTO role_nhanvien (ID_role, ID_user) VALUES ('PC','02') 
INSERT INTO role_nhanvien (ID_role, ID_user) VALUES ('PC','03') 

INSERT INTO thuc_uong (ID_thuc_uong, ten_thuc_uong) VALUES ('ESP01',N'Espresso') 

INSERT INTO nguyen_lieu (ID_nguyen_lieu, ten_nguyen_lieu, don_vi, so_luong) VALUES ('CF01', N'cafe', 'kg',10) 
INSERT INTO nguyen_lieu (ID_nguyen_lieu, ten_nguyen_lieu, don_vi, so_luong) VALUES ('MLK', N'sua', 'l',5) 
INSERT INTO nguyen_lieu (ID_nguyen_lieu, ten_nguyen_lieu, don_vi, so_luong) VALUES ('SUGR', N'duong', 'kg',5) 

INSERT INTO cong_thuc (ID_thuc_uong, ID_nguyen_lieu, so_luong) VALUES ('ESP01','CF01',0.03) 