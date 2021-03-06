USE [HotelManagement]
GO
ALTER TABLE [dbo].[tblUser] DROP CONSTRAINT [FK_tblUser_tblLogin]
GO
ALTER TABLE [dbo].[tblReservation] DROP CONSTRAINT [FK_tblService_tblRoom]
GO
ALTER TABLE [dbo].[tblReservation] DROP CONSTRAINT [FK_tblService_tblDiscount]
GO
ALTER TABLE [dbo].[tblReservation] DROP CONSTRAINT [FK_tblService_Guest]
GO
ALTER TABLE [dbo].[tblPrice] DROP CONSTRAINT [FK_Price_tblRoom]
GO
ALTER TABLE [dbo].[tblBilling] DROP CONSTRAINT [FK_tblBilling_tblReservation]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 5/31/2019 1:55:10 AM ******/
DROP TABLE [dbo].[tblUser]
GO
/****** Object:  Table [dbo].[tblRoom]    Script Date: 5/31/2019 1:55:10 AM ******/
DROP TABLE [dbo].[tblRoom]
GO
/****** Object:  Table [dbo].[tblReservation]    Script Date: 5/31/2019 1:55:10 AM ******/
DROP TABLE [dbo].[tblReservation]
GO
/****** Object:  Table [dbo].[tblPrice]    Script Date: 5/31/2019 1:55:10 AM ******/
DROP TABLE [dbo].[tblPrice]
GO
/****** Object:  Table [dbo].[tblLogin]    Script Date: 5/31/2019 1:55:10 AM ******/
DROP TABLE [dbo].[tblLogin]
GO
/****** Object:  Table [dbo].[tblDiscount]    Script Date: 5/31/2019 1:55:10 AM ******/
DROP TABLE [dbo].[tblDiscount]
GO
/****** Object:  Table [dbo].[tblBilling]    Script Date: 5/31/2019 1:55:10 AM ******/
DROP TABLE [dbo].[tblBilling]
GO
/****** Object:  Table [dbo].[tblBilling]    Script Date: 5/31/2019 1:55:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBilling](
	[ID] [int] NOT NULL,
	[ReserveID] [int] NULL,
	[Payment] [int] NULL,
	[Discount] [int] NULL,
	[Total] [int] NULL,
 CONSTRAINT [PK_tblBilling] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDiscount]    Script Date: 5/31/2019 1:55:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDiscount](
	[ID] [int] NOT NULL,
	[DiscountType] [nvarchar](50) NULL,
	[DiscountRate] [int] NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblDiscount] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLogin]    Script Date: 5/31/2019 1:55:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLogin](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
	[role] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblUser] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPrice]    Script Date: 5/31/2019 1:55:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPrice](
	[ID] [int] NOT NULL,
	[RoomID] [int] NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_Price] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblReservation]    Script Date: 5/31/2019 1:55:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblReservation](
	[ID] [int] NOT NULL,
	[GuestID] [int] NULL,
	[RoomID] [int] NULL,
	[CheckInDate] [datetime] NULL,
	[CheckOutDate] [datetime] NULL,
	[NoOfChild] [int] NULL,
	[NoOfAdult] [int] NULL,
	[DiscountID] [int] NULL,
	[Remarks] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblService] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRoom]    Script Date: 5/31/2019 1:55:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRoom](
	[ID] [int] NOT NULL,
	[RoomNumber] [nvarchar](50) NULL,
	[RoomType] [nvarchar](50) NULL,
	[RoomRate] [int] NULL,
	[NoOfOccupancy] [int] NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblRoom] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 5/31/2019 1:55:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[ID] [int] NOT NULL,
	[UserFName] [nvarchar](50) NULL,
	[UserMName] [nvarchar](50) NULL,
	[UserLName] [nvarchar](50) NULL,
	[UserAddress] [nvarchar](50) NULL,
	[UserContactNumber] [nvarchar](50) NULL,
	[UserGender] [nvarchar](50) NULL,
	[UserEmail] [nvarchar](50) NULL,
	[Remarks] [nvarchar](50) NULL,
	[UserName] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblGuest] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblBilling] ([ID], [ReserveID], [Payment], [Discount], [Total]) VALUES (1, 1, 1000000, 500000, 500000)
INSERT [dbo].[tblBilling] ([ID], [ReserveID], [Payment], [Discount], [Total]) VALUES (2, 2, 1400000, 700000, 700000)
INSERT [dbo].[tblBilling] ([ID], [ReserveID], [Payment], [Discount], [Total]) VALUES (3, 3, 400000, 200000, 200000)
INSERT [dbo].[tblDiscount] ([ID], [DiscountType], [DiscountRate], [Status]) VALUES (1, N'Giáng Sinh 2019', 20, N'Inactive')
INSERT [dbo].[tblDiscount] ([ID], [DiscountType], [DiscountRate], [Status]) VALUES (2, N'Tết Dương Lịch 2019', 30, N'Inactive')
INSERT [dbo].[tblDiscount] ([ID], [DiscountType], [DiscountRate], [Status]) VALUES (3, N'Sinh Nhật Khách Sạn', 50, N'Active')
INSERT [dbo].[tblDiscount] ([ID], [DiscountType], [DiscountRate], [Status]) VALUES (4, N'Tri Ân Khách Hàng ', 40, N'Active')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'123', N'123', N'Guest')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'hanguyen', N'16110060', N'Manager')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'huyh', N'123456', N'Guest')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'new guestt', N'123456', N'Guest')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'phuocnguyen', N'123456', N'Guest')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'quile', N'123456', N'Receptionist')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'thinh', N'123456', N'Receptionist')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'thuyngan', N'123456', N'Guest')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'thuyngan1', N'123456', N'Guest')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'thuyngan2', N'123456', N'Guest')
INSERT [dbo].[tblPrice] ([ID], [RoomID], [Price]) VALUES (1, 1, 200)
INSERT [dbo].[tblPrice] ([ID], [RoomID], [Price]) VALUES (2, 2, 200)
INSERT [dbo].[tblPrice] ([ID], [RoomID], [Price]) VALUES (3, 3, 200)
INSERT [dbo].[tblPrice] ([ID], [RoomID], [Price]) VALUES (4, 4, 300)
INSERT [dbo].[tblPrice] ([ID], [RoomID], [Price]) VALUES (5, 5, 300)
INSERT [dbo].[tblPrice] ([ID], [RoomID], [Price]) VALUES (6, 6, 400)
INSERT [dbo].[tblPrice] ([ID], [RoomID], [Price]) VALUES (7, 7, 350)
INSERT [dbo].[tblPrice] ([ID], [RoomID], [Price]) VALUES (8, 8, 400)
INSERT [dbo].[tblPrice] ([ID], [RoomID], [Price]) VALUES (9, 9, 200)
INSERT [dbo].[tblPrice] ([ID], [RoomID], [Price]) VALUES (10, 10, 300)
INSERT [dbo].[tblPrice] ([ID], [RoomID], [Price]) VALUES (11, 11, 400)
INSERT [dbo].[tblPrice] ([ID], [RoomID], [Price]) VALUES (12, 12, 400)
INSERT [dbo].[tblReservation] ([ID], [GuestID], [RoomID], [CheckInDate], [CheckOutDate], [NoOfChild], [NoOfAdult], [DiscountID], [Remarks]) VALUES (1, 7, 1, CAST(N'2019-05-31T01:43:25.000' AS DateTime), CAST(N'2019-06-06T00:00:00.000' AS DateTime), 0, 2, 3, N'Checkout')
INSERT [dbo].[tblReservation] ([ID], [GuestID], [RoomID], [CheckInDate], [CheckOutDate], [NoOfChild], [NoOfAdult], [DiscountID], [Remarks]) VALUES (2, 9, 2, CAST(N'2019-05-31T01:50:33.000' AS DateTime), CAST(N'2019-06-08T00:00:00.000' AS DateTime), 1, 1, 3, N'Checkin')
INSERT [dbo].[tblReservation] ([ID], [GuestID], [RoomID], [CheckInDate], [CheckOutDate], [NoOfChild], [NoOfAdult], [DiscountID], [Remarks]) VALUES (3, 9, 1, CAST(N'2019-06-04T01:51:16.000' AS DateTime), CAST(N'2019-06-07T00:00:00.000' AS DateTime), 0, 1, 3, N'Reserve')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (1, N'101', N'phòng đơn', 4, 2, N'Reserve')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (2, N'102', N'phòng đơn', 3, 2, N'Occupied')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (3, N'103', N'phòng đôi', 4, 5, N'Available')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (4, N'104', N'phòng đôi', 2, 5, N'Available')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (5, N'201', N'phòng đơn', 4, 2, N'Available')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (6, N'202', N'phòng đôi', 4, 5, N'Available')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (7, N'203', N'phòng đôi', 3, 8, N'Available')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (8, N'301', N'dorm', 3, 16, N'Available')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (9, N'303', N'giường đơn', 2, 2, N'Available')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (10, N'302', N'giường đơn', 3, 2, N'Available')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (11, N'401', N'dorm', 4, 8, N'Available')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (12, N'402', N'dorm', 4, 10, N'Available')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Remarks], [UserName]) VALUES (1, N'Nguyen', N'Luong My', N'Ha', N'Binh Chanh', N'0777774315', N'Female', N'nguyenluongmyha@gmail.com', N'Available', N'hanguyen')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Remarks], [UserName]) VALUES (2, N'Lê', N'Bá', N'Huỳnh', N'Q9', N'123456789', N'Female', N'huynhle@gmail.com', N'Available', N'huyh')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Remarks], [UserName]) VALUES (3, N'Nguyễn', N'Công', N'Thịnh', N'Quận Thủ Đức', N'00112233', N'Male', N'thinh@gmail.com', N'Available', N'thinh')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Remarks], [UserName]) VALUES (4, N'Lê', N'Duy', N'Quí', N'Vũng Tàu', N'987654321', N'Female', N'quile@gmail.com', N'Available', N'quile')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Remarks], [UserName]) VALUES (5, N'Nguyễn', N'Thúy', N'Ngân', N'Bình Chánh', N'12346463132', N'Female', N'thuyngan@gmail.com', N'Available', N'thuyngan')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Remarks], [UserName]) VALUES (6, N'Nguyễn', N'Duy', N'Phước', N'Q9', N'0123456798', N'Male', N'123456789', N'Available', N'phuocnguyen')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Remarks], [UserName]) VALUES (7, N'Nguyễn', N'Thúy', N'Ngân', N'Bình Chánh', N'12346463132', N'Female', N'thuyngan@gmail.com', N'Available', N'thuyngan1')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Remarks], [UserName]) VALUES (8, N'Nguyễn', N'Thúy', N'Ngân', N'Bình Chánh', N'12346463132', N'Female', N'thuyngan@gmail.com', N'Available', N'thuyngan2')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Remarks], [UserName]) VALUES (9, N'my', N'new', N'guest', N'Thủ Đức', N'0123654987', N'Male', N'newguest@gmail.com', N'Checkin', N'123')
ALTER TABLE [dbo].[tblBilling]  WITH CHECK ADD  CONSTRAINT [FK_tblBilling_tblReservation] FOREIGN KEY([ReserveID])
REFERENCES [dbo].[tblReservation] ([ID])
GO
ALTER TABLE [dbo].[tblBilling] CHECK CONSTRAINT [FK_tblBilling_tblReservation]
GO
ALTER TABLE [dbo].[tblPrice]  WITH CHECK ADD  CONSTRAINT [FK_Price_tblRoom] FOREIGN KEY([RoomID])
REFERENCES [dbo].[tblRoom] ([ID])
GO
ALTER TABLE [dbo].[tblPrice] CHECK CONSTRAINT [FK_Price_tblRoom]
GO
ALTER TABLE [dbo].[tblReservation]  WITH CHECK ADD  CONSTRAINT [FK_tblService_Guest] FOREIGN KEY([GuestID])
REFERENCES [dbo].[tblUser] ([ID])
GO
ALTER TABLE [dbo].[tblReservation] CHECK CONSTRAINT [FK_tblService_Guest]
GO
ALTER TABLE [dbo].[tblReservation]  WITH CHECK ADD  CONSTRAINT [FK_tblService_tblDiscount] FOREIGN KEY([DiscountID])
REFERENCES [dbo].[tblDiscount] ([ID])
GO
ALTER TABLE [dbo].[tblReservation] CHECK CONSTRAINT [FK_tblService_tblDiscount]
GO
ALTER TABLE [dbo].[tblReservation]  WITH CHECK ADD  CONSTRAINT [FK_tblService_tblRoom] FOREIGN KEY([RoomID])
REFERENCES [dbo].[tblRoom] ([ID])
GO
ALTER TABLE [dbo].[tblReservation] CHECK CONSTRAINT [FK_tblService_tblRoom]
GO
ALTER TABLE [dbo].[tblUser]  WITH CHECK ADD  CONSTRAINT [FK_tblUser_tblLogin] FOREIGN KEY([UserName])
REFERENCES [dbo].[tblLogin] ([username])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblUser] CHECK CONSTRAINT [FK_tblUser_tblLogin]
GO
