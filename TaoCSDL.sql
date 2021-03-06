USE [QLKH]
GO
/****** Object:  StoredProcedure [dbo].[TimMatHangTheoMa]    Script Date: 12/2/2020 9:47:16 AM ******/
DROP PROCEDURE [dbo].[TimMatHangTheoMa]
GO
/****** Object:  StoredProcedure [dbo].[TimMatHang]    Script Date: 12/2/2020 9:47:16 AM ******/
DROP PROCEDURE [dbo].[TimMatHang]
GO
/****** Object:  StoredProcedure [dbo].[ThemPhieuNhap]    Script Date: 12/2/2020 9:47:16 AM ******/
DROP PROCEDURE [dbo].[ThemPhieuNhap]
GO
/****** Object:  StoredProcedure [dbo].[ThemHangNhap]    Script Date: 12/2/2020 9:47:16 AM ******/
DROP PROCEDURE [dbo].[ThemHangNhap]
GO
/****** Object:  StoredProcedure [dbo].[SearchDonNhanHang]    Script Date: 12/2/2020 9:47:16 AM ******/
DROP PROCEDURE [dbo].[SearchDonNhanHang]
GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 12/2/2020 9:47:16 AM ******/
DROP PROCEDURE [dbo].[Login]
GO
ALTER TABLE [dbo].[TinhTrang] DROP CONSTRAINT [FK__TinhTrang__Ma_Ha__3B75D760]
GO
ALTER TABLE [dbo].[PhieuXuatHang] DROP CONSTRAINT [FK__PhieuXuat__NhanV__2B3F6F97]
GO
ALTER TABLE [dbo].[PhieuNhapHang] DROP CONSTRAINT [FK__PhieuNhap__NhanV__286302EC]
GO
ALTER TABLE [dbo].[NhanVien] DROP CONSTRAINT [FK__NhanVien__ID_Nho__25869641]
GO
ALTER TABLE [dbo].[MatHang] DROP CONSTRAINT [FK__MatHang__NV_Tao__2E1BDC42]
GO
ALTER TABLE [dbo].[HangNhap] DROP CONSTRAINT [FK__HangNhap__MP_Nha__30F848ED]
GO
ALTER TABLE [dbo].[HangNhap] DROP CONSTRAINT [FK__HangNhap__MaHang__31EC6D26]
GO
ALTER TABLE [dbo].[HangHoa] DROP CONSTRAINT [FK__HangHoa__MP_Xuat__36B12243]
GO
ALTER TABLE [dbo].[HangHoa] DROP CONSTRAINT [FK__HangHoa__MP_Nhap__35BCFE0A]
GO
ALTER TABLE [dbo].[HangHoa] DROP CONSTRAINT [FK__HangHoa__MaNV_Xu__38996AB5]
GO
ALTER TABLE [dbo].[HangHoa] DROP CONSTRAINT [FK__HangHoa__MaNV_Nh__37A5467C]
GO
ALTER TABLE [dbo].[HangHoa] DROP CONSTRAINT [FK__HangHoa__MaMatHa__34C8D9D1]
GO
/****** Object:  Table [dbo].[TinhTrang]    Script Date: 12/2/2020 9:47:16 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TinhTrang]') AND type in (N'U'))
DROP TABLE [dbo].[TinhTrang]
GO
/****** Object:  Table [dbo].[PhieuXuatHang]    Script Date: 12/2/2020 9:47:16 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhieuXuatHang]') AND type in (N'U'))
DROP TABLE [dbo].[PhieuXuatHang]
GO
/****** Object:  Table [dbo].[NhomNhanVien]    Script Date: 12/2/2020 9:47:16 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhomNhanVien]') AND type in (N'U'))
DROP TABLE [dbo].[NhomNhanVien]
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 12/2/2020 9:47:16 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HangHoa]') AND type in (N'U'))
DROP TABLE [dbo].[HangHoa]
GO
/****** Object:  View [dbo].[viewDanhSachNhapHang]    Script Date: 12/2/2020 9:47:16 AM ******/
DROP VIEW [dbo].[viewDanhSachNhapHang]
GO
/****** Object:  Table [dbo].[HangNhap]    Script Date: 12/2/2020 9:47:16 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HangNhap]') AND type in (N'U'))
DROP TABLE [dbo].[HangNhap]
GO
/****** Object:  Table [dbo].[MatHang]    Script Date: 12/2/2020 9:47:16 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MatHang]') AND type in (N'U'))
DROP TABLE [dbo].[MatHang]
GO
/****** Object:  Table [dbo].[PhieuNhapHang]    Script Date: 12/2/2020 9:47:16 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhieuNhapHang]') AND type in (N'U'))
DROP TABLE [dbo].[PhieuNhapHang]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/2/2020 9:47:16 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhanVien]') AND type in (N'U'))
DROP TABLE [dbo].[NhanVien]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/2/2020 9:47:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID_Nhom] [nvarchar](30) NOT NULL,
	[MaNhanVien] [nvarchar](30) NOT NULL,
	[TenNhanVien] [nvarchar](50) NOT NULL,
	[QueQuan] [nvarchar](100) NULL,
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NULL,
	[MatKhau] [varchar](30) NOT NULL,
	[So_CMND] [varchar](50) NOT NULL,
	[Email] [varchar](100) NULL,
	[SDT] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhapHang]    Script Date: 12/2/2020 9:47:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapHang](
	[MaPhieu] [nvarchar](100) NOT NULL,
	[NgayNhap] [smalldatetime] NOT NULL,
	[MoTa] [nvarchar](200) NULL,
	[NhanVien_Nhap] [nvarchar](30) NULL,
	[NhapTu] [nchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatHang]    Script Date: 12/2/2020 9:47:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatHang](
	[MaMatHang] [nvarchar](100) NOT NULL,
	[NhaSanXuat] [nvarchar](50) NULL,
	[TenMatHang] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](200) NULL,
	[GiaTri] [money] NULL,
	[NV_Tao] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMatHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangNhap]    Script Date: 12/2/2020 9:47:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangNhap](
	[SoLuong] [int] NOT NULL,
	[MP_Nhap] [nvarchar](100) NOT NULL,
	[MaHangNhap] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MP_Nhap] ASC,
	[MaHangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewDanhSachNhapHang]    Script Date: 12/2/2020 9:47:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[viewDanhSachNhapHang] 
AS
SELECT PN.MaPhieu, PN.MoTa, PN.NgayNhap, PN.NhapTu ,NhanVien.TenNhanVien as NhanVienNhap, SUM(HangNhap.SoLuong*MatHang.GiaTri) as GiaTri
FROM PhieuNhapHang PN, HangNhap, MatHang, NhanVien
WHERE PN.MaPhieu=HangNhap.MP_Nhap AND HangNhap.MaHangNhap=MatHang.MaMatHang AND NhanVien.MaNhanVien=PN.NhanVien_Nhap
GROUP BY PN.MaPhieu, PN.MoTa, PN.NgayNhap, PN.NhanVien_Nhap, NhanVien.TenNhanVien, PN.NhapTu
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 12/2/2020 9:47:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHangHoa] [nvarchar](100) NOT NULL,
	[MaNV_KiemKe] [nvarchar](30) NOT NULL,
	[Ngay_KiemKe] [date] NOT NULL,
	[HanSuDung] [date] NOT NULL,
	[NgaySanXuat] [date] NOT NULL,
	[ViTri] [nvarchar](100) NULL,
	[NgayNhapKho] [smalldatetime] NOT NULL,
	[MaMatHang] [nvarchar](100) NULL,
	[MP_NhapHang] [nvarchar](100) NOT NULL,
	[MP_XuatHang] [nvarchar](100) NOT NULL,
	[MaNV_NhapKho] [nvarchar](30) NOT NULL,
	[MaNV_XuatKho] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomNhanVien]    Script Date: 12/2/2020 9:47:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomNhanVien](
	[ID] [nvarchar](30) NOT NULL,
	[TenNhom] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuXuatHang]    Script Date: 12/2/2020 9:47:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuatHang](
	[MaPhieu] [nvarchar](100) NOT NULL,
	[MoTa] [nvarchar](200) NULL,
	[NgayTao] [smalldatetime] NOT NULL,
	[NgayXuat_DuKien] [smalldatetime] NOT NULL,
	[NgayXuat_ThucTe] [smalldatetime] NOT NULL,
	[NhanVien_Xuat] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinhTrang]    Script Date: 12/2/2020 9:47:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhTrang](
	[MaTinhTrang] [nvarchar](50) NOT NULL,
	[TenTinhTrang] [nvarchar](50) NOT NULL,
	[Ma_HangHoa] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTinhTrang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD FOREIGN KEY([MaMatHang])
REFERENCES [dbo].[MatHang] ([MaMatHang])
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD FOREIGN KEY([MaNV_NhapKho])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD FOREIGN KEY([MaNV_XuatKho])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD FOREIGN KEY([MP_NhapHang])
REFERENCES [dbo].[PhieuNhapHang] ([MaPhieu])
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD FOREIGN KEY([MP_XuatHang])
REFERENCES [dbo].[PhieuXuatHang] ([MaPhieu])
GO
ALTER TABLE [dbo].[HangNhap]  WITH CHECK ADD FOREIGN KEY([MaHangNhap])
REFERENCES [dbo].[MatHang] ([MaMatHang])
GO
ALTER TABLE [dbo].[HangNhap]  WITH CHECK ADD FOREIGN KEY([MP_Nhap])
REFERENCES [dbo].[PhieuNhapHang] ([MaPhieu])
GO
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD FOREIGN KEY([NV_Tao])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([ID_Nhom])
REFERENCES [dbo].[NhomNhanVien] ([ID])
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD FOREIGN KEY([NhanVien_Nhap])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuXuatHang]  WITH CHECK ADD FOREIGN KEY([NhanVien_Xuat])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[TinhTrang]  WITH CHECK ADD FOREIGN KEY([Ma_HangHoa])
REFERENCES [dbo].[HangHoa] ([MaHangHoa])
GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 12/2/2020 9:47:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Login] 
	@username varchar(50), @password varchar(50)
	as
	BEGIN
		SELECT * 
		FROM NhanVien
		WHERE TenDangNhap=@username AND MatKhau=@password
	END
GO
/****** Object:  StoredProcedure [dbo].[SearchDonNhanHang]    Script Date: 12/2/2020 9:47:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SearchDonNhanHang]
	@textsearch varchar(50)
	as
	BEGIN
		SELECT *
		FROM viewDanhSachNhapHang
		WHERE MaPhieu LIKE '%'+@textsearch+'%' OR NhanVienNhap LIKE '%'+@textsearch+'%' 
		OR NgayNhap LIKE '%'+@textsearch+'%' OR MoTa LIKE '%'+@textsearch+'%'
	END
GO
/****** Object:  StoredProcedure [dbo].[ThemHangNhap]    Script Date: 12/2/2020 9:47:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemHangNhap]
	@soluong int, @mpnhap varchar(50), @mahangnhap varchar(50) 
	as
	BEGIN
		INSERT INTO HangNhap VALUES(@soluong,@mpnhap,@mahangnhap)
	END
GO
/****** Object:  StoredProcedure [dbo].[ThemPhieuNhap]    Script Date: 12/2/2020 9:47:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemPhieuNhap]
	@maphieu varchar(50),@NgayNhap datetime, @mota varchar(50), @nhanvien_nhap varchar(50) 
	as
	BEGIN
		INSERT INTO PhieuNhapHang VALUES(@maphieu,@NgayNhap,@mota,@nhanvien_nhap)
	END
GO
/****** Object:  StoredProcedure [dbo].[TimMatHang]    Script Date: 12/2/2020 9:47:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TimMatHang]
	@mamathang varchar(50),@tenmathang varchar(50), @nhasanxuat varchar(50), @giatri money, @nvtao nvarchar(50)
	as
	BEGIN
		SELECT *
		FROM MatHang
		WHERE @mamathang=MaMatHang OR @tenmathang=TenMatHang OR @nhasanxuat=NhaSanXuat OR GiaTri=@giatri OR @nvtao=NV_Tao
	END
GO
/****** Object:  StoredProcedure [dbo].[TimMatHangTheoMa]    Script Date: 12/2/2020 9:47:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TimMatHangTheoMa]
	@mamathang varchar(50)
	as
	BEGIN
		SELECT *
		FROM MatHang
		WHERE @mamathang=MaMatHang
	END
GO
