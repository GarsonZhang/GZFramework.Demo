USE [master]
GO

/****** Object:  Database [ClothingPSI_System]    Script Date: 2017-06-19 20:31:54 ******/
CREATE DATABASE [ClothingPSI_System] ON  PRIMARY 
( NAME = N'GZFrameworkSample_System', FILENAME = N'C:\DataBase\ClothingPSI_System.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GZFrameworkSample_System_log', FILENAME = N'C:\DataBase\ClothingPSI_System_log.ldf' , SIZE = 1280KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [ClothingPSI_System] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ClothingPSI_System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ClothingPSI_System] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ClothingPSI_System] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ClothingPSI_System] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ClothingPSI_System] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ClothingPSI_System] SET ARITHABORT OFF 
GO

ALTER DATABASE [ClothingPSI_System] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [ClothingPSI_System] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ClothingPSI_System] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ClothingPSI_System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ClothingPSI_System] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ClothingPSI_System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ClothingPSI_System] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ClothingPSI_System] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ClothingPSI_System] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ClothingPSI_System] SET  DISABLE_BROKER 
GO

ALTER DATABASE [ClothingPSI_System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ClothingPSI_System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ClothingPSI_System] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ClothingPSI_System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ClothingPSI_System] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ClothingPSI_System] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [ClothingPSI_System] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ClothingPSI_System] SET RECOVERY FULL 
GO

ALTER DATABASE [ClothingPSI_System] SET  MULTI_USER 
GO

ALTER DATABASE [ClothingPSI_System] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ClothingPSI_System] SET DB_CHAINING OFF 
GO

USE [ClothingPSI_System]
GO

EXEC [ClothingPSI_System].sys.sp_addextendedproperty @name=N'SQLSourceControl Database Revision', @value=8 
GO

EXEC [ClothingPSI_System].sys.sp_addextendedproperty @name=N'SQLSourceControl Scripts Location', @value=N'<?xml version="1.0" encoding="utf-16" standalone="yes"?>
<ISOCCompareLocation version="1" type="SvnLocation">
  <RepositoryUrl>https://180.166.238.221:2443/svn/DB_GZFrameworkSample_Data/systemDB/</RepositoryUrl>
</ISOCCompareLocation>' 
GO

USE [master]
GO

ALTER DATABASE [ClothingPSI_System] SET  READ_WRITE 
GO


