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
/****** Object:  Table [dbo].[tblUser]    Script Date: 5/28/2019 8:55:39 AM ******/
DROP TABLE [dbo].[tblUser]
GO
/****** Object:  Table [dbo].[tblRoom]    Script Date: 5/28/2019 8:55:39 AM ******/
DROP TABLE [dbo].[tblRoom]
GO
/****** Object:  Table [dbo].[tblReservation]    Script Date: 5/28/2019 8:55:39 AM ******/
DROP TABLE [dbo].[tblReservation]
GO
/****** Object:  Table [dbo].[tblLogin]    Script Date: 5/28/2019 8:55:39 AM ******/
DROP TABLE [dbo].[tblLogin]
GO
/****** Object:  Table [dbo].[tblDiscount]    Script Date: 5/28/2019 8:55:39 AM ******/
DROP TABLE [dbo].[tblDiscount]
GO
/****** Object:  Table [dbo].[tblDiscount]    Script Date: 5/28/2019 8:55:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDiscount](
	[ID] [int] NOT NULL,
	[DiscountType] [nvarchar](50) NULL,
	[DiscountRate] [int] NULL,
 CONSTRAINT [PK_tblDiscount] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLogin]    Script Date: 5/28/2019 8:55:39 AM ******/
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
/****** Object:  Table [dbo].[tblReservation]    Script Date: 5/28/2019 8:55:39 AM ******/
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
	[AdvancePayment] [int] NULL,
	[DiscountID] [int] NULL,
	[Remarks] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblService] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRoom]    Script Date: 5/28/2019 8:55:39 AM ******/
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
/****** Object:  Table [dbo].[tblUser]    Script Date: 5/28/2019 8:55:39 AM ******/
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
INSERT [dbo].[tblDiscount] ([ID], [DiscountType], [DiscountRate]) VALUES (1, N'Giáng Sinh 2019', 20)
INSERT [dbo].[tblDiscount] ([ID], [DiscountType], [DiscountRate]) VALUES (2, N'Tết Dương Lịch 2019', 30)
INSERT [dbo].[tblDiscount] ([ID], [DiscountType], [DiscountRate]) VALUES (3, N'Sinh Nhật Khách Sạn', 50)
INSERT [dbo].[tblDiscount] ([ID], [DiscountType], [DiscountRate]) VALUES (4, N'Tri Ân Khách Hàng ', 40)
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'hanguyen', N'16110060', N'Manager')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'huyh', N'123456', N'Guest')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'phuocnguyen', N'123456', N'Guest')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'quile', N'123456', N'Receptionist')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'thinh', N'123456', N'Receptionist')
INSERT [dbo].[tblReservation] ([ID], [GuestID], [RoomID], [CheckInDate], [CheckOutDate], [NoOfChild], [NoOfAdult], [AdvancePayment], [DiscountID], [Remarks]) VALUES (1, 2, 1, CAST(N'2019-05-27T00:00:00.000' AS DateTime), CAST(N'2019-05-29T00:00:00.000' AS DateTime), 1, 1, 0, 1, N'Checkin')
INSERT [dbo].[tblReservation] ([ID], [GuestID], [RoomID], [CheckInDate], [CheckOutDate], [NoOfChild], [NoOfAdult], [AdvancePayment], [DiscountID], [Remarks]) VALUES (2, 6, 2, CAST(N'2019-05-29T00:00:00.000' AS DateTime), CAST(N'2019-05-31T00:00:00.000' AS DateTime), 0, 2, 10000, 1, N'Reserve')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (1, N'101', N'phòng đơn', 4, 2, N'Occupied')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (2, N'102', N'phòng đơn', 3, 2, N'Reserve')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (3, N'103', N'phòng đôi', 4, 5, N'Available')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (4, N'104', N'phòng đôi', 2, 5, N'Available')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (5, N'201', N'phòng đơn', 4, 2, N'Available')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (6, N'202', N'phòng đôi', 4, 5, N'Available')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (7, N'203', N'phòng đôi', 3, 8, N'Available')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (8, N'301', N'dorm', 3, 16, N'Available')
INSERT [dbo].[tblRoom] ([ID], [RoomNumber], [RoomType], [RoomRate], [NoOfOccupancy], [Status]) VALUES (9, N'302', N'dorm', 4, 8, N'Available')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Remarks], [UserName]) VALUES (1, N'Nguyen', N'Luong My', N'Ha', N'Binh Chanh', N'0777774315', N'Female', N'nguyenluongmyha@gmail.com', N'Available', N'hanguyen')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Remarks], [UserName]) VALUES (2, N'Lê', N'Bá', N'Huỳnh', N'Q9', N'123456789', N'Female', N'huynhle@gmail.com', N'Available', N'huyh')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Remarks], [UserName]) VALUES (3, N'Nguyễn', N'Công', N'Thịnh', N'Quận Thủ Đức', N'00112233', N'Male', N'thinh@gmail.com', N'Available', N'thinh')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Remarks], [UserName]) VALUES (4, N'Lê', N'Duy', N'Quí', N'Vũng Tàu', N'987654321', N'Female', N'quile@gmail.com', N'Available', N'quile')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Remarks], [UserName]) VALUES (6, N'Nguyễn', N'Duy', N'Phước', N'Q9', N'0123456798', N'Male', N'123456789', N'Available', N'phuocnguyen')
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
