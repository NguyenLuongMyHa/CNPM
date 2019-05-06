USE [HotelManagement]
GO
ALTER TABLE [dbo].[tblUser] DROP CONSTRAINT [FK_tblUser_tblLogin]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 5/7/2019 1:01:59 AM ******/
DROP TABLE [dbo].[tblUser]
GO
/****** Object:  Table [dbo].[tblLogin]    Script Date: 5/7/2019 1:01:59 AM ******/
DROP TABLE [dbo].[tblLogin]
GO
/****** Object:  Table [dbo].[tblLogin]    Script Date: 5/7/2019 1:01:59 AM ******/
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
/****** Object:  Table [dbo].[tblUser]    Script Date: 5/7/2019 1:01:59 AM ******/
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
	[Status] [nvarchar](50) NULL,
	[Remarks] [nvarchar](50) NULL,
	[UserName] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblGuest] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'hanguyen', N'16110060', N'Manager')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'huynhle', N'123456', N'Guest')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'phuocnguyen', N'123456', N'Guest')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'quile', N'123456', N'Guest')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'recept1', N'123456', N'Receptionist')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'recept2', N'123654', N'Receptionist')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'thinh', N'123456', N'Receptionist')
INSERT [dbo].[tblLogin] ([username], [password], [role]) VALUES (N'thuyngan', N'123456', N'Guest')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Status], [Remarks], [UserName]) VALUES (1, N'Nguyen', N'Luong My', N'Ha', N'Binh Chanh', N'0777774315', N'Female', N'nguyenluongmyha@gmail.com', N'Active', N'Available', N'hanguyen')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Status], [Remarks], [UserName]) VALUES (2, N'Lê', N'Bá', N'Huỳnh', N'Quận 9', N'123456789', N'Male', N'huynhle@gmail.com', N'Active', N'Available', N'huynhle')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Status], [Remarks], [UserName]) VALUES (3, N'Nguyen', N'Cong', N'Thinh', N'Thủ Đức', N'0777774315', N'Male', N'nguyencongthinh@gmail.com', N'Active', N'Available', N'thinh')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Status], [Remarks], [UserName]) VALUES (4, N'Lê', N'Duy', N'Quí', N'Vũng Tàu', N'123654987', N'Male', N'quile@gmail.com', N'Active', N'Available', N'quile')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Status], [Remarks], [UserName]) VALUES (5, N'Nguyễn', N'Thúy', N'Ngân', N'Bình Chánh', N'0123654987', N'Female', N'thuyngan@gmail.com', N'Active', N'Available', N'thuyngan')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Status], [Remarks], [UserName]) VALUES (6, N'Nguyễn', N'Duy', N'Phước', N'Hoảng Diệu 2', N'123456789', N'Male', N'phuocnguyen@gmail.com', N'Active', N'Available', N'phuocnguyen')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Status], [Remarks], [UserName]) VALUES (7, N'recep1', N'', N'', N'', N'', N'Female', N'', N'Active', N'Available', N'recept1')
INSERT [dbo].[tblUser] ([ID], [UserFName], [UserMName], [UserLName], [UserAddress], [UserContactNumber], [UserGender], [UserEmail], [Status], [Remarks], [UserName]) VALUES (8, N'recept2', N'', N'', N'', N'', N'Female', N'', N'Active', N'Available', N'recept2')
ALTER TABLE [dbo].[tblUser]  WITH CHECK ADD  CONSTRAINT [FK_tblUser_tblLogin] FOREIGN KEY([UserName])
REFERENCES [dbo].[tblLogin] ([username])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblUser] CHECK CONSTRAINT [FK_tblUser_tblLogin]
GO
