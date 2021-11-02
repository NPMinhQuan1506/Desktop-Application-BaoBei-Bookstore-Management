USE [QuanLyNhaSach]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 02/11/2021 10:05:38 CH ******/
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
/****** Object:  Table [dbo].[ChiTietKhuyenMai]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[ChiTietPhanQuyen]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[ChiTietSach]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[ChucVu]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[GioiTinh]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[HinhAnh]    Script Date: 02/11/2021 10:05:41 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HinhAnh](
	[MaHA] [int] IDENTITY(1,1) NOT NULL,
	[DuongDan] [varchar](100) NOT NULL,
	[DuoiTep] [varchar](10) NULL,
	[ChuSoHuu] [nvarchar](50) NULL,
	[HienThi] [bit] NULL CONSTRAINT [DF_HinhAnh_HienThi]  DEFAULT ((1)),
 CONSTRAINT [PK_HinhAnh] PRIMARY KEY CLUSTERED 
(
	[MaHA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HinhAnhSanPham]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[HinhThuc]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[HoaDon]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[LoaiKhach]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 02/11/2021 10:05:41 CH ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaXuatBan]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[NhomKhach]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[NhomQuyen]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[SanPham]    Script Date: 02/11/2021 10:05:41 CH ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[TaiKhoan_KH]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[TaiKhoan_NV]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[ThaoTac]    Script Date: 02/11/2021 10:05:41 CH ******/
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
/****** Object:  Table [dbo].[TheLoai]    Script Date: 02/11/2021 10:05:41 CH ******/
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
INSERT [dbo].[ChiTietSach] ([ISBN], [MaNXB], [MaTG], [NamXuatBanDauTien], [NamXuatBanMoiNhat], [SoTrang]) VALUES (N'9782221113127', 2, 2, CAST(N'2017-01-01' AS Date), CAST(N'2017-01-01' AS Date), 150)
INSERT [dbo].[ChiTietSach] ([ISBN], [MaNXB], [MaTG], [NamXuatBanDauTien], [NamXuatBanMoiNhat], [SoTrang]) VALUES (N'9786041076945', 1, 1, CAST(N'2012-01-01' AS Date), CAST(N'2021-01-01' AS Date), 180)
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [GhiChu], [HienThi]) VALUES (1, N'Quản Lý', NULL, 1)
INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [GhiChu], [HienThi]) VALUES (2, N'Trưởng Ca', NULL, 1)
INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [GhiChu], [HienThi]) VALUES (3, N'Kế Toán', NULL, 1)
INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [GhiChu], [HienThi]) VALUES (4, N'Thu Ngân', NULL, 1)
INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [GhiChu], [HienThi]) VALUES (5, N'Nhân Viên Kho', NULL, 1)
INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [GhiChu], [HienThi]) VALUES (6, N'IT', NULL, 1)
INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [GhiChu], [HienThi]) VALUES (7, N'Bảo Vệ', NULL, 1)
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
SET IDENTITY_INSERT [dbo].[GioiTinh] ON 

INSERT [dbo].[GioiTinh] ([MaGT], [TenGT]) VALUES (1, N'Nam')
INSERT [dbo].[GioiTinh] ([MaGT], [TenGT]) VALUES (2, N'Nữ')
INSERT [dbo].[GioiTinh] ([MaGT], [TenGT]) VALUES (3, N'Khác')
SET IDENTITY_INSERT [dbo].[GioiTinh] OFF
SET IDENTITY_INSERT [dbo].[HinhAnh] ON 

