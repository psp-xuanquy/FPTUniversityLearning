/****** Object:  Database [BirdFarmShop]    Script Date: 11/13/2023 11:50:51 AM ******/
CREATE DATABASE [BirdFarmShop];
GO
ALTER DATABASE [BirdFarmShop] SET COMPATIBILITY_LEVEL = 150
GO
ALTER DATABASE [BirdFarmShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BirdFarmShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BirdFarmShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BirdFarmShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BirdFarmShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [BirdFarmShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BirdFarmShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BirdFarmShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BirdFarmShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BirdFarmShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BirdFarmShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BirdFarmShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BirdFarmShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BirdFarmShop] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [BirdFarmShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BirdFarmShop] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [BirdFarmShop] SET  MULTI_USER 
GO
ALTER DATABASE [BirdFarmShop] SET ENCRYPTION ON
GO
ALTER DATABASE [BirdFarmShop] SET QUERY_STORE = ON
GO
ALTER DATABASE [BirdFarmShop] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 100, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
/*** The scripts of database scoped configurations in Azure should be executed inside the target database connection. ***/
GO
-- ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 8;
USE [BirdFarmShop]
GO
/****** Object:  Table [dbo].[tb_Account]    Script Date: 11/13/2023 11:50:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Account](
	[user_id] [nvarchar](50) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[role] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tb_UserAccount] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Bird]    Script Date: 11/13/2023 11:50:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Bird](
	[bird_id] [nvarchar](50) NOT NULL,
	[bird_species_id] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[gender] [nvarchar](10) NOT NULL,
	[birth_month_year] [date] NOT NULL,
	[description] [nvarchar](500) NULL,
	[bird_image] [nvarchar](100) NOT NULL,
	[price] [decimal](18, 0) NOT NULL,
	[offspring_available] [bit] NOT NULL,
	[status_selling] [bit] NOT NULL,
	[status_sold] [bit] NOT NULL,
 CONSTRAINT [PK_tb_BirdProduct] PRIMARY KEY CLUSTERED 
(
	[bird_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_BirdCategory]    Script Date: 11/13/2023 11:50:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_BirdCategory](
	[bird_species_id] [nvarchar](50) NOT NULL,
	[bird_species_name] [nvarchar](50) NOT NULL,
	[description] [nvarchar](300) NULL,
 CONSTRAINT [PK_tb_birdCategory_1] PRIMARY KEY CLUSTERED 
(
	[bird_species_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Breeding]    Script Date: 11/13/2023 11:50:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Breeding](
	[breeding_id] [nvarchar](50) NOT NULL,
	[bird_male_id] [nvarchar](50) NOT NULL,
	[bird_female_id] [nvarchar](50) NOT NULL,
	[status_done] [bit] NOT NULL,
 CONSTRAINT [PK_tb_Breeding] PRIMARY KEY CLUSTERED 
(
	[breeding_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Cart]    Script Date: 11/13/2023 11:50:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Cart](
	[cart_id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [nvarchar](50) NOT NULL,
	[user_id] [nvarchar](50) NOT NULL,
	[total] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_tb_Cart] PRIMARY KEY CLUSTERED 
(
	[cart_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Nest]    Script Date: 11/13/2023 11:50:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Nest](
	[nest_id] [nvarchar](50) NOT NULL,
	[bird_id_male] [nvarchar](50) NOT NULL,
	[bird_id_female] [nvarchar](50) NOT NULL,
	[bird_species] [nvarchar](20) NOT NULL,
	[name] [nvarchar](70) NOT NULL,
	[description] [nvarchar](200) NULL,
	[price] [decimal](18, 0) NOT NULL,
	[quantity] [int] NOT NULL,
	[bird_image] [nvarchar](100) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_tb_Nest] PRIMARY KEY CLUSTERED 
(
	[nest_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Order]    Script Date: 11/13/2023 11:50:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Order](
	[order_id] [nvarchar](50) NOT NULL,
	[user_id] [nvarchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[phone] [nvarchar](11) NOT NULL,
	[payment_method_id] [nvarchar](20) NOT NULL,
	[provider_id] [nvarchar](20) NOT NULL,
	[total] [decimal](18, 0) NOT NULL,
	[create_at] [date] NOT NULL,
	[estimated_date] [date] NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_tb_Order] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_OrderItem]    Script Date: 11/13/2023 11:50:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_OrderItem](
	[order_item_id] [nvarchar](50) NOT NULL,
	[product_id] [nvarchar](50) NOT NULL,
	[order_id] [nvarchar](50) NOT NULL,
	[price] [decimal](18, 0) NOT NULL,
	[status_pending] [bit] NOT NULL,
	[status_process] [bit] NOT NULL,
	[status_cancel] [bit] NOT NULL,
 CONSTRAINT [PK_tb_OrderItem] PRIMARY KEY CLUSTERED 
(
	[order_item_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_PaymentMethod]    Script Date: 11/13/2023 11:50:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_PaymentMethod](
	[payment_method_id] [nvarchar](20) NOT NULL,
	[payment_method_name] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tb_PaymentMethod] PRIMARY KEY CLUSTERED 
(
	[payment_method_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Provider]    Script Date: 11/13/2023 11:50:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Provider](
	[provider_id] [nvarchar](20) NOT NULL,
	[provider_name] [nvarchar](30) NULL,
 CONSTRAINT [PK_tb_Provider] PRIMARY KEY CLUSTERED 
(
	[provider_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_User]    Script Date: 11/13/2023 11:50:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_User](
	[user_id] [nvarchar](50) NOT NULL,
	[full_name] [nvarchar](30) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[gender] [nvarchar](10) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[phone] [nvarchar](10) NOT NULL,
	[date_of_bird] [date] NOT NULL,
	[zipcode] [nvarchar](10) NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_tb_Bird_bird_species_id]    Script Date: 11/13/2023 11:50:51 AM ******/
CREATE NONCLUSTERED INDEX [IX_tb_Bird_bird_species_id] ON [dbo].[tb_Bird]
(
	[bird_species_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, DROP_EXISTING = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_tb_Cart_user_id]    Script Date: 11/13/2023 11:50:51 AM ******/
CREATE NONCLUSTERED INDEX [IX_tb_Cart_user_id] ON [dbo].[tb_Cart]
(
	[user_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, DROP_EXISTING = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_tb_Nest_bird_id_female]    Script Date: 11/13/2023 11:50:51 AM ******/
CREATE NONCLUSTERED INDEX [IX_tb_Nest_bird_id_female] ON [dbo].[tb_Nest]
(
	[bird_id_female] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, DROP_EXISTING = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_tb_Nest_bird_id_male]    Script Date: 11/13/2023 11:50:51 AM ******/
CREATE NONCLUSTERED INDEX [IX_tb_Nest_bird_id_male] ON [dbo].[tb_Nest]
(
	[bird_id_male] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, DROP_EXISTING = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tb_Account]  WITH CHECK ADD  CONSTRAINT [FK_tb_UserAccount_tb_User] FOREIGN KEY([user_id])
REFERENCES [dbo].[tb_User] ([user_id])
GO
ALTER TABLE [dbo].[tb_Account] CHECK CONSTRAINT [FK_tb_UserAccount_tb_User]
GO
ALTER TABLE [dbo].[tb_Bird]  WITH CHECK ADD  CONSTRAINT [FK_tb_BirdProduct_tb_BirdCategory] FOREIGN KEY([bird_species_id])
REFERENCES [dbo].[tb_BirdCategory] ([bird_species_id])
GO
ALTER TABLE [dbo].[tb_Bird] CHECK CONSTRAINT [FK_tb_BirdProduct_tb_BirdCategory]
GO
ALTER TABLE [dbo].[tb_Breeding]  WITH CHECK ADD  CONSTRAINT [FK_tb_Breeding_tb_Bird] FOREIGN KEY([bird_male_id])
REFERENCES [dbo].[tb_Bird] ([bird_id])
GO
ALTER TABLE [dbo].[tb_Breeding] CHECK CONSTRAINT [FK_tb_Breeding_tb_Bird]
GO
ALTER TABLE [dbo].[tb_Breeding]  WITH CHECK ADD  CONSTRAINT [FK_tb_Breeding_tb_Bird1] FOREIGN KEY([bird_female_id])
REFERENCES [dbo].[tb_Bird] ([bird_id])
GO
ALTER TABLE [dbo].[tb_Breeding] CHECK CONSTRAINT [FK_tb_Breeding_tb_Bird1]
GO
ALTER TABLE [dbo].[tb_Cart]  WITH CHECK ADD  CONSTRAINT [FK_tb_Cart_tb_User] FOREIGN KEY([user_id])
REFERENCES [dbo].[tb_User] ([user_id])
GO
ALTER TABLE [dbo].[tb_Cart] CHECK CONSTRAINT [FK_tb_Cart_tb_User]
GO
ALTER TABLE [dbo].[tb_Nest]  WITH CHECK ADD  CONSTRAINT [FK_tb_Nest_tb_Bird] FOREIGN KEY([bird_id_male])
REFERENCES [dbo].[tb_Bird] ([bird_id])
GO
ALTER TABLE [dbo].[tb_Nest] CHECK CONSTRAINT [FK_tb_Nest_tb_Bird]
GO
ALTER TABLE [dbo].[tb_Nest]  WITH CHECK ADD  CONSTRAINT [FK_tb_Nest_tb_Bird1] FOREIGN KEY([bird_id_female])
REFERENCES [dbo].[tb_Bird] ([bird_id])
GO
ALTER TABLE [dbo].[tb_Nest] CHECK CONSTRAINT [FK_tb_Nest_tb_Bird1]
GO
ALTER TABLE [dbo].[tb_Order]  WITH CHECK ADD  CONSTRAINT [FK_tb_Order_tb_PaymentMethod] FOREIGN KEY([payment_method_id])
REFERENCES [dbo].[tb_PaymentMethod] ([payment_method_id])
GO
ALTER TABLE [dbo].[tb_Order] CHECK CONSTRAINT [FK_tb_Order_tb_PaymentMethod]
GO
ALTER TABLE [dbo].[tb_Order]  WITH CHECK ADD  CONSTRAINT [FK_tb_Order_tb_Provider] FOREIGN KEY([provider_id])
REFERENCES [dbo].[tb_Provider] ([provider_id])
GO
ALTER TABLE [dbo].[tb_Order] CHECK CONSTRAINT [FK_tb_Order_tb_Provider]
GO
ALTER TABLE [dbo].[tb_Order]  WITH CHECK ADD  CONSTRAINT [FK_tb_Order_tb_User] FOREIGN KEY([user_id])
REFERENCES [dbo].[tb_User] ([user_id])
GO
ALTER TABLE [dbo].[tb_Order] CHECK CONSTRAINT [FK_tb_Order_tb_User]
GO
ALTER TABLE [dbo].[tb_OrderItem]  WITH CHECK ADD  CONSTRAINT [FK_tb_OrderItem_tb_Order] FOREIGN KEY([order_id])
REFERENCES [dbo].[tb_Order] ([order_id])
GO
ALTER TABLE [dbo].[tb_OrderItem] CHECK CONSTRAINT [FK_tb_OrderItem_tb_Order]
GO
ALTER DATABASE [BirdFarmShop] SET  READ_WRITE 
GO
