USE [master]
GO

/****** Object:  Database [EmployeeManagement]    Script Date: 16-Apr-19 8:26:30 PM ******/
CREATE DATABASE [EmployeeManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Companay', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\Companay.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Companay_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\Companay_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [EmployeeManagement] SET COMPATIBILITY_LEVEL = 130
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EmployeeManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [EmployeeManagement] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [EmployeeManagement] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [EmployeeManagement] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [EmployeeManagement] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [EmployeeManagement] SET ARITHABORT OFF 
GO

ALTER DATABASE [EmployeeManagement] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [EmployeeManagement] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [EmployeeManagement] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [EmployeeManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [EmployeeManagement] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [EmployeeManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [EmployeeManagement] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [EmployeeManagement] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [EmployeeManagement] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [EmployeeManagement] SET  DISABLE_BROKER 
GO

ALTER DATABASE [EmployeeManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [EmployeeManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [EmployeeManagement] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [EmployeeManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [EmployeeManagement] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [EmployeeManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [EmployeeManagement] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [EmployeeManagement] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [EmployeeManagement] SET  MULTI_USER 
GO

ALTER DATABASE [EmployeeManagement] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [EmployeeManagement] SET DB_CHAINING OFF 
GO

ALTER DATABASE [EmployeeManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [EmployeeManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [EmployeeManagement] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [EmployeeManagement] SET QUERY_STORE = OFF
GO

USE [EmployeeManagement]
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE [EmployeeManagement] SET  READ_WRITE 
GO

