# PortalCustomerManagmentChallange

Başarılı bir şekilde test için aşağıdaki konumdaki SQL URL'in değişmesi gerekmektedir. Bilginize.

PortalCustomerManagmentChallangeDataAccess/Concrete/EntityFramework/Context/SimpleContextDb'de bulunan "Data Source" kısmını kendi bilginize göre güncellemeniz gerekmektedir. SQL tablosu için aşağıdaki scripti kullanabilirsiniz.

Script:

Visual Studip SQL Server Object Explorer

USE [TestDb]
GO

/****** Object: Table [dbo].[Users] Script Date: 13.06.2023 00:41:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (50) NULL,
    [Surname]   NVARCHAR (50) NULL,
    [Email]     NVARCHAR (50) NULL,
    [Password]  NVARCHAR (50) NULL,
    [TCKN]      NVARCHAR (50) NULL,
    [TCKNCheck] BIT           NULL
);



Microsoft SQL Server Management Studio

USE [TestDb]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 13.06.2023 00:41:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[TCKN] [nvarchar](50) NULL,
	[TCKNCheck] [bit] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


