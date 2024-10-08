USE [master]
GO
/****** Object:  Database [mcf]    Script Date: 16/09/2024 12:53:32 ******/
CREATE DATABASE [mcf]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'mcf', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\mcf.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'mcf_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\mcf_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [mcf] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [mcf].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [mcf] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [mcf] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [mcf] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [mcf] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [mcf] SET ARITHABORT OFF 
GO
ALTER DATABASE [mcf] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [mcf] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [mcf] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [mcf] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [mcf] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [mcf] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [mcf] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [mcf] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [mcf] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [mcf] SET  DISABLE_BROKER 
GO
ALTER DATABASE [mcf] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [mcf] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [mcf] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [mcf] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [mcf] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [mcf] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [mcf] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [mcf] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [mcf] SET  MULTI_USER 
GO
ALTER DATABASE [mcf] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [mcf] SET DB_CHAINING OFF 
GO
ALTER DATABASE [mcf] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [mcf] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [mcf] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [mcf] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [mcf] SET QUERY_STORE = ON
GO
ALTER DATABASE [mcf] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [mcf]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 16/09/2024 12:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ms_storage_location]    Script Date: 16/09/2024 12:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ms_storage_location](
	[location_id] [varchar](10) NOT NULL,
	[location_name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ms_storage_location] PRIMARY KEY CLUSTERED 
(
	[location_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ms_user]    Script Date: 16/09/2024 12:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ms_user](
	[user_id] [bigint] IDENTITY(1,1) NOT NULL,
	[user_name] [varchar](20) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[is_active] [bit] NOT NULL,
 CONSTRAINT [PK_ms_user] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tr_bpkb]    Script Date: 16/09/2024 12:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tr_bpkb](
	[agreement_number] [varchar](100) NOT NULL,
	[bpkb_no] [varchar](100) NOT NULL,
	[branch_id] [varchar](10) NOT NULL,
	[bpkb_date] [datetime2](7) NOT NULL,
	[faktur_no] [varchar](100) NOT NULL,
	[faktur_date] [datetime2](7) NOT NULL,
	[location_id] [varchar](10) NOT NULL,
	[police_no] [varchar](20) NOT NULL,
	[bpkb_date_in] [datetime2](7) NOT NULL,
	[created_by] [varchar](20) NOT NULL,
	[created_on] [datetime2](7) NOT NULL,
	[last_updated_by] [varchar](20) NULL,
	[last_updated_on] [datetime2](7) NULL,
 CONSTRAINT [PK_tr_bpkb] PRIMARY KEY CLUSTERED 
(
	[agreement_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_tr_bpkb_location_id]    Script Date: 16/09/2024 12:53:32 ******/
CREATE NONCLUSTERED INDEX [IX_tr_bpkb_location_id] ON [dbo].[tr_bpkb]
(
	[location_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tr_bpkb]  WITH CHECK ADD  CONSTRAINT [FK_tr_bpkb_ms_storage_location_location_id] FOREIGN KEY([location_id])
REFERENCES [dbo].[ms_storage_location] ([location_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tr_bpkb] CHECK CONSTRAINT [FK_tr_bpkb_ms_storage_location_location_id]
GO
USE [master]
GO
ALTER DATABASE [mcf] SET  READ_WRITE 
GO
