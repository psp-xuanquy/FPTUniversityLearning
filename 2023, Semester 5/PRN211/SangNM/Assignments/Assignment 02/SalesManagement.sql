USE [master]
GO
/****** Object:  Database [SalesManagement]    Script Date: 10/30/2023 10:40:16 PM ******/
CREATE DATABASE [SalesManagement]
GO
USE [SalesManagement]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 10/30/2023 10:40:16 PM ******/                                                
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[ProductName] [nvarchar](40) NOT NULL,
	[Weight] [nvarchar](20) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[UnitsInStock] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Member]    Script Date: 10/30/2023 10:40:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberID] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](100) NOT NULL Unique,
	[CompanyName] [nvarchar](40) NOT NULL,
	[City] [nvarchar](15) NOT NULL,
	[Country] [nvarchar](15) NOT NULL,
	[Password] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[OrderDetail]    Script Date: 10/30/2023 10:40:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderID] [int] NOT NULL,	
	[ProductID] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [float] NOT NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Order]    Script Date: 10/30/2023 10:40:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [int] NOT NULL,
	[MemberID] [int] NOT NULL,
	[OrderDate] [date] NOT NULL,
	[RequiredDate] [date] NULL,
	[ShippedDate] [date] NULL,
	[Freight] [money] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET IDENTITY_INSERT [dbo].[Product] ON 
GO
INSERT [dbo].[Product] ([ProductID], [CategoryID], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (1, 1, N'Product A', N'1 lb', 10000.000, 100)
GO
INSERT [dbo].[Product] ([ProductID], [CategoryID], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (2, 1, N'Product B', N'2 lb', 20000.000, 200)
GO
INSERT [dbo].[Product] ([ProductID], [CategoryID], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (3, 2, N'Product C', N'3 lb', 30000.000, 50)
GO
INSERT [dbo].[Product] ([ProductID], [CategoryID], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (4, 2, N'Product D', N'4 lb', 40000.000, 150)
GO
INSERT [dbo].[Product] ([ProductID], [CategoryID], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (5, 3, N'Product E', N'5 lb', 50000.000, 180)
GO
INSERT [dbo].[Product] ([ProductID], [CategoryID], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (6, 3, N'Product F', N'6 lb', 60000.000, 300)
GO
INSERT [dbo].[Product] ([ProductID], [CategoryID], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (7, 4, N'Product G', N'7 lb', 70000.000, 50)
GO
INSERT [dbo].[Product] ([ProductID], [CategoryID], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (8, 4, N'Product H', N'8 lb', 80000.000, 100)
GO
SET IDENTITY_INSERT [dbo].[Product] OFF
GO

SET IDENTITY_INSERT [dbo].[Member] ON 
GO
/*INSERT [dbo].[Member] ([MemberID], [Email], [CompanyName], [City], [Country], [Password]) VALUES (0, N'admin@fstore.com', null, null, null, N'admin@@')
GO*/
INSERT [dbo].[Member] ([MemberID], [Email], [CompanyName], [City], [Country], [Password]) VALUES (1, N'abc@gmail.com', N'FPT', N'HCM', N'Vietnam', N'123456')
GO
INSERT [dbo].[Member] ([MemberID], [Email], [CompanyName], [City], [Country], [Password]) VALUES (2, N'quydxse170242@fpt.edu.com', N'FPT', N'HCM', N'Vietnam', N'123456')
GO
INSERT [dbo].[Member] ([MemberID], [Email], [CompanyName], [City], [Country], [Password]) VALUES (3, N'xuanquy@gmail.com', N'FPT', N'Dak Lak', N'Vietnam', N'123456')
GO
INSERT [dbo].[Member] ([MemberID], [Email], [CompanyName], [City], [Country], [Password]) VALUES (4, N'dao@gmail.com', N'PsP', N'Tokyo', N'Japan', N'123456')
GO
INSERT [dbo].[Member] ([MemberID], [Email], [CompanyName], [City], [Country], [Password]) VALUES (5, N'xuan@gmail.com', N'PsP', N'Washington, D.C', N'America', N'123456')
GO
INSERT [dbo].[Member] ([MemberID], [Email], [CompanyName], [City], [Country], [Password]) VALUES (6, N'quy@gmail.com', N'PsP', N'Wuhan', N'China', N'123456')
GO
SET IDENTITY_INSERT [dbo].[Member] OFF
GO


INSERT [dbo].[OrderDetail] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (1, 4, 60000.000, 10, 0.1)
GO
INSERT [dbo].[OrderDetail] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (1, 6, 70000.000, 15, 0.1)
GO
INSERT [dbo].[OrderDetail] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (2, 2, 80000.000, 20, 0.2)
GO
INSERT [dbo].[OrderDetail] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (2, 5, 90000.000, 25, 0.2)
GO

INSERT [dbo].[Order] ([OrderID], [MemberID], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (1, 1, CAST(N'2023-10-30' AS Date), CAST(N'2023-11-02' AS Date), CAST(N'2023-11-02' AS Date), 200)
GO
INSERT [dbo].[Order] ([OrderID], [MemberID], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (2, 2, CAST(N'2023-10-25' AS Date), CAST(N'2023-11-02' AS Date), CAST(N'2023-11-02' AS Date), 300)
GO

ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Product]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Member] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Member] ([MemberID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Member]
GO
USE [master]
GO
ALTER DATABASE [SalesManagement] SET  READ_WRITE 
GO
