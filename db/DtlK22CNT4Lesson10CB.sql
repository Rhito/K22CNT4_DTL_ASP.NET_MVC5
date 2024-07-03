USE [DtlK22CNT4Lesson10CB]
GO
/****** Object:  Table [dbo].[DtlAccount]    Script Date: 7/3/2024 2:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DtlAccount](
	[DtlId] [int] IDENTITY(1,1) NOT NULL,
	[DtlUserName] [nvarchar](50) NULL,
	[DtlPassword] [nvarchar](50) NULL,
	[DtlFullName] [nvarchar](50) NULL,
	[DtlEmail] [nvarchar](50) NULL,
	[DtlPhone] [nvarchar](50) NULL,
	[DtlActive] [bit] NULL,
 CONSTRAINT [PK_DtlAccount] PRIMARY KEY CLUSTERED 
(
	[DtlId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DtlAccount] ON 

INSERT [dbo].[DtlAccount] ([DtlId], [DtlUserName], [DtlPassword], [DtlFullName], [DtlEmail], [DtlPhone], [DtlActive]) VALUES (1, N'TienLuc', N'123', N'Đinh Tiến Lực', N'Long@gmail.com', N'038176378', 1)
SET IDENTITY_INSERT [dbo].[DtlAccount] OFF
GO
