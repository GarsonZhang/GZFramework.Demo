USE [master]
GO

/****** Object:  Database [ClothingPSI_Business]    Script Date: 2017-06-19 20:32:22 ******/
CREATE DATABASE [ClothingPSI_Business] ON  PRIMARY 
( NAME = N'GZFrameworkSample_Data', FILENAME = N'C:\DataBase\ClothingPSI_Business.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GZFrameworkSample_Data_log', FILENAME = N'C:\DataBase\ClothingPSI_Business_log.ldf' , SIZE = 8384KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [ClothingPSI_Business] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ClothingPSI_Business].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ClothingPSI_Business] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ClothingPSI_Business] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ClothingPSI_Business] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ClothingPSI_Business] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ClothingPSI_Business] SET ARITHABORT OFF 
GO

ALTER DATABASE [ClothingPSI_Business] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [ClothingPSI_Business] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ClothingPSI_Business] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ClothingPSI_Business] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ClothingPSI_Business] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ClothingPSI_Business] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ClothingPSI_Business] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ClothingPSI_Business] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ClothingPSI_Business] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ClothingPSI_Business] SET  DISABLE_BROKER 
GO

ALTER DATABASE [ClothingPSI_Business] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ClothingPSI_Business] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ClothingPSI_Business] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ClothingPSI_Business] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ClothingPSI_Business] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ClothingPSI_Business] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [ClothingPSI_Business] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ClothingPSI_Business] SET RECOVERY FULL 
GO

ALTER DATABASE [ClothingPSI_Business] SET  MULTI_USER 
GO

ALTER DATABASE [ClothingPSI_Business] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ClothingPSI_Business] SET DB_CHAINING OFF 
GO

USE [ClothingPSI_Business]
GO

EXEC [ClothingPSI_Business].sys.sp_addextendedproperty @name=N'SQLSourceControl Database Revision', @value=9 
GO

EXEC [ClothingPSI_Business].sys.sp_addextendedproperty @name=N'SQLSourceControl Scripts Location', @value=N'<?xml version="1.0" encoding="utf-16" standalone="yes"?>
<ISOCCompareLocation version="1" type="SvnLocation">
  <RepositoryUrl>https://180.166.238.221:2443/svn/DB_GZFrameworkSample_Data/DataDB/</RepositoryUrl>
</ISOCCompareLocation>' 
GO

USE [master]
GO

ALTER DATABASE [ClothingPSI_Business] SET  READ_WRITE 
GO


