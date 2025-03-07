USE [master]
GO
/****** Object:  Database [P_GYMMM]    Script Date: 02/02/2025 14:40:27 ******/
CREATE DATABASE [P_GYMMM] ON  PRIMARY 
( NAME = N'P_GYMMM', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\P_GYMMM.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'P_GYMMM_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\P_GYMMM_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [P_GYMMM] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [P_GYMMM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [P_GYMMM] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [P_GYMMM] SET ANSI_NULLS OFF
GO
ALTER DATABASE [P_GYMMM] SET ANSI_PADDING OFF
GO
ALTER DATABASE [P_GYMMM] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [P_GYMMM] SET ARITHABORT OFF
GO
ALTER DATABASE [P_GYMMM] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [P_GYMMM] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [P_GYMMM] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [P_GYMMM] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [P_GYMMM] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [P_GYMMM] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [P_GYMMM] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [P_GYMMM] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [P_GYMMM] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [P_GYMMM] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [P_GYMMM] SET  DISABLE_BROKER
GO
ALTER DATABASE [P_GYMMM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [P_GYMMM] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [P_GYMMM] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [P_GYMMM] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [P_GYMMM] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [P_GYMMM] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [P_GYMMM] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [P_GYMMM] SET  READ_WRITE
GO
ALTER DATABASE [P_GYMMM] SET RECOVERY SIMPLE
GO
ALTER DATABASE [P_GYMMM] SET  MULTI_USER
GO
ALTER DATABASE [P_GYMMM] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [P_GYMMM] SET DB_CHAINING OFF
GO
USE [P_GYMMM]
GO
/****** Object:  Table [dbo].[Equipment_Category]    Script Date: 02/02/2025 14:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Equipment_Category](
	[EC_ID] [int] NOT NULL,
	[EC_NAME] [varchar](50) NULL,
 CONSTRAINT [PK_Equipment_Category] PRIMARY KEY CLUSTERED 
(
	[EC_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Equipment_Category] ([EC_ID], [EC_NAME]) VALUES (1, N'Cardio')
INSERT [dbo].[Equipment_Category] ([EC_ID], [EC_NAME]) VALUES (2, N'Strength')
INSERT [dbo].[Equipment_Category] ([EC_ID], [EC_NAME]) VALUES (3, N'Functional Training')
INSERT [dbo].[Equipment_Category] ([EC_ID], [EC_NAME]) VALUES (4, N'Yoga/Pilates')
INSERT [dbo].[Equipment_Category] ([EC_ID], [EC_NAME]) VALUES (5, N'jjjbgdhfb')
INSERT [dbo].[Equipment_Category] ([EC_ID], [EC_NAME]) VALUES (6, N'rope')
/****** Object:  Table [dbo].[CITY]    Script Date: 02/02/2025 14:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CITY](
	[C_ID] [int] NOT NULL,
	[C_NAME] [varchar](50) NULL,
 CONSTRAINT [PK_CITY] PRIMARY KEY CLUSTERED 
(
	[C_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (1, N'Ahmedabad')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (2, N'Amreli')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (3, N'Anand')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (4, N'Banaskantha')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (5, N'Baroda')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (6, N'Bharuch')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (7, N'Bhavnagar')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (8, N'Dahod')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (9, N'Dang')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (10, N'Dwarka')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (11, N'Gandhinagar')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (12, N'Jamnagar')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (13, N'Junagadh')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (14, N'Kheda')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (15, N'Kutch')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (16, N'Mehsana')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (17, N'Nadiad')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (18, N'Narmada')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (19, N'Navsari')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (20, N'Panchmahals')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (21, N'Patan')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (22, N'Porbandar')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (23, N'Rajkot')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (24, N'Sabarkantha')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (25, N'Surat')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (26, N'Surendranagar')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (27, N'Vadodara')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (28, N'Valsad')
INSERT [dbo].[CITY] ([C_ID], [C_NAME]) VALUES (29, N'Vapi')
/****** Object:  Table [dbo].[ADMIN_TBL]    Script Date: 02/02/2025 14:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ADMIN_TBL](
	[A_ID] [int] NOT NULL,
	[pass] [varchar](50) NULL,
 CONSTRAINT [PK_ADMIN_TBL] PRIMARY KEY CLUSTERED 
(
	[A_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ADMIN_TBL] ([A_ID], [pass]) VALUES (1, N'1234')
/****** Object:  Table [dbo].[NewMember]    Script Date: 02/02/2025 14:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NewMember](
	[MID] [int] IDENTITY(1,1) NOT NULL,
	[Fname] [varchar](50) NOT NULL,
	[Lname] [varchar](50) NOT NULL,
	[Gender] [varchar](10) NOT NULL,
	[Dob] [varchar](75) NOT NULL,
	[Mobile] [bigint] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[JoinDate] [varchar](50) NOT NULL,
	[GymTime] [varchar](50) NOT NULL,
	[Maddress] [varchar](500) NOT NULL,
	[MembershipTime] [varchar](50) NOT NULL,
 CONSTRAINT [PK_NewMember] PRIMARY KEY CLUSTERED 
(
	[MID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[NewMember] ON
INSERT [dbo].[NewMember] ([MID], [Fname], [Lname], [Gender], [Dob], [Mobile], [Email], [JoinDate], [GymTime], [Maddress], [MembershipTime]) VALUES (1, N'Asmi', N'Matliwala', N'Female', N'05-04-2004', 7043047739, N'21bmiit123@gmail.com', N'11-04-2023', N'07AM-08AM', N'df sf srgre gewreygey gyds   y gfsadgfd ggygsdb jkdhgdhfdghgdshgu bhdhjdgkhdbhj ', N'1 Month')
INSERT [dbo].[NewMember] ([MID], [Fname], [Lname], [Gender], [Dob], [Mobile], [Email], [JoinDate], [GymTime], [Maddress], [MembershipTime]) VALUES (3, N'Preet', N'Jariwala', N'Male', N'12-04-2023', 7894561230, N'fdcfc@gmail.com', N'12-04-2023', N'07AM-08AM', N'gyft ftyf tftrd ydt fddfyu gfdxffhjcft y fgh ', N'3 Month')
SET IDENTITY_INSERT [dbo].[NewMember] OFF
/****** Object:  Table [dbo].[Equipment_tbl]    Script Date: 02/02/2025 14:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Equipment_tbl](
	[E_ID] [int] NOT NULL,
	[E_NAME] [varchar](100) NULL,
	[C_ID] [int] NULL,
	[E_PRICE] [int] NULL,
 CONSTRAINT [PK_Equipment_tbl] PRIMARY KEY CLUSTERED 
(
	[E_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Equipment_tbl] ([E_ID], [E_NAME], [C_ID], [E_PRICE]) VALUES (1, N'Treadmil', 1, 70000)
INSERT [dbo].[Equipment_tbl] ([E_ID], [E_NAME], [C_ID], [E_PRICE]) VALUES (2, N'Elloptical', 1, 50000)
INSERT [dbo].[Equipment_tbl] ([E_ID], [E_NAME], [C_ID], [E_PRICE]) VALUES (3, N'Stationary bike', 1, 30000)
INSERT [dbo].[Equipment_tbl] ([E_ID], [E_NAME], [C_ID], [E_PRICE]) VALUES (4, N'Rowing matchine', 1, 45000)
INSERT [dbo].[Equipment_tbl] ([E_ID], [E_NAME], [C_ID], [E_PRICE]) VALUES (5, N'Weight bentch', 2, 15000)
INSERT [dbo].[Equipment_tbl] ([E_ID], [E_NAME], [C_ID], [E_PRICE]) VALUES (6, N'Squat rack', 2, 25000)
INSERT [dbo].[Equipment_tbl] ([E_ID], [E_NAME], [C_ID], [E_PRICE]) VALUES (7, N'Smith machine', 2, 100000)
INSERT [dbo].[Equipment_tbl] ([E_ID], [E_NAME], [C_ID], [E_PRICE]) VALUES (8, N'Cable machine', 2, 110000)
INSERT [dbo].[Equipment_tbl] ([E_ID], [E_NAME], [C_ID], [E_PRICE]) VALUES (9, N'Kettlebell', 3, 4000)
INSERT [dbo].[Equipment_tbl] ([E_ID], [E_NAME], [C_ID], [E_PRICE]) VALUES (10, N'Medicine ball', 3, 2500)
INSERT [dbo].[Equipment_tbl] ([E_ID], [E_NAME], [C_ID], [E_PRICE]) VALUES (11, N'Battle ropes', 3, 7000)
INSERT [dbo].[Equipment_tbl] ([E_ID], [E_NAME], [C_ID], [E_PRICE]) VALUES (12, N'Yoga mat', 4, 400)
INSERT [dbo].[Equipment_tbl] ([E_ID], [E_NAME], [C_ID], [E_PRICE]) VALUES (13, N'Pilates ring', 4, 600)
INSERT [dbo].[Equipment_tbl] ([E_ID], [E_NAME], [C_ID], [E_PRICE]) VALUES (14, N'rope1', 6, 500)
INSERT [dbo].[Equipment_tbl] ([E_ID], [E_NAME], [C_ID], [E_PRICE]) VALUES (15, N'msjkdcbjydbvchjd', 6, 600)
/****** Object:  Table [dbo].[NewStaff]    Script Date: 02/02/2025 14:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NewStaff](
	[SID] [int] IDENTITY(1,1) NOT NULL,
	[Fname] [varchar](50) NOT NULL,
	[Lname] [varchar](50) NOT NULL,
	[Gender] [varchar](10) NOT NULL,
	[Dob] [varchar](75) NOT NULL,
	[Mobile] [bigint] NOT NULL,
	[Salary] [bigint] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[JoinDate] [varchar](50) NOT NULL,
	[C_ID] [int] NOT NULL,
	[Saddress] [varchar](300) NOT NULL,
	[Password] [int] NULL,
 CONSTRAINT [PK_NewStaff] PRIMARY KEY CLUSTERED 
(
	[SID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[NewStaff] ON
INSERT [dbo].[NewStaff] ([SID], [Fname], [Lname], [Gender], [Dob], [Mobile], [Salary], [Email], [JoinDate], [C_ID], [Saddress], [Password]) VALUES (1, N'Parth', N'Patel', N'Male', N'03-03-2004', 1234567879, 50000, N'1hdshdvzghx@gmail.com', N'11-04-2023', 25, N'fds fd gfdsg g fdsg', 1234)
INSERT [dbo].[NewStaff] ([SID], [Fname], [Lname], [Gender], [Dob], [Mobile], [Salary], [Email], [JoinDate], [C_ID], [Saddress], [Password]) VALUES (3, N'MEgh', N'Gadiyali', N'Male', N'07-02-2020', 2312132423, 60000, N'jbgvhgdb@gmail.com', N'12-04-2023', 25, N'egyfdyughwiecf gucoe fuycc r gucbhqcjidefhcerob jdcerkmdchfjewvkmdevwmfd', 1234)
SET IDENTITY_INSERT [dbo].[NewStaff] OFF
/****** Object:  Table [dbo].[order_tb]    Script Date: 02/02/2025 14:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[order_tb](
	[o_id] [int] IDENTITY(1,1) NOT NULL,
	[oec_id] [int] NULL,
	[oe_id] [int] NULL,
	[oe_address] [varchar](300) NULL,
	[oe_price] [int] NULL,
	[or_qty] [int] NULL,
	[ot_total] [bigint] NULL,
 CONSTRAINT [PK_order_tb] PRIMARY KEY CLUSTERED 
(
	[o_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[order_tb] ON
INSERT [dbo].[order_tb] ([o_id], [oec_id], [oe_id], [oe_address], [oe_price], [or_qty], [ot_total]) VALUES (1, 3, 11, N' fdssgsdg sfdgdbsfhdsfnhd', 7000, 15, 105000)
INSERT [dbo].[order_tb] ([o_id], [oec_id], [oe_id], [oe_address], [oe_price], [or_qty], [ot_total]) VALUES (2, 1, 2, N'rtgryhswyhsys', 50000, 4, 200000)
INSERT [dbo].[order_tb] ([o_id], [oec_id], [oe_id], [oe_address], [oe_price], [or_qty], [ot_total]) VALUES (3, 1, 2, N'rtbsrdyntdjbvvsrbdtjbh', 50000, 2, 100000)
INSERT [dbo].[order_tb] ([o_id], [oec_id], [oe_id], [oe_address], [oe_price], [or_qty], [ot_total]) VALUES (4, 2, 5, N' vatgaryhtrreetqwretrheeyt', 15000, 3, 45000)
INSERT [dbo].[order_tb] ([o_id], [oec_id], [oe_id], [oe_address], [oe_price], [or_qty], [ot_total]) VALUES (5, 2, 6, N'r ewbryrtheewfwqefrgethey', 25000, 4, 100000)
INSERT [dbo].[order_tb] ([o_id], [oec_id], [oe_id], [oe_address], [oe_price], [or_qty], [ot_total]) VALUES (7, 6, 14, N'rehyjcty yecwr twer', 500, 4, 2000)
INSERT [dbo].[order_tb] ([o_id], [oec_id], [oe_id], [oe_address], [oe_price], [or_qty], [ot_total]) VALUES (8, 2, 6, N'ebatsr rb', 25000, 2, 50000)
SET IDENTITY_INSERT [dbo].[order_tb] OFF
/****** Object:  ForeignKey [FK_Equipment_tbl_Equipment_Category]    Script Date: 02/02/2025 14:40:47 ******/
ALTER TABLE [dbo].[Equipment_tbl]  WITH CHECK ADD  CONSTRAINT [FK_Equipment_tbl_Equipment_Category] FOREIGN KEY([C_ID])
REFERENCES [dbo].[Equipment_Category] ([EC_ID])
GO
ALTER TABLE [dbo].[Equipment_tbl] CHECK CONSTRAINT [FK_Equipment_tbl_Equipment_Category]
GO
/****** Object:  ForeignKey [FK_NewStaff_CITY]    Script Date: 02/02/2025 14:40:47 ******/
ALTER TABLE [dbo].[NewStaff]  WITH CHECK ADD  CONSTRAINT [FK_NewStaff_CITY] FOREIGN KEY([C_ID])
REFERENCES [dbo].[CITY] ([C_ID])
GO
ALTER TABLE [dbo].[NewStaff] CHECK CONSTRAINT [FK_NewStaff_CITY]
GO
/****** Object:  ForeignKey [FK_order_tb_Equipment_Category]    Script Date: 02/02/2025 14:40:47 ******/
ALTER TABLE [dbo].[order_tb]  WITH CHECK ADD  CONSTRAINT [FK_order_tb_Equipment_Category] FOREIGN KEY([oec_id])
REFERENCES [dbo].[Equipment_Category] ([EC_ID])
GO
ALTER TABLE [dbo].[order_tb] CHECK CONSTRAINT [FK_order_tb_Equipment_Category]
GO
/****** Object:  ForeignKey [FK_order_tb_Equipment_tbl]    Script Date: 02/02/2025 14:40:47 ******/
ALTER TABLE [dbo].[order_tb]  WITH CHECK ADD  CONSTRAINT [FK_order_tb_Equipment_tbl] FOREIGN KEY([oe_id])
REFERENCES [dbo].[Equipment_tbl] ([E_ID])
GO
ALTER TABLE [dbo].[order_tb] CHECK CONSTRAINT [FK_order_tb_Equipment_tbl]
GO
