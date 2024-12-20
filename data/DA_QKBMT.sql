USE [master]
GO
/****** Object:  Database [DA_QLBMT]    Script Date: 1/3/2024 10:39:05 AM ******/
CREATE DATABASE [DA_QLBMT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DA_QLBMT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DA_QLBMT.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DA_QLBMT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DA_QLBMT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DA_QLBMT] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DA_QLBMT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DA_QLBMT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DA_QLBMT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DA_QLBMT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DA_QLBMT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DA_QLBMT] SET ARITHABORT OFF 
GO
ALTER DATABASE [DA_QLBMT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DA_QLBMT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DA_QLBMT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DA_QLBMT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DA_QLBMT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DA_QLBMT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DA_QLBMT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DA_QLBMT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DA_QLBMT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DA_QLBMT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DA_QLBMT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DA_QLBMT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DA_QLBMT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DA_QLBMT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DA_QLBMT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DA_QLBMT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DA_QLBMT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DA_QLBMT] SET RECOVERY FULL 
GO
ALTER DATABASE [DA_QLBMT] SET  MULTI_USER 
GO
ALTER DATABASE [DA_QLBMT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DA_QLBMT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DA_QLBMT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DA_QLBMT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DA_QLBMT] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DA_QLBMT] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DA_QLBMT', N'ON'
GO
ALTER DATABASE [DA_QLBMT] SET QUERY_STORE = ON
GO
ALTER DATABASE [DA_QLBMT] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DA_QLBMT]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 1/3/2024 10:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[SOHD] [nvarchar](40) NOT NULL,
	[MAHANG] [nvarchar](40) NOT NULL,
	[SL] [int] NULL,
	[DONGIA] [float] NULL,
	[GIAMGIA] [float] NULL,
	[THANHTIEN] [money] NULL,
 CONSTRAINT [pk_cthd] PRIMARY KEY CLUSTERED 
