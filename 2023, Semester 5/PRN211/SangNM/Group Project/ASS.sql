Create database PRN211Project

USE [PRN211Project]
GO
ALTER DATABASE [PRN211Project] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PRN211Project] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PRN211Project] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PRN211Project] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PRN211Project] SET ARITHABORT OFF 
GO
ALTER DATABASE [PRN211Project] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PRN211Project] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PRN211Project] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PRN211Project] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PRN211Project] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PRN211Project] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PRN211Project] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PRN211Project] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PRN211Project] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PRN211Project] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PRN211Project] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PRN211Project] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PRN211Project] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PRN211Project] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PRN211Project] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PRN211Project] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [PRN211Project] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PRN211Project] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PRN211Project] SET  MULTI_USER 
GO
ALTER DATABASE [PRN211Project] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PRN211Project] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PRN211Project] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PRN211Project] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PRN211Project] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PRN211Project] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PRN211Project] SET QUERY_STORE = OFF
GO
USE [PRN211Project]
GO
/****** Object:  Table [dbo].[tblCategories]    Script Date: 11/6/2023 2:24:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCategories](
	[categoryID] [nchar](10) NOT NULL,
	[categoryName] [nchar](10) NULL,
 CONSTRAINT [PK_tblCategories] PRIMARY KEY CLUSTERED 
(
	[categoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblOrderDetails]    Script Date: 11/6/2023 2:24:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOrderDetails](
	[orderID] [uniqueidentifier] NOT NULL,
	[productID] [nchar](15) NOT NULL,
	[quantity] [int] NULL,
	[totalPrice] [float] NULL,
 CONSTRAINT [PK_tblOrderDetails_1] PRIMARY KEY CLUSTERED 
(
	[orderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblOrders]    Script Date: 11/6/2023 2:24:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOrders](
	[orderID] [uniqueidentifier] NOT NULL,
	[staffID] [nchar](15) NULL,
	[customerName] [nchar](25) NULL,
	[date] [datetime] NULL,
	[orderPrice] [float] NULL,
	[statusID] [nchar](15) NULL,
	[paymentMethod] [nchar](20) NULL,
 CONSTRAINT [PK_tblOrders] PRIMARY KEY CLUSTERED 
(
	[orderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProducts]    Script Date: 11/6/2023 2:24:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProducts](
	[productID] [nchar](15) NOT NULL,
	[productName] [nchar](30) NULL,
	[price] [float] NULL,
	[quantity] [int] NULL,
	[imageSrc] [nchar](50) NULL,
	[categoryID] [nchar](10) NULL,
	[statusID] [nchar](15) NULL,
 CONSTRAINT [PK_tblProducts] PRIMARY KEY CLUSTERED 
(
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRoles]    Script Date: 11/6/2023 2:24:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRoles](
	[roleID] [nchar](15) NOT NULL,
	[roleName] [nchar](15) NULL,
 CONSTRAINT [PK_tblRoles] PRIMARY KEY CLUSTERED 
(
	[roleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblStaff]    Script Date: 11/6/2023 2:24:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStaff](
	[staffID] [nchar](15) NOT NULL,
	[fullName] [nchar](25) NULL,
	[address] [nchar](50) NULL,
	[phoneNumber] [nchar](10) NULL,
	[password] [nchar](20) NULL,
	[roleID] [nchar](15) NULL,
	[statusID] [nchar](15) NULL,
	[email] [nchar](25) NULL,
 CONSTRAINT [PK_tblStaff] PRIMARY KEY CLUSTERED 
(
	[staffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblStatus]    Script Date: 11/6/2023 2:24:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStatus](
	[statusID] [nchar](15) NOT NULL,
	[statusName] [nchar](20) NULL,
 CONSTRAINT [PK_tblStatus] PRIMARY KEY CLUSTERED 
(
	[statusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_tblOrderDetails_productID]    Script Date: 11/6/2023 2:24:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_tblOrderDetails_productID] ON [dbo].[tblOrderDetails]
(
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_tblOrders_staffID]    Script Date: 11/6/2023 2:24:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_tblOrders_staffID] ON [dbo].[tblOrders]
(
	[staffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_tblOrders_statusID]    Script Date: 11/6/2023 2:24:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_tblOrders_statusID] ON [dbo].[tblOrders]
(
	[statusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_tblProducts_categoryID]    Script Date: 11/6/2023 2:24:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_tblProducts_categoryID] ON [dbo].[tblProducts]
(
	[categoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_tblProducts_statusID]    Script Date: 11/6/2023 2:24:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_tblProducts_statusID] ON [dbo].[tblProducts]
(
	[statusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_tblStaff_roleID]    Script Date: 11/6/2023 2:24:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_tblStaff_roleID] ON [dbo].[tblStaff]
(
	[roleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_tblStaff_statusID]    Script Date: 11/6/2023 2:24:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_tblStaff_statusID] ON [dbo].[tblStaff]
(
	[statusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblOrderDetails_tblOrderDetails] FOREIGN KEY([orderID])
REFERENCES [dbo].[tblOrders] ([orderID])
GO
ALTER TABLE [dbo].[tblOrderDetails] CHECK CONSTRAINT [FK_tblOrderDetails_tblOrderDetails]
GO
ALTER TABLE [dbo].[tblOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblOrderDetails_tblProducts] FOREIGN KEY([productID])
REFERENCES [dbo].[tblProducts] ([productID])
GO
ALTER TABLE [dbo].[tblOrderDetails] CHECK CONSTRAINT [FK_tblOrderDetails_tblProducts]
GO
ALTER TABLE [dbo].[tblOrders]  WITH CHECK ADD  CONSTRAINT [FK_tblOrders_tblStaff] FOREIGN KEY([staffID])
REFERENCES [dbo].[tblStaff] ([staffID])
GO
ALTER TABLE [dbo].[tblOrders] CHECK CONSTRAINT [FK_tblOrders_tblStaff]
GO
ALTER TABLE [dbo].[tblOrders]  WITH CHECK ADD  CONSTRAINT [FK_tblOrders_tblStatus] FOREIGN KEY([statusID])
REFERENCES [dbo].[tblStatus] ([statusID])
GO
ALTER TABLE [dbo].[tblOrders] CHECK CONSTRAINT [FK_tblOrders_tblStatus]
GO
ALTER TABLE [dbo].[tblProducts]  WITH CHECK ADD  CONSTRAINT [FK_tblProducts_tblCategories] FOREIGN KEY([categoryID])
REFERENCES [dbo].[tblCategories] ([categoryID])
GO
ALTER TABLE [dbo].[tblProducts] CHECK CONSTRAINT [FK_tblProducts_tblCategories]
GO
ALTER TABLE [dbo].[tblProducts]  WITH CHECK ADD  CONSTRAINT [FK_tblProducts_tblStatus] FOREIGN KEY([statusID])
REFERENCES [dbo].[tblStatus] ([statusID])
GO
ALTER TABLE [dbo].[tblProducts] CHECK CONSTRAINT [FK_tblProducts_tblStatus]
GO
ALTER TABLE [dbo].[tblStaff]  WITH CHECK ADD  CONSTRAINT [FK_tblStaff_tblRoles] FOREIGN KEY([roleID])
REFERENCES [dbo].[tblRoles] ([roleID])
GO
ALTER TABLE [dbo].[tblStaff] CHECK CONSTRAINT [FK_tblStaff_tblRoles]
GO
ALTER TABLE [dbo].[tblStaff]  WITH CHECK ADD  CONSTRAINT [FK_tblStaff_tblStatus] FOREIGN KEY([statusID])
REFERENCES [dbo].[tblStatus] ([statusID])
GO
ALTER TABLE [dbo].[tblStaff] CHECK CONSTRAINT [FK_tblStaff_tblStatus]
GO
USE [master]
GO
ALTER DATABASE [PRN211Project] SET  READ_WRITE 
GO


-- Create tblCategories Table
INSERT INTO [PRN211Project].[dbo].[tblCategories] ([categoryID], [categoryName])
VALUES
    ('C001', 'Electro'),
    ('C002', 'Clothing'),
    ('C003', 'Home'),
    ('C004', 'Books'),
    ('C005', 'Sports');

	-- Create tblOrders Table
INSERT INTO [PRN211Project].[dbo].[tblOrders] ([orderID], [staffID], [customerName], [date], [orderPrice], [statusID], [paymentMethod])
VALUES
    (NEWID(), 'S001', 'John Doe', '2023-11-06 14:30:00', 316.50, 'OS001', 'Credit Card'),
    (NEWID(), 'S002', 'Jane Smith', '2023-11-07 09:45:00', 120.25, 'OS002', 'PayPal'),
    (NEWID(), 'S003', 'Bob Johnson', '2023-11-08 16:20:00', 195.75, 'OS001', 'Cash'),
    (NEWID(), 'S001', 'Alice Williams', '2023-11-09 11:10:00', 90.25, 'OS003', 'Credit Card'),
    (NEWID(), 'S002', 'Charlie Brown', '2023-11-10 13:55:00', 50.25, 'OS002', 'Cash');

	-- Create tblStaff Table
INSERT INTO [PRN211Project].[dbo].[tblStaff] ([staffID], [fullName], [address], [phoneNumber], [password], [roleID], [statusID], [email])
VALUES
    ('S001', 'Admin User', '123 Admin St', '1234567890', 'admin123', 'AD', 'PS001', 'admin@example.com'),
    ('S002', 'Manager One', '456 Manager St', '9876543210', 'manager456', 'MN', 'PS001', 'manager1@example.com'),
    ('S003', 'Salesperson Two', '789 Sales St', '1112223333', 'salesperson789', 'ST', 'PS001', 'sales2@example.com');
-- Create tblRoles Table
INSERT INTO [PRN211Project].[dbo].[tblRoles] ([roleID], [roleName])
VALUES
    ('AD', 'Admin'),
    ('MN', 'Manager'),
    ('SL', 'Salesperson'),
    ('SV', 'Service'),
    ('ST', 'Staff');
-- Create tblStatus Table
INSERT INTO [PRN211Project].[dbo].[tblStatus] ([statusID], [statusName])
VALUES
    ('PS001', 'Active'),
    ('PS002', 'Inactive'),
    ('OS001', 'Processing'),
    ('OS002', 'Shipped'),
    ('OS003', 'Delivered'),
	('OS004', 'Available'),
	('OS005', 'Not Available');
	-- Create tblOrders Table
INSERT INTO [PRN211Project].[dbo].[tblOrders] ([orderID], [staffID], [customerName], [date], [orderPrice], [statusID], [paymentMethod])
VALUES
    (NEWID(), 'S001', 'John Doe', '2023-11-06 14:30:00', 316.50, 'OS001', 'Credit Card'),
    (NEWID(), 'S002', 'Jane Smith', '2023-11-07 09:45:00', 120.25, 'OS002', 'PayPal'),
    (NEWID(), 'S003', 'Bob Johnson', '2023-11-08 16:20:00', 195.75, 'OS001', 'Cash'),
    (NEWID(), 'S001', 'Alice Williams', '2023-11-09 11:10:00', 90.25, 'OS003', 'Credit Card'),
    (NEWID(), 'S002', 'Charlie Brown', '2023-11-10 13:55:00', 50.25, 'OS002', 'Cash');
	-- Create tblProducts Table
INSERT INTO [PRN211Project].[dbo].[tblProducts] ([productID], [productName], [price], [quantity], [imageSrc], [categoryID], [statusID])
VALUES
    ('P001', 'Smartphone X', 299.99, 50, 'phone_image.jpg', 'C001', 'OS004'),
    ('P002', 'Laptop Pro', 899.99, 20, 'laptop_image.jpg', 'C001', 'OS004'),
    ('P003', 'Garden Chair', 19.99, 100, 'chair_image.jpg', 'C003', 'OS004'),
    ('P004', 'Python Programming Book', 39.99, 30, 'book_image.jpg', 'C004', 'OS004'),
    ('P005', 'Soccer Ball', 14.99, 50, 'ball_image.jpg', 'C005', 'OS004');
	-- Create tblOrderDetails Table
INSERT INTO [PRN211Project].[dbo].[tblOrderDetails] ([orderID], [productID], [quantity], [totalPrice])
VALUES
    ('34BBF5BC-842A-481D-A756-3F7A90DCF4FC', 'P001', 2, 316.5),
    ('1AFCB80A-F91A-4073-ABE4-1580A0E90C77', 'P002', 1, 50.25),
    ('37513B1D-4361-4FAB-A021-321152FA8639', 'P003', 3, 195.75)
