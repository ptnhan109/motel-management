USE [sale_test]
GO
/****** Object:  Schema [moma.ptnhan.net]    Script Date: 5/20/2024 8:21:52 AM ******/
CREATE SCHEMA [moma.ptnhan.net]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/20/2024 8:21:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppContracts]    Script Date: 5/20/2024 8:21:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppContracts](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[ContractNo] [nvarchar](100) NULL,
	[CustomerId] [uniqueidentifier] NULL,
	[Name] [nvarchar](255) NULL,
	[CustomerName] [nvarchar](63) NULL,
	[CustomerPhone] [nvarchar](16) NULL,
	[RoomId] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ExpiredDate] [datetime2](7) NULL,
	[DepositedAmount] [decimal](18, 2) NOT NULL,
	[Type] [int] NOT NULL,
	[ContractDuration] [int] NULL,
	[Status] [int] NOT NULL,
	[AdvanceAmount] [decimal](18, 2) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_AppContracts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BoardingHouses]    Script Date: 5/20/2024 8:21:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoardingHouses](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[Name] [nvarchar](150) NULL,
	[Address] [nvarchar](250) NULL,
	[Description] [nvarchar](150) NULL,
	[Months] [int] NOT NULL,
	[StartDatePayment] [int] NULL,
	[EndDatePayment] [int] NULL,
	[CityId] [uniqueidentifier] NULL,
	[IsNotLimitTime] [bit] NULL,
	[IsSelfPayment] [bit] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_BoardingHouses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 5/20/2024 8:21:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContractTerm]    Script Date: 5/20/2024 8:21:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractTerm](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[AppContractId] [uniqueidentifier] NOT NULL,
	[Type] [int] NOT NULL,
	[Content] [nvarchar](max) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_ContractTerm] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 5/20/2024 8:21:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Phone] [nvarchar](16) NULL,
	[BirthDay] [datetime2](7) NOT NULL,
	[IdentificationCitizen] [nvarchar](13) NULL,
	[IdFactory] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Email] [nvarchar](50) NULL,
	[Career] [int] NULL,
	[Gender] [int] NULL,
	[AvatarPath] [nvarchar](150) NULL,
	[FontIdentityPath] [nvarchar](150) NULL,
	[BackIdentityPath] [nvarchar](150) NULL,
	[RoomId] [uniqueidentifier] NULL,
	[Password] [nvarchar](max) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FitmentInRooms]    Script Date: 5/20/2024 8:21:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FitmentInRooms](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[RoomId] [uniqueidentifier] NOT NULL,
	[FitmentId] [uniqueidentifier] NOT NULL,
	[Quantity] [int] NOT NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_FitmentInRooms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fitments]    Script Date: 5/20/2024 8:21:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fitments](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[Name] [nvarchar](150) NULL,
	[IsCanUse] [bit] NOT NULL,
	[RecoupPrice] [decimal](18, 2) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Fitments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoices]    Script Date: 5/20/2024 8:21:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoices](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[StageRoomId] [uniqueidentifier] NOT NULL,
	[ProvideId] [uniqueidentifier] NULL,
	[LastValue] [decimal](18, 2) NULL,
	[NewValue] [decimal](18, 2) NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Amount] [decimal](18, 2) NULL,
	[Name] [nvarchar](max) NULL,
	[ProvideType] [int] NOT NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Invoices] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provides]    Script Date: 5/20/2024 8:21:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provides](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Type] [int] NOT NULL,
	[DefaultPrice] [decimal](18, 2) NOT NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Provides] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomDepositeds]    Script Date: 5/20/2024 8:21:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomDepositeds](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[RoomId] [uniqueidentifier] NOT NULL,
	[DateStart] [datetime2](7) NOT NULL,
	[DateEnd] [datetime2](7) NOT NULL,
	[DespositedValue] [decimal](18, 2) NOT NULL,
	[Note] [nvarchar](150) NULL,
	[Name] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[IdentityNumber] [nvarchar](max) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_RoomDepositeds] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 5/20/2024 8:21:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[BoardingHouseId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Floor] [int] NULL,
	[MaxHuman] [int] NULL,
	[Description] [nvarchar](4000) NULL,
	[Status] [int] NOT NULL,
	[Location] [nvarchar](63) NULL,
	[IsSelfContainer] [bit] NULL,
	[Count] [int] NULL,
	[Area] [int] NOT NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceInBoardingHouses]    Script Date: 5/20/2024 8:21:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceInBoardingHouses](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[BoardingHouseId] [uniqueidentifier] NOT NULL,
	[ProvideId] [uniqueidentifier] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_ServiceInBoardingHouses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StagePayments]    Script Date: 5/20/2024 8:21:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StagePayments](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[InvoiceNo] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[StageDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NOT NULL,
	[TotalAmount] [decimal](18, 2) NOT NULL,
	[AmountPaid] [decimal](18, 2) NOT NULL,
	[RoomData] [int] NOT NULL,
	[TotalRooms] [int] NOT NULL,
	[RoomPaid] [int] NOT NULL,
	[IsComplete] [bit] NOT NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_StagePayments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StageRooms]    Script Date: 5/20/2024 8:21:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StageRooms](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[StagePaymentId] [uniqueidentifier] NOT NULL,
	[RoomId] [uniqueidentifier] NOT NULL,
	[PaymentStatus] [int] NOT NULL,
	[TotalAmount] [decimal](18, 2) NOT NULL,
	[IsCompleted] [bit] NOT NULL,
	[IsSubtractToDeposited] [bit] NOT NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_StageRooms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SystemFiles]    Script Date: 5/20/2024 8:21:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SystemFiles](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[MapId] [uniqueidentifier] NOT NULL,
	[FileType] [int] NOT NULL,
	[FileName] [nvarchar](max) NULL,
	[Extension] [nvarchar](max) NULL,
	[Path] [nvarchar](max) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_SystemFiles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Systems]    Script Date: 5/20/2024 8:21:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Systems](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[GroupKey] [nvarchar](max) NULL,
	[Group] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Value] [nvarchar](max) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Systems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserInfos]    Script Date: 5/20/2024 8:21:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfos](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Phone] [nvarchar](16) NULL,
	[DayOfBirth] [datetime2](7) NULL,
	[City] [nvarchar](max) NULL,
	[IdentityNumber] [nvarchar](16) NULL,
	[IdentityProvider] [nvarchar](200) NULL,
	[IdentityDate] [nvarchar](150) NULL,
	[Address] [nvarchar](255) NULL,
	[Email] [nvarchar](255) NULL,
	[AccountBankNumber] [nvarchar](50) NULL,
	[BankName] [nvarchar](50) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_UserInfos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 5/20/2024 8:21:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[Password] [nvarchar](255) NULL,
	[role] [int] NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Gender] [int] NOT NULL,
	[Mail] [nvarchar](255) NULL,
	[Phone] [nvarchar](10) NULL,
	[CityId] [uniqueidentifier] NULL,
	[Address] [nvarchar](255) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicles]    Script Date: 5/20/2024 8:21:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicles](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NOT NULL,
	[Type] [int] NOT NULL,
	[LicensePlate] [nvarchar](255) NULL,
	[Color] [nvarchar](255) NULL,
	[CustomerId] [uniqueidentifier] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Vehicles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221127072047___1.0.0', N'3.1.27')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221202161707_1.0.1', N'3.1.27')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221211052301__1.0.2', N'3.1.27')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230212130700___1.0.3', N'3.1.27')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231009150519___1.0.4', N'3.1.27')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231010132529___1.0.5', N'3.1.27')
