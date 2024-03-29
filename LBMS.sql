USE [master]
GO
/****** Object:  Database [LBMS]    Script Date: 8/5/2017 4:56:48 AM ******/
CREATE DATABASE [LBMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LBMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\LBMS.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LBMS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\LBMS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LBMS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LBMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LBMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LBMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LBMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LBMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LBMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [LBMS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LBMS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [LBMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LBMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LBMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LBMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LBMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LBMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LBMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LBMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LBMS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LBMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LBMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LBMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LBMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LBMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LBMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LBMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LBMS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LBMS] SET  MULTI_USER 
GO
ALTER DATABASE [LBMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LBMS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LBMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LBMS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [LBMS]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 8/5/2017 4:56:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Admin](
	[User id] [varchar](50) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Type] [varchar](50) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[User id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Book]    Script Date: 8/5/2017 4:56:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Book](
	[Book ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](max) NOT NULL,
	[Author] [varchar](max) NOT NULL,
	[Publisher] [varchar](50) NULL,
	[ISBN] [varchar](50) NOT NULL,
	[Category] [varchar](50) NOT NULL,
	[Actual Quantity] [int] NOT NULL,
	[Current Quantity] [int] NOT NULL,
	[Shelf no] [varchar](50) NOT NULL,
	[Date Added] [date] NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[Book ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Book_Issue]    Script Date: 8/5/2017 4:56:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Book_Issue](
	[BI No] [int] IDENTITY(1,1) NOT NULL,
	[Member ID] [varchar](50) NOT NULL,
	[Category] [varchar](50) NOT NULL,
	[Title] [varchar](max) NOT NULL,
	[Book ID] [int] NOT NULL,
	[Issued date] [date] NOT NULL,
	[Return date] [date] NOT NULL,
 CONSTRAINT [PK_Book_Issue] PRIMARY KEY CLUSTERED 
(
	[BI No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Book_Return]    Script Date: 8/5/2017 4:56:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Book_Return](
	[BR no] [int] IDENTITY(1,1) NOT NULL,
	[Member ID] [varchar](50) NOT NULL,
	[Book ID] [int] NOT NULL,
	[Issued date] [date] NOT NULL,
	[Return date] [date] NOT NULL,
	[Delay] [int] NULL,
	[Fine] [float] NULL,
 CONSTRAINT [PK_Book_Return] PRIMARY KEY CLUSTERED 
(
	[BR no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Member]    Script Date: 8/5/2017 4:56:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Member](
	[Membership Type] [varchar](50) NOT NULL,
	[Member ID] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Department] [varchar](50) NOT NULL,
	[Address] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Chk] [int] NOT NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[Member ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Admin] ([User id], [Username], [Password], [Email], [Type]) VALUES (N'AD001', N'admin', N'admin', N'admin@gmail.com', N'Admin')
INSERT [dbo].[Admin] ([User id], [Username], [Password], [Email], [Type]) VALUES (N'AD002', N'student', N'student', N'std@istt.edu.bd', N'Member')
INSERT [dbo].[Admin] ([User id], [Username], [Password], [Email], [Type]) VALUES (N'AD003', N'milon', N'123', N'milon@yahoo.com', N'Member')
SET IDENTITY_INSERT [dbo].[Book] ON 

INSERT [dbo].[Book] ([Book ID], [Title], [Author], [Publisher], [ISBN], [Category], [Actual Quantity], [Current Quantity], [Shelf no], [Date Added]) VALUES (1, N'Programming in ANSI C (Sixth Edition)', N'E Balagurusamy', N'Tata McGraw-Hill Education Pvt. Ltd, 2012', N'9781259004612', N'Computer Science', 25, 25, N'C-01', CAST(0x1F3D0B00 AS Date))
INSERT [dbo].[Book] ([Book ID], [Title], [Author], [Publisher], [ISBN], [Category], [Actual Quantity], [Current Quantity], [Shelf no], [Date Added]) VALUES (2, N'Data Structures (Schaum’s Outline Series)', N'Seymour Lipschutz', N'Tata McGraw-Hill Education Pvt. Ltd 0', N'9780070601680', N'Computer Science', 25, 25, N'C-01', CAST(0x1F3D0B00 AS Date))
INSERT [dbo].[Book] ([Book ID], [Title], [Author], [Publisher], [ISBN], [Category], [Actual Quantity], [Current Quantity], [Shelf no], [Date Added]) VALUES (3, N'Fundamentals of Computer Algorithms (Computer software engineering series)', N'Ellis Horowitz, Sartaj Sahni', N'Computer Sci.P., 1984', N'9780914894223', N'Computer Science', 25, 23, N'C-01', CAST(0x1F3D0B00 AS Date))
SET IDENTITY_INSERT [dbo].[Book] OFF
SET IDENTITY_INSERT [dbo].[Book_Issue] ON 

INSERT [dbo].[Book_Issue] ([BI No], [Member ID], [Category], [Title], [Book ID], [Issued date], [Return date]) VALUES (1, N'S001', N'Computer Science', N'Fundamentals of Computer Algorithms (Computer software engineering series)', 3, CAST(0x1F3D0B00 AS Date), CAST(0x263D0B00 AS Date))
INSERT [dbo].[Book_Issue] ([BI No], [Member ID], [Category], [Title], [Book ID], [Issued date], [Return date]) VALUES (2, N'S002', N'Computer Science', N'Fundamentals of Computer Algorithms (Computer software engineering series)', 3, CAST(0x213D0B00 AS Date), CAST(0x283D0B00 AS Date))
SET IDENTITY_INSERT [dbo].[Book_Issue] OFF
INSERT [dbo].[Member] ([Membership Type], [Member ID], [Name], [Department], [Address], [Contact], [Email], [Chk]) VALUES (N'Employee', N'E001', N'Pappu', N'CSE', N'Mirpur-14', N'01684359536', N'', 1)
INSERT [dbo].[Member] ([Membership Type], [Member ID], [Name], [Department], [Address], [Contact], [Email], [Chk]) VALUES (N'Student', N'S001', N'Md. Abdur Rahman', N'CSE', N'Mirpur-14', N'01685456257', N'a.rahman@gmail.com', 0)
INSERT [dbo].[Member] ([Membership Type], [Member ID], [Name], [Department], [Address], [Contact], [Email], [Chk]) VALUES (N'Student', N'S002', N'Salauddin', N'CSE', N'Elephant Road', N'01687589469', N'salauddin@yahoo.com', 0)
INSERT [dbo].[Member] ([Membership Type], [Member ID], [Name], [Department], [Address], [Contact], [Email], [Chk]) VALUES (N'Taecher', N'T001', N'Mamun-ur-Rashid', N'CSE', N'Mirpur-12', N'01710665456', N'mamun_cse@istt.edu.bd', 1)
USE [master]
GO
ALTER DATABASE [LBMS] SET  READ_WRITE 
GO
