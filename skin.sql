USE [SkinMarket]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 05.07.2022 9:42:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[idClient] [int] IDENTITY(1,1) NOT NULL,
	[IdRole] [int] NULL,
	[idClientInformation] [int] NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[idClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientInformation]    Script Date: 05.07.2022 9:42:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientInformation](
	[idClientInformation] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Login] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Balance] [decimal](18, 0) NULL,
	[Link] [nvarchar](max) NULL,
	[Image] [image] NULL,
 CONSTRAINT [PK_ClientInformation] PRIMARY KEY CLUSTERED 
(
	[idClientInformation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Operation]    Script Date: 05.07.2022 9:42:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operation](
	[idOperation] [int] IDENTITY(1,1) NOT NULL,
	[idSkin] [int] NULL,
	[Date] [date] NULL,
	[TypeOperation] [nvarchar](50) NULL,
 CONSTRAINT [PK_Operation] PRIMARY KEY CLUSTERED 
(
	[idOperation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 05.07.2022 9:42:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[idRole] [int] NOT NULL,
	[Type] [nvarchar](50) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[idRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Skin]    Script Date: 05.07.2022 9:42:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skin](
	[idSkin] [int] IDENTITY(1,1) NOT NULL,
	[idClient] [int] NULL,
	[AveragePrice] [nvarchar](50) NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[LowestPrice] [nvarchar](50) NULL,
	[Currency] [nvarchar](50) NULL,
	[Price] [nvarchar](50) NULL,
	[Status] [bit] NULL,
	[Name] [nvarchar](max) NULL,
	[SkinSold] [bit] NULL,
 CONSTRAINT [PK_Skin] PRIMARY KEY CLUSTERED 
(
	[idSkin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([idClient], [IdRole], [idClientInformation]) VALUES (3, 1, 3)
INSERT [dbo].[Client] ([idClient], [IdRole], [idClientInformation]) VALUES (6, 3, 6)
INSERT [dbo].[Client] ([idClient], [IdRole], [idClientInformation]) VALUES (9, 2, 9)
INSERT [dbo].[Client] ([idClient], [IdRole], [idClientInformation]) VALUES (10, 2, 10)
INSERT [dbo].[Client] ([idClient], [IdRole], [idClientInformation]) VALUES (11, 2, 11)
INSERT [dbo].[Client] ([idClient], [IdRole], [idClientInformation]) VALUES (12, 2, 12)
INSERT [dbo].[Client] ([idClient], [IdRole], [idClientInformation]) VALUES (13, 2, 13)
INSERT [dbo].[Client] ([idClient], [IdRole], [idClientInformation]) VALUES (14, 2, 14)
INSERT [dbo].[Client] ([idClient], [IdRole], [idClientInformation]) VALUES (15, 2, 15)
INSERT [dbo].[Client] ([idClient], [IdRole], [idClientInformation]) VALUES (16, 2, 16)
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[ClientInformation] ON 

INSERT [dbo].[ClientInformation] ([idClientInformation], [Name], [Login], [Password], [Balance], [Link], [Image]) VALUES (3, N'2', N'2', N'2', CAST(917 AS Decimal(18, 0)), N'admin@admin', NULL)
INSERT [dbo].[ClientInformation] ([idClientInformation], [Name], [Login], [Password], [Balance], [Link], [Image]) VALUES (6, N'CSGO-BackPack', N'Shop', N'Shop', CAST(9999999 AS Decimal(18, 0)), N'CSBACK', NULL)
INSERT [dbo].[ClientInformation] ([idClientInformation], [Name], [Login], [Password], [Balance], [Link], [Image]) VALUES (9, N'testUser12', N'0', N'0', CAST(10000 AS Decimal(18, 0)), N' teest@mail', NULL)
INSERT [dbo].[ClientInformation] ([idClientInformation], [Name], [Login], [Password], [Balance], [Link], [Image]) VALUES (10, N'boba', N'4', N'4', CAST(10010 AS Decimal(18, 0)), N'boba@mail.ru', NULL)
INSERT [dbo].[ClientInformation] ([idClientInformation], [Name], [Login], [Password], [Balance], [Link], [Image]) VALUES (11, N'kokakola', N'1', N'1', CAST(10839 AS Decimal(18, 0)), N'bibka@gmail.ru', NULL)
INSERT [dbo].[ClientInformation] ([idClientInformation], [Name], [Login], [Password], [Balance], [Link], [Image]) VALUES (12, N'gg', N'15', N'15', CAST(43057 AS Decimal(18, 0)), N'ff@mail.commail', NULL)
INSERT [dbo].[ClientInformation] ([idClientInformation], [Name], [Login], [Password], [Balance], [Link], [Image]) VALUES (13, N'vile', N'5', N'5', CAST(10000 AS Decimal(18, 0)), N'12121212', NULL)
INSERT [dbo].[ClientInformation] ([idClientInformation], [Name], [Login], [Password], [Balance], [Link], [Image]) VALUES (14, N'boba', N'12', N'12', CAST(0 AS Decimal(18, 0)), N'121212', NULL)
INSERT [dbo].[ClientInformation] ([idClientInformation], [Name], [Login], [Password], [Balance], [Link], [Image]) VALUES (15, N'kild', N'6', N'6', CAST(19948 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[ClientInformation] ([idClientInformation], [Name], [Login], [Password], [Balance], [Link], [Image]) VALUES (16, N'mko', N'a', N'a', CAST(9990 AS Decimal(18, 0)), N' a', NULL)
SET IDENTITY_INSERT [dbo].[ClientInformation] OFF
GO
SET IDENTITY_INSERT [dbo].[Operation] ON 

INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (26, 22, CAST(N'2022-06-15' AS Date), N'buy skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (27, 23, CAST(N'2022-06-15' AS Date), N'buy skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (28, 22, CAST(N'2022-06-15' AS Date), N'sell skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (29, 24, CAST(N'2022-06-15' AS Date), N'buy skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (30, 25, CAST(N'2022-06-15' AS Date), N'buy skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (31, 26, CAST(N'2022-06-15' AS Date), N'buy skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (32, 26, CAST(N'2022-06-15' AS Date), N'sell skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (33, 25, CAST(N'2022-06-15' AS Date), N'sell skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (34, 27, CAST(N'2022-06-15' AS Date), N'buy skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (35, 28, CAST(N'2022-06-15' AS Date), N'buy skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (36, 29, CAST(N'2022-06-15' AS Date), N'buy skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (37, 29, CAST(N'2022-06-15' AS Date), N'sell skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (38, 30, CAST(N'2022-06-15' AS Date), N'buy skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (39, 24, CAST(N'2022-06-17' AS Date), N'sell skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (40, 31, CAST(N'2022-06-17' AS Date), N'buy skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (41, 31, CAST(N'2022-06-17' AS Date), N'sell skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (42, 32, CAST(N'2022-06-17' AS Date), N'buy skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (43, 32, CAST(N'2022-06-17' AS Date), N'sell skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (44, 33, CAST(N'2022-06-18' AS Date), N'buy skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (45, 34, CAST(N'2022-06-18' AS Date), N'buy skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (46, 35, CAST(N'2022-06-18' AS Date), N'buy skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (47, 35, CAST(N'2022-06-18' AS Date), N'sell skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (48, 36, CAST(N'2022-06-28' AS Date), N'buy skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (49, 36, CAST(N'2022-06-28' AS Date), N'sell skin')
INSERT [dbo].[Operation] ([idOperation], [idSkin], [Date], [TypeOperation]) VALUES (50, 37, CAST(N'2022-06-28' AS Date), N'buy skin')
SET IDENTITY_INSERT [dbo].[Operation] OFF
GO
INSERT [dbo].[Role] ([idRole], [Type]) VALUES (1, N'Admin')
INSERT [dbo].[Role] ([idRole], [Type]) VALUES (2, N'Client')
INSERT [dbo].[Role] ([idRole], [Type]) VALUES (3, N'Market')
GO
SET IDENTITY_INSERT [dbo].[Skin] ON 

INSERT [dbo].[Skin] ([idSkin], [idClient], [AveragePrice], [ImageUrl], [LowestPrice], [Currency], [Price], [Status], [Name], [SkinSold]) VALUES (22, 12, N'62.29', N'http://cdn.steamcommunity.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhnwMzJemkV08-jhIWZlP_1IbzUklRZ7cRnk6eSp92h2gGwrkRvZGymI4aVcwY5ZVuFrAS5xuy605e1v5_PznEyvyBx-z-DyHxgUuDa/', N'53.96', N'USD', N'54.000', 1, N'AK-47 | Fuel Injector (Battle-Scarred)', 1)
INSERT [dbo].[Skin] ([idSkin], [idClient], [AveragePrice], [ImageUrl], [LowestPrice], [Currency], [Price], [Status], [Name], [SkinSold]) VALUES (23, 12, N'60.19', N'http://cdn.steamcommunity.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhnwMzJemkV0966m4-PhOf7Ia_um25V4dB8xO3Hpdn22lWxqUc9Zmr0J9XBIw89M1GGqFC8ybzvgMLvvJ6azSE1viM8pSGK5KY2J5A/', N'53.96', N'USD', N'50.800', 0, N'AK-47 | Bloodsport (Field-Tested)', 0)
INSERT [dbo].[Skin] ([idSkin], [idClient], [AveragePrice], [ImageUrl], [LowestPrice], [Currency], [Price], [Status], [Name], [SkinSold]) VALUES (24, 11, N'62.29', N'http://cdn.steamcommunity.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhnwMzJemkV08-jhIWZlP_1IbzUklRZ7cRnk6eSp92h2gGwrkRvZGymI4aVcwY5ZVuFrAS5xuy605e1v5_PznEyvyBx-z-DyHxgUuDa/', N'53.96', N'USD', N'54.000', 1, N'AK-47 | Fuel Injector (Battle-Scarred)', 0)
INSERT [dbo].[Skin] ([idSkin], [idClient], [AveragePrice], [ImageUrl], [LowestPrice], [Currency], [Price], [Status], [Name], [SkinSold]) VALUES (25, 11, N'117.4', N'http://cdn.steamcommunity.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhhwszHeDFH6OO-kYGdjrmjYuvSwDIAvpAnib3C9o_3jFDsr0JpYWzyJ4eWIA48NQmB_Fm2lbzsm9bi66WZ81pV/', N'97.54', N'USD', N'100', 1, N'AK-47 | Case Hardened (Battle-Scarred)', 1)
INSERT [dbo].[Skin] ([idSkin], [idClient], [AveragePrice], [ImageUrl], [LowestPrice], [Currency], [Price], [Status], [Name], [SkinSold]) VALUES (26, 11, N'9.12', N'http://cdn.steamcommunity.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhoyszJemkV4N27q4KHgvLLPr7Vn35cppJ02uyUrI2h3wDkrkFsZz-gLdXHIA87MFjTqFm-wevvjcC0tZrPnXp9-n51Y5J6evE/', N'7.59', N'USD', N'9', 1, N'AK-47 | Blue Laminate (Well-Worn)', 1)
INSERT [dbo].[Skin] ([idSkin], [idClient], [AveragePrice], [ImageUrl], [LowestPrice], [Currency], [Price], [Status], [Name], [SkinSold]) VALUES (27, 12, N'9.12', N'http://cdn.steamcommunity.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhoyszJemkV4N27q4KHgvLLPr7Vn35cppJ02uyUrI2h3wDkrkFsZz-gLdXHIA87MFjTqFm-wevvjcC0tZrPnXp9-n51Y5J6evE/', N'7.59', N'USD', N'9', 0, N'AK-47 | Blue Laminate (Well-Worn)', 0)
INSERT [dbo].[Skin] ([idSkin], [idClient], [AveragePrice], [ImageUrl], [LowestPrice], [Currency], [Price], [Status], [Name], [SkinSold]) VALUES (28, 12, N'117.4', N'http://cdn.steamcommunity.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhhwszHeDFH6OO-kYGdjrmjYuvSwDIAvpAnib3C9o_3jFDsr0JpYWzyJ4eWIA48NQmB_Fm2lbzsm9bi66WZ81pV/', N'97.54', N'USD', N'100', 0, N'AK-47 | Case Hardened (Battle-Scarred)', 0)
INSERT [dbo].[Skin] ([idSkin], [idClient], [AveragePrice], [ImageUrl], [LowestPrice], [Currency], [Price], [Status], [Name], [SkinSold]) VALUES (29, 13, N'27.04', N'http://cdn.steamcommunity.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgposbaqKAxf2-r3dTlS7ciJhImFnMj8NrrHj1Rd6dd2j6eV9tqkjQKy-xFrMGr0IISUdwE4YViF_AK5wuzph8K8tZrPyHQy7ilz-z-DyLdyMPZ_/', N'25.23', N'USD', N'26', 1, N'Glock-18 | Pink DDPAT (Battle-Scarred)', 1)
INSERT [dbo].[Skin] ([idSkin], [idClient], [AveragePrice], [ImageUrl], [LowestPrice], [Currency], [Price], [Status], [Name], [SkinSold]) VALUES (30, 12, N'27.04', N'http://cdn.steamcommunity.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgposbaqKAxf2-r3dTlS7ciJhImFnMj8NrrHj1Rd6dd2j6eV9tqkjQKy-xFrMGr0IISUdwE4YViF_AK5wuzph8K8tZrPyHQy7ilz-z-DyLdyMPZ_/', N'25.23', N'USD', N'26', 0, N'Glock-18 | Pink DDPAT (Battle-Scarred)', 0)
INSERT [dbo].[Skin] ([idSkin], [idClient], [AveragePrice], [ImageUrl], [LowestPrice], [Currency], [Price], [Status], [Name], [SkinSold]) VALUES (31, 11, N'4.72', N'http://cdn.steamcommunity.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhjxszJemkV09G3h5SOhe7LP7LWnn8fvJYh3-qR942higTmqBZpYGild4adIQQ5ZA6B_AC3lebo0ce-78vOnGwj5HeAJ9sV6g/', N'3.53', N'USD', N'4.210', 1, N'AK-47 | Elite Build (Factory New)', 0)
INSERT [dbo].[Skin] ([idSkin], [idClient], [AveragePrice], [ImageUrl], [LowestPrice], [Currency], [Price], [Status], [Name], [SkinSold]) VALUES (32, 11, N'0.09', N'http://cdn.steamcommunity.com/economy/image/IzMF03bi9WpSBq-S-ekoE33L-iLqGFHVaU25ZzQNQcXdB2ozio1RrlIWFK3UfvMYB8UsvjiMXojflsZalyxSh31CIyHz2GZ-KuFpPsrTzBGp8bPUU2b7cQjILjPeGRAwS7dZYWzaq2Kj7LmWRDufRbx-EQ9XdatSoW1KacjbPxJrh4Fa-WC92VRzGVArfclJYgKuxmAaIbE8lXgWcJ1VyDUzM2az/', N'0.06', N'USD', N'0.08', 1, N'Sealed Graffiti | Rly (Princess Pink)', 1)
INSERT [dbo].[Skin] ([idSkin], [idClient], [AveragePrice], [ImageUrl], [LowestPrice], [Currency], [Price], [Status], [Name], [SkinSold]) VALUES (33, 15, N'59.02', N'http://cdn.steamcommunity.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhnwMzJemkV0966m4-PhOf7Ia_um25V4dB8xO3Hpdn22lWxqUc9Zmr0J9XBIw89M1GGqFC8ybzvgMLvvJ6azSE1viM8pSGK5KY2J5A/', N'53.9', N'USD', N'52.000', 0, N'AK-47 | Bloodsport (Field-Tested)', 0)
INSERT [dbo].[Skin] ([idSkin], [idClient], [AveragePrice], [ImageUrl], [LowestPrice], [Currency], [Price], [Status], [Name], [SkinSold]) VALUES (34, 16, N'8.9', N'http://cdn.steamcommunity.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhoyszJemkV4N27q4KHgvLLPr7Vn35cppJ02uyUrI2h3wDkrkFsZz-gLdXHIA87MFjTqFm-wevvjcC0tZrPnXp9-n51Y5J6evE/', N'7.51', N'USD', N'9.495', 0, N'AK-47 | Blue Laminate (Well-Worn)', 0)
INSERT [dbo].[Skin] ([idSkin], [idClient], [AveragePrice], [ImageUrl], [LowestPrice], [Currency], [Price], [Status], [Name], [SkinSold]) VALUES (35, 16, N'0.09', N'http://cdn.steamcommunity.com/economy/image/IzMF03bi9WpSBq-S-ekoE33L-iLqGFHVaU25ZzQNQcXdB2ozio1RrlIWFK3UfvMYB8UsvjiMXojflsZalyxSh31CIyHz2GZ-KuFpPsrTzBGp8bPUU2b7cQjILjPeGRAwS7dZYWzaq2Kj7LmWRDufRbx-EQ9XdatSoW1KacjbPxJrh4Fa-WC92VRzGVArfclJYgKuxmAaIbE8lXgWcJ1VyDUzM2az/', N'0.06', N'USD', N'0.08', 1, N'Sealed Graffiti | Rly (Princess Pink)', 0)
INSERT [dbo].[Skin] ([idSkin], [idClient], [AveragePrice], [ImageUrl], [LowestPrice], [Currency], [Price], [Status], [Name], [SkinSold]) VALUES (36, 11, N'83.73', N'http://cdn.steamcommunity.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhjxszYcDNW5Nmkq4GAw6DLP7LWnn8fvscmibGTpdSmigGyqRFrYm_wJdfBdQ84YAmD-1S6wrru08W-7ZianWwj5HfSt_Eogg/', N'75.9', N'USD', N'83', 1, N'AK-47 | Jaguar (Factory New)', 1)
INSERT [dbo].[Skin] ([idSkin], [idClient], [AveragePrice], [ImageUrl], [LowestPrice], [Currency], [Price], [Status], [Name], [SkinSold]) VALUES (37, 3, N'83.73', N'http://cdn.steamcommunity.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhjxszYcDNW5Nmkq4GAw6DLP7LWnn8fvscmibGTpdSmigGyqRFrYm_wJdfBdQ84YAmD-1S6wrru08W-7ZianWwj5HfSt_Eogg/', N'75.9', N'USD', N'83', 0, N'AK-47 | Jaguar (Factory New)', 0)
SET IDENTITY_INSERT [dbo].[Skin] OFF
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_ClientInformation] FOREIGN KEY([idClientInformation])
REFERENCES [dbo].[ClientInformation] ([idClientInformation])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_ClientInformation]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Role] FOREIGN KEY([IdRole])
REFERENCES [dbo].[Role] ([idRole])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Role]
GO
ALTER TABLE [dbo].[Operation]  WITH CHECK ADD  CONSTRAINT [FK_Operation_Skin] FOREIGN KEY([idSkin])
REFERENCES [dbo].[Skin] ([idSkin])
GO
ALTER TABLE [dbo].[Operation] CHECK CONSTRAINT [FK_Operation_Skin]
GO
ALTER TABLE [dbo].[Skin]  WITH CHECK ADD  CONSTRAINT [FK_Skin_Client] FOREIGN KEY([idClient])
REFERENCES [dbo].[Client] ([idClient])
GO
ALTER TABLE [dbo].[Skin] CHECK CONSTRAINT [FK_Skin_Client]
GO
