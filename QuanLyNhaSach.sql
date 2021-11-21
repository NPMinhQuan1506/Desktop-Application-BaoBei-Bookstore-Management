USE [QuanLyNhaSach]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [varchar](100) NOT NULL,
	[SKU] [varchar](100) NOT NULL,
	[SoLuong] [int] NULL,
	[GiaBan] [decimal](18, 0) NULL,
	[GiamGia] [decimal](18, 0) NULL,
	[HienThi] [bit] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[SKU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietKhuyenMai]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietKhuyenMai](
	[MaKM] [varchar](100) NOT NULL,
	[SKU] [varchar](100) NOT NULL,
	[GiamGiaSanPham] [decimal](18, 0) NULL,
	[GhiChu] [nvarchar](max) NULL,
	[HienThi] [bit] NULL,
 CONSTRAINT [PK_ChiTietKhuyenMai] PRIMARY KEY CLUSTERED 
(
	[MaKM] ASC,
	[SKU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietPhanQuyen]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhanQuyen](
	[MaPQ] [int] NOT NULL,
	[MaCV] [int] NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[HienThi] [bit] NULL,
 CONSTRAINT [PK_ChiTietPhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaPQ] ASC,
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPN] [varchar](100) NOT NULL,
	[SKU] [varchar](100) NOT NULL,
	[SoLuong] [int] NULL,
	[GiaNhap] [decimal](18, 0) NULL,
	[HienThi] [bit] NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[SKU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietSach]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietSach](
	[ISBN] [varchar](100) NOT NULL,
	[MaNXB] [int] NULL,
	[MaTG] [int] NULL,
	[NamXuatBanDauTien] [date] NULL,
	[NamXuatBanMoiNhat] [date] NULL,
	[SoTrang] [int] NOT NULL CONSTRAINT [DF_ChiTietSach_SoTrang]  DEFAULT ((1)),
 CONSTRAINT [PK_ChiTietSach] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [int] IDENTITY(1,1) NOT NULL,
	[TenCV] [nvarchar](100) NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
	[HienThi] [bit] NULL CONSTRAINT [DF_ChucVu_HienThi]  DEFAULT ((1)),
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GioiTinh]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioiTinh](
	[MaGT] [int] IDENTITY(1,1) NOT NULL,
	[TenGT] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_GioiTinh] PRIMARY KEY CLUSTERED 