INSERT [dbo].[HinhAnh] ([MaHA], [DuongDan], [DuoiTep], [ChuSoHuu], [HienThi]) VALUES (1, N'https://drive.google.com/file/d/1cv722a2SJu7FVg7kLh8jr9lt_s7Ai_gv/view?usp=sharing', N'png', N'KhachHang', 1)
INSERT [dbo].[HinhAnh] ([MaHA], [DuongDan], [DuoiTep], [ChuSoHuu], [HienThi]) VALUES (2, N'https://drive.google.com/file/d/1cv722a2SJu7FVg7kLh8jr9lt_s7Ai_gv/view?usp=sharing', N'png', N'KhachHang', 1)
INSERT [dbo].[HinhAnh] ([MaHA], [DuongDan], [DuoiTep], [ChuSoHuu], [HienThi]) VALUES (3, N'https://drive.google.com/file/d/1cv722a2SJu7FVg7kLh8jr9lt_s7Ai_gv/view?usp=sharing', N'png', N'KhachHang', 1)
INSERT [dbo].[HinhAnh] ([MaHA], [DuongDan], [DuoiTep], [ChuSoHuu], [HienThi]) VALUES (4, N'https://drive.google.com/file/d/1cv722a2SJu7FVg7kLh8jr9lt_s7Ai_gv/view?usp=sharing', N'png', N'NhanVien', 1)
INSERT [dbo].[HinhAnh] ([MaHA], [DuongDan], [DuoiTep], [ChuSoHuu], [HienThi]) VALUES (5, N'https://drive.google.com/file/d/1cv722a2SJu7FVg7kLh8jr9lt_s7Ai_gv/view?usp=sharing', N'png', N'NhanVien', 1)
INSERT [dbo].[HinhAnh] ([MaHA], [DuongDan], [DuoiTep], [ChuSoHuu], [HienThi]) VALUES (6, N'https://drive.google.com/file/d/1cv722a2SJu7FVg7kLh8jr9lt_s7Ai_gv/view?usp=sharing', N'png', N'NhanVien', 1)
INSERT [dbo].[HinhAnh] ([MaHA], [DuongDan], [DuoiTep], [ChuSoHuu], [HienThi]) VALUES (7, N'https://drive.google.com/file/d/1cv722a2SJu7FVg7kLh8jr9lt_s7Ai_gv/view?usp=sharing', N'png', N'SanPham', 1)
INSERT [dbo].[HinhAnh] ([MaHA], [DuongDan], [DuoiTep], [ChuSoHuu], [HienThi]) VALUES (8, N'https://drive.google.com/file/d/1cv722a2SJu7FVg7kLh8jr9lt_s7Ai_gv/view?usp=sharing', N'png', N'SanPham', 1)
SET IDENTITY_INSERT [dbo].[HinhAnh] OFF
INSERT [dbo].[HinhAnhSanPham] ([MaHA], [SKU], [GhiChu], [HienThi]) VALUES (7, N'8934974150510', NULL, 1)
INSERT [dbo].[HinhAnhSanPham] ([MaHA], [SKU], [GhiChu], [HienThi]) VALUES (8, N'8935235212022', NULL, 1)
SET IDENTITY_INSERT [dbo].[HinhThuc] ON 

