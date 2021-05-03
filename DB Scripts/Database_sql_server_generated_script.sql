USE [master]
GO
/****** Object:  Database [cs6232-g3]    Script Date: 3/8/2021 2:23:59 AM ******/
CREATE DATABASE [cs6232-g3]
GO
ALTER DATABASE [cs6232-g3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cs6232-g3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cs6232-g3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cs6232-g3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cs6232-g3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cs6232-g3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cs6232-g3] SET ARITHABORT OFF 
GO
ALTER DATABASE [cs6232-g3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cs6232-g3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cs6232-g3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cs6232-g3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cs6232-g3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cs6232-g3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cs6232-g3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cs6232-g3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cs6232-g3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cs6232-g3] SET  DISABLE_BROKER 
GO
ALTER DATABASE [cs6232-g3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cs6232-g3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cs6232-g3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cs6232-g3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cs6232-g3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cs6232-g3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cs6232-g3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cs6232-g3] SET RECOVERY FULL 
GO
ALTER DATABASE [cs6232-g3] SET  MULTI_USER 
GO
ALTER DATABASE [cs6232-g3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cs6232-g3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cs6232-g3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cs6232-g3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cs6232-g3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cs6232-g3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'cs6232-g3', N'ON'
GO
ALTER DATABASE [cs6232-g3] SET QUERY_STORE = OFF
GO
USE [cs6232-g3]
GO
/****** Object:  Table [dbo].[appointments]    Script Date: 3/8/2021 2:23:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[appointments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[patientId] [int] NOT NULL,
	[doctor_id] [int] NOT NULL,
	[AppointmentDateTime] [datetime2](0) NOT NULL,
	[reasons] [varchar](45) NOT NULL,
	[status] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[doctor_id] ASC,
	[AppointmentDateTime] ASC,
	[status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clinicadmins]    Script Date: 3/8/2021 2:23:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clinicadmins](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[persons_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doctors]    Script Date: 3/8/2021 2:23:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doctors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[persons_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doctorspecialities]    Script Date: 3/8/2021 2:23:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doctorspecialities](
	[doctor_id] [int] NOT NULL,
	[specialityType] [varchar](45) NOT NULL,
	[description] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[doctor_id] ASC,
	[specialityType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[labtests]    Script Date: 3/8/2021 2:23:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[labtests](
	[patientId] [int] NOT NULL,
	[orderDateTime] [datetime2](0) NOT NULL,
	[performedDateTime] [datetime2](0) NULL,
	[testCode] [varchar](10) NOT NULL,
	[results] [varchar](45) NULL,
	[normal] [varchar](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[patientId] ASC,
	[orderDateTime] ASC,
	[testCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 3/8/2021 2:23:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[userName] [varchar](45) NOT NULL,
	[passwordHash] [BINARY](64) NOT NULL,
	[admin_id] [int] NULL,
	[nurse_id] [int] NULL,
	[doctor_id] [int] NULL,
	[patient_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nurses]    Script Date: 3/8/2021 2:23:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nurses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[status] [varchar](45) NOT NULL,
	[persons_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patients]    Script Date: 3/8/2021 2:23:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patients](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[persons_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[persons]    Script Date: 3/8/2021 2:23:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persons](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [varchar](45) NOT NULL,
	[lastName] [varchar](45) NOT NULL,
	[dateOfBirth] [date] NOT NULL,
	[gender] [varchar](10) NOT NULL,
	[SSN] [char](9) NULL,
	[Address1] [varchar](45) NOT NULL,
	[Address2] [varchar](45) NULL,
	[city] [varchar](45) NOT NULL,
	[state] [varchar](2) NOT NULL,
	[zipcode] [varchar](10) NOT NULL,
	[phoneNumber] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[firstName] ASC,
	[lastName] ASC,
	[dateOfBirth] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[state]    Script Date: 3/8/2021 2:23:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[state](
	[stateCode] [varchar](2) NOT NULL,
	[name] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[stateCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tests]    Script Date: 3/8/2021 2:23:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tests](
	[testCode] [varchar](10) NOT NULL,
	[Name] [varchar](45) NOT NULL,
	[description] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[testCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[visits]    Script Date: 3/8/2021 2:23:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[visits](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[appointment_id] [int] NULL,
	[weight] [decimal](10, 2) NOT NULL,
	[height] [decimal](10, 2) NOT NULL,
	[bodyTemparature] [int] NOT NULL,
	[pulse] [int] NOT NULL,
	[symptoms] [varchar](45) NOT NULL,
	[nurseId] [int] NOT NULL,
	[bloodPressureSystolic] [int] NOT NULL,
	[bloodPressureDiastolic] [int] NOT NULL,
	[initialDiagnose] [varchar](45) NOT NULL,
	[finalDiagnose] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[appointments]  WITH CHECK ADD FOREIGN KEY([doctor_id])
REFERENCES [dbo].[doctors] ([Id])
GO
ALTER TABLE [dbo].[appointments]  WITH CHECK ADD FOREIGN KEY([patientId])
REFERENCES [dbo].[patients] ([id])
GO
ALTER TABLE [dbo].[clinicadmins]  WITH CHECK ADD FOREIGN KEY([persons_id])
REFERENCES [dbo].[persons] ([id])
GO
ALTER TABLE [dbo].[doctors]  WITH CHECK ADD FOREIGN KEY([persons_id])
REFERENCES [dbo].[persons] ([id])
GO
ALTER TABLE [dbo].[doctorspecialities]  WITH CHECK ADD FOREIGN KEY([doctor_id])
REFERENCES [dbo].[doctors] ([Id])
GO
ALTER TABLE [dbo].[labtests]  WITH CHECK ADD FOREIGN KEY([testCode])
REFERENCES [dbo].[tests] ([testCode])
GO
ALTER TABLE [dbo].[login]  WITH CHECK ADD FOREIGN KEY([admin_id])
REFERENCES [dbo].[clinicadmins] ([Id])
GO
ALTER TABLE [dbo].[login]  WITH CHECK ADD FOREIGN KEY([doctor_id])
REFERENCES [dbo].[doctors] ([Id])
GO
ALTER TABLE [dbo].[login]  WITH CHECK ADD FOREIGN KEY([nurse_id])
REFERENCES [dbo].[nurses] ([Id])
GO
ALTER TABLE [dbo].[login]  WITH CHECK ADD FOREIGN KEY([patient_id])
REFERENCES [dbo].[patients] ([id])
GO
ALTER TABLE [dbo].[nurses]  WITH CHECK ADD FOREIGN KEY([persons_id])
REFERENCES [dbo].[persons] ([id])
GO
ALTER TABLE [dbo].[patients]  WITH CHECK ADD FOREIGN KEY([persons_id])
REFERENCES [dbo].[persons] ([id])
GO
ALTER TABLE [dbo].[persons]  WITH CHECK ADD FOREIGN KEY([state])
REFERENCES [dbo].[state] ([stateCode])
GO
ALTER TABLE [dbo].[visits]  WITH CHECK ADD FOREIGN KEY([appointment_id])
REFERENCES [dbo].[appointments] ([Id])
GO
ALter TABLE [dbo].[labtests] ADD visit_id int
GO
ALTER TABLE [dbo].[labtests]  WITH CHECK ADD FOREIGN KEY([visit_id])
REFERENCES [dbo].[visits] ([Id])
GO
ALTER TABLE visits
ALTER COLUMN bodyTemparature decimal(10,1)
GO
ALTER TABLE visits
ALTER COLUMN bloodPressureSystolic decimal(10,1)
GO
ALTER TABLE visits
ALTER COLUMN bloodPressureDiastolic decimal(10,1)
GO
ALTER TABLE [dbo].[visits]  WITH CHECK ADD FOREIGN KEY([nurseId])
REFERENCES [dbo].[nurses] ([Id])
GO
USE [master]
GO
ALTER DATABASE [cs6232-g3] SET  READ_WRITE 
GO
