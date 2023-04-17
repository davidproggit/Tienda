USE [master]
GO
/****** Object:  Database [TiendaUPE]    Script Date: 15/04/2023 17:00:40 ******/
CREATE DATABASE [TiendaUPE]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TiendaUPE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\TiendaUPE.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TiendaUPE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\TiendaUPE_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [TiendaUPE] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TiendaUPE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TiendaUPE] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TiendaUPE] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TiendaUPE] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TiendaUPE] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TiendaUPE] SET ARITHABORT OFF 
GO
ALTER DATABASE [TiendaUPE] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TiendaUPE] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TiendaUPE] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TiendaUPE] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TiendaUPE] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TiendaUPE] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TiendaUPE] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TiendaUPE] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TiendaUPE] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TiendaUPE] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TiendaUPE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TiendaUPE] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TiendaUPE] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TiendaUPE] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TiendaUPE] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TiendaUPE] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TiendaUPE] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TiendaUPE] SET RECOVERY FULL 
GO
ALTER DATABASE [TiendaUPE] SET  MULTI_USER 
GO
ALTER DATABASE [TiendaUPE] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TiendaUPE] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TiendaUPE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TiendaUPE] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TiendaUPE] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TiendaUPE] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TiendaUPE', N'ON'
GO
ALTER DATABASE [TiendaUPE] SET QUERY_STORE = ON
GO
ALTER DATABASE [TiendaUPE] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TiendaUPE]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 15/04/2023 17:00:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NombreLogin] [nvarchar](100) NOT NULL,
	[Clave] [nvarchar](100) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Apellido] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Cargo] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [TiendaUPE] SET  READ_WRITE 
GO
