USE [master]
GO
/****** Object:  Database [employeesManagementDB]    Script Date: 2/5/2021 2:30:48 AM ******/
CREATE DATABASE [employeesManagementDB]

ALTER DATABASE [employeesManagementDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [employeesManagementDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [employeesManagementDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [employeesManagementDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [employeesManagementDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [employeesManagementDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [employeesManagementDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [employeesManagementDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [employeesManagementDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [employeesManagementDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [employeesManagementDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [employeesManagementDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [employeesManagementDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [employeesManagementDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [employeesManagementDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [employeesManagementDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [employeesManagementDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [employeesManagementDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [employeesManagementDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [employeesManagementDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [employeesManagementDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [employeesManagementDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [employeesManagementDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [employeesManagementDB] SET  MULTI_USER 
GO
ALTER DATABASE [employeesManagementDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [employeesManagementDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [employeesManagementDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [employeesManagementDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [employeesManagementDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [employeesManagementDB] SET QUERY_STORE = OFF
GO
USE [employeesManagementDB]
GO
/****** Object:  Table [dbo].[Activities]    Script Date: 2/5/2021 2:30:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Activities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Companies]    Script Date: 2/5/2021 2:30:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[LegalFormId] [int] NOT NULL,
	[ActivityId] [int] NOT NULL,
 CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 2/5/2021 2:30:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Firstname] [nvarchar](50) NOT NULL,
	[Secondname] [nvarchar](50) NOT NULL,
	[Middlename] [nvarchar](50) NULL,
	[DateEmployment] [date] NOT NULL,
	[PositionId] [int] NOT NULL,
	[CompanyId] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LegalForms]    Script Date: 2/5/2021 2:30:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LegalForms](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LegalForms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Positions]    Script Date: 2/5/2021 2:30:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Positions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Positions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Activities] ON 

INSERT [dbo].[Activities] ([Id], [Name]) VALUES (1, N'Аутсорс')
INSERT [dbo].[Activities] ([Id], [Name]) VALUES (5, N'Образование')
INSERT [dbo].[Activities] ([Id], [Name]) VALUES (2, N'Программное обеспечение')
INSERT [dbo].[Activities] ([Id], [Name]) VALUES (3, N'Строительство')
INSERT [dbo].[Activities] ([Id], [Name]) VALUES (4, N'Торговля')
SET IDENTITY_INSERT [dbo].[Activities] OFF
SET IDENTITY_INSERT [dbo].[Companies] ON 

INSERT [dbo].[Companies] ([Id], [Name], [LegalFormId], [ActivityId]) VALUES (1, N'MicroXP', 2, 2)
INSERT [dbo].[Companies] ([Id], [Name], [LegalFormId], [ActivityId]) VALUES (2, N'ПАК', 1, 4)
INSERT [dbo].[Companies] ([Id], [Name], [LegalFormId], [ActivityId]) VALUES (4, N'WorldSoft', 3, 2)
INSERT [dbo].[Companies] ([Id], [Name], [LegalFormId], [ActivityId]) VALUES (9, N'FastHelp', 2, 1)
INSERT [dbo].[Companies] ([Id], [Name], [LegalFormId], [ActivityId]) VALUES (10, N'SellCar', 3, 4)
SET IDENTITY_INSERT [dbo].[Companies] OFF
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([Id], [Firstname], [Secondname], [Middlename], [DateEmployment], [PositionId], [CompanyId]) VALUES (4, N'Кирилл', N'Иванов', N'Иванович', CAST(N'2016-01-01' AS Date), 6, 2)
INSERT [dbo].[Employees] ([Id], [Firstname], [Secondname], [Middlename], [DateEmployment], [PositionId], [CompanyId]) VALUES (6, N'Кирилл', N'Быстров', N'Алексеевич', CAST(N'2016-01-02' AS Date), 1, 1)
INSERT [dbo].[Employees] ([Id], [Firstname], [Secondname], [Middlename], [DateEmployment], [PositionId], [CompanyId]) VALUES (9, N'Александр', N'Фролов', N'Викторович', CAST(N'2020-01-30' AS Date), 4, 1)
INSERT [dbo].[Employees] ([Id], [Firstname], [Secondname], [Middlename], [DateEmployment], [PositionId], [CompanyId]) VALUES (10, N'Евгений', N'Винярский', N'Адамович', CAST(N'2015-10-30' AS Date), 3, 10)
INSERT [dbo].[Employees] ([Id], [Firstname], [Secondname], [Middlename], [DateEmployment], [PositionId], [CompanyId]) VALUES (11, N'Антон', N'Гунько', N'Алексеевич', CAST(N'2020-11-05' AS Date), 1, 1)
INSERT [dbo].[Employees] ([Id], [Firstname], [Secondname], [Middlename], [DateEmployment], [PositionId], [CompanyId]) VALUES (12, N'Михаил', N'Бурак', N'Иванович', CAST(N'2015-02-01' AS Date), 3, 2)
INSERT [dbo].[Employees] ([Id], [Firstname], [Secondname], [Middlename], [DateEmployment], [PositionId], [CompanyId]) VALUES (13, N'Анна', N'Вашнякова', N'Алексеевна', CAST(N'2020-01-01' AS Date), 2, 4)
SET IDENTITY_INSERT [dbo].[Employees] OFF
SET IDENTITY_INSERT [dbo].[LegalForms] ON 

INSERT [dbo].[LegalForms] ([Id], [Name]) VALUES (1, N'ЗАО')
INSERT [dbo].[LegalForms] ([Id], [Name]) VALUES (2, N'ОАО')
INSERT [dbo].[LegalForms] ([Id], [Name]) VALUES (3, N'ООО')
SET IDENTITY_INSERT [dbo].[LegalForms] OFF
SET IDENTITY_INSERT [dbo].[Positions] ON 

INSERT [dbo].[Positions] ([Id], [Name]) VALUES (4, N'Бизнес-аналитик')
INSERT [dbo].[Positions] ([Id], [Name]) VALUES (6, N'Директор')
INSERT [dbo].[Positions] ([Id], [Name]) VALUES (5, N'Каменщик')
INSERT [dbo].[Positions] ([Id], [Name]) VALUES (3, N'Менеджер')
INSERT [dbo].[Positions] ([Id], [Name]) VALUES (1, N'Программист')
INSERT [dbo].[Positions] ([Id], [Name]) VALUES (2, N'Тестировщик')
SET IDENTITY_INSERT [dbo].[Positions] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_ActivityName]    Script Date: 2/5/2021 2:30:48 AM ******/
ALTER TABLE [dbo].[Activities] ADD  CONSTRAINT [UQ_ActivityName] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_LegalFormName]    Script Date: 2/5/2021 2:30:48 AM ******/
ALTER TABLE [dbo].[LegalForms] ADD  CONSTRAINT [UQ_LegalFormName] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_PositionName]    Script Date: 2/5/2021 2:30:48 AM ******/
ALTER TABLE [dbo].[Positions] ADD  CONSTRAINT [UQ_PositionName] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Companies]  WITH CHECK ADD  CONSTRAINT [FK_Companies_Activities] FOREIGN KEY([ActivityId])
REFERENCES [dbo].[Activities] ([Id])
GO
ALTER TABLE [dbo].[Companies] CHECK CONSTRAINT [FK_Companies_Activities]
GO
ALTER TABLE [dbo].[Companies]  WITH CHECK ADD  CONSTRAINT [FK_Companies_LegalForms] FOREIGN KEY([LegalFormId])
REFERENCES [dbo].[LegalForms] ([Id])
GO
ALTER TABLE [dbo].[Companies] CHECK CONSTRAINT [FK_Companies_LegalForms]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Companies] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Companies] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Companies]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Positions] FOREIGN KEY([PositionId])
REFERENCES [dbo].[Positions] ([Id])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Positions]
GO
USE [master]
GO
ALTER DATABASE [employeesManagementDB] SET  READ_WRITE 
GO
