USE master
GO

CREATE DATABASE Sunglasses2023DB
GO

USE Sunglasses2023DB
GO

CREATE TABLE Account(
  MemberAccountID int primary key,
  MemberAccountPassword nvarchar(70) not null,
  MemberFullName nvarchar(100) not null,
  MemberEmail nvarchar(100) unique, 
  Role int
)
GO

INSERT INTO Account VALUES(211 ,N'@2', N'Administrator', 'admin@SunGlassesStore.info', 1);
INSERT INTO Account VALUES(212 ,N'@2', N'Staff', 'staff@SunGlassesStore.info', 2);
INSERT INTO Account VALUES(213 ,N'@2', N'Manager', 'manager@SunGlassesStore.info', 3);
INSERT INTO Account VALUES(214 ,N'@2', N'Customer', 'customer@SunGlassesStore.info', 4);
GO


CREATE TABLE Manufacturer(
  ManufacturerId nvarchar(30) primary key,
  ManufacturerName nvarchar(100) not null,
  ManufacturerDescription nvarchar(250) not null
)
GO
INSERT INTO Manufacturer VALUES(N'GT00443', N'Ray-Ban', N'Ray-Ban is a brand of luxury sunglasses and eyeglasses created in 1936 by Bausch & Lomb')
GO
INSERT INTO Manufacturer VALUES(N'GT00444', N'Oakley', N'Oakley is a well-known manufacturer of high-quality sunglasses, known for their durability, style, and innovative lens technology.')
GO
INSERT INTO Manufacturer VALUES(N'GT00445', N'Vogue', N'Their sunglasses are known for their durability, comfort, and fashion-forward designs. ')
GO
INSERT INTO Manufacturer VALUES(N'GT00446', N'Gucci', N'Gucci is an Italian luxury fashion brand that is known for its high-end sunglasses.')
GO
INSERT INTO Manufacturer VALUES(N'GT00447', N'Maui Jim', N'Maui Jim is a well-known manufacturer of high-quality sunglasses, excellent UV protection and glare reduction. ')
GO



CREATE TABLE Sunglasses(
 SunglassesId int primary key,
 SunglassesName nvarchar(100) not null,
 Feature nvarchar(220),
 Material nvarchar(40),
 Shape nvarchar(40),
 Price decimal,
 Quantity int, 
 CreatedDate Datetime,
 ManufacturerId nvarchar(30) references Manufacturer(ManufacturerId) on delete cascade on update cascade
)
GO

INSERT INTO Sunglasses VALUES(6651, N'Foldable Square Sunglasses 1143821', N'Spring Hinges , Custom engraving , Universal Bridge Fit ', N'Plastic', N'Square', 84.5, 100, CAST(N'2023-10-16' AS DateTime), 'GT00447')
GO
INSERT INTO Sunglasses VALUES(6660, N'Square Glasses 270524', N'Custom engraving , Universal Bridge Fit ', N'Plastic', N'Square', 149.5, 200, CAST(N'2023-10-16' AS DateTime), 'GT00443')
GO
INSERT INTO Sunglasses VALUES(6652, N'Rectangle Glasses 696421', N'Nose Pads , Spring Hinges ', N'Stainless Steel', N'Rectangle', 129.5, 300, CAST(N'2023-10-16' AS DateTime), 'GT00443')
GO
INSERT INTO Sunglasses VALUES(6653, N'Cat-Eye Glasses 2043925', N' Spring Hinges , Custom engraving ', N'Plastic', N'Cat-Eye', 99.5, 400, CAST(N'2023-10-16' AS DateTime), 'GT00443')
GO
INSERT INTO Sunglasses VALUES(6654, N'Round Glasses 2041217', N' Spring Hinges , Custom engraving , Universal Bridge Fit ', N'Plastic', N'Round', 109.5, 200, CAST(N'2023-10-16' AS DateTime), 'GT00443')
GO
INSERT INTO Sunglasses VALUES(6655, N'Glow-in-the-Dark Round Glasses 2029150', N'Narrow Fit , Custom engraving , Lightweight ', N'Plastic', N'Round', 139.5, 100, CAST(N'2023-10-16' AS DateTime), 'GT00444')
GO
INSERT INTO Sunglasses VALUES(6656, N'Kids Oval Glasses 4454829', N'Feature: Custom engraving ', N'Acetate', N'Oval', 149.5, 500, CAST(N'2023-10-16' AS DateTime), 'GT00444')
GO
INSERT INTO Sunglasses VALUES(6657, N'Kids Flexible Rectangle Glasses 2021621', N'Feature: Lightweight', N'Plastic', N'Rectangle', 239.5, 300, CAST(N'2023-10-16' AS DateTime), 'GT00445')
GO
INSERT INTO Sunglasses VALUES(6658, N'Foldable Round Sunglasses 1161021', N'Feature: Nose Pads', N'Stainless Steel', N'Round', 499.5, 200, CAST(N'2023-10-16' AS DateTime), 'GT00443')
GO
INSERT INTO Sunglasses VALUES(6659, N'Foldable Aviator Sunglasses 1160911', N'Nose Pads ', N'Stainless Steel', N'Aviator', 49.5, 200, CAST(N'2023-10-16' AS DateTime), 'GT00447')
GO