USE [master]
GO
/****** Object:  Database [Strifedb]    Script Date: 2020/08/01 21:32:36 ******/
CREATE DATABASE [Strifedb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Strifedb', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Strifedb.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Strifedb_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Strifedb_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Strifedb] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Strifedb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Strifedb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Strifedb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Strifedb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Strifedb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Strifedb] SET ARITHABORT OFF 
GO
ALTER DATABASE [Strifedb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Strifedb] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Strifedb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Strifedb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Strifedb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Strifedb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Strifedb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Strifedb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Strifedb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Strifedb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Strifedb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Strifedb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Strifedb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Strifedb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Strifedb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Strifedb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Strifedb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Strifedb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Strifedb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Strifedb] SET  MULTI_USER 
GO
ALTER DATABASE [Strifedb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Strifedb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Strifedb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Strifedb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Strifedb]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2020/08/01 21:32:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[Name] [varchar](50) NULL,
	[Surname] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[Unit] [varchar](50) NULL,
	[Street] [varchar](50) NULL,
	[Suburb] [varchar](50) NULL,
	[Province] [varchar](50) NULL,
	[ZipCode] [varchar](50) NULL,
	[Country] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Profile] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [Strifedb] SET  READ_WRITE 
GO
