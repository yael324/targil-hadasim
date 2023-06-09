USE [master]
GO
/****** Object:  Database [HealthFundManagement]    Script Date: 11/05/2023 19:27:46 ******/
CREATE DATABASE [HealthFundManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HealthFundManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\HealthFundManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HealthFundManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\HealthFundManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [HealthFundManagement] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HealthFundManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HealthFundManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HealthFundManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HealthFundManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HealthFundManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HealthFundManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [HealthFundManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HealthFundManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HealthFundManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HealthFundManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HealthFundManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HealthFundManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HealthFundManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HealthFundManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HealthFundManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HealthFundManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HealthFundManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HealthFundManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HealthFundManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HealthFundManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HealthFundManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HealthFundManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HealthFundManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HealthFundManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HealthFundManagement] SET  MULTI_USER 
GO
ALTER DATABASE [HealthFundManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HealthFundManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HealthFundManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HealthFundManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HealthFundManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HealthFundManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [HealthFundManagement] SET QUERY_STORE = ON
GO
ALTER DATABASE [HealthFundManagement] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [HealthFundManagement]
GO
/****** Object:  Table [dbo].[tblEmployees]    Script Date: 11/05/2023 19:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmployees](
	[id] [nvarchar](50) NOT NULL,
	[firstName] [nvarchar](50) NOT NULL,
	[lastName] [nvarchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[dateOfBirth] [datetime] NOT NULL,
	[phone] [nvarchar](50) NULL,
	[mobilePhone] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblPatients] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSicks]    Script Date: 11/05/2023 19:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSicks](
	[id] [nvarchar](50) NOT NULL,
	[datePositiveResult] [datetime2](7) NOT NULL,
	[dateOfRecovery] [datetime2](7) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblVaccinations]    Script Date: 11/05/2023 19:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblVaccinations](
	[id] [nvarchar](50) NOT NULL,
	[dateOfVaccination] [datetime] NOT NULL,
	[vaccineProducer] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tblEmployees] ([id], [firstName], [lastName], [address], [dateOfBirth], [phone], [mobilePhone]) VALUES (N'1', N'1', N'2', N'string', CAST(N'2023-05-11T11:57:18.287' AS DateTime), N'string', N'string')
INSERT [dbo].[tblEmployees] ([id], [firstName], [lastName], [address], [dateOfBirth], [phone], [mobilePhone]) VALUES (N'207485873', N'tal', N'levi', N'harimon street 2 ', CAST(N'1994-08-10T15:42:20.490' AS DateTime), N'6587878', N'0528968857')
INSERT [dbo].[tblEmployees] ([id], [firstName], [lastName], [address], [dateOfBirth], [phone], [mobilePhone]) VALUES (N'324858696', N'yael', N'rot', N'hateena street 80', CAST(N'1973-12-11T15:48:16.077' AS DateTime), N'5714545', N'0583258849')
INSERT [dbo].[tblEmployees] ([id], [firstName], [lastName], [address], [dateOfBirth], [phone], [mobilePhone]) VALUES (N'325878451', N'chaya', N'cohen', N'Jaffa Street in Jerusalem', CAST(N'2000-02-11T13:41:26.050' AS DateTime), N'5711859', N'0528759969')
INSERT [dbo].[tblEmployees] ([id], [firstName], [lastName], [address], [dateOfBirth], [phone], [mobilePhone]) VALUES (N'77777777', N'e', N'e', N'er', CAST(N'2023-05-11T11:33:40.537' AS DateTime), N'3232323', N'2323232323')
INSERT [dbo].[tblEmployees] ([id], [firstName], [lastName], [address], [dateOfBirth], [phone], [mobilePhone]) VALUES (N'string', N'string', N'string', N'string', CAST(N'2023-05-11T10:41:18.473' AS DateTime), N'string', N'string')
GO
INSERT [dbo].[tblSicks] ([id], [datePositiveResult], [dateOfRecovery]) VALUES (N'325878451', CAST(N'2021-05-11T13:43:11.8270000' AS DateTime2), CAST(N'2021-05-21T13:43:11.8270000' AS DateTime2))
INSERT [dbo].[tblSicks] ([id], [datePositiveResult], [dateOfRecovery]) VALUES (N'207485873', CAST(N'2020-11-11T15:51:41.2570000' AS DateTime2), CAST(N'2020-11-21T15:51:41.2570000' AS DateTime2))
GO
INSERT [dbo].[tblVaccinations] ([id], [dateOfVaccination], [vaccineProducer]) VALUES (N'11414444', CAST(N'2023-05-11T13:38:58.937' AS DateTime), N'string')
INSERT [dbo].[tblVaccinations] ([id], [dateOfVaccination], [vaccineProducer]) VALUES (N'325878451', CAST(N'2020-02-11T13:44:58.687' AS DateTime), N'Pfizer')
INSERT [dbo].[tblVaccinations] ([id], [dateOfVaccination], [vaccineProducer]) VALUES (N'207485873', CAST(N'2020-07-13T15:53:23.403' AS DateTime), N'Pfizer')
GO
ALTER TABLE [dbo].[tblSicks]  WITH CHECK ADD  CONSTRAINT [FK_tblSicks_tblEmployees] FOREIGN KEY([id])
REFERENCES [dbo].[tblEmployees] ([id])
GO
ALTER TABLE [dbo].[tblSicks] CHECK CONSTRAINT [FK_tblSicks_tblEmployees]
GO
USE [master]
GO
ALTER DATABASE [HealthFundManagement] SET  READ_WRITE 
GO
