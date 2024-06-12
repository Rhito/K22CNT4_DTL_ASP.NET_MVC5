USE [DtlK22CNT4Lesson07Db]
GO
/****** Object:  Table [dbo].[dtlKhoa]    Script Date: 6/12/2024 2:43:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtlKhoa](
	[dtlMaKH] [nchar](10) NOT NULL,
	[dtlTenKhoa] [nvarchar](50) NULL,
	[dtlTrangThai] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dtlSinhVien]    Script Date: 6/12/2024 2:43:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtlSinhVien](
	[dtkMaSV] [nchar](10) NOT NULL,
	[DtlHoSV] [nvarchar](50) NULL,
	[DtlTenSV] [nvarchar](50) NULL,
	[DtlPhai] [bit] NULL,
	[DtlEmail] [nvarchar](50) NULL,
	[DtlPhone] [nvarchar](50) NULL,
	[DtlMaKH] [nchar](10) NULL,
	[DtlTrangThai] [bit] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[dtlKhoa] ([dtlMaKH], [dtlTenKhoa], [dtlTrangThai]) VALUES (N'K22CNT4   ', N'Công nghệ thông tin 4', 1)
GO
INSERT [dbo].[dtlSinhVien] ([dtkMaSV], [DtlHoSV], [DtlTenSV], [DtlPhai], [DtlEmail], [DtlPhone], [DtlMaKH], [DtlTrangThai]) VALUES (N'2210900038', N'Đinh Tiến', N'Lực', 1, N'Lasnguyen06@gmail.com', N'0372657743', N'K22CNT4   ', 1)
GO
