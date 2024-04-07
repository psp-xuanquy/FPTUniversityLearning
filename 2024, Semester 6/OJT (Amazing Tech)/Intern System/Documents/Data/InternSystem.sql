USE [master]
GO
/****** Object:  Database [Intern-System]    Script Date: 1/8/2024 10:55:38 AM ******/
CREATE DATABASE [Intern-System]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Intern-System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Intern-System.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Intern-System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Intern-System_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Intern-System] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Intern-System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Intern-System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Intern-System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Intern-System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Intern-System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Intern-System] SET ARITHABORT OFF 
GO
ALTER DATABASE [Intern-System] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Intern-System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Intern-System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Intern-System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Intern-System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Intern-System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Intern-System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Intern-System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Intern-System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Intern-System] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Intern-System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Intern-System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Intern-System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Intern-System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Intern-System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Intern-System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Intern-System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Intern-System] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Intern-System] SET  MULTI_USER 
GO
ALTER DATABASE [Intern-System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Intern-System] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Intern-System] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Intern-System] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Intern-System] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Intern-System] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Intern-System] SET QUERY_STORE = ON
GO
ALTER DATABASE [Intern-System] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Intern-System]
GO
/****** Object:  Table [dbo].[CongNgheDuAn]    Script Date: 1/8/2024 10:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongNgheDuAn](
	[Id] [nvarchar](450) NOT NULL,
	[IdDuAn] [nvarchar](450) NOT NULL,
	[TenCongNghe] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[DeletedBy] [nvarchar](max) NULL,
	[CreatedTime] [datetimeoffset](7) NOT NULL,
	[LastUpdatedTime] [datetimeoffset](7) NOT NULL,
	[DeletedTime] [datetimeoffset](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CvComment]    Script Date: 1/8/2024 10:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CvComment](
	[Id] [nvarchar](450) NOT NULL,
	[NguoiDuocComment] [nvarchar](450) NOT NULL,
	[NguoiComment] [nvarchar](450) NOT NULL,
	[Comment] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[DeletedBy] [nvarchar](max) NULL,
	[CreatedTime] [datetimeoffset](7) NOT NULL,
	[LastUpdatedTime] [datetimeoffset](7) NOT NULL,
	[DeletedTime] [datetimeoffset](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dashboard]    Script Date: 1/8/2024 10:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dashboard](
	[Id] [nvarchar](450) NOT NULL,
	[ReceivedCV] [int] NOT NULL,
	[Interviewed] [int] NOT NULL,
	[Passed] [int] NOT NULL,
	[Interning] [int] NOT NULL,
	[Interned] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DuAn]    Script Date: 1/8/2024 10:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DuAn](
	[Id] [nvarchar](450) NOT NULL,
	[Ten] [nvarchar](max) NULL,
	[Leader] [nvarchar](450) NULL,
	[ThoiGianBatDau] [datetimeoffset](7) NULL,
	[ThoiGianKetThuc] [datetimeoffset](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[DeletedBy] [nvarchar](max) NULL,
	[CreatedTime] [datetimeoffset](7) NOT NULL,
	[LastUpdatedTime] [datetimeoffset](7) NOT NULL,
	[DeletedTime] [datetimeoffset](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InternDuAn]    Script Date: 1/8/2024 10:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InternDuAn](
	[Id] [nvarchar](450) NOT NULL,
	[IdIntern] [nvarchar](450) NOT NULL,
	[IdDuAn] [nvarchar](450) NOT NULL,
	[ViTri] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[DeletedBy] [nvarchar](max) NULL,
	[CreatedTime] [datetimeoffset](7) NOT NULL,
	[LastUpdatedTime] [datetimeoffset](7) NOT NULL,
	[DeletedTime] [datetimeoffset](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InternInfo]    Script Date: 1/8/2024 10:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InternInfo](
	[Id] [nvarchar](450) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[HoVaTen] [nvarchar](450) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[MSSV] [nvarchar](450) NOT NULL,
	[EmailTruong] [nvarchar](450) NOT NULL,
	[EmailCaNhan] [nvarchar](450) NOT NULL,
	[Sdt] [nvarchar](450) NOT NULL,
	[DiaChi] [nvarchar](450) NOT NULL,
	[SdtNguoiThan] [nvarchar](450) NOT NULL,
	[GPA] [decimal](18, 0) NOT NULL,
	[TrinhDoTiengAnh] [nvarchar](450) NOT NULL,
	[ChungChi] [nvarchar](450) NOT NULL,
	[GioiThieuBanThan] [nvarchar](450) NOT NULL,
	[LinkFacebook] [nvarchar](450) NOT NULL,
	[LinkCV] [nvarchar](max) NOT NULL,
	[NganhHoc] [nvarchar](450) NOT NULL,
	[Status] [nvarchar](450) NOT NULL,
	[Round] [int] NOT NULL,
	[KiThucTapId] [nvarchar](450) NOT NULL,
	[StartDate] [datetimeoffset](7) NOT NULL,
	[EndDate] [datetimeoffset](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[DeletedBy] [nvarchar](max) NULL,
	[CreatedTime] [datetimeoffset](7) NOT NULL,
	[LastUpdatedTime] [datetimeoffset](7) NOT NULL,
	[DeletedTime] [datetimeoffset](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KiThucTap]    Script Date: 1/8/2024 10:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KiThucTap](
	[Id] [nvarchar](450) NOT NULL,
	[IdTruong] [nvarchar](450) NOT NULL,
	[NgayBatDau] [datetimeoffset](7) NULL,
	[NgayKetThuc] [datetimeoffset](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[DeletedBy] [nvarchar](max) NULL,
	[CreatedTime] [datetimeoffset](7) NOT NULL,
	[LastUpdatedTime] [datetimeoffset](7) NOT NULL,
	[DeletedTime] [datetimeoffset](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichPhongVan]    Script Date: 1/8/2024 10:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichPhongVan](
	[Id] [nvarchar](450) NOT NULL,
	[NguoiPhongVan] [nvarchar](450) NOT NULL,
	[NguoiDuocPhongVan] [nvarchar](450) NOT NULL,
	[ThoiGianPhongVan] [datetimeoffset](7) NOT NULL,
	[DiaDiemPhongVan] [nvarchar](max) NULL,
	[DaXacNhanMail] [bit] NOT NULL,
	[TrangThai] [bit] NOT NULL,
	[KetQua] [bit] NOT NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[DeletedBy] [nvarchar](max) NULL,
	[CreatedTime] [datetimeoffset](7) NOT NULL,
	[LastUpdatedTime] [datetimeoffset](7) NOT NULL,
	[DeletedTime] [datetimeoffset](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomZalo]    Script Date: 1/8/2024 10:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomZalo](
	[Id] [nvarchar](450) NOT NULL,
	[TenNhom] [nvarchar](max) NULL,
	[LinkNhom] [nvarchar](max) NULL,
	[Mentor] [nvarchar](450) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[DeletedBy] [nvarchar](max) NULL,
	[CreatedTime] [datetimeoffset](7) NOT NULL,
	[LastUpdatedTime] [datetimeoffset](7) NOT NULL,
	[DeletedTime] [datetimeoffset](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 1/8/2024 10:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[RoleGroup] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongBao]    Script Date: 1/8/2024 10:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongBao](
	[Id] [nvarchar](450) NOT NULL,
	[TinhTrang] [int] NOT NULL,
	[NguoiNhan] [nvarchar](450) NOT NULL,
	[NguoiGui] [nvarchar](450) NOT NULL,
	[TieuDe] [nvarchar](450) NOT NULL,
	[NoiDung] [nvarchar](450) NOT NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[DeletedBy] [nvarchar](max) NULL,
	[CreatedTime] [datetimeoffset](7) NOT NULL,
	[LastUpdatedTime] [datetimeoffset](7) NOT NULL,
	[DeletedTime] [datetimeoffset](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TruongHoc]    Script Date: 1/8/2024 10:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TruongHoc](
	[Id] [nvarchar](450) NOT NULL,
	[Ten] [nvarchar](max) NULL,
	[SoTuanThucTap] [int] NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[DeletedBy] [nvarchar](max) NULL,
	[CreatedTime] [datetimeoffset](7) NOT NULL,
	[LastUpdatedTime] [datetimeoffset](7) NOT NULL,
	[DeletedTime] [datetimeoffset](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserNhomZalo]    Script Date: 1/8/2024 10:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserNhomZalo](
	[Id] [nvarchar](450) NOT NULL,
	[IdNhom] [nvarchar](450) NULL,
	[UserId] [nvarchar](450) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[DeletedBy] [nvarchar](max) NULL,
	[CreatedTime] [datetimeoffset](7) NOT NULL,
	[LastUpdatedTime] [datetimeoffset](7) NOT NULL,
	[DeletedTime] [datetimeoffset](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 1/8/2024 10:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[Id] [nvarchar](450) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 1/8/2024 10:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[Sdt] [nvarchar](max) NULL,
	[SdtXacNhan] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[CreatedTime] [datetimeoffset](7) NOT NULL,
	[DeletedTime] [datetimeoffset](7) NULL,
	[LastUpdatedTime] [datetimeoffset](7) NOT NULL,
	[PasswordEncrypt] [nvarchar](max) NOT NULL,
	[ResetToken] [nvarchar](max) NULL,
	[ResetTokenExpires] [datetimeoffset](7) NULL,
	[UserCode] [nvarchar](450) NOT NULL,
	[VerificationToken] [nvarchar](max) NULL,
	[Verified] [datetimeoffset](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTokens]    Script Date: 1/8/2024 10:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTokens](
	[Id] [nvarchar](450) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[CongNgheDuAn]  WITH CHECK ADD FOREIGN KEY([IdDuAn])
REFERENCES [dbo].[DuAn] ([Id])
GO
ALTER TABLE [dbo].[CvComment]  WITH CHECK ADD FOREIGN KEY([NguoiDuocComment])
REFERENCES [dbo].[InternInfo] ([Id])
GO
ALTER TABLE [dbo].[CvComment]  WITH CHECK ADD FOREIGN KEY([NguoiComment])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[DuAn]  WITH CHECK ADD FOREIGN KEY([Leader])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[InternDuAn]  WITH CHECK ADD FOREIGN KEY([IdDuAn])
REFERENCES [dbo].[DuAn] ([Id])
GO
ALTER TABLE [dbo].[InternDuAn]  WITH CHECK ADD FOREIGN KEY([IdIntern])
REFERENCES [dbo].[InternInfo] ([Id])
GO
ALTER TABLE [dbo].[InternInfo]  WITH CHECK ADD FOREIGN KEY([KiThucTapId])
REFERENCES [dbo].[KiThucTap] ([Id])
GO
ALTER TABLE [dbo].[InternInfo]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[KiThucTap]  WITH CHECK ADD FOREIGN KEY([IdTruong])
REFERENCES [dbo].[TruongHoc] ([Id])
GO
ALTER TABLE [dbo].[LichPhongVan]  WITH CHECK ADD FOREIGN KEY([NguoiPhongVan])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[LichPhongVan]  WITH CHECK ADD FOREIGN KEY([NguoiDuocPhongVan])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[NhomZalo]  WITH CHECK ADD FOREIGN KEY([Mentor])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[ThongBao]  WITH CHECK ADD FOREIGN KEY([NguoiGui])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[ThongBao]  WITH CHECK ADD FOREIGN KEY([NguoiNhan])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[UserNhomZalo]  WITH CHECK ADD FOREIGN KEY([IdNhom])
REFERENCES [dbo].[NhomZalo] ([Id])
GO
ALTER TABLE [dbo].[UserNhomZalo]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[UserTokens]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
USE [master]
GO
ALTER DATABASE [Intern-System] SET  READ_WRITE 
GO
