USE [master]
GO
/****** Object:  Database [FcalcDB]    Script Date: 30/6/2021 19:24:00 ******/
CREATE DATABASE [FcalcDB]
 CONTAINMENT = NONE
GO
ALTER DATABASE [FcalcDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FcalcDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FcalcDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FcalcDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FcalcDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FcalcDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FcalcDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [FcalcDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FcalcDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FcalcDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FcalcDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FcalcDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FcalcDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FcalcDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FcalcDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FcalcDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FcalcDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FcalcDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FcalcDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FcalcDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FcalcDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FcalcDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FcalcDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FcalcDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FcalcDB] SET RECOVERY FULL 
GO
ALTER DATABASE [FcalcDB] SET  MULTI_USER 
GO
ALTER DATABASE [FcalcDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FcalcDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FcalcDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FcalcDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FcalcDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'FcalcDB', N'ON'
GO
ALTER DATABASE [FcalcDB] SET QUERY_STORE = OFF
GO
USE [FcalcDB]
GO
/****** Object:  Table [dbo].[CommercialPlan]    Script Date: 30/6/2021 19:24:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommercialPlan](
	[idCommercialplan] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](16) NULL,
	[idPlantype] [int] NULL,
	[price] [decimal](8, 2) NULL,
	[status] [char](1) NULL,
	[creationDate] [datetime] NULL,
 CONSTRAINT [PK_CommercialPlan] PRIMARY KEY CLUSTERED 
(
	[idCommercialplan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CommercialPlanRange]    Script Date: 30/6/2021 19:24:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommercialPlanRange](
	[idPlanrange] [int] IDENTITY(1,1) NOT NULL,
	[startRange] [int] NULL,
	[endRange] [int] NULL,
	[price] [decimal](6, 2) NULL,
	[idCommercialplan] [int] NULL,
	[status] [char](1) NULL,
	[creationDate] [datetime] NULL,
 CONSTRAINT [PK_CommercialPlanRange] PRIMARY KEY CLUSTERED 
(
	[idPlanrange] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 30/6/2021 19:24:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[idCustomer] [int] IDENTITY(1,1) NOT NULL,
	[ruc] [nchar](13) NULL,
	[legalName] [nchar](64) NULL,
	[idCommercialplan] [int] NULL,
	[status] [char](1) NULL,
	[creationDate] [datetime] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[idCustomer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExecutionLog]    Script Date: 30/6/2021 19:24:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExecutionLog](
	[idExecutionlog] [int] IDENTITY(1,1) NOT NULL,
	[idCustomer] [int] NULL,
	[transactionsCount] [int] NULL,
	[totalCalc] [decimal](6, 2) NULL,
	[month] [int] NULL,
	[creationDate] [datetime] NULL,
	[status] [char](1) NULL,
 CONSTRAINT [PK_ExecutionLog] PRIMARY KEY CLUSTERED 
(
	[idExecutionlog] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanType]    Script Date: 30/6/2021 19:24:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanType](
	[idPlantype] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](16) NULL,
	[requireRange] [bit] NULL,
	[isDynamic] [bit] NULL,
	[status] [char](1) NULL,
	[creationDate] [date] NULL,
 CONSTRAINT [PK_PlanType] PRIMARY KEY CLUSTERED 
(
	[idPlantype] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CommercialPlan]  WITH CHECK ADD  CONSTRAINT [FK_CommercialPlan_PlanType] FOREIGN KEY([idPlantype])
REFERENCES [dbo].[PlanType] ([idPlantype])
GO
ALTER TABLE [dbo].[CommercialPlan] CHECK CONSTRAINT [FK_CommercialPlan_PlanType]
GO
ALTER TABLE [dbo].[CommercialPlanRange]  WITH CHECK ADD  CONSTRAINT [FK_CommercialPlanRange_CommercialPlan] FOREIGN KEY([idCommercialplan])
REFERENCES [dbo].[CommercialPlan] ([idCommercialplan])
GO
ALTER TABLE [dbo].[CommercialPlanRange] CHECK CONSTRAINT [FK_CommercialPlanRange_CommercialPlan]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_CommercialPlan] FOREIGN KEY([idCommercialplan])
REFERENCES [dbo].[CommercialPlan] ([idCommercialplan])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_CommercialPlan]
GO
ALTER TABLE [dbo].[ExecutionLog]  WITH CHECK ADD  CONSTRAINT [FK_ExecutionLog_Customer] FOREIGN KEY([idCustomer])
REFERENCES [dbo].[Customer] ([idCustomer])
GO
ALTER TABLE [dbo].[ExecutionLog] CHECK CONSTRAINT [FK_ExecutionLog_Customer]
GO
USE [master]
GO
ALTER DATABASE [FcalcDB] SET  READ_WRITE 
GO