(
	[MaGT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HinhAnh]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HinhAnh](
	[MaHA] [int] IDENTITY(1,1) NOT NULL,
	[Anh] [varbinary](max) NULL,
	[DuongDan] [varchar](100) NULL,
	[DuoiTep] [varchar](10) NULL,
	[ChuSoHuu] [nvarchar](50) NULL,
	[HienThi] [bit] NULL CONSTRAINT [DF_HinhAnh_HienThi]  DEFAULT ((1)),
 CONSTRAINT [PK_HinhAnh] PRIMARY KEY CLUSTERED 
(
	[MaHA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HinhAnhSanPham]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HinhAnhSanPham](
	[MaHA] [int] NOT NULL,
	[SKU] [varchar](100) NOT NULL,
	[GhiChu] [nvarchar](200) NULL,
	[HienThi] [bit] NULL CONSTRAINT [DF_HinhAnhSanPham_HienThi]  DEFAULT ((1)),
 CONSTRAINT [PK_HinhAnhSanPham] PRIMARY KEY CLUSTERED 
(
	[MaHA] ASC,
	[SKU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HinhThuc]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HinhThuc](
	[MaHT] [int] IDENTITY(1,1) NOT NULL,
	[TenHT] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](max) NULL,
	[HienThi] [bit] NULL CONSTRAINT [DF_HinhThuc_HienThi]  DEFAULT ((1)),
 CONSTRAINT [PK_HinhThuc] PRIMARY KEY CLUSTERED 
(
	[MaHT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [varchar](100) NOT NULL,
	[MaNV] [varchar](50) NULL,
	[MaKH] [varchar](50) NULL,
	[TongTien] [decimal](18, 0) NOT NULL,
	[GiamGia] [decimal](18, 0) NULL,
	[PhiGiaoHang] [decimal](18, 0) NULL,
	[MaTTHD] [int] NULL,
	[GhiChu] [nvarchar](max) NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[HienThi] [bit] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](50) NOT NULL,
	[TenKH] [nvarchar](100) NOT NULL,
	[MaGT] [int] NULL,
	[MaHA] [int] NULL,
	[MaLK] [int] NULL CONSTRAINT [DF_KhachHang_MaLK]  DEFAULT ((1)),
	[MaNK] [int] NULL,
	[MaTK] [int] NULL,
	[NgaySinh] [date] NULL,
	[Email] [varchar](100) NULL,
	[DienThoai] [varchar](15) NOT NULL,
	[DiaChi] [nvarchar](150) NULL,
	[GhiChu] [nvarchar](max) NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[HienThi] [bit] NULL CONSTRAINT [DF_KhachHang_HienThi]  DEFAULT ((1)),
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[MaKM] [varchar](100) NOT NULL,
	[TenKM] [nvarchar](100) NOT NULL,
	[ThoiGianBatDau] [datetime] NOT NULL,
	[ThoiGianKetThuc] [datetime] NOT NULL,
	[GiamGiaHoaDon] [decimal](18, 0) NULL,
	[DonViGiam] [nvarchar](10) NULL,
	[DieuKien] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](max) NULL,
	[HienThi] [bit] NULL,
 CONSTRAINT [PK_ChuongTrinhKhuyenMai] PRIMARY KEY CLUSTERED 
(
	[MaKM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiKhach]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiKhach](
	[MaLK] [int] IDENTITY(1,1) NOT NULL,
	[TenLK] [nvarchar](100) NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
	[HienThi] [bit] NULL CONSTRAINT [DF_LoaiKhach_HienThi]  DEFAULT ((1)),
 CONSTRAINT [PK_LoaiKhach] PRIMARY KEY CLUSTERED 
(
	[MaLK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](50) NOT NULL,
	[TenNCC] [nvarchar](100) NOT NULL,
	[MaSoThue] [varchar](50) NULL,
	[Email] [varchar](100) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [varchar](15) NULL,
	[HienThi] [bit] NULL CONSTRAINT [DF_NhaCungCap_HienThi]  DEFAULT ((1)),
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](50) NOT NULL,
	[TenNV] [nvarchar](100) NOT NULL,
	[MaGT] [int] NULL,
	[MaCV] [int] NULL,
	[MaTK] [int] NULL,
	[MaHA] [int] NULL,
	[CMND_CCCD] [varchar](15) NOT NULL,
	[NgaySinh] [date] NULL,
	[Luong] [decimal](18, 0) NULL,
	[NgayThue] [datetime] NULL,
	[Email] [varchar](100) NULL,
	[DienThoai] [varchar](15) NOT NULL,
	[DiaChi] [nvarchar](150) NULL,
	[GhiChu] [nvarchar](max) NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[HienThi] [bit] NULL CONSTRAINT [DF_NhanVien_HienThi]  DEFAULT ((1)),
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_NhanVien_CMND_CCCD] UNIQUE NONCLUSTERED 
(
	[CMND_CCCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaXuatBan]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaXuatBan](
	[MaNXB] [int] IDENTITY(1,1) NOT NULL,
	[TenNXB] [nvarchar](100) NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
	[HienThi] [bit] NULL CONSTRAINT [DF_NhaXuatBan_HienThi]  DEFAULT ((1)),
 CONSTRAINT [PK_NhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhomKhach]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomKhach](
	[MaNK] [int] IDENTITY(1,1) NOT NULL,
	[TenNK] [nvarchar](100) NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
	[HienThi] [bit] NULL CONSTRAINT [DF_NhomKhach_HienThi]  DEFAULT ((1)),
 CONSTRAINT [PK_NhomKhach] PRIMARY KEY CLUSTERED 
(
	[MaNK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhomQuyen]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomQuyen](
	[MaNQ] [int] IDENTITY(1,1) NOT NULL,
	[TenNQ] [nvarchar](100) NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[HienThi] [bit] NULL CONSTRAINT [DF_NhomQuyen_HienThi]  DEFAULT ((1)),
 CONSTRAINT [PK_NhomQuyen] PRIMARY KEY CLUSTERED 
(
	[MaNQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[MaPQ] [int] IDENTITY(1,1) NOT NULL,
	[MaNQ] [int] NULL,
	[MaTT] [int] NULL,
	[GhiChu] [nvarchar](max) NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[HienThi] [bit] NULL CONSTRAINT [DF_PhanQuyen_HienThi]  DEFAULT ((1)),
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaPQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [varchar](100) NOT NULL,
	[MaNCC] [varchar](50) NULL,
	[MaNV] [varchar](50) NULL,
	[TongTien] [decimal](18, 0) NULL,
	[GhiChu] [nvarchar](max) NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[HienThi] [bit] NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SanPham](
	[SKU] [varchar](100) NOT NULL,
	[ISBN] [varchar](100) NULL,
	[TenSP] [nvarchar](100) NULL,
	[MaNCC] [varchar](50) NULL,
	[MaHT] [int] NULL,
	[MaTL] [int] NULL,
	[NgonNgu] [nvarchar](50) NULL,
	[PhienBan] [nvarchar](50) NULL,
	[SoLuongTon] [int] NULL,
	[TonToiThieu] [int] NULL CONSTRAINT [DF_SanPham_TonToiThieu]  DEFAULT ((1)),
	[DonViTinh] [nvarchar](50) NULL,
	[GiaBan] [decimal](18, 0) NULL,
	[DanhGia] [int] NULL CONSTRAINT [DF_SanPham_DanhGia]  DEFAULT ((0)),
	[MoTa] [nvarchar](max) NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[HienThi] [bit] NULL CONSTRAINT [DF_SanPham_HienThi]  DEFAULT ((1)),
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[SKU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_SanPham_ISBN] UNIQUE NONCLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTG] [int] IDENTITY(1,1) NOT NULL,
	[TenTG] [nvarchar](100) NOT NULL,
	[HienThi] [bit] NULL CONSTRAINT [DF_TacGia_HienThi]  DEFAULT ((1)),
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan_KH]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan_KH](
	[MaTK] [int] IDENTITY(1,1) NOT NULL,
	[TenTK] [varchar](100) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[HienThi] [bit] NULL CONSTRAINT [DF_TaiKhoan_KH_HienThi]  DEFAULT ((1)),
 CONSTRAINT [PK_TaiKhoan_KH] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan_NV]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan_NV](
	[MaTK] [int] IDENTITY(1,1) NOT NULL,
	[TenTK] [varchar](100) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
	[GoiYMatKhau] [varchar](100) NOT NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[HienThi] [bit] NOT NULL CONSTRAINT [DF_TaiKhoan_HienThi]  DEFAULT ((1)),
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThaoTac]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThaoTac](
	[MaTT] [int] IDENTITY(1,1) NOT NULL,
	[TenTT] [nvarchar](100) NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhat] [datetime] NULL,
	[HienThi] [bit] NULL CONSTRAINT [DF_ThaoTac_HienThi]  DEFAULT ((1)),
 CONSTRAINT [PK_ThaoTac] PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 21/11/2021 9:37:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTL] [int] IDENTITY(1,1) NOT NULL,
	[TenTL] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](max) NULL,
	[HienThi] [bit] NULL CONSTRAINT [DF_TheLoai_HienThi]  DEFAULT ((1)),
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  CONSTRAINT [DF_ChiTietHoaDon_HienThi]  DEFAULT ((1)) FOR [HienThi]
GO
ALTER TABLE [dbo].[ChiTietKhuyenMai] ADD  CONSTRAINT [DF_ChiTietKhuyenMai_HienThi]  DEFAULT ((1)) FOR [HienThi]
GO
ALTER TABLE [dbo].[ChiTietPhanQuyen] ADD  CONSTRAINT [DF_ChiTietPhanQuyen_HienThi]  DEFAULT ((1)) FOR [HienThi]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] ADD  CONSTRAINT [DF_ChiTietPhieuNhap_HienThi]  DEFAULT ((1)) FOR [HienThi]
GO
ALTER TABLE [dbo].[HoaDon] ADD  CONSTRAINT [DF_HoaDon_GiamGia]  DEFAULT ((0)) FOR [GiamGia]
GO
ALTER TABLE [dbo].[HoaDon] ADD  CONSTRAINT [DF_HoaDon_PhiGiaoHang]  DEFAULT ((0)) FOR [PhiGiaoHang]
GO
ALTER TABLE [dbo].[HoaDon] ADD  CONSTRAINT [DF_HoaDon_MaTTHD]  DEFAULT ((1)) FOR [MaTTHD]
GO
ALTER TABLE [dbo].[HoaDon] ADD  CONSTRAINT [DF_HoaDon_HienThi]  DEFAULT ((1)) FOR [HienThi]
GO
ALTER TABLE [dbo].[KhuyenMai] ADD  CONSTRAINT [DF_ChuongTrinhKhuyenMai_HienThi]  DEFAULT ((1)) FOR [HienThi]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  CONSTRAINT [DF_PhieuNhap_HienThi]  DEFAULT ((1)) FOR [HienThi]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([SKU])
REFERENCES [dbo].[SanPham] ([SKU])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[ChiTietKhuyenMai]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietKhuyenMai_KhuyenMai] FOREIGN KEY([MaKM])
REFERENCES [dbo].[KhuyenMai] ([MaKM])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietKhuyenMai] CHECK CONSTRAINT [FK_ChiTietKhuyenMai_KhuyenMai]
GO
ALTER TABLE [dbo].[ChiTietKhuyenMai]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietKhuyenMai_SanPham] FOREIGN KEY([SKU])
REFERENCES [dbo].[SanPham] ([SKU])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietKhuyenMai] CHECK CONSTRAINT [FK_ChiTietKhuyenMai_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhanQuyen_PhanQuyen] FOREIGN KEY([MaPQ])
REFERENCES [dbo].[PhanQuyen] ([MaPQ])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPhanQuyen] CHECK CONSTRAINT [FK_ChiTietPhanQuyen_PhanQuyen]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[ChiTietSach]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietSach_NXB] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NhaXuatBan] ([MaNXB])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[ChiTietSach] CHECK CONSTRAINT [FK_ChiTietSach_NXB]
GO
ALTER TABLE [dbo].[ChiTietSach]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietSach_Sach] FOREIGN KEY([ISBN])
REFERENCES [dbo].[SanPham] ([ISBN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietSach] CHECK CONSTRAINT [FK_ChiTietSach_Sach]
GO
ALTER TABLE [dbo].[ChiTietSach]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietSach_TacGia] FOREIGN KEY([MaTG])
REFERENCES [dbo].[TacGia] ([MaTG])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[ChiTietSach] CHECK CONSTRAINT [FK_ChiTietSach_TacGia]
GO
ALTER TABLE [dbo].[HinhAnhSanPham]  WITH CHECK ADD  CONSTRAINT [FK_HinhAnhSanPham_HinhAnh] FOREIGN KEY([MaHA])
REFERENCES [dbo].[HinhAnh] ([MaHA])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HinhAnhSanPham] CHECK CONSTRAINT [FK_HinhAnhSanPham_HinhAnh]
GO
ALTER TABLE [dbo].[HinhAnhSanPham]  WITH CHECK ADD  CONSTRAINT [FK_HinhAnhSanPham_SanPham] FOREIGN KEY([SKU])
REFERENCES [dbo].[SanPham] ([SKU])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HinhAnhSanPham] CHECK CONSTRAINT [FK_HinhAnhSanPham_SanPham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_GioiTinh] FOREIGN KEY([MaGT])
REFERENCES [dbo].[GioiTinh] ([MaGT])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_GioiTinh]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_HinhAnh] FOREIGN KEY([MaHA])
REFERENCES [dbo].[HinhAnh] ([MaHA])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_HinhAnh]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_LoaiKhach] FOREIGN KEY([MaLK])
REFERENCES [dbo].[LoaiKhach] ([MaLK])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_LoaiKhach]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_NhomKhach] FOREIGN KEY([MaNK])
REFERENCES [dbo].[NhomKhach] ([MaNK])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_NhomKhach]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_TaiKhoan] FOREIGN KEY([MaTK])
REFERENCES [dbo].[TaiKhoan_KH] ([MaTK])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_TaiKhoan]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_GioiTinh] FOREIGN KEY([MaGT])
REFERENCES [dbo].[GioiTinh] ([MaGT])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_GioiTinh]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_HinhAnh] FOREIGN KEY([MaHA])
REFERENCES [dbo].[HinhAnh] ([MaHA])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_HinhAnh]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoan] FOREIGN KEY([MaTK])
REFERENCES [dbo].[TaiKhoan_NV] ([MaTK])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TaiKhoan]
GO
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyen_NhomQuyen] FOREIGN KEY([MaNQ])
REFERENCES [dbo].[NhomQuyen] ([MaNQ])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[PhanQuyen] CHECK CONSTRAINT [FK_PhanQuyen_NhomQuyen]
GO
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyen_ThaoTac] FOREIGN KEY([MaTT])
REFERENCES [dbo].[ThaoTac] ([MaTT])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[PhanQuyen] CHECK CONSTRAINT [FK_PhanQuyen_ThaoTac]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_HoaDon_NCC]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_HinhThuc] FOREIGN KEY([MaHT])
REFERENCES [dbo].[HinhThuc] ([MaHT])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_HinhThuc]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_NhaCungCap]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_TheLoai] FOREIGN KEY([MaTL])
REFERENCES [dbo].[TheLoai] ([MaTL])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_TheLoai]
GO
