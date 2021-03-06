USE [QLTHUVIEN]
GO
/****** Object:  Table [dbo].[tbl_ChiTietPhieuMuon]    Script Date: 01/12/2020 13:34:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ChiTietPhieuMuon](
	[MaPM] [char](10) NOT NULL,
	[MaSach] [char](10) NOT NULL,
	[NgayMuon] [date] NULL,
	[NgayTra] [date] NULL,
	[GhiChu] [nvarchar](200) NULL,
 CONSTRAINT [PK_PhieuMuon] PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_LoaiSach]    Script Date: 01/12/2020 13:34:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_LoaiSach](
	[MaLoai] [char](10) NOT NULL,
	[TenLoai] [nvarchar](100) NULL,
 CONSTRAINT [PK_MaLoai] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_NhanVien]    Script Date: 01/12/2020 13:34:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_NhanVien](
	[MaNV] [char](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[Phai] [nvarchar](10) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [char](11) NULL,
 CONSTRAINT [PK_MaNV] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_PhieuMuon]    Script Date: 01/12/2020 13:34:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PhieuMuon](
	[MaPM] [char](10) NOT NULL,
	[MaSV] [char](10) NOT NULL,
	[MaNV] [char](10) NOT NULL,
 CONSTRAINT [PK_MaPM] PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Sach]    Script Date: 01/12/2020 13:34:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Sach](
	[MaSach] [char](10) NOT NULL,
	[MaLoai] [char](10) NOT NULL,
	[TenSach] [nvarchar](200) NULL,
	[TacGia] [nvarchar](50) NULL,
	[NhaXuatBan] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_MaSach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_SinhVien]    Script Date: 01/12/2020 13:34:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_SinhVien](
	[MaSV] [char](10) NOT NULL,
	[TenDG] [nvarchar](50) NULL,
	[Phai] [nvarchar](10) NULL,
	[NamSinh] [int] NULL,
	[NgayCapThe] [date] NULL,
	[NgayHetHan] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_MaSV] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_TaiKhoan]    Script Date: 01/12/2020 13:34:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_TaiKhoan](
	[User] [nchar](20) NOT NULL,
	[Password] [nchar](20) NOT NULL,
	[email] [nchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_LoaiSach] ([MaLoai], [TenLoai]) VALUES (N'ML001     ', N'Truyện dài')
INSERT [dbo].[tbl_LoaiSach] ([MaLoai], [TenLoai]) VALUES (N'ML002     ', N'Truyện ngắn')
INSERT [dbo].[tbl_LoaiSach] ([MaLoai], [TenLoai]) VALUES (N'ML003     ', N'Khoa học thường thức')
INSERT [dbo].[tbl_LoaiSach] ([MaLoai], [TenLoai]) VALUES (N'ML004     ', N'Giáo trình')
INSERT [dbo].[tbl_LoaiSach] ([MaLoai], [TenLoai]) VALUES (N'ML005     ', N'Tiểu thuyết')
INSERT [dbo].[tbl_LoaiSach] ([MaLoai], [TenLoai]) VALUES (N'ML006     ', N'Thơ')
GO
INSERT [dbo].[tbl_Sach] ([MaSach], [MaLoai], [TenSach], [TacGia], [NhaXuatBan], [SoLuong]) VALUES (N'MS001     ', N'ML001     ', N'Dế Mèn Phiêu Lưu Ký', N'Tô Hoài', N'Kim Đồng', 1)
INSERT [dbo].[tbl_Sach] ([MaSach], [MaLoai], [TenSach], [TacGia], [NhaXuatBan], [SoLuong]) VALUES (N'MS002     ', N'ML002     ', N'Thằng Cuội', N'Dân gian', N'Kim Đồng', 1)
INSERT [dbo].[tbl_Sach] ([MaSach], [MaLoai], [TenSach], [TacGia], [NhaXuatBan], [SoLuong]) VALUES (N'MS003     ', N'ML001     ', N'Tiếng gọi nơi hoang dã', N'Jack London', N'Lao động', 1)
INSERT [dbo].[tbl_Sach] ([MaSach], [MaLoai], [TenSach], [TacGia], [NhaXuatBan], [SoLuong]) VALUES (N'MS004     ', N'ML002     ', N'Chiếc lược ngà', N'Nguyễn Quang Sách', N'Phương Nam Book', 1)
GO
INSERT [dbo].[tbl_TaiKhoan] ([User], [Password], [email]) VALUES (N'dattran2105         ', N'123                 ', N'dat@gmail.com                                     ')
INSERT [dbo].[tbl_TaiKhoan] ([User], [Password], [email]) VALUES (N'dattran22           ', N'123                 ', N'dat@gmail.com                                     ')
INSERT [dbo].[tbl_TaiKhoan] ([User], [Password], [email]) VALUES (N'dattran2206         ', N'2206@               ', N'trantiendat@gmail.com                             ')
GO
ALTER TABLE [dbo].[tbl_ChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_MaPM] FOREIGN KEY([MaPM])
REFERENCES [dbo].[tbl_PhieuMuon] ([MaPM])
GO
ALTER TABLE [dbo].[tbl_ChiTietPhieuMuon] CHECK CONSTRAINT [FK_MaPM]
GO
ALTER TABLE [dbo].[tbl_ChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_MaSach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[tbl_Sach] ([MaSach])
GO
ALTER TABLE [dbo].[tbl_ChiTietPhieuMuon] CHECK CONSTRAINT [FK_MaSach]
GO
ALTER TABLE [dbo].[tbl_PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PhieuMuon_tbl_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tbl_NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tbl_PhieuMuon] CHECK CONSTRAINT [FK_tbl_PhieuMuon_tbl_NhanVien]
GO
ALTER TABLE [dbo].[tbl_PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PhieuMuon_tbl_SinhVien] FOREIGN KEY([MaSV])
REFERENCES [dbo].[tbl_SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[tbl_PhieuMuon] CHECK CONSTRAINT [FK_tbl_PhieuMuon_tbl_SinhVien]
GO
ALTER TABLE [dbo].[tbl_Sach]  WITH CHECK ADD  CONSTRAINT [FK_MaLoai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[tbl_LoaiSach] ([MaLoai])
GO
ALTER TABLE [dbo].[tbl_Sach] CHECK CONSTRAINT [FK_MaLoai]
GO
ALTER TABLE [dbo].[tbl_ChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [Chk_NgayMuon] CHECK  (([NgayTra]>[NgayMuon]))
GO
ALTER TABLE [dbo].[tbl_ChiTietPhieuMuon] CHECK CONSTRAINT [Chk_NgayMuon]
GO
ALTER TABLE [dbo].[tbl_SinhVien]  WITH CHECK ADD  CONSTRAINT [Chk_Ngay] CHECK  (([NgayHetHan]>[NgayCapThe]))
GO
ALTER TABLE [dbo].[tbl_SinhVien] CHECK CONSTRAINT [Chk_Ngay]
GO