INSERT [dbo].[HinhThuc] ([MaHT], [TenHT], [GhiChu], [HienThi]) VALUES (1, N'Bìa Cứng', NULL, 1)
INSERT [dbo].[HinhThuc] ([MaHT], [TenHT], [GhiChu], [HienThi]) VALUES (2, N'Bìa Mềm', NULL, 1)
INSERT [dbo].[HinhThuc] ([MaHT], [TenHT], [GhiChu], [HienThi]) VALUES (3, N'Hộp/Bộ', NULL, 1)
SET IDENTITY_INSERT [dbo].[HinhThuc] OFF
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [MaGT], [MaHA], [MaLK], [MaNK], [MaTK], [NgaySinh], [Email], [DienThoai], [DiaChi], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (N'KH079010120001', N'Nguyen Ho Thanh Truc', 2, 1, 1, 1, NULL, CAST(N'2000-07-15' AS Date), NULL, N'0909323657', NULL, NULL, CAST(N'2021-11-01 08:48:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [MaGT], [MaHA], [MaLK], [MaNK], [MaTK], [NgaySinh], [Email], [DienThoai], [DiaChi], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (N'KH079010293001', N'Đào Thanh Long', 1, 2, 1, 2, 1, CAST(N'1993-12-29' AS Date), N'user1@gmail.com', N'0906603462', N'12 Đường Số 2, phường 14, Quận 6, TP HCM', NULL, CAST(N'2021-10-22 10:20:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [MaGT], [MaHA], [MaLK], [MaNK], [MaTK], [NgaySinh], [Email], [DienThoai], [DiaChi], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (N'KH079020300001', N'Công Ty Trang Sách', NULL, 3, 2, 3, 2, NULL, N'cty1@gmail.com', N'0852234669', N'R4-35 Hưng Phước 3, Phú Mỹ Hưng, Phường Tân Phong, Quận 7, TPHCM', N'MST: 0317004797', CAST(N'2021-10-25 16:15:00.000' AS DateTime), NULL, 1)
SET IDENTITY_INSERT [dbo].[LoaiKhach] ON 

INSERT [dbo].[LoaiKhach] ([MaLK], [TenLK], [GhiChu], [HienThi]) VALUES (1, N'Cá Nhân', NULL, 1)
INSERT [dbo].[LoaiKhach] ([MaLK], [TenLK], [GhiChu], [HienThi]) VALUES (2, N'Doanh Nghiệp', NULL, 1)
SET IDENTITY_INSERT [dbo].[LoaiKhach] OFF
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [MaSoThue], [Email], [DiaChi], [DienThoai], [HienThi]) VALUES (N'NCC000001', N'Công Ty Cổ Phần Phát Hành Sách Tp.HCM', N'0304142047', N'fahasa-sg@hcm.vnn.vn', N'60-62 Lê Lợi, P.Bến Nghé, Q.1, Tp.HCM', N'(028) 38225798', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [MaSoThue], [Email], [DiaChi], [DienThoai], [HienThi]) VALUES (N'NCC000002', N'Công Ty TNHH Văn Hóa Việt Long', N'0304733305', N'info@vietlonbook.com', N'14/35 Đào Duy Anh, P.9, Q. Phú Nhuận, Tp.HCM', N'(028) 38452708', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [MaSoThue], [Email], [DiaChi], [DienThoai], [HienThi]) VALUES (N'NCC000003', N'Nhà Sách Trực Tuyến BOOKBYE.VN', N'0302009552', N'info@bookbuy.vn', N'147 Pasteur, P.6, Q.3, Tp.HCM', N'(028) 38207153', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaGT], [MaCV], [MaTK], [MaHA], [CMND_CCCD], [NgaySinh], [Luong], [NgayThue], [Email], [DienThoai], [DiaChi], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (N'NV000001', N'Nguyễn Thị Thảo Trang', 2, 1, 3, 4, N'079880055523', CAST(N'1988-11-03' AS Date), CAST(26000000 AS Decimal(18, 0)), CAST(N'2015-06-13 08:00:00.000' AS DateTime), N'nttt1103@gmail.com', N'0909158241', N'65-67 Nguyễn Văn Luông, P.15, Q.6, TP.HCM', NULL, CAST(N'2015-06-13 08:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaGT], [MaCV], [MaTK], [MaHA], [CMND_CCCD], [NgaySinh], [Luong], [NgayThue], [Email], [DienThoai], [DiaChi], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (N'NV000002', N'Tô Hoài Nam', 1, 2, 2, 5, N'063951523591', CAST(N'1995-06-06' AS Date), CAST(12000000 AS Decimal(18, 0)), CAST(N'2018-06-13 06:00:00.000' AS DateTime), N'hoainam.t66@gmail.com', N'0908872981', N'156/21/7/1 Trần Xuân Soạn, P.3, Q.7, TP.HCM', NULL, CAST(N'2018-06-13 06:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaGT], [MaCV], [MaTK], [MaHA], [CMND_CCCD], [NgaySinh], [Luong], [NgayThue], [Email], [DienThoai], [DiaChi], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (N'NV000003', N'Nguyễn Ngọc Thu Vân', 2, 4, 1, 6, N'055982156122', CAST(N'1998-02-02' AS Date), CAST(85000000 AS Decimal(18, 0)), CAST(N'2019-04-15 09:00:00.000' AS DateTime), N'tvnguyen98@gmail.com', N'0906621512', N'339/15 Nguyễn Khắc Chân. P.Cầu Kho, Q.1, TP.HCM', NULL, CAST(N'2019-04-15 09:00:00.000' AS DateTime), NULL, 1)
SET IDENTITY_INSERT [dbo].[NhaXuatBan] ON 

INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB], [GhiChu], [HienThi]) VALUES (1, N'Nhà Xuất Bản Giáo Dục', NULL, 1)
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB], [GhiChu], [HienThi]) VALUES (2, N'Nhà Xuất Bản Trẻ', NULL, 1)
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB], [GhiChu], [HienThi]) VALUES (3, N'Nhà Xuất Bản Kim Đồng', NULL, 1)
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB], [GhiChu], [HienThi]) VALUES (4, N'Nhà Xuất Bản Lao Động', NULL, 1)
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB], [GhiChu], [HienThi]) VALUES (5, N'Nhà Xu?t B?n Th?i Đ?i', NULL, 1)
SET IDENTITY_INSERT [dbo].[NhaXuatBan] OFF
SET IDENTITY_INSERT [dbo].[NhomKhach] ON 

