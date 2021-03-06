USE [master]
GO

/****** Object:  Database [Clube_informatica]    Script Date: 04/05/2022 01:30:25 ******/
CREATE DATABASE [Clube_informatica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Clube_informatica', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Clube_informatica.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Clube_informatica_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Clube_informatica_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Clube_informatica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Clube_informatica] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Clube_informatica] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Clube_informatica] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Clube_informatica] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Clube_informatica] SET ARITHABORT OFF 
GO

ALTER DATABASE [Clube_informatica] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [Clube_informatica] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Clube_informatica] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Clube_informatica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Clube_informatica] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Clube_informatica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Clube_informatica] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Clube_informatica] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Clube_informatica] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Clube_informatica] SET  ENABLE_BROKER 
GO

ALTER DATABASE [Clube_informatica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Clube_informatica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Clube_informatica] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Clube_informatica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Clube_informatica] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Clube_informatica] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Clube_informatica] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Clube_informatica] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Clube_informatica] SET  MULTI_USER 
GO

ALTER DATABASE [Clube_informatica] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Clube_informatica] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Clube_informatica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Clube_informatica] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Clube_informatica] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Clube_informatica] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [Clube_informatica] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Clube_informatica] SET  READ_WRITE 
GO

