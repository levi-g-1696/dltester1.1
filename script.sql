USE [master]
GO
/****** Object:  Database [DL_Tester]    Script Date: 5/7/2022 9:31:00 PM ******/
CREATE DATABASE [DL_Tester]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DL_Tester', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DL_Tester.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DL_Tester_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DL_Tester_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DL_Tester] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DL_Tester].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DL_Tester] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DL_Tester] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DL_Tester] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DL_Tester] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DL_Tester] SET ARITHABORT OFF 
GO
ALTER DATABASE [DL_Tester] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DL_Tester] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DL_Tester] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DL_Tester] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DL_Tester] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DL_Tester] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DL_Tester] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DL_Tester] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DL_Tester] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DL_Tester] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DL_Tester] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DL_Tester] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DL_Tester] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DL_Tester] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DL_Tester] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DL_Tester] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DL_Tester] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DL_Tester] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DL_Tester] SET  MULTI_USER 
GO
ALTER DATABASE [DL_Tester] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DL_Tester] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DL_Tester] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DL_Tester] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DL_Tester] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DL_Tester] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DL_Tester] SET QUERY_STORE = OFF
GO
USE [DL_Tester]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/7/2022 9:31:01 PM ******/
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
/****** Object:  Table [dbo].[DataScheduals]    Script Date: 5/7/2022 9:31:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DataScheduals](
	[SchedID] [int] IDENTITY(1001,1) NOT NULL,
	[SessionID] [int] NULL,
	[IsSent] [bit] NULL,
	[WasErrorOnSending] [bit] NULL,
	[RepeatCounter] [int] NULL,
	[Time] [datetime] NOT NULL,
	[monitorsVal] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_DataScheduals] PRIMARY KEY CLUSTERED 
(
	[SchedID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Destinations]    Script Date: 5/7/2022 9:31:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Destinations](
	[DestinationID] [int] IDENTITY(300,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[ProtocolType] [nchar](10) NULL,
	[Port] [int] NOT NULL,
	[SrvUser] [nvarchar](20) NULL,
	[SrvPassword] [nvarchar](30) NULL,
	[Protocolid] [int] NULL,
	[IPaddress] [nvarchar](20) NULL,
	[VirtualPath] [nvarchar](80) NULL,
 CONSTRAINT [PK_Destinations] PRIMARY KEY CLUSTERED 
(
	[DestinationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonitorLists]    Script Date: 5/7/2022 9:31:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonitorLists](
	[MonListID] [int] IDENTITY(100,1) NOT NULL,
	[Name] [nvarchar](25) NOT NULL,
	[MonitorNames] [nvarchar](max) NULL,
 CONSTRAINT [PK_MonitorLists] PRIMARY KEY CLUSTERED 
(
	[MonListID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OutputTypes]    Script Date: 5/7/2022 9:31:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OutputTypes](
	[OutputTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_OutputTypes] PRIMARY KEY CLUSTERED 
(
	[OutputTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sessions]    Script Date: 5/7/2022 9:31:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sessions](
	[SessionID] [int] IDENTITY(5000,1) NOT NULL,
	[Name] [nvarchar](25) NOT NULL,
	[OutputTypeID] [int] NULL,
	[CreationDate] [datetime] NULL,
	[ExpirationDate] [datetime] NULL,
	[IsEnable] [bit] NULL,
	[HasConfirmation] [bit] NULL,
	[MonitorListID] [int] NULL,
	[Repeat] [int] NULL,
	[Pause] [float] NULL,
	[TimingBase] [int] NULL,
	[StartTime] [datetime] NULL,
	[UserID] [int] NULL,
	[StartOnEnable] [bit] NULL,
	[SpecHeaderID] [int] NULL,
	[ValTimesID] [int] NULL,
	[DestinationID] [int] NULL,
 CONSTRAINT [PK_Sessions] PRIMARY KEY CLUSTERED 
(
	[SessionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SpecialHeaders]    Script Date: 5/7/2022 9:31:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpecialHeaders](
	[SpecHeaderID] [int] NOT NULL,
	[Name] [nchar](20) NULL,
	[Line1] [nvarchar](200) NULL,
	[Line2] [nvarchar](200) NULL,
	[Line3] [nvarchar](200) NULL,
	[Line4] [nvarchar](200) NULL,
	[Line5] [nvarchar](200) NULL,
	[Line6] [nvarchar](200) NULL,
 CONSTRAINT [PK_SpecialHeaders] PRIMARY KEY CLUSTERED 
(
	[SpecHeaderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 5/7/2022 9:31:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] NOT NULL,
	[UserName] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](30) NOT NULL,
	[ExpirationDate] [datetime] NULL,
	[CreationDate] [datetime] NULL,
	[IsAdmin] [bit] NOT NULL,
	[IsEnable] [bit] NOT NULL,
 CONSTRAINT [PK_users_1] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ValuesTimes]    Script Date: 5/7/2022 9:31:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ValuesTimes](
	[ValTimesID] [int] IDENTITY(1000,1) NOT NULL,
	[Name] [nvarchar](25) NULL,
	[DuringTime] [float] NULL,
	[MonFrom] [nvarchar](250) NULL,
	[MonTo] [nvarchar](250) NULL,
	[MonListID] [int] NULL,
	[MonNames] [nvarchar](250) NULL,
 CONSTRAINT [PK_ValuesTimes_1] PRIMARY KEY CLUSTERED 
(
	[ValTimesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Sessions]  WITH CHECK ADD  CONSTRAINT [FK_Sessions_Destinations] FOREIGN KEY([DestinationID])
REFERENCES [dbo].[Destinations] ([DestinationID])
GO
ALTER TABLE [dbo].[Sessions] CHECK CONSTRAINT [FK_Sessions_Destinations]
GO
ALTER TABLE [dbo].[Sessions]  WITH CHECK ADD  CONSTRAINT [FK_Sessions_MonitorLists] FOREIGN KEY([MonitorListID])
REFERENCES [dbo].[MonitorLists] ([MonListID])
GO
ALTER TABLE [dbo].[Sessions] CHECK CONSTRAINT [FK_Sessions_MonitorLists]
GO
ALTER TABLE [dbo].[Sessions]  WITH CHECK ADD  CONSTRAINT [FK_Sessions_OutputTypes] FOREIGN KEY([OutputTypeID])
REFERENCES [dbo].[OutputTypes] ([OutputTypeID])
GO
ALTER TABLE [dbo].[Sessions] CHECK CONSTRAINT [FK_Sessions_OutputTypes]
GO
ALTER TABLE [dbo].[Sessions]  WITH CHECK ADD  CONSTRAINT [FK_Sessions_SpecialHeaders] FOREIGN KEY([SpecHeaderID])
REFERENCES [dbo].[SpecialHeaders] ([SpecHeaderID])
GO
ALTER TABLE [dbo].[Sessions] CHECK CONSTRAINT [FK_Sessions_SpecialHeaders]
GO
ALTER TABLE [dbo].[Sessions]  WITH CHECK ADD  CONSTRAINT [FK_Sessions_users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Sessions] CHECK CONSTRAINT [FK_Sessions_users]
GO
ALTER TABLE [dbo].[ValuesTimes]  WITH CHECK ADD  CONSTRAINT [FK_ValuesTimes_MonitorLists] FOREIGN KEY([MonListID])
REFERENCES [dbo].[MonitorLists] ([MonListID])
GO
ALTER TABLE [dbo].[ValuesTimes] CHECK CONSTRAINT [FK_ValuesTimes_MonitorLists]
GO
USE [master]
GO
ALTER DATABASE [DL_Tester] SET  READ_WRITE 
GO