INSERT [dbo].[NhomKhach] ([MaNK], [TenNK], [GhiChu], [HienThi]) VALUES (1, N'Khách Thường', NULL, 1)
INSERT [dbo].[NhomKhach] ([MaNK], [TenNK], [GhiChu], [HienThi]) VALUES (2, N'Thành Viên', NULL, 1)
INSERT [dbo].[NhomKhach] ([MaNK], [TenNK], [GhiChu], [HienThi]) VALUES (3, N'VIP', NULL, 1)
SET IDENTITY_INSERT [dbo].[NhomKhach] OFF
SET IDENTITY_INSERT [dbo].[NhomQuyen] ON 

INSERT [dbo].[NhomQuyen] ([MaNQ], [TenNQ], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (1, N'Quản Lý Hóa Đơn', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[NhomQuyen] ([MaNQ], [TenNQ], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (2, N'Quản Lý Chi Tiết Hóa Đơn', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[NhomQuyen] ([MaNQ], [TenNQ], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (3, N'Quản Lý Phiếu Nhập', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[NhomQuyen] ([MaNQ], [TenNQ], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (4, N'Quản Lý Chi Tiết Phiếu Nhập', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[NhomQuyen] ([MaNQ], [TenNQ], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (5, N'Quản Lý Nhân Viên', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[NhomQuyen] ([MaNQ], [TenNQ], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (6, N'Quản Lý Tài Khoản Nhân Viên', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[NhomQuyen] ([MaNQ], [TenNQ], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (7, N'Quản Lý Khách Hàng', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[NhomQuyen] ([MaNQ], [TenNQ], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (8, N'Quản Lý Tài Khoản Khách Hàng', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[NhomQuyen] ([MaNQ], [TenNQ], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (9, N'Quản Lý Khuyến Mãi', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[NhomQuyen] ([MaNQ], [TenNQ], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (10, N'Quản Lý Chi Tiết Khuyến Mãi', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[NhomQuyen] ([MaNQ], [TenNQ], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (11, N'Quản Lý Hệ Thống', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[NhomQuyen] ([MaNQ], [TenNQ], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (12, N'Bán Hàng', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[NhomQuyen] ([MaNQ], [TenNQ], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (13, N'test', NULL, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[NhomQuyen] OFF
SET IDENTITY_INSERT [dbo].[PhanQuyen] ON 

INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (1, 1, 1, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (2, 1, 2, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (3, 1, 3, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (4, 1, 4, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (5, 2, 2, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (6, 2, 3, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (7, 2, 4, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (8, 3, 1, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (9, 3, 2, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (10, 3, 3, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (11, 3, 4, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (12, 4, 2, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (13, 4, 3, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (14, 4, 4, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (15, 5, 1, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (16, 5, 2, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (17, 5, 3, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (18, 5, 4, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (19, 6, 5, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (20, 7, 1, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (21, 7, 2, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (22, 7, 3, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (23, 7, 4, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (24, 8, 5, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (25, 9, 1, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (26, 9, 2, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (27, 9, 3, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (28, 9, 4, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (29, 10, 1, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (30, 10, 2, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (31, 10, 3, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (32, 10, 4, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (33, 11, 6, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (34, 11, 7, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (35, 11, 8, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (36, 12, 9, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (37, 12, 10, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[PhanQuyen] ([MaPQ], [MaNQ], [MaTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (38, 12, 11, NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
SET IDENTITY_INSERT [dbo].[PhanQuyen] OFF
INSERT [dbo].[SanPham] ([SKU], [ISBN], [TenSP], [MaNCC], [MaHT], [MaTL], [NgonNgu], [PhienBan], [SoLuongTon], [TonToiThieu], [DonViTinh], [GiaBan], [DanhGia], [MoTa], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (N'8934974150510', N'9786041076945', N'Trên Đường Băng', N'NCC000002', 2, 3, N'Tiếng Việt', N'13', 150, 50, N'quyển', CAST(80000 AS Decimal(18, 0)), 75, NULL, CAST(N'2021-11-02 11:11:01.000' AS DateTime), NULL, 1)
INSERT [dbo].[SanPham] ([SKU], [ISBN], [TenSP], [MaNCC], [MaHT], [MaTL], [NgonNgu], [PhienBan], [SoLuongTon], [TonToiThieu], [DonViTinh], [GiaBan], [DanhGia], [MoTa], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (N'8935235212022', N'9782221113127', N'Người Trộm Bóng', N'NCC000001', 1, 1, N'Tiếng Việt', N'7', 51, 50, N'quyển', CAST(78000 AS Decimal(18, 0)), 80, NULL, CAST(N'2021-11-02 11:11:00.000' AS DateTime), NULL, 1)
SET IDENTITY_INSERT [dbo].[TacGia] ON 

INSERT [dbo].[TacGia] ([MaTG], [TenTG], [HienThi]) VALUES (1, N'Nguyễn Nhật Ánh', 1)
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [HienThi]) VALUES (2, N'Gào', 1)
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [HienThi]) VALUES (3, N'Gari', 1)
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [HienThi]) VALUES (4, N'Minh Mẫn', 1)
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [HienThi]) VALUES (5, N'Marc Levy', 1)
SET IDENTITY_INSERT [dbo].[TacGia] OFF
SET IDENTITY_INSERT [dbo].[TaiKhoan_KH] ON 

INSERT [dbo].[TaiKhoan_KH] ([MaTK], [TenTK], [MatKhau], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (1, N'KH01', N'user123', CAST(N'2021-10-22 10:20:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[TaiKhoan_KH] ([MaTK], [TenTK], [MatKhau], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (2, N'KH02', N'user123', CAST(N'2021-10-25 16:15:00.000' AS DateTime), NULL, 1)
SET IDENTITY_INSERT [dbo].[TaiKhoan_KH] OFF
SET IDENTITY_INSERT [dbo].[TaiKhoan_NV] ON 

INSERT [dbo].[TaiKhoan_NV] ([MaTK], [TenTK], [MatKhau], [GoiYMatKhau], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (1, N'user1', N'user123', N'GoiY', CAST(N'2021-11-02 15:15:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[TaiKhoan_NV] ([MaTK], [TenTK], [MatKhau], [GoiYMatKhau], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (2, N'admin1', N'admin123', N'GoiYQuanLy', CAST(N'2021-11-02 15:15:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[TaiKhoan_NV] ([MaTK], [TenTK], [MatKhau], [GoiYMatKhau], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (3, N'sudo', N'su123456', N'superuser', CAST(N'2021-11-02 16:00:00.000' AS DateTime), NULL, 1)
SET IDENTITY_INSERT [dbo].[TaiKhoan_NV] OFF
SET IDENTITY_INSERT [dbo].[ThaoTac] ON 

INSERT [dbo].[ThaoTac] ([MaTT], [TenTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (1, N'Xem Danh Sách', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[ThaoTac] ([MaTT], [TenTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (2, N'Thêm', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[ThaoTac] ([MaTT], [TenTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (3, N'Sửa', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[ThaoTac] ([MaTT], [TenTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (4, N'Xóa', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[ThaoTac] ([MaTT], [TenTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (5, N'Ngừng Hoạt Động', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[ThaoTac] ([MaTT], [TenTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (6, N'Xem Lích Sử Thao Tác', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[ThaoTac] ([MaTT], [TenTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (7, N'Sao Lưu Dữ Liệu', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[ThaoTac] ([MaTT], [TenTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (8, N'Phục Hồi Dữ Liệu', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[ThaoTac] ([MaTT], [TenTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (9, N'Đặt Hàng', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[ThaoTac] ([MaTT], [TenTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (10, N'Xuất Hóa Đơn', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[ThaoTac] ([MaTT], [TenTT], [GhiChu], [NgayTao], [NgayCapNhat], [HienThi]) VALUES (11, N'Xem Lịch Sử Hóa Đơn', NULL, CAST(N'2021-11-02 00:00:00.000' AS DateTime), NULL, 1)
SET IDENTITY_INSERT [dbo].[ThaoTac] OFF
SET IDENTITY_INSERT [dbo].[TheLoai] ON 

INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (1, N'Tiểu Thuyết', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (2, N'Truyện Ngắn - Tản Văn', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (3, N'Light Novel', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (4, N'Ngôn Tình - Kiếm Hiệp', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (5, N'Truyện Trinh Thám', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (6, N'Tác Phẩm Kinh Điển', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (7, N'Huyền Bí - Giả Tưởng - Kinh Dị', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (8, N'Phóng Sự - Ký Sự - Phê Bình Văn Học', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (9, N'Tác Giả - Tác Phẩm', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (10, N'Hành Động - Phiêu Lưu', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (11, N'Truyện Cười - Châm Biếm- Trào Phúng', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (12, N'Truyện Ngụ Ngôn', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (13, N'Thơ - Văn học dân gian - Cổ tích', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (14, N'Quản Trị - Lãnh Đạo', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (15, N'Nhân Vật - Bài Học Kinh Doanh', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (16, N'Marketing - Bán Hàng', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (17, N'Phân Tích Kinh Tế', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (18, N'Khởi Nghiệp - Làm Giàu', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (19, N'Tài Chính - Ngân Hàng', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (20, N'Chứng Khoán - Bất Động Sản - Đầu Tư', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (21, N'Nhân Sự - Việc Làm', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (22, N'Kế Toán - Kiểm Toán - Thuế', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (23, N'Tâm Lý - Kỹ năng sống', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (24, N'Board Game Các Loại', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (25, N'Card Game', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (26, N'Rút Gỗ', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (27, N'Đồ Chơi Nấu Ăn', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (28, N'Đồ Chơi Ảo Thuật', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (29, N'Hóa Trang', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (30, N'Ukulele', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (31, N'Harmonica', NULL, 1)
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [GhiChu], [HienThi]) VALUES (32, N'Kalimba', NULL, 1)
SET IDENTITY_INSERT [dbo].[TheLoai] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NhanVien_CMND_CCCD]    Script Date: 02/11/2021 10:05:42 CH ******/
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [UQ_NhanVien_CMND_CCCD] UNIQUE NONCLUSTERED 
(
	[CMND_CCCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_SanPham_ISBN]    Script Date: 02/11/2021 10:05:42 CH ******/
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [UQ_SanPham_ISBN] UNIQUE NONCLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
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