GO
INSERT [dbo].[AppContracts] ([Id], [CreatedAt], [UpdatedAt], [ContractNo], [CustomerId], [Name], [CustomerName], [CustomerPhone], [RoomId], [CreatedDate], [ExpiredDate], [DepositedAmount], [Type], [ContractDuration], [Status], [AdvanceAmount], [IsDeleted]) VALUES (N'a30f983e-0440-4410-9702-4ee50dcc7597', CAST(N'2024-05-20T00:58:53.2577985' AS DateTime2), CAST(N'2024-05-20T00:58:53.2577989' AS DateTime2), NULL, NULL, N'Hợp đồng đặt cọc phòng Phòng T101', N'Phạm Trọng Nhân', N'0775331777', N'e383e717-d1e2-4fa0-9d49-9b4592c869a3', CAST(N'2024-05-20T00:00:00.0000000' AS DateTime2), CAST(N'2024-05-27T00:00:00.0000000' AS DateTime2), CAST(500000.00 AS Decimal(18, 2)), 0, NULL, 0, CAST(0.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[AppContracts] ([Id], [CreatedAt], [UpdatedAt], [ContractNo], [CustomerId], [Name], [CustomerName], [CustomerPhone], [RoomId], [CreatedDate], [ExpiredDate], [DepositedAmount], [Type], [ContractDuration], [Status], [AdvanceAmount], [IsDeleted]) VALUES (N'd19a9eee-6532-407d-9a57-74fe0574b6e8', CAST(N'2024-05-20T01:02:06.1987268' AS DateTime2), CAST(N'2024-05-20T01:02:06.1987270' AS DateTime2), NULL, N'd0e7fbf6-4997-4b9f-b364-899fb999d786', N'Hợp đồng thuê phòng Phòng T101', N'Phạm Trọng Nhân', N'0775331777', N'e383e717-d1e2-4fa0-9d49-9b4592c869a3', CAST(N'2024-05-20T00:00:00.0000000' AS DateTime2), CAST(N'2025-05-20T00:00:00.0000000' AS DateTime2), CAST(500000.00 AS Decimal(18, 2)), 1, 12, 0, CAST(5000000.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[BoardingHouses] ([Id], [CreatedAt], [UpdatedAt], [Name], [Address], [Description], [Months], [StartDatePayment], [EndDatePayment], [CityId], [IsNotLimitTime], [IsSelfPayment], [IsDeleted]) VALUES (N'e674114f-c72a-4c95-bddd-b75264235f6d', CAST(N'2024-05-20T00:56:09.6174385' AS DateTime2), CAST(N'2024-05-20T00:56:09.6174386' AS DateTime2), N'Khu trọ 521 Cổ Nhuế', N'521/33 Cổ Nhuế, Từ Liêm, Hà Nội', N'Nhà mới xây', 3, 1, 5, NULL, NULL, NULL, 0)
GO
INSERT [dbo].[ContractTerm] ([Id], [CreatedAt], [UpdatedAt], [AppContractId], [Type], [Content], [IsDeleted]) VALUES (N'0968acc6-6562-4db9-932e-673c46a77f20', CAST(N'2024-05-20T01:02:06.2346806' AS DateTime2), CAST(N'2024-05-20T01:02:06.2346826' AS DateTime2), N'd19a9eee-6532-407d-9a57-74fe0574b6e8', 1, N'Không về quá 12h đêm.', 0)
GO
INSERT [dbo].[Customers] ([Id], [CreatedAt], [UpdatedAt], [Name], [Phone], [BirthDay], [IdentificationCitizen], [IdFactory], [Address], [Email], [Career], [Gender], [AvatarPath], [FontIdentityPath], [BackIdentityPath], [RoomId], [Password], [IsDeleted]) VALUES (N'd0e7fbf6-4997-4b9f-b364-899fb999d786', CAST(N'2024-05-20T01:02:06.0821148' AS DateTime2), CAST(N'2024-05-20T01:02:06.0821185' AS DateTime2), N'Phạm Trọng Nhân', N'0775331777', CAST(N'1994-10-09T00:00:00.0000000' AS DateTime2), N'031094003103', N'CAHP', N'Đoàn Lập, Tiên Lãng, Hải Phòng', N'ptnhan109@gmail.com', 0, 1, N'/Contact/70c74f99-2271-4153-9c5d-4f1a2c87533d_anh-chan-dung.jpg', N'/Contact/2d06436a-a470-4ec6-9355-35a3bc8006a4_cccd-mat-truoc.jpg', N'/Contact/43fa9ea6-c42c-4c8d-aee0-1167bb922f23_cccd-mat-sau.jpg', N'e383e717-d1e2-4fa0-9d49-9b4592c869a3', N'T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=', 0)
GO
INSERT [dbo].[FitmentInRooms] ([Id], [CreatedAt], [UpdatedAt], [RoomId], [FitmentId], [Quantity], [IsDeleted]) VALUES (N'972f2ef9-8970-4c47-a0de-09b21b731aa3', CAST(N'2024-05-20T00:57:42.5970692' AS DateTime2), CAST(N'2024-05-20T00:57:42.5970694' AS DateTime2), N'e383e717-d1e2-4fa0-9d49-9b4592c869a3', N'88d524af-d083-4d9f-a5cb-c0a6bbfeec2d', 1, 0)
INSERT [dbo].[FitmentInRooms] ([Id], [CreatedAt], [UpdatedAt], [RoomId], [FitmentId], [Quantity], [IsDeleted]) VALUES (N'69b2656c-d77a-4114-a8af-1e951feeca84', CAST(N'2024-05-20T00:57:42.5970699' AS DateTime2), CAST(N'2024-05-20T00:57:42.5970701' AS DateTime2), N'e383e717-d1e2-4fa0-9d49-9b4592c869a3', N'e13e9098-5e5f-4435-b8bd-e80c7e5fbd55', 1, 0)
INSERT [dbo].[FitmentInRooms] ([Id], [CreatedAt], [UpdatedAt], [RoomId], [FitmentId], [Quantity], [IsDeleted]) VALUES (N'b7e601ff-eb80-48c6-8bd0-5b878d826f3f', CAST(N'2024-05-20T00:57:42.5970679' AS DateTime2), CAST(N'2024-05-20T00:57:42.5970680' AS DateTime2), N'e383e717-d1e2-4fa0-9d49-9b4592c869a3', N'cf52484d-d71a-4d7d-a48f-5fd99aae977e', 1, 0)
INSERT [dbo].[FitmentInRooms] ([Id], [CreatedAt], [UpdatedAt], [RoomId], [FitmentId], [Quantity], [IsDeleted]) VALUES (N'00e38a0f-1dc3-4405-b0f8-660f66c1b814', CAST(N'2024-05-20T00:57:42.5970631' AS DateTime2), CAST(N'2024-05-20T00:57:42.5970652' AS DateTime2), N'e383e717-d1e2-4fa0-9d49-9b4592c869a3', N'28912826-3ac6-4b54-9bce-2872d8851c39', 1, 0)
INSERT [dbo].[FitmentInRooms] ([Id], [CreatedAt], [UpdatedAt], [RoomId], [FitmentId], [Quantity], [IsDeleted]) VALUES (N'30a96107-270a-465a-bdd3-9cdc6131e55b', CAST(N'2024-05-20T00:57:42.5970706' AS DateTime2), CAST(N'2024-05-20T00:57:42.5970707' AS DateTime2), N'e383e717-d1e2-4fa0-9d49-9b4592c869a3', N'31ac5ee3-e272-49aa-aeac-f49c42c9f396', 1, 0)
INSERT [dbo].[FitmentInRooms] ([Id], [CreatedAt], [UpdatedAt], [RoomId], [FitmentId], [Quantity], [IsDeleted]) VALUES (N'f64f2dcf-031b-41f6-bb00-a2d53887a229', CAST(N'2024-05-20T00:57:42.5970685' AS DateTime2), CAST(N'2024-05-20T00:57:42.5970687' AS DateTime2), N'e383e717-d1e2-4fa0-9d49-9b4592c869a3', N'5903b994-6ca5-476a-a432-66b0d3240449', 1, 0)
INSERT [dbo].[FitmentInRooms] ([Id], [CreatedAt], [UpdatedAt], [RoomId], [FitmentId], [Quantity], [IsDeleted]) VALUES (N'6953c386-5440-41aa-b842-c936f501746c', CAST(N'2024-05-20T00:57:42.5970671' AS DateTime2), CAST(N'2024-05-20T00:57:42.5970673' AS DateTime2), N'e383e717-d1e2-4fa0-9d49-9b4592c869a3', N'fec645f2-573d-426d-a6c5-4ee3ddb0e773', 1, 0)
INSERT [dbo].[FitmentInRooms] ([Id], [CreatedAt], [UpdatedAt], [RoomId], [FitmentId], [Quantity], [IsDeleted]) VALUES (N'098f4f6d-c575-4ca7-a5ec-ef3791f71ae0', CAST(N'2024-05-20T00:57:42.5970664' AS DateTime2), CAST(N'2024-05-20T00:57:42.5970666' AS DateTime2), N'e383e717-d1e2-4fa0-9d49-9b4592c869a3', N'f728cff8-b79b-4949-803b-2c320c731adf', 1, 0)
GO
INSERT [dbo].[Fitments] ([Id], [CreatedAt], [UpdatedAt], [Name], [IsCanUse], [RecoupPrice], [Description], [IsDeleted]) VALUES (N'28912826-3ac6-4b54-9bce-2872d8851c39', CAST(N'2023-10-02T17:26:05.1533333' AS DateTime2), CAST(N'2023-10-02T17:26:05.1533333' AS DateTime2), N'Bàn chữ Z', 1, CAST(500000.00 AS Decimal(18, 2)), NULL, 0)
INSERT [dbo].[Fitments] ([Id], [CreatedAt], [UpdatedAt], [Name], [IsCanUse], [RecoupPrice], [Description], [IsDeleted]) VALUES (N'f728cff8-b79b-4949-803b-2c320c731adf', CAST(N'2023-10-02T17:26:05.0600000' AS DateTime2), CAST(N'2023-10-02T17:26:05.0600000' AS DateTime2), N'Quạt trần', 1, CAST(3000000.00 AS Decimal(18, 2)), NULL, 0)
INSERT [dbo].[Fitments] ([Id], [CreatedAt], [UpdatedAt], [Name], [IsCanUse], [RecoupPrice], [Description], [IsDeleted]) VALUES (N'fec645f2-573d-426d-a6c5-4ee3ddb0e773', CAST(N'2023-10-02T17:26:05.0433333' AS DateTime2), CAST(N'2023-10-02T17:26:05.0433333' AS DateTime2), N'Bình nước nóng', 1, CAST(1500000.00 AS Decimal(18, 2)), NULL, 0)
INSERT [dbo].[Fitments] ([Id], [CreatedAt], [UpdatedAt], [Name], [IsCanUse], [RecoupPrice], [Description], [IsDeleted]) VALUES (N'cf52484d-d71a-4d7d-a48f-5fd99aae977e', CAST(N'2023-10-02T17:26:05.0766667' AS DateTime2), CAST(N'2023-10-02T17:26:05.0766667' AS DateTime2), N'Bồn cầu', 1, CAST(2500000.00 AS Decimal(18, 2)), NULL, 0)
INSERT [dbo].[Fitments] ([Id], [CreatedAt], [UpdatedAt], [Name], [IsCanUse], [RecoupPrice], [Description], [IsDeleted]) VALUES (N'5903b994-6ca5-476a-a432-66b0d3240449', CAST(N'2023-10-02T17:25:09.6500000' AS DateTime2), CAST(N'2023-10-02T17:25:09.6500000' AS DateTime2), N'Điều hòa', 1, CAST(7000000.00 AS Decimal(18, 2)), NULL, 0)
INSERT [dbo].[Fitments] ([Id], [CreatedAt], [UpdatedAt], [Name], [IsCanUse], [RecoupPrice], [Description], [IsDeleted]) VALUES (N'88d524af-d083-4d9f-a5cb-c0a6bbfeec2d', CAST(N'2023-10-02T17:26:05.0766667' AS DateTime2), CAST(N'2023-10-02T17:26:05.0766667' AS DateTime2), N'Vòi sen', 1, CAST(500000.00 AS Decimal(18, 2)), NULL, 0)
INSERT [dbo].[Fitments] ([Id], [CreatedAt], [UpdatedAt], [Name], [IsCanUse], [RecoupPrice], [Description], [IsDeleted]) VALUES (N'e13e9098-5e5f-4435-b8bd-e80c7e5fbd55', CAST(N'2023-10-02T17:26:05.0766667' AS DateTime2), CAST(N'2023-10-02T17:26:05.0766667' AS DateTime2), N'Máy giặt', 1, CAST(5000000.00 AS Decimal(18, 2)), NULL, 0)
INSERT [dbo].[Fitments] ([Id], [CreatedAt], [UpdatedAt], [Name], [IsCanUse], [RecoupPrice], [Description], [IsDeleted]) VALUES (N'31ac5ee3-e272-49aa-aeac-f49c42c9f396', CAST(N'2023-10-02T17:26:05.0900000' AS DateTime2), CAST(N'2023-10-02T17:26:05.0900000' AS DateTime2), N'Bồn rửa', 1, CAST(1200000.00 AS Decimal(18, 2)), NULL, 0)
GO
INSERT [dbo].[Invoices] ([Id], [CreatedAt], [UpdatedAt], [StageRoomId], [ProvideId], [LastValue], [NewValue], [Price], [Amount], [Name], [ProvideType], [IsDeleted]) VALUES (N'67953ab3-969a-4bf3-9b09-55a64ac6ae9f', CAST(N'2024-05-20T01:08:03.7496752' AS DateTime2), CAST(N'2024-05-20T01:08:03.7496800' AS DateTime2), N'107dc104-f909-45c8-b697-9deb7095f6a0', N'05839c8d-56f4-41c7-2424-08dbc648d512', CAST(0.00 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), CAST(200000.00 AS Decimal(18, 2)), CAST(200000.00 AS Decimal(18, 2)), N'Internet tốc độ cao', 0, 0)
INSERT [dbo].[Invoices] ([Id], [CreatedAt], [UpdatedAt], [StageRoomId], [ProvideId], [LastValue], [NewValue], [Price], [Amount], [Name], [ProvideType], [IsDeleted]) VALUES (N'cbadc759-2302-49c5-967d-a87bb07fddc1', CAST(N'2024-05-20T01:08:03.7496902' AS DateTime2), CAST(N'2024-05-20T01:08:03.7496904' AS DateTime2), N'107dc104-f909-45c8-b697-9deb7095f6a0', N'82e1700e-998b-4248-2422-08dbc648d512', CAST(0.00 AS Decimal(18, 2)), CAST(90.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), CAST(360000.00 AS Decimal(18, 2)), N'Tiền điện', 1, 0)
INSERT [dbo].[Invoices] ([Id], [CreatedAt], [UpdatedAt], [StageRoomId], [ProvideId], [LastValue], [NewValue], [Price], [Amount], [Name], [ProvideType], [IsDeleted]) VALUES (N'19ab052a-df98-4752-b73d-f2909519a676', CAST(N'2024-05-20T01:08:03.7496908' AS DateTime2), CAST(N'2024-05-20T01:08:03.7496909' AS DateTime2), N'107dc104-f909-45c8-b697-9deb7095f6a0', N'169adc61-3b97-4080-2423-08dbc648d512', CAST(0.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(50000.00 AS Decimal(18, 2)), CAST(500000.00 AS Decimal(18, 2)), N'Tiền nước', 2, 0)
GO
INSERT [dbo].[Provides] ([Id], [CreatedAt], [UpdatedAt], [Name], [Type], [DefaultPrice], [IsDeleted]) VALUES (N'b0bb2ec0-f8fd-404e-241f-08dbc648d512', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'Bảo vệ', 2, CAST(10000.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Provides] ([Id], [CreatedAt], [UpdatedAt], [Name], [Type], [DefaultPrice], [IsDeleted]) VALUES (N'cb5dbc3e-de2c-4525-2420-08dbc648d512', CAST(N'2023-10-06T15:47:25.5826106' AS DateTime2), CAST(N'2023-10-06T15:47:25.5826171' AS DateTime2), N'Thang máy', 2, CAST(50000.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Provides] ([Id], [CreatedAt], [UpdatedAt], [Name], [Type], [DefaultPrice], [IsDeleted]) VALUES (N'ab003853-3043-45b1-2421-08dbc648d512', CAST(N'2023-10-06T15:48:55.0792334' AS DateTime2), CAST(N'2023-10-06T15:48:55.0792418' AS DateTime2), N'Đèn cầu thang', 2, CAST(10000.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Provides] ([Id], [CreatedAt], [UpdatedAt], [Name], [Type], [DefaultPrice], [IsDeleted]) VALUES (N'82e1700e-998b-4248-2422-08dbc648d512', CAST(N'2023-10-06T15:49:11.6097622' AS DateTime2), CAST(N'2023-10-06T15:49:11.6097693' AS DateTime2), N'Tiền điện', 1, CAST(4000.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Provides] ([Id], [CreatedAt], [UpdatedAt], [Name], [Type], [DefaultPrice], [IsDeleted]) VALUES (N'169adc61-3b97-4080-2423-08dbc648d512', CAST(N'2023-10-06T15:49:23.8026795' AS DateTime2), CAST(N'2023-10-06T15:49:23.8026848' AS DateTime2), N'Tiền nước', 2, CAST(50000.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Provides] ([Id], [CreatedAt], [UpdatedAt], [Name], [Type], [DefaultPrice], [IsDeleted]) VALUES (N'05839c8d-56f4-41c7-2424-08dbc648d512', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'Internet tốc độ cao', 0, CAST(200000.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Provides] ([Id], [CreatedAt], [UpdatedAt], [Name], [Type], [DefaultPrice], [IsDeleted]) VALUES (N'ee972f14-7294-448d-94a9-08dc4e735872', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'Tiền rác thải', 2, CAST(15000.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Provides] ([Id], [CreatedAt], [UpdatedAt], [Name], [Type], [DefaultPrice], [IsDeleted]) VALUES (N'c27a415d-bd21-4921-7ac0-08dc78252d44', CAST(N'2024-05-20T00:00:24.8150360' AS DateTime2), CAST(N'2024-05-20T00:00:24.8150451' AS DateTime2), N'Vệ sinh cầu thang', 2, CAST(10000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Provides] ([Id], [CreatedAt], [UpdatedAt], [Name], [Type], [DefaultPrice], [IsDeleted]) VALUES (N'0ec53d12-34b3-4a75-7ac1-08dc78252d44', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'Phí vệ sinh', 2, CAST(10000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Provides] ([Id], [CreatedAt], [UpdatedAt], [Name], [Type], [DefaultPrice], [IsDeleted]) VALUES (N'b673ae60-b109-4af1-7ac2-08dc78252d44', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'Phí môi trường', 2, CAST(12000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Provides] ([Id], [CreatedAt], [UpdatedAt], [Name], [Type], [DefaultPrice], [IsDeleted]) VALUES (N'd39374b2-1f17-45bc-7ac3-08dc78252d44', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'Phí vệ sinh môi trường', 0, CAST(10000.00 AS Decimal(18, 2)), 1)
GO
INSERT [dbo].[Rooms] ([Id], [CreatedAt], [UpdatedAt], [BoardingHouseId], [Name], [Price], [Floor], [MaxHuman], [Description], [Status], [Location], [IsSelfContainer], [Count], [Area], [IsDeleted]) VALUES (N'e383e717-d1e2-4fa0-9d49-9b4592c869a3', CAST(N'2024-05-20T00:57:42.2674540' AS DateTime2), CAST(N'2024-05-20T00:57:42.2674573' AS DateTime2), N'e674114f-c72a-4c95-bddd-b75264235f6d', N'Phòng T101', CAST(2500000.00 AS Decimal(18, 2)), 1, 10, N'Phòng tầng 1 gần nhà để xe', 2, N'null', 1, NULL, 0, 0)
GO
INSERT [dbo].[ServiceInBoardingHouses] ([Id], [CreatedAt], [UpdatedAt], [BoardingHouseId], [ProvideId], [Price], [IsDeleted]) VALUES (N'16a7b1a3-b41b-4992-999c-35f46e52ac8d', CAST(N'2024-05-20T00:56:09.6434679' AS DateTime2), CAST(N'2024-05-20T00:56:09.6434680' AS DateTime2), N'e674114f-c72a-4c95-bddd-b75264235f6d', N'05839c8d-56f4-41c7-2424-08dbc648d512', CAST(200000.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[ServiceInBoardingHouses] ([Id], [CreatedAt], [UpdatedAt], [BoardingHouseId], [ProvideId], [Price], [IsDeleted]) VALUES (N'f2aa6e77-6354-470e-a056-5655e700a5c1', CAST(N'2024-05-20T00:56:09.6434673' AS DateTime2), CAST(N'2024-05-20T00:56:09.6434674' AS DateTime2), N'e674114f-c72a-4c95-bddd-b75264235f6d', N'169adc61-3b97-4080-2423-08dbc648d512', CAST(50000.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[ServiceInBoardingHouses] ([Id], [CreatedAt], [UpdatedAt], [BoardingHouseId], [ProvideId], [Price], [IsDeleted]) VALUES (N'f6dd1146-4f45-4849-b11b-fe6113913552', CAST(N'2024-05-20T00:56:09.6434663' AS DateTime2), CAST(N'2024-05-20T00:56:09.6434665' AS DateTime2), N'e674114f-c72a-4c95-bddd-b75264235f6d', N'82e1700e-998b-4248-2422-08dbc648d512', CAST(4000.00 AS Decimal(18, 2)), 0)
GO
INSERT [dbo].[StagePayments] ([Id], [CreatedAt], [UpdatedAt], [InvoiceNo], [Name], [StageDate], [EndDate], [TotalAmount], [AmountPaid], [RoomData], [TotalRooms], [RoomPaid], [IsComplete], [IsDeleted]) VALUES (N'b972eec5-d4d7-4cc9-bbdc-be154d3a0efb', CAST(N'2024-05-20T00:48:54.9650085' AS DateTime2), CAST(N'2024-05-20T00:48:54.9650096' AS DateTime2), N'DTT000000001', N'Đợt thanh toán tiền tháng 5 năm 2024', CAST(N'2024-05-20T00:00:00.0000000' AS DateTime2), CAST(N'2024-05-25T00:00:00.0000000' AS DateTime2), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 0, 1, 0, 0, 0)
INSERT [dbo].[StagePayments] ([Id], [CreatedAt], [UpdatedAt], [InvoiceNo], [Name], [StageDate], [EndDate], [TotalAmount], [AmountPaid], [RoomData], [TotalRooms], [RoomPaid], [IsComplete], [IsDeleted]) VALUES (N'532cf65b-2511-4a20-94a8-f0a07d527803', CAST(N'2024-05-20T01:05:28.7691782' AS DateTime2), CAST(N'2024-05-20T01:05:28.7691785' AS DateTime2), N'DTT000000002', N'Đợt thanh toán tiền tháng 5 năm 2024', CAST(N'2024-05-01T00:00:00.0000000' AS DateTime2), CAST(N'2024-05-10T00:00:00.0000000' AS DateTime2), CAST(1060000.00 AS Decimal(18, 2)), CAST(1060000.00 AS Decimal(18, 2)), 1, 1, 1, 1, 0)
GO
INSERT [dbo].[StageRooms] ([Id], [CreatedAt], [UpdatedAt], [StagePaymentId], [RoomId], [PaymentStatus], [TotalAmount], [IsCompleted], [IsSubtractToDeposited], [IsDeleted]) VALUES (N'107dc104-f909-45c8-b697-9deb7095f6a0', CAST(N'2024-05-20T01:08:03.8510497' AS DateTime2), CAST(N'2024-05-20T01:08:03.8510647' AS DateTime2), N'532cf65b-2511-4a20-94a8-f0a07d527803', N'e383e717-d1e2-4fa0-9d49-9b4592c869a3', 2, CAST(1060000.00 AS Decimal(18, 2)), 1, 1, 0)
GO
INSERT [dbo].[SystemFiles] ([Id], [CreatedAt], [UpdatedAt], [MapId], [FileType], [FileName], [Extension], [Path], [IsDeleted]) VALUES (N'7b2b0351-0292-4c23-b326-04c399cc1a92', CAST(N'2024-05-20T00:41:53.6423740' AS DateTime2), CAST(N'2024-05-20T00:41:53.6423798' AS DateTime2), N'9058c58f-9761-492f-8a02-2e5859ca5b90', 0, N'/Room/23b30280-3706-4f1c-a09f-89c772439d4a_anh-phong-tro-2.jpg', N'.jpg', N'/Room//Room/23b30280-3706-4f1c-a09f-89c772439d4a_anh-phong-tro-2.jpg', 0)
INSERT [dbo].[SystemFiles] ([Id], [CreatedAt], [UpdatedAt], [MapId], [FileType], [FileName], [Extension], [Path], [IsDeleted]) VALUES (N'22257373-d977-49b6-8a94-1faa927df0f3', CAST(N'2024-05-18T14:15:21.1239090' AS DateTime2), CAST(N'2024-05-18T14:15:21.1239125' AS DateTime2), N'f6d13c37-3d03-4ce4-9c55-c7c8b8265e03', 0, N'/Room/071ada49-d795-4537-b564-815f30bdc52c_unnamed-3.jpg', N'.jpg', N'/Room//Room/071ada49-d795-4537-b564-815f30bdc52c_unnamed-3.jpg', 0)
INSERT [dbo].[SystemFiles] ([Id], [CreatedAt], [UpdatedAt], [MapId], [FileType], [FileName], [Extension], [Path], [IsDeleted]) VALUES (N'f0c758ce-9326-44d7-941e-2c98991ec4d6', CAST(N'2024-05-19T22:11:34.0589145' AS DateTime2), CAST(N'2024-05-19T22:11:34.0589182' AS DateTime2), N'd98b0e77-1b7c-4109-aa8a-c3ac4af5b63f', 0, N'/Room/4d72f49a-c402-409f-bef3-e8e689170698_anh-phong-tro-1.jpg', N'.jpg', N'/Room//Room/4d72f49a-c402-409f-bef3-e8e689170698_anh-phong-tro-1.jpg', 0)
INSERT [dbo].[SystemFiles] ([Id], [CreatedAt], [UpdatedAt], [MapId], [FileType], [FileName], [Extension], [Path], [IsDeleted]) VALUES (N'e1cf72bc-82f6-46f0-8156-5926c5d092df', CAST(N'2024-05-20T00:41:53.6230914' AS DateTime2), CAST(N'2024-05-20T00:41:53.6230953' AS DateTime2), N'9058c58f-9761-492f-8a02-2e5859ca5b90', 0, N'/Room/f82a4647-920c-4dda-9c83-a90d644ca5c7_anh-phong-tro-1.jpg', N'.jpg', N'/Room//Room/f82a4647-920c-4dda-9c83-a90d644ca5c7_anh-phong-tro-1.jpg', 0)
INSERT [dbo].[SystemFiles] ([Id], [CreatedAt], [UpdatedAt], [MapId], [FileType], [FileName], [Extension], [Path], [IsDeleted]) VALUES (N'5dccf706-36c6-4777-864d-5a4cd3a86e9e', CAST(N'2024-05-19T22:47:14.3332732' AS DateTime2), CAST(N'2024-05-19T22:47:14.3332758' AS DateTime2), N'f706ed6c-64e8-4a6f-b61f-2765de25220c', 0, N'/Room/5b3a1ca0-7f86-4c6e-8d6d-a023655a06e3_anh-phong-tro-2.jpg', N'.jpg', N'/Room//Room/5b3a1ca0-7f86-4c6e-8d6d-a023655a06e3_anh-phong-tro-2.jpg', 0)
INSERT [dbo].[SystemFiles] ([Id], [CreatedAt], [UpdatedAt], [MapId], [FileType], [FileName], [Extension], [Path], [IsDeleted]) VALUES (N'920c9bcd-ad2c-4a7a-a9c9-728714e29d3e', CAST(N'2024-05-20T00:57:42.5344925' AS DateTime2), CAST(N'2024-05-20T00:57:42.5344954' AS DateTime2), N'e383e717-d1e2-4fa0-9d49-9b4592c869a3', 0, N'/Room/6cc948d3-1c05-4733-b419-1b9cce77128d_anh-phong-tro-1.jpg', N'.jpg', N'/Room//Room/6cc948d3-1c05-4733-b419-1b9cce77128d_anh-phong-tro-1.jpg', 0)
INSERT [dbo].[SystemFiles] ([Id], [CreatedAt], [UpdatedAt], [MapId], [FileType], [FileName], [Extension], [Path], [IsDeleted]) VALUES (N'83d057d9-e712-4b43-8535-7ad0f3290bdd', CAST(N'2024-05-19T22:47:14.3294477' AS DateTime2), CAST(N'2024-05-19T22:47:14.3294514' AS DateTime2), N'f706ed6c-64e8-4a6f-b61f-2765de25220c', 0, N'/Room/259b3d3d-daa1-4872-a95a-560c02f26426_anh-phong-tro-1.jpg', N'.jpg', N'/Room//Room/259b3d3d-daa1-4872-a95a-560c02f26426_anh-phong-tro-1.jpg', 0)
INSERT [dbo].[SystemFiles] ([Id], [CreatedAt], [UpdatedAt], [MapId], [FileType], [FileName], [Extension], [Path], [IsDeleted]) VALUES (N'9fa98ae2-df94-40c9-b3cb-7ca89f138dfc', CAST(N'2024-05-19T22:46:29.8133765' AS DateTime2), CAST(N'2024-05-19T22:46:29.8133797' AS DateTime2), N'4118c02b-e1c6-4bb5-8d3c-96597281e44a', 0, N'/Room/93f8ce71-5618-4890-b538-8c6007f99e2f_anh-phong-tro-1.jpg', N'.jpg', N'/Room//Room/93f8ce71-5618-4890-b538-8c6007f99e2f_anh-phong-tro-1.jpg', 0)
INSERT [dbo].[SystemFiles] ([Id], [CreatedAt], [UpdatedAt], [MapId], [FileType], [FileName], [Extension], [Path], [IsDeleted]) VALUES (N'7e0ffcb8-6763-4acd-a82e-a52d6f4946f3', CAST(N'2024-05-19T22:46:29.8209360' AS DateTime2), CAST(N'2024-05-19T22:46:29.8209387' AS DateTime2), N'4118c02b-e1c6-4bb5-8d3c-96597281e44a', 0, N'/Room/d1cefe90-cb74-4104-981d-cb6859e83087_anh-phong-tro-2.jpg', N'.jpg', N'/Room//Room/d1cefe90-cb74-4104-981d-cb6859e83087_anh-phong-tro-2.jpg', 0)
INSERT [dbo].[SystemFiles] ([Id], [CreatedAt], [UpdatedAt], [MapId], [FileType], [FileName], [Extension], [Path], [IsDeleted]) VALUES (N'4a0f0c6a-5478-4850-94f3-a97e0e97acd4', CAST(N'2024-05-19T22:11:34.0670225' AS DateTime2), CAST(N'2024-05-19T22:11:34.0670252' AS DateTime2), N'd98b0e77-1b7c-4109-aa8a-c3ac4af5b63f', 0, N'/Room/dc1e69f4-876c-43a2-ba4e-b1164bab6d1f_anh-phong-tro-2.jpg', N'.jpg', N'/Room//Room/dc1e69f4-876c-43a2-ba4e-b1164bab6d1f_anh-phong-tro-2.jpg', 0)
INSERT [dbo].[SystemFiles] ([Id], [CreatedAt], [UpdatedAt], [MapId], [FileType], [FileName], [Extension], [Path], [IsDeleted]) VALUES (N'e710309d-8e0e-4c15-805c-c939bb49970a', CAST(N'2024-05-19T19:30:03.7773591' AS DateTime2), CAST(N'2024-05-19T19:30:03.7773622' AS DateTime2), N'ccd86af4-947d-467d-b841-679a8263a4dc', 0, N'/Room/c62a6b1f-4b62-4db9-8a8a-ce1980b2015e_anh-chan-dung.jpg', N'.jpg', N'/Room//Room/c62a6b1f-4b62-4db9-8a8a-ce1980b2015e_anh-chan-dung.jpg', 0)
INSERT [dbo].[SystemFiles] ([Id], [CreatedAt], [UpdatedAt], [MapId], [FileType], [FileName], [Extension], [Path], [IsDeleted]) VALUES (N'3b6b9ce6-f92e-4ae1-926b-d3f87b58b44f', CAST(N'2024-05-20T00:57:42.5660403' AS DateTime2), CAST(N'2024-05-20T00:57:42.5660453' AS DateTime2), N'e383e717-d1e2-4fa0-9d49-9b4592c869a3', 0, N'/Room/0177d3da-6b50-41ec-9c7b-de002e04aa7b_anh-phong-tro-2.jpg', N'.jpg', N'/Room//Room/0177d3da-6b50-41ec-9c7b-de002e04aa7b_anh-phong-tro-2.jpg', 0)
INSERT [dbo].[SystemFiles] ([Id], [CreatedAt], [UpdatedAt], [MapId], [FileType], [FileName], [Extension], [Path], [IsDeleted]) VALUES (N'4d583c2c-b9b9-47cb-b2bf-de635ad978a3', CAST(N'2024-05-19T22:47:21.2535947' AS DateTime2), CAST(N'2024-05-19T22:47:21.2535980' AS DateTime2), N'c143d774-ad41-4d11-97b0-674effdbf2e0', 0, N'/Room/70c12b71-8b13-472f-a5f1-a371cdb1bd28_anh-phong-tro-1.jpg', N'.jpg', N'/Room//Room/70c12b71-8b13-472f-a5f1-a371cdb1bd28_anh-phong-tro-1.jpg', 0)
INSERT [dbo].[SystemFiles] ([Id], [CreatedAt], [UpdatedAt], [MapId], [FileType], [FileName], [Extension], [Path], [IsDeleted]) VALUES (N'72033d56-0205-42fb-80b0-f50883fc8d36', CAST(N'2024-05-19T22:47:21.3636711' AS DateTime2), CAST(N'2024-05-19T22:47:21.3636752' AS DateTime2), N'c143d774-ad41-4d11-97b0-674effdbf2e0', 0, N'/Room/0f2f31a3-a753-4e9e-86e7-5d329b49bbd0_anh-phong-tro-2.jpg', N'.jpg', N'/Room//Room/0f2f31a3-a753-4e9e-86e7-5d329b49bbd0_anh-phong-tro-2.jpg', 0)
GO
INSERT [dbo].[UserInfos] ([Id], [CreatedAt], [UpdatedAt], [UserId], [Name], [Phone], [DayOfBirth], [City], [IdentityNumber], [IdentityProvider], [IdentityDate], [Address], [Email], [AccountBankNumber], [BankName], [IsDeleted]) VALUES (N'24b385db-635b-4aae-b132-b2758c3e5fc4', CAST(N'2023-10-09T22:05:58.8933333' AS DateTime2), CAST(N'2023-10-09T22:05:58.8933333' AS DateTime2), N'634e65c2-ea3e-4647-8024-584fc979cbd6', N'Vũ Quang Hải', N'0354.740.085', CAST(N'2023-10-09T22:05:58.8933333' AS DateTime2), N'Hà Nội', N'031094003103', N'Công an Hà Nội', N'2024-05-21', N'401/36 Cổ Nhuế 2, Từ Liêm, Hà Nội', N'haivq@gmail.com', N'19032932923', N'Techcombank Hội sở', 0)
GO
INSERT [dbo].[Users] ([Id], [CreatedAt], [UpdatedAt], [Password], [role], [Name], [Gender], [Mail], [Phone], [CityId], [Address], [IsDeleted]) VALUES (N'634e65c2-ea3e-4647-8024-584fc979cbd6', CAST(N'2023-10-10T20:25:29.2639976' AS DateTime2), CAST(N'2023-10-10T20:25:29.2644854' AS DateTime2), N'T24UgcZyY5d5T538cm2QRc80DLB/e79sk97fjiJDzJw=', 0, N'Phạm Trọng Nhân', 1, N'trongnhan1110i@gmail.com', N'0775331777', NULL, N'Cổ Nhuế, Từ Liêm', 0)
GO
INSERT [dbo].[Vehicles] ([Id], [CreatedAt], [UpdatedAt], [Type], [LicensePlate], [Color], [CustomerId], [IsDeleted]) VALUES (N'32592cbe-d59f-4557-839a-de65cc2c6e6a', CAST(N'2024-05-20T01:02:06.1122151' AS DateTime2), CAST(N'2024-05-20T01:02:06.1122179' AS DateTime2), 1, N'15H1 403084', N'Đỏ đen', N'd0e7fbf6-4997-4b9f-b364-899fb999d786', 0)
GO
ALTER TABLE [dbo].[Rooms] ADD  DEFAULT ((0)) FOR [Area]
GO
ALTER TABLE [dbo].[StageRooms] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsSubtractToDeposited]
GO
ALTER TABLE [dbo].[AppContracts]  WITH CHECK ADD  CONSTRAINT [FK_AppContracts_Rooms_RoomId] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Rooms] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AppContracts] CHECK CONSTRAINT [FK_AppContracts_Rooms_RoomId]
GO
ALTER TABLE [dbo].[BoardingHouses]  WITH CHECK ADD  CONSTRAINT [FK_BoardingHouses_Cities_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[BoardingHouses] CHECK CONSTRAINT [FK_BoardingHouses_Cities_CityId]
GO
ALTER TABLE [dbo].[ContractTerm]  WITH CHECK ADD  CONSTRAINT [FK_ContractTerm_AppContracts_AppContractId] FOREIGN KEY([AppContractId])
REFERENCES [dbo].[AppContracts] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ContractTerm] CHECK CONSTRAINT [FK_ContractTerm_AppContracts_AppContractId]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Rooms_RoomId] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Rooms] ([Id])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Rooms_RoomId]
GO
ALTER TABLE [dbo].[FitmentInRooms]  WITH CHECK ADD  CONSTRAINT [FK_FitmentInRooms_Fitments_FitmentId] FOREIGN KEY([FitmentId])
REFERENCES [dbo].[Fitments] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FitmentInRooms] CHECK CONSTRAINT [FK_FitmentInRooms_Fitments_FitmentId]
GO
ALTER TABLE [dbo].[FitmentInRooms]  WITH CHECK ADD  CONSTRAINT [FK_FitmentInRooms_Rooms_RoomId] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Rooms] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FitmentInRooms] CHECK CONSTRAINT [FK_FitmentInRooms_Rooms_RoomId]
GO
ALTER TABLE [dbo].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Invoices_Provides_ProvideId] FOREIGN KEY([ProvideId])
REFERENCES [dbo].[Provides] ([Id])
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_Invoices_Provides_ProvideId]
GO
ALTER TABLE [dbo].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Invoices_StageRooms_StageRoomId] FOREIGN KEY([StageRoomId])
REFERENCES [dbo].[StageRooms] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_Invoices_StageRooms_StageRoomId]
GO
ALTER TABLE [dbo].[RoomDepositeds]  WITH CHECK ADD  CONSTRAINT [FK_RoomDepositeds_Rooms_RoomId] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Rooms] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RoomDepositeds] CHECK CONSTRAINT [FK_RoomDepositeds_Rooms_RoomId]
GO
ALTER TABLE [dbo].[Rooms]  WITH CHECK ADD  CONSTRAINT [FK_Rooms_BoardingHouses_BoardingHouseId] FOREIGN KEY([BoardingHouseId])
REFERENCES [dbo].[BoardingHouses] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Rooms] CHECK CONSTRAINT [FK_Rooms_BoardingHouses_BoardingHouseId]
GO
ALTER TABLE [dbo].[ServiceInBoardingHouses]  WITH CHECK ADD  CONSTRAINT [FK_ServiceInBoardingHouses_BoardingHouses_BoardingHouseId] FOREIGN KEY([BoardingHouseId])
REFERENCES [dbo].[BoardingHouses] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ServiceInBoardingHouses] CHECK CONSTRAINT [FK_ServiceInBoardingHouses_BoardingHouses_BoardingHouseId]
GO
ALTER TABLE [dbo].[ServiceInBoardingHouses]  WITH CHECK ADD  CONSTRAINT [FK_ServiceInBoardingHouses_Provides_ProvideId] FOREIGN KEY([ProvideId])
REFERENCES [dbo].[Provides] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ServiceInBoardingHouses] CHECK CONSTRAINT [FK_ServiceInBoardingHouses_Provides_ProvideId]
GO
ALTER TABLE [dbo].[StageRooms]  WITH CHECK ADD  CONSTRAINT [FK_StageRooms_Rooms_RoomId] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Rooms] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StageRooms] CHECK CONSTRAINT [FK_StageRooms_Rooms_RoomId]
GO
ALTER TABLE [dbo].[StageRooms]  WITH CHECK ADD  CONSTRAINT [FK_StageRooms_StagePayments_StagePaymentId] FOREIGN KEY([StagePaymentId])
REFERENCES [dbo].[StagePayments] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StageRooms] CHECK CONSTRAINT [FK_StageRooms_StagePayments_StagePaymentId]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Cities_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Cities_CityId]
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK_Vehicles_Customers_CustomerId]
GO