(
	[SOHD] ASC,
	[MAHANG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 1/3/2024 10:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[SOHD] [nvarchar](40) NOT NULL,
	[NGHD] [smalldatetime] NULL,
	[MAKH] [nvarchar](40) NULL,
	[MANV] [nvarchar](40) NULL,
	[TRIGIA] [money] NULL,
 CONSTRAINT [pk_hd] PRIMARY KEY CLUSTERED 
(
	[SOHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 1/3/2024 10:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKH] [nvarchar](40) NOT NULL,
	[HOTEN] [nvarchar](40) NULL,
	[GIOITINHKH] [nvarchar](4) NULL,
	[DCHI] [nvarchar](50) NULL,
	[SODT] [varchar](20) NULL,
	[NGSINH] [smalldatetime] NULL,
	[NGDK] [smalldatetime] NULL,
	[LOAIKH] [nvarchar](40) NULL,
 CONSTRAINT [pk_kh] PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIHANG]    Script Date: 1/3/2024 10:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIHANG](
	[MALOAI] [nvarchar](40) NOT NULL,
	[TENLOAI] [nvarchar](40) NULL,
 CONSTRAINT [pk_lh] PRIMARY KEY CLUSTERED 
(
	[MALOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MATHANG]    Script Date: 1/3/2024 10:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MATHANG](
	[MAHANG] [nvarchar](40) NOT NULL,
	[MALOAI] [nvarchar](40) NULL,
	[MANCC] [nvarchar](40) NULL,
	[TENSP] [nvarchar](40) NULL,
	[DVT] [nvarchar](10) NULL,
	[NUOCSX] [nvarchar](20) NULL,
	[GIA] [money] NULL,
	[ANH] [nvarchar](200) NULL,
	[GHICHU] [nvarchar](200) NULL,
	[SOLUONG] [int] NULL,
 CONSTRAINT [pk_mathang] PRIMARY KEY CLUSTERED 
(
	[MAHANG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHACC]    Script Date: 1/3/2024 10:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACC](
	[MANCC] [nvarchar](40) NOT NULL,
	[TENNCC] [varchar](14) NULL,
	[TENGIAODICH] [varchar](40) NULL,
	[DIACHI] [nvarchar](40) NULL,
	[DIENTHOAI] [varchar](20) NULL,
	[EMAIL] [varchar](50) NULL,
 CONSTRAINT [pk_ncc] PRIMARY KEY CLUSTERED 
(
	[MANCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 1/3/2024 10:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [nvarchar](40) NOT NULL,
	[HOTEN] [nvarchar](40) NULL,
	[GIOITINHNV] [nvarchar](4) NULL,
	[SODT] [varchar](20) NULL,
	[NGVL] [smalldatetime] NULL,
	[LOAINV] [nvarchar](40) NULL,
 CONSTRAINT [pk_nv] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUBAOHANH]    Script Date: 1/3/2024 10:39:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUBAOHANH](
	[MAPBH] [nvarchar](40) NOT NULL,
	[MAHANG] [nvarchar](40) NULL,
	[THOIGIANBH] [nvarchar](10) NULL,
	[SOHD] [nvarchar](40) NULL,
 CONSTRAINT [pk_pbh] PRIMARY KEY CLUSTERED 
(
	[MAPBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTHD] ([SOHD], [MAHANG], [SL], [DONGIA], [GIAMGIA], [THANHTIEN]) VALUES (N'HDB12142023_214306', N'LT06', 34, 195000000, 20, 5304000000.0000)
INSERT [dbo].[CTHD] ([SOHD], [MAHANG], [SL], [DONGIA], [GIAMGIA], [THANHTIEN]) VALUES (N'HDB12142023_215300', N'LT02', 15, 2199, 5, 31335.7500)
INSERT [dbo].[CTHD] ([SOHD], [MAHANG], [SL], [DONGIA], [GIAMGIA], [THANHTIEN]) VALUES (N'HDB12152023_082023', N'LT05', 5, 17990000, 10, 80955000.0000)
INSERT [dbo].[CTHD] ([SOHD], [MAHANG], [SL], [DONGIA], [GIAMGIA], [THANHTIEN]) VALUES (N'HDB122024_215225', N'LT04', 4, 17890000, 10, 64404000.0000)
GO
INSERT [dbo].[HOADON] ([SOHD], [NGHD], [MAKH], [MANV], [TRIGIA]) VALUES (N'HDB12142023_214306', CAST(N'2023-12-14T00:00:00' AS SmallDateTime), N'KH03', N'NV04', 5304000000.0000)
INSERT [dbo].[HOADON] ([SOHD], [NGHD], [MAKH], [MANV], [TRIGIA]) VALUES (N'HDB12142023_215300', CAST(N'2023-12-14T00:00:00' AS SmallDateTime), N'KH06', N'NV06', 31335.7500)
INSERT [dbo].[HOADON] ([SOHD], [NGHD], [MAKH], [MANV], [TRIGIA]) VALUES (N'HDB12152023_082023', CAST(N'2023-12-15T00:00:00' AS SmallDateTime), N'KH05', N'NV05', 80955000.0000)
INSERT [dbo].[HOADON] ([SOHD], [NGHD], [MAKH], [MANV], [TRIGIA]) VALUES (N'HDB122024_215225', CAST(N'2024-01-02T00:00:00' AS SmallDateTime), N'KH05', N'NV03', 64404000.0000)
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [GIOITINHKH], [DCHI], [SODT], [NGSINH], [NGDK], [LOAIKH]) VALUES (N'KH01', N'Nguyễn Văn Nam', N'Nam', N'Xô Viết Nghệ Tĩnh, Q.Bình Thạnh, TpHCM', N'0942546763', CAST(N'1960-05-02T00:00:00' AS SmallDateTime), CAST(N'2006-03-20T00:00:00' AS SmallDateTime), N'Khách hàng Thường')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [GIOITINHKH], [DCHI], [SODT], [NGSINH], [NGDK], [LOAIKH]) VALUES (N'KH02', N'Trần Ngọc Hân', N'Nữ', N'23/5 Nguyễn Trãi, Q5, TpHCM', N'098256478', CAST(N'1974-03-04T00:00:00' AS SmallDateTime), CAST(N'2006-07-30T00:00:00' AS SmallDateTime), N'Khách hàng VIP')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [GIOITINHKH], [DCHI], [SODT], [NGSINH], [NGDK], [LOAIKH]) VALUES (N'KH03', N'Trần Ngọc Linh', N'Nữ', N'45 Nguyễn Cảnh Chân, Q1, TpHCM', N'038776266', CAST(N'1980-12-06T00:00:00' AS SmallDateTime), CAST(N'2006-08-05T00:00:00' AS SmallDateTime), N'Khách Hàng Thường')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [GIOITINHKH], [DCHI], [SODT], [NGSINH], [NGDK], [LOAIKH]) VALUES (N'KH04', N'Trần Minh Long', N'Nam', N'50/34 Lê Đại Hành, Q12, TpHCM', N'0917325476', CAST(N'1965-09-03T00:00:00' AS SmallDateTime), CAST(N'2006-10-02T00:00:00' AS SmallDateTime), N'Khách Hàng Thường')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [GIOITINHKH], [DCHI], [SODT], [NGSINH], [NGDK], [LOAIKH]) VALUES (N'KH05', N'Lê Nhật Minh', N'Nam', N'34 Trương Định, Q3, TpHCM', N'048246108', CAST(N'1950-03-10T00:00:00' AS SmallDateTime), CAST(N'2006-10-20T00:00:00' AS SmallDateTime), N'Khách Hàng Vip')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [GIOITINHKH], [DCHI], [SODT], [NGSINH], [NGDK], [LOAIKH]) VALUES (N'KH06', N'Lê Hoài Thương', N'Nữ', N'227 Nguyễn Văn Cừ, Q5, TpHCM', N'0786314738', CAST(N'1981-12-31T00:00:00' AS SmallDateTime), CAST(N'2006-11-24T00:00:00' AS SmallDateTime), N'Khách Hàng Vip')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [GIOITINHKH], [DCHI], [SODT], [NGSINH], [NGDK], [LOAIKH]) VALUES (N'KH07', N'Nguyễn Văn Tâm', N'Nam', N'32/3 Trần Bình Trọng, Q5, TpHCM', N'0167383565', CAST(N'1971-06-04T00:00:00' AS SmallDateTime), CAST(N'2006-12-01T00:00:00' AS SmallDateTime), N'Khách Hàng Thường')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [GIOITINHKH], [DCHI], [SODT], [NGSINH], [NGDK], [LOAIKH]) VALUES (N'KH08', N'Phan Thị Thanh', N'Nữ', N'45/2 An Dương Vương, Q5, TpHCM', N'0384435756', CAST(N'1971-01-10T00:00:00' AS SmallDateTime), CAST(N'2006-12-13T00:00:00' AS SmallDateTime), N'Khách Hàng Vip')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [GIOITINHKH], [DCHI], [SODT], [NGSINH], [NGDK], [LOAIKH]) VALUES (N'KH09', N'Lê Hà Vinh', N'Nam', N'873 Lê Hồng Phong, Q5, TpHCM', N'0986547463', CAST(N'1979-09-03T00:00:00' AS SmallDateTime), CAST(N'2007-01-14T00:00:00' AS SmallDateTime), N'Khách Hàng Thường')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [GIOITINHKH], [DCHI], [SODT], [NGSINH], [NGDK], [LOAIKH]) VALUES (N'KH10', N'Hà Duy Lập', N'Nam', N'34/34B Nguyẽn Trãi, Q1, TpHCM', N'0987468904', CAST(N'1983-05-02T00:00:00' AS SmallDateTime), CAST(N'2007-01-16T00:00:00' AS SmallDateTime), N'Khách Hàng Vip')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [GIOITINHKH], [DCHI], [SODT], [NGSINH], [NGDK], [LOAIKH]) VALUES (N'KH11', N'Nguyễn Lê Hoàng', N'Nam', N'P6,Cao Lãnh', N'0943452865', CAST(N'2003-06-15T00:00:00' AS SmallDateTime), CAST(N'2023-12-14T00:00:00' AS SmallDateTime), N'Khách Hàng Mua Thiếu')
GO
INSERT [dbo].[LOAIHANG] ([MALOAI], [TENLOAI]) VALUES (N'LK  ', N'Linh Kiện')
INSERT [dbo].[LOAIHANG] ([MALOAI], [TENLOAI]) VALUES (N'LT  ', N'LapTop')
INSERT [dbo].[LOAIHANG] ([MALOAI], [TENLOAI]) VALUES (N'Ma  ', N'MacBook')
INSERT [dbo].[LOAIHANG] ([MALOAI], [TENLOAI]) VALUES (N'MT  ', N'Máy tính')
INSERT [dbo].[LOAIHANG] ([MALOAI], [TENLOAI]) VALUES (N'PK  ', N'Phụ Kiện')
GO
INSERT [dbo].[MATHANG] ([MAHANG], [MALOAI], [MANCC], [TENSP], [DVT], [NUOCSX], [GIA], [ANH], [GHICHU], [SOLUONG]) VALUES (N'LT01', N'LT  ', N'ncc1', N'Dell Inspiron 16', N'Chiếc', N'Hoa Kỳ', 25190000.0000, N'D:\QLBMT\Image\NBDE_5620_P1WKN_1.png', N'Hàng Mới', 105)
INSERT [dbo].[MATHANG] ([MAHANG], [MALOAI], [MANCC], [TENSP], [DVT], [NUOCSX], [GIA], [ANH], [GHICHU], [SOLUONG]) VALUES (N'LT02', N'LT  ', N'ncc2', N'Lenovo Ideapad Gaming 3', N'Chiếc', N'Trung Quốc', 21990000.0000, N'D:\QLBMT\Image\7315_lenovo_ideapad_gaming_3_1.jpg', N'Hàng Mới', 58)
INSERT [dbo].[MATHANG] ([MAHANG], [MALOAI], [MANCC], [TENSP], [DVT], [NUOCSX], [GIA], [ANH], [GHICHU], [SOLUONG]) VALUES (N'LT03', N'LT  ', N'ncc3', N'MSI Modern 15-1024vn', N'Chiếc', N'Trung Quốc', 16890000.0000, N'D:\QLBMT\Image\10074_msi_modern_15_a11m_1024vn_1.jpg', N'Hàng Mới', 96)
INSERT [dbo].[MATHANG] ([MAHANG], [MALOAI], [MANCC], [TENSP], [DVT], [NUOCSX], [GIA], [ANH], [GHICHU], [SOLUONG]) VALUES (N'LT04', N'LT  ', N'ncc4', N'Asus TUF Gaming FX506HF', N'Chiếc', N'Trung Quốc', 17890000.0000, N'D:\QLBMT\Image\asus-tuf-gaming-f15-fx506hf-i5-hn014w-thumb-600x600.jpg', N'Hàng Mới', 70)
INSERT [dbo].[MATHANG] ([MAHANG], [MALOAI], [MANCC], [TENSP], [DVT], [NUOCSX], [GIA], [ANH], [GHICHU], [SOLUONG]) VALUES (N'LT05', N'LT  ', N'ncc5', N'Acer Swift Go SFG14', N'Chiếc', N'Trung Quốc', 17990000.0000, N'D:\QLBMT\Image\81KPCN4+OSL._AC_UF894,1000_QL80_.jpg', N'Hàng Mới', 49)
INSERT [dbo].[MATHANG] ([MAHANG], [MALOAI], [MANCC], [TENSP], [DVT], [NUOCSX], [GIA], [ANH], [GHICHU], [SOLUONG]) VALUES (N'LT06', N'LT  ', N'ncc3', N'MSI  Bravo 15', N'Chiếc', N'Trung Quốc', 19500000.0000, N'D:\QLBMT\Image\2061_0_1.jpg', N'Hàng Mới', 10)
INSERT [dbo].[MATHANG] ([MAHANG], [MALOAI], [MANCC], [TENSP], [DVT], [NUOCSX], [GIA], [ANH], [GHICHU], [SOLUONG]) VALUES (N'MT01', N'MT  ', N'ncc1', N'DELL OptiPlex 3040', N'Bộ', N'Hoa Kỳ', 17890000.0000, N'D:\QLBMT\Image\6f37dae03239fd67a428.jpg', N'Hàng Mới', 38)
INSERT [dbo].[MATHANG] ([MAHANG], [MALOAI], [MANCC], [TENSP], [DVT], [NUOCSX], [GIA], [ANH], [GHICHU], [SOLUONG]) VALUES (N'MT02', N'MT  ', N'ncc4', N'Asus S500SD', N'Bộ', N'Trung Quốc', 13990000.0000, N'D:\QLBMT\Image\Asus S500SD.png', N'Hàng Mới', 5)
INSERT [dbo].[MATHANG] ([MAHANG], [MALOAI], [MANCC], [TENSP], [DVT], [NUOCSX], [GIA], [ANH], [GHICHU], [SOLUONG]) VALUES (N'MT03', N'MT  ', N'ncc5', N'ACER VERITON X2690G', N'Bộ', N'Trung Quốc', 14510000.0000, N'D:\QLBMT\Image\X2690GV247YHbmix-Cover.jpg', N'Hàng Mới', 20)
INSERT [dbo].[MATHANG] ([MAHANG], [MALOAI], [MANCC], [TENSP], [DVT], [NUOCSX], [GIA], [ANH], [GHICHU], [SOLUONG]) VALUES (N'MT04', N'MT  ', N'ncc3', N'MSI Creator P50 11SI', N'Bộ', N'Trung Quốc', 13890000.0000, N'D:\QLBMT\Image\pc-msi-creator-p50-11si-i5-058xvn638015648334163914.jpg', N'Hàng Mới', 30)
INSERT [dbo].[MATHANG] ([MAHANG], [MALOAI], [MANCC], [TENSP], [DVT], [NUOCSX], [GIA], [ANH], [GHICHU], [SOLUONG]) VALUES (N'MT05', N'MT  ', N'ncc2', N'Lenovo ThinkCentre M70t', N'Bộ', N'Trung Quốc', 17990000.0000, N'D:\QLBMT\Image\lenovo-thinkcentre-m70t-gen-3-a4.jpg', N'Hàng Mới', 5)
INSERT [dbo].[MATHANG] ([MAHANG], [MALOAI], [MANCC], [TENSP], [DVT], [NUOCSX], [GIA], [ANH], [GHICHU], [SOLUONG]) VALUES (N'MT06', N'MT  ', N'ncc6', N'IMac', N'Bộ', N'Hoa Kỳ', 24890000.0000, N'D:\QLBMT\Image\imac-slide-1024x545.jpg', N'Hàng Mới', 15)
INSERT [dbo].[MATHANG] ([MAHANG], [MALOAI], [MANCC], [TENSP], [DVT], [NUOCSX], [GIA], [ANH], [GHICHU], [SOLUONG]) VALUES (N'PK01', N'PK  ', N'ncc1', N'Chuột Không Dây DELL VM126', N'Con', N'Hoa Kỳ', 150000.0000, N'D:\QLBMT\Image\unnamed.png', N'Hàng Mới', 60)
GO
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [TENGIAODICH], [DIACHI], [DIENTHOAI], [EMAIL]) VALUES (N'ncc1', N'DELL', N'DL', N'Round Rock, Texas, Hoa Kỳ', N'029857897', N'congtyDELL@gmail.com')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [TENGIAODICH], [DIACHI], [DIENTHOAI], [EMAIL]) VALUES (N'ncc2', N'LENOVO', N'lv', N' Bắc Kinh, Quảng Châu , Trung Quốc', N'0546563354', N'congtyLENOVO@gmail.com')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [TENGIAODICH], [DIACHI], [DIENTHOAI], [EMAIL]) VALUES (N'ncc3', N'MSI', N'ms', N'Bắc Kinh, Quảng Châu , Trung Quốc', N'0345567327', N'congtyMSI@gmail.com')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [TENGIAODICH], [DIACHI], [DIENTHOAI], [EMAIL]) VALUES (N'ncc4', N'ASUS', N'as', N'Đài Loan,Trung Quốc', N'0546547678', N'congtyASUS@gmail.com')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [TENGIAODICH], [DIACHI], [DIENTHOAI], [EMAIL]) VALUES (N'ncc5', N'ACER', N'ac', N'Đài Loan,Trung Quốc', N'0543456463', N'congtyACER@gmail.com')
INSERT [dbo].[NHACC] ([MANCC], [TENNCC], [TENGIAODICH], [DIACHI], [DIENTHOAI], [EMAIL]) VALUES (N'ncc6', N'APPLE', N'ap', N'Round Rock, Texas, Hoa Kỳ', N'0436767837', N'congtyAPPLE@gmail.com')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [GIOITINHNV], [SODT], [NGVL], [LOAINV]) VALUES (N'NV01', N'Nguyễn Minh Nhựt', N'Nam', N'0927345678', CAST(N'2006-04-13T00:00:00' AS SmallDateTime), N'Kỹ Thuật Viên')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [GIOITINHNV], [SODT], [NGVL], [LOAINV]) VALUES (N'NV02', N'Lê Thị Phi Yến', N'Nữ', N'0987567390', CAST(N'2006-04-21T00:00:00' AS SmallDateTime), N'Nhân viên bán hàng')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [GIOITINHNV], [SODT], [NGVL], [LOAINV]) VALUES (N'NV03', N'Nguyễn Văn B', N'Nam', N'0997047382', CAST(N'2006-04-27T00:00:00' AS SmallDateTime), N'Nhân viên Kho')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [GIOITINHNV], [SODT], [NGVL], [LOAINV]) VALUES (N'NV04', N'Ngô Thanh Tuấn', N'Nam', N'0913758498', CAST(N'2006-02-25T00:00:00' AS SmallDateTime), N'Nhân viên bán hàng')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [GIOITINHNV], [SODT], [NGVL], [LOAINV]) VALUES (N'NV05', N'Trần Thanh Tâm', N'Nam', N'0941258884', CAST(N'2006-11-27T00:00:00' AS SmallDateTime), N'Nhân Viên Sửa Chửa')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [GIOITINHNV], [SODT], [NGVL], [LOAINV]) VALUES (N'NV06', N'Nguyễn Tiến Thành', N'Nam', N'0347324120', CAST(N'2007-11-27T23:38:00' AS SmallDateTime), N'Nhân viên bán hàng')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [GIOITINHNV], [SODT], [NGVL], [LOAINV]) VALUES (N'NV07', N'Nguyễn Thị Cẩm Tiên', N'Nữ', N'069565343', CAST(N'2006-11-30T00:00:00' AS SmallDateTime), N'Nhân viên bán hàng')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [GIOITINHNV], [SODT], [NGVL], [LOAINV]) VALUES (N'NV08', N'Trần Võ Anh Vũ', N'Nam', N'0941258885', CAST(N'2023-12-14T00:00:00' AS SmallDateTime), N'Nhân Viên Bán Hàng')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [GIOITINHNV], [SODT], [NGVL], [LOAINV]) VALUES (N'NV09', N'Huỳnh Thị Cẩm Thu', N'Nữ', N'0341286480', CAST(N'2023-12-16T00:00:00' AS SmallDateTime), N'Nhân Viên Bán Hàng')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [GIOITINHNV], [SODT], [NGVL], [LOAINV]) VALUES (N'NV10', N'Trần Huy Tuấn', N'Nam', N'0386995538', CAST(N'2023-12-16T00:00:00' AS SmallDateTime), N'Nhân Viên Kho')
GO
INSERT [dbo].[PHIEUBAOHANH] ([MAPBH], [MAHANG], [THOIGIANBH], [SOHD]) VALUES (N'BH132024_072928', N'LT05', N'12 Tháng', N'HDB12152023_082023')
INSERT [dbo].[PHIEUBAOHANH] ([MAPBH], [MAHANG], [THOIGIANBH], [SOHD]) VALUES (N'BH132024_072946', N'LT02', N'12 Tháng', N'HDB12142023_215300')
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [fk01_CTHD] FOREIGN KEY([SOHD])
REFERENCES [dbo].[HOADON] ([SOHD])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [fk01_CTHD]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [fk02_CTHD] FOREIGN KEY([MAHANG])
REFERENCES [dbo].[MATHANG] ([MAHANG])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [fk02_CTHD]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [fk01_HD] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACHHANG] ([MAKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [fk01_HD]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [fk02_HD] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [fk02_HD]
GO
ALTER TABLE [dbo].[MATHANG]  WITH CHECK ADD  CONSTRAINT [FK_MH_LH] FOREIGN KEY([MALOAI])
REFERENCES [dbo].[LOAIHANG] ([MALOAI])
GO
ALTER TABLE [dbo].[MATHANG] CHECK CONSTRAINT [FK_MH_LH]
GO
ALTER TABLE [dbo].[MATHANG]  WITH CHECK ADD  CONSTRAINT [FK_MH_NCC] FOREIGN KEY([MANCC])
REFERENCES [dbo].[NHACC] ([MANCC])
GO
ALTER TABLE [dbo].[MATHANG] CHECK CONSTRAINT [FK_MH_NCC]
GO
ALTER TABLE [dbo].[PHIEUBAOHANH]  WITH CHECK ADD  CONSTRAINT [fk01_PBH] FOREIGN KEY([SOHD])
REFERENCES [dbo].[HOADON] ([SOHD])
GO
ALTER TABLE [dbo].[PHIEUBAOHANH] CHECK CONSTRAINT [fk01_PBH]
GO
ALTER TABLE [dbo].[PHIEUBAOHANH]  WITH CHECK ADD  CONSTRAINT [fk02_PBH] FOREIGN KEY([MAHANG])
REFERENCES [dbo].[MATHANG] ([MAHANG])
GO
ALTER TABLE [dbo].[PHIEUBAOHANH] CHECK CONSTRAINT [fk02_PBH]
GO
USE [master]
GO
ALTER DATABASE [DA_QLBMT] SET  READ_WRITE 
GO
