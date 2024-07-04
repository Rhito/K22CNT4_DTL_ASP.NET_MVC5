USE [DtlK22CNT4Lesson11Db]
GO
/****** Object:  Table [dbo].[DtlCategory]    Script Date: 7/4/2024 9:49:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DtlCategory](
	[DtlId] [int] IDENTITY(1,1) NOT NULL,
	[DtlCateName] [nvarchar](50) NULL,
	[DtlStatus] [bit] NULL,
 CONSTRAINT [PK_DtlCategory] PRIMARY KEY CLUSTERED 
(
	[DtlId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DtlProduct]    Script Date: 7/4/2024 9:49:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DtlProduct](
	[DtlId2210900038] [nvarchar](50) NOT NULL,
	[DtlProName] [nvarchar](50) NULL,
	[DtlQty] [int] NULL,
	[DtlPrice] [float] NULL,
	[DtlCateId] [int] NULL,
	[DtlActive] [bit] NULL,
 CONSTRAINT [PK_DtlProduct] PRIMARY KEY CLUSTERED 
(
	[DtlId2210900038] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DtlCategory] ON 

INSERT [dbo].[DtlCategory] ([DtlId], [DtlCateName], [DtlStatus]) VALUES (1, N'2210900038', 1)
INSERT [dbo].[DtlCategory] ([DtlId], [DtlCateName], [DtlStatus]) VALUES (2, N'Iphone', 0)
SET IDENTITY_INSERT [dbo].[DtlCategory] OFF
GO
INSERT [dbo].[DtlProduct] ([DtlId2210900038], [DtlProName], [DtlQty], [DtlPrice], [DtlCateId], [DtlActive]) VALUES (N'2210900038', N'Đinh Tiến Lực', 1, 1000000000, 1, 1)
INSERT [dbo].[DtlProduct] ([DtlId2210900038], [DtlProName], [DtlQty], [DtlPrice], [DtlCateId], [DtlActive]) VALUES (N'SMP01', N'Iphone 16pro', 12, 23331213, 2, 1)
GO
ALTER TABLE [dbo].[DtlProduct]  WITH CHECK ADD  CONSTRAINT [FK_DtlProduct_DtlCategory] FOREIGN KEY([DtlCateId])
REFERENCES [dbo].[DtlCategory] ([DtlId])
GO
ALTER TABLE [dbo].[DtlProduct] CHECK CONSTRAINT [FK_DtlProduct_DtlCategory]
GO
