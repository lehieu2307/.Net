USE [master]
GO
/****** Object:  Database [qliTBDT]    Script Date: 1/3/2022 6:53:27 PM ******/
CREATE DATABASE [qliTBDT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'qliTBDT', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DUYSQLSERVER\MSSQL\DATA\qliTBDT.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'qliTBDT_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DUYSQLSERVER\MSSQL\DATA\qliTBDT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [qliTBDT] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [qliTBDT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [qliTBDT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [qliTBDT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [qliTBDT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [qliTBDT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [qliTBDT] SET ARITHABORT OFF 
GO
ALTER DATABASE [qliTBDT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [qliTBDT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [qliTBDT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [qliTBDT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [qliTBDT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [qliTBDT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [qliTBDT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [qliTBDT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [qliTBDT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [qliTBDT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [qliTBDT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [qliTBDT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [qliTBDT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [qliTBDT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [qliTBDT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [qliTBDT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [qliTBDT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [qliTBDT] SET RECOVERY FULL 
GO
ALTER DATABASE [qliTBDT] SET  MULTI_USER 
GO
ALTER DATABASE [qliTBDT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [qliTBDT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [qliTBDT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [qliTBDT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [qliTBDT] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [qliTBDT] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'qliTBDT', N'ON'
GO
ALTER DATABASE [qliTBDT] SET QUERY_STORE = OFF
GO
USE [qliTBDT]
GO
/****** Object:  Table [dbo].[Taikhoan]    Script Date: 1/3/2022 6:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taikhoan](
	[stt] [bigint] IDENTITY(1,1) NOT NULL,
	[Taikhoan] [nvarchar](50) NULL,
	[Matkhau] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThietBi]    Script Date: 1/3/2022 6:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThietBi](
	[MaTB] [nvarchar](50) NOT NULL,
	[LoaiTB] [nvarchar](50) NULL,
	[TenTB] [nvarchar](50) NULL,
	[Soluong] [nvarchar](50) NULL,
	[Donvitinh] [nvarchar](50) NULL,
	[Giatien] [nvarchar](50) NULL,
	[Ngaynhap] [nvarchar](50) NULL,
 CONSTRAINT [PK_ThietBi_1] PRIMARY KEY CLUSTERED 
(
	[MaTB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thongke]    Script Date: 1/3/2022 6:53:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thongke](
	[MaTK] [bigint] IDENTITY(1,1) NOT NULL,
	[MaTB] [nvarchar](50) NULL,
	[LoaiTB] [nvarchar](50) NULL,
	[TenTB] [nvarchar](50) NULL,
	[Soluong] [nvarchar](50) NULL,
	[Donvitinh] [nvarchar](50) NULL,
	[Giatien] [nvarchar](50) NULL,
	[Ngaynhap] [nvarchar](50) NULL,
	[Ngaymua] [nvarchar](50) NULL,
 CONSTRAINT [PK_Thongke] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Taikhoan] ON 

INSERT [dbo].[Taikhoan] ([stt], [Taikhoan], [Matkhau]) VALUES (1, N'hieu', N'1         ')
INSERT [dbo].[Taikhoan] ([stt], [Taikhoan], [Matkhau]) VALUES (2, N'admin', N'1         ')
INSERT [dbo].[Taikhoan] ([stt], [Taikhoan], [Matkhau]) VALUES (3, N'admin1', N'1         ')
SET IDENTITY_INSERT [dbo].[Taikhoan] OFF
GO
INSERT [dbo].[ThietBi] ([MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap]) VALUES (N'tb1', N'Ti vi, âm thanh, máy chiếu', N'Cáp HDMI', N'25', N'sợi', N'10000', N'12/3/2020')
INSERT [dbo].[ThietBi] ([MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap]) VALUES (N'tb10', N'Làm đẹp, sức khỏe', N'Máy massage mặt', N'22', N'cái', N'300000', N'21/4/2021')
INSERT [dbo].[ThietBi] ([MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap]) VALUES (N'tb11', N'Làm đẹp, sức khỏe', N' Máy rửa mặt', N'48', N'cái', N'340000', N'21/2/2020')
INSERT [dbo].[ThietBi] ([MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap]) VALUES (N'tb12', N'Điện gia dụng nhỏ', N'Máy sấy trái cây', N'32', N'cái', N'230000', N'4/1/2020')
INSERT [dbo].[ThietBi] ([MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap]) VALUES (N'tb2', N'Điện gia dụng nhỏ', N'Bàn ủi', N'32', N'cái ', N'306000', N'5/6/2021')
INSERT [dbo].[ThietBi] ([MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap]) VALUES (N'tb3', N'Đồ dùng gia đình', N'Đèn điện, đèn sạc', N'88', N'cái ', N'90000', N'24/8/2021')
INSERT [dbo].[ThietBi] ([MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap]) VALUES (N'tb4', N'Đồ dùng gia đình', N'Máy đánh trứng', N'40', N'cái ', N'230000', N'20/2/2020')
INSERT [dbo].[ThietBi] ([MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap]) VALUES (N'tb5', N'Vệ sinh nhà cửa', N'Máy hút bụi', N'23', N'cái ', N'1300000', N'21/2/2021')
INSERT [dbo].[ThietBi] ([MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap]) VALUES (N'tb6', N'Ti vi, âm thanh, máy chiếu', N'Micro', N'23', N'cái', N'120000', N'21/4/2020')
INSERT [dbo].[ThietBi] ([MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap]) VALUES (N'tb7', N'Ti vi, âm thanh, máy chiếu', N'Khung treo TV', N'34', N'cái', N'12000', N'4/6/2021')
INSERT [dbo].[ThietBi] ([MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap]) VALUES (N'tb8', N'Ti vi, âm thanh, máy chiếu', N'Remote', N'99', N'cái', N'30000', N'15/3/2020')
INSERT [dbo].[ThietBi] ([MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap]) VALUES (N'tb9', N'Làm đẹp, sức khỏe', N'Khẩu trang lọc khí', N'224', N'hộp', N'250000', N'23/8/2020')
GO
SET IDENTITY_INSERT [dbo].[Thongke] ON 

INSERT [dbo].[Thongke] ([MaTK], [MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap], [Ngaymua]) VALUES (6, N'tb9', N'Làm đẹp, sức khỏe', N'Khẩu trang lọc khí', N'1', N'hộp', N'250000', N'23/8/2020', N'1/3/2022 6:00:28 PM')
INSERT [dbo].[Thongke] ([MaTK], [MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap], [Ngaymua]) VALUES (7, N'tb3', N'Đồ dùng gia đình', N'Đèn điện, đèn sạc', N'1', N'cái ', N'90000', N'24/8/2021', N'1/3/2022 6:03:17 PM')
INSERT [dbo].[Thongke] ([MaTK], [MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap], [Ngaymua]) VALUES (8, N'tb7', N'Ti vi, âm thanh, máy chiếu', N'Khung treo TV', N'1', N'cái', N'12000', N'4/6/2021', N'1/3/2022 6:03:20 PM')
INSERT [dbo].[Thongke] ([MaTK], [MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap], [Ngaymua]) VALUES (9, N'tb11', N'Làm đẹp, sức khỏe', N' Máy rửa mặt', N'1', N'cái', N'340000', N'21/2/2020', N'1/3/2022 6:03:24 PM')
INSERT [dbo].[Thongke] ([MaTK], [MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap], [Ngaymua]) VALUES (10, N'tb8', N'Ti vi, âm thanh, máy chiếu', N'Remote', N'1', N'cái', N'30000', N'15/3/2020', N'1/3/2022 6:03:28 PM')
INSERT [dbo].[Thongke] ([MaTK], [MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap], [Ngaymua]) VALUES (11, N'tb1', N'Ti vi, âm thanh, máy chiếu', N'Cáp HDMI', N'1', N'sợi', N'10000', N'12/3/2020', N'1/3/2022 6:07:22 PM')
INSERT [dbo].[Thongke] ([MaTK], [MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap], [Ngaymua]) VALUES (12, N'tb1', N'Ti vi, âm thanh, máy chiếu', N'Cáp HDMI', N'1', N'sợi', N'10000', N'12/3/2020', N'1/3/2022 6:08:40 PM')
INSERT [dbo].[Thongke] ([MaTK], [MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap], [Ngaymua]) VALUES (13, N'tb10', N'Làm đẹp, sức khỏe', N'Máy massage mặt', N'1', N'cái', N'300000', N'21/4/2021', N'1/3/2022 6:37:48 PM')
INSERT [dbo].[Thongke] ([MaTK], [MaTB], [LoaiTB], [TenTB], [Soluong], [Donvitinh], [Giatien], [Ngaynhap], [Ngaymua]) VALUES (14, N'tb1', N'Ti vi, âm thanh, máy chiếu', N'Cáp HDMI', N'1', N'sợi', N'10000', N'12/3/2020', N'1/3/2022 6:44:14 PM')
SET IDENTITY_INSERT [dbo].[Thongke] OFF
GO
USE [master]
GO
ALTER DATABASE [qliTBDT] SET  READ_WRITE 
GO
