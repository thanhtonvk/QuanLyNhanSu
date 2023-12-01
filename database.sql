create
    database QLNhanSu
go
use QLNhanSu
go
create table NhanVien
(
    MaNV     varchar(10) primary key,
    TenNV    nvarchar(50) not null,
    NgaySinh datetime,
    DiaChi   nvarchar(50),
    GioiTinh int,
    MaPB     varchar(10)  not null,
    MaTD     varchar(10)  not null,
    MaBL     varchar(10)  not null
)
go
create table TrinhDo
(
    MaTD  varchar(10) primary key,
    TenTD nvarchar(50)
)
go
create table NgoaiNgu
(
    MaNN  varchar(10) primary key,
    TenNN nvarchar(50)
)
go
create table NgoaiNguNhanVien
(
    MaNV    varchar(10) not null,
    MaNN    varchar(10) not null,
    NgayCap datetime
)
go
create table ChucVu
(
    MaCV  varchar(10) primary key,
    TenCV nvarchar(50) not null
)
go
create table ChucVuNhanVien
(
    MaNV   varchar(10) not null,
    MaCV   varchar(10) not null,
    NgayBD datetime,
    NgayKT datetime
)
go
create table PhongBan
(
    MaPB  varchar(10) primary key,
    TenPB nvarchar(50) not null
)
go
create table BaoHiem
(
    MaBH  varchar(10) primary key,
    TenBH nvarchar(50)
)
go
create table BaoHiemNhanVien
(
    MaNV   varchar(10) not null,
    MaBH   varchar(10) not null,
    NgayBD datetime,
    NgayKT datetime,
    NoiCap nvarchar(50),
    GhiChu ntext
)
go
create table CheDo
(
    MaCD  varchar(10) primary key,
    TenCD nvarchar(50) not null
)
go
create table CheDoNhanVien
(
    MaNV   varchar(10) not null,
    MaCD   varchar(10) not null,
    NgayBD datetime,
    NgayKT datetime
)
go
create table BacLuong
(
    MaBL  varchar(10) primary key,
    TenBL nvarchar(50) not null,
    HeSBL float
)
go
create table BangCong
(
    MaNV     varchar(10) not null,
    NgayCong datetime    not null

)
go
create table [User]
(
    UserName nvarchar(50) primary key,
    HoTen    nvarchar(50) not null,
    Password nvarchar(50) not null,
    Quyen    nvarchar(50)
)
go
alter table NgoaiNguNhanVien
    add constraint pk_ngoaingunhanvien primary key (MaNV, MaNN)
go
alter table ChucVuNhanVien
    add constraint pk_chucvunhanvien primary key (MaNV, MaCV)
go
alter table BaoHiemNhanVien
    add constraint pk_baohiemnhanvien primary key (MaNV, MaBH)
go
alter table CheDoNhanVien
    add constraint pk_chedonhanvien primary key (MaNV, MaCD)
go
alter table BangCong
    add constraint pk_bangcong primary key (MaNV, NgayCong)
go
alter table NhanVien
    add constraint fk_pb foreign key (MaPB) references PhongBan (MaPB)
go
alter table NhanVien
    add constraint fk_td foreign key (MaTD) references TrinhDo (MaTD)
go
alter table NhanVien
    add constraint fk_bl foreign key (MaBL) references BacLuong (MaBL)
go
alter table ChucVuNhanVien
    add constraint fk_chuvu foreign key (MaNV) references NhanVien (MaNV)
alter table NgoaiNguNhanVien
    add constraint fk_ngoaingu foreign key (MaNV) references NhanVien (MaNV)
alter table CheDoNhanVien
    add constraint fk_chedo foreign key (MaNV) references NhanVien (MaNV)
alter table BaoHiemNhanVien
    add constraint fk_baohiem foreign key (MaNV) references NhanVien (MaNV)
go
alter table ChucVuNhanVien
    add constraint fk_chuvunhanvien foreign key (MaCV) references ChucVu (MaCV)
alter table NgoaiNguNhanVien
    add constraint fk_ngoaingunhanvien foreign key (MaNN) references NgoaiNgu (MaNN)
alter table CheDoNhanVien
    add constraint fk_chedonhanvien foreign key (MaCD) references CheDo (MaCD)
alter table BaoHiemNhanVien
    add constraint fk_baohiemnhanvien foreign key (MaBH) references BaoHiem (MaBH)
go
alter table BangCong
    add constraint fk_bangcong foreign key (MaNV) references NhanVien (MaNV)