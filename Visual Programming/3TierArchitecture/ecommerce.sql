USE [master]
GO
/****** Object:  Database [ecommerce]    Script Date: 10/16/2021 7:27:35 PM ******/
CREATE DATABASE [ecommerce]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ecommerce', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ecommerce.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ecommerce_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ecommerce_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ecommerce] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ecommerce].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ecommerce] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ecommerce] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ecommerce] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ecommerce] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ecommerce] SET ARITHABORT OFF 
GO
ALTER DATABASE [ecommerce] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ecommerce] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ecommerce] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ecommerce] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ecommerce] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ecommerce] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ecommerce] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ecommerce] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ecommerce] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ecommerce] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ecommerce] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ecommerce] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ecommerce] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ecommerce] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ecommerce] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ecommerce] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ecommerce] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ecommerce] SET RECOVERY FULL 
GO
ALTER DATABASE [ecommerce] SET  MULTI_USER 
GO
ALTER DATABASE [ecommerce] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ecommerce] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ecommerce] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ecommerce] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ecommerce] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ecommerce] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ecommerce', N'ON'
GO
ALTER DATABASE [ecommerce] SET QUERY_STORE = OFF
GO
USE [ecommerce]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 10/16/2021 7:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](10) NOT NULL,
	[email] [nchar](10) NOT NULL,
	[cnic] [nchar](10) NOT NULL,
	[address] [nchar](10) NOT NULL,
	[phone] [nchar](10) NOT NULL,
	[gender] [nchar](10) NOT NULL,
	[city] [nchar](10) NOT NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 10/16/2021 7:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](10) NOT NULL,
	[price] [nchar](10) NOT NULL,
	[stock] [nchar](10) NOT NULL,
	[vendor] [nchar](10) NOT NULL,
	[description] [nchar](10) NOT NULL,
	[category] [nchar](10) NOT NULL,
	[status] [nchar](10) NOT NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[supplier]    Script Date: 10/16/2021 7:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[supplier](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](10) NOT NULL,
	[cnic] [nchar](10) NOT NULL,
	[phone] [nchar](10) NOT NULL,
	[address] [nchar](10) NOT NULL,
	[email] [nchar](10) NOT NULL,
 CONSTRAINT [PK_supplier] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[product] ON 

INSERT [dbo].[product] ([id], [name], [price], [stock], [vendor], [description], [category], [status]) VALUES (3, N'Joggers   ', N'$223      ', N'21        ', N'Nike      ', N'Durable   ', N'Shoes     ', N'Available ')
INSERT [dbo].[product] ([id], [name], [price], [stock], [vendor], [description], [category], [status]) VALUES (4, N'Kajal     ', N'$21       ', N'45        ', N'Olivia    ', N'Best      ', N'Makeup    ', N'Available ')
INSERT [dbo].[product] ([id], [name], [price], [stock], [vendor], [description], [category], [status]) VALUES (5, N'Cerilac   ', N'$7        ', N'33        ', N'Nestle    ', N'Best      ', N'Food      ', N'Available ')
SET IDENTITY_INSERT [dbo].[product] OFF
GO
USE [master]
GO
ALTER DATABASE [ecommerce] SET  READ_WRITE 
GO
