USE [Gos]
GO
/****** Object:  Table [dbo].[Gostnomer]    Script Date: 05.06.2022 23:20:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gostnomer](
	[IdGost] [int] NOT NULL,
	[Numbernomer] [nvarchar](50) NULL,
	[Numberseats] [nvarchar](50) NULL,
	[Numberrooms] [nvarchar](50) NULL,
	[Bathroom] [nvarchar](50) NULL,
	[Equipment] [nvarchar](50) NULL,
	[Img] [nvarchar](50) NULL,
 CONSTRAINT [PK_Gostnomer] PRIMARY KEY CLUSTERED 
(
	[IdGost] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guestc]    Script Date: 05.06.2022 23:20:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guestc](
	[IdGuestc] [int] NOT NULL,
	[NumberPassport] [nchar](10) NULL,
	[NumberSeria] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[Fetherland] [nvarchar](50) NULL,
	[Birthday] [date] NULL,
	[Adress] [nchar](10) NULL,
	[Goal] [nvarchar](50) NULL,
	[Login] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Guestc] PRIMARY KEY CLUSTERED 
(
	[IdGuestc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 05.06.2022 23:20:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[IdSer] [int] NOT NULL,
	[Sefes] [nvarchar](50) NULL,
	[Cost] [nvarchar](50) NULL,
	[TimeServices] [nvarchar](50) NOT NULL,
	[Numberofvisits] [nvarchar](50) NULL,
	[Img] [nvarchar](50) NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[IdSer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zacebece]    Script Date: 05.06.2022 23:20:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zacebece](
	[Id] [int] NOT NULL,
	[NumberPassport] [nvarchar](50) NULL,
	[Numbernomer] [nvarchar](50) NULL,
	[Zacelenie] [date] NULL,
	[Becelenie] [date] NULL,
	[IdGost] [nvarchar](50) NULL,
	[IdGuestc] [nchar](10) NULL,
 CONSTRAINT [PK_Zacebece] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Zacebece]  WITH CHECK ADD  CONSTRAINT [FK_Zacebece_Gostnomer] FOREIGN KEY([Id])
REFERENCES [dbo].[Gostnomer] ([IdGost])
GO
ALTER TABLE [dbo].[Zacebece] CHECK CONSTRAINT [FK_Zacebece_Gostnomer]
GO
ALTER TABLE [dbo].[Zacebece]  WITH CHECK ADD  CONSTRAINT [FK_Zacebece_Guestc] FOREIGN KEY([Id])
REFERENCES [dbo].[Guestc] ([IdGuestc])
GO
ALTER TABLE [dbo].[Zacebece] CHECK CONSTRAINT [FK_Zacebece_Guestc]
GO
ALTER TABLE [dbo].[Zacebece]  WITH CHECK ADD  CONSTRAINT [FK_Zacebece_Services] FOREIGN KEY([Id])
REFERENCES [dbo].[Services] ([IdSer])
GO
ALTER TABLE [dbo].[Zacebece] CHECK CONSTRAINT [FK_Zacebece_Services]
GO
