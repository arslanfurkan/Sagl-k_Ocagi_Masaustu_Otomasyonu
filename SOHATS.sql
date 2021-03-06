USE [master]
GO
/****** Object:  Database [SOHATS]    Script Date: 4.01.2019 00:05:05 ******/
CREATE DATABASE [SOHATS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SOHATS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SOHATS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SOHATS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SOHATS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SOHATS] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SOHATS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SOHATS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SOHATS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SOHATS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SOHATS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SOHATS] SET ARITHABORT OFF 
GO
ALTER DATABASE [SOHATS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SOHATS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SOHATS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SOHATS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SOHATS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SOHATS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SOHATS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SOHATS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SOHATS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SOHATS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SOHATS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SOHATS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SOHATS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SOHATS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SOHATS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SOHATS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SOHATS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SOHATS] SET RECOVERY FULL 
GO
ALTER DATABASE [SOHATS] SET  MULTI_USER 
GO
ALTER DATABASE [SOHATS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SOHATS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SOHATS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SOHATS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SOHATS] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SOHATS', N'ON'
GO
ALTER DATABASE [SOHATS] SET QUERY_STORE = OFF
GO
USE [SOHATS]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [SOHATS]
GO
/****** Object:  Table [dbo].[Cikis]    Script Date: 4.01.2019 00:05:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cikis](
	[CikisId] [int] IDENTITY(1,1) NOT NULL,
	[DosyaNo] [int] NOT NULL,
	[SevkTarihi] [nvarchar](50) NOT NULL,
	[CikisTarihi] [nvarchar](50) NULL,
	[Odeme] [nvarchar](20) NULL,
	[ToplamTutar] [nvarchar](20) NULL,
 CONSTRAINT [PK_Cikis] PRIMARY KEY CLUSTERED 
(
	[CikisId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hasta]    Script Date: 4.01.2019 00:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hasta](
	[DosyaNo] [int] IDENTITY(1,1) NOT NULL,
	[TckimlikNo] [nvarchar](11) NOT NULL,
	[Ad] [nvarchar](15) NOT NULL,
	[Soyad] [nvarchar](15) NOT NULL,
	[DogumYeri] [nvarchar](15) NULL,
	[DogumTarihi] [datetime] NULL,
	[BabaAdi] [nvarchar](15) NULL,
	[AnneAdi] [nvarchar](15) NULL,
	[Cinsiyet] [nvarchar](5) NULL,
	[KanGrubu] [nvarchar](5) NULL,
	[MedeniHal] [nvarchar](5) NULL,
	[Adres] [nvarchar](255) NULL,
	[Tel] [nvarchar](20) NULL,
	[KurumSicilNo] [nvarchar](10) NULL,
	[KurumAdi] [nvarchar](50) NULL,
	[YakinTel] [nvarchar](20) NULL,
	[YakinKurumSicilNo] [nvarchar](10) NULL,
	[YakinKurumAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Hasta_1] PRIMARY KEY CLUSTERED 
(
	[DosyaNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Islem]    Script Date: 4.01.2019 00:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Islem](
	[IslemId] [int] IDENTITY(1,1) NOT NULL,
	[IslemAdi] [nvarchar](50) NULL,
	[BirimFiyat] [nvarchar](50) NULL,
 CONSTRAINT [PK_Islem] PRIMARY KEY CLUSTERED 
(
	[IslemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 4.01.2019 00:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[KullaniciKodu] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](20) NOT NULL,
	[Soyad] [nvarchar](20) NOT NULL,
	[Sifre] [nvarchar](20) NOT NULL,
	[Yetki] [bit] NOT NULL,
	[EvTel] [nvarchar](20) NULL,
	[CepTel] [nvarchar](20) NULL,
	[Adres] [nvarchar](255) NULL,
	[Unvan] [nvarchar](50) NULL,
	[IseBaslama] [datetime] NULL,
	[Maas] [nvarchar](20) NULL,
	[DogumYeri] [nvarchar](50) NULL,
	[AnneAdi] [nvarchar](20) NULL,
	[BabaAdi] [nvarchar](20) NULL,
	[Cinsiyet] [nvarchar](5) NOT NULL,
	[KanGrubu] [nvarchar](5) NULL,
	[MedeniHal] [nvarchar](10) NOT NULL,
	[DogumTarihi] [datetime] NULL,
	[TckimlikNo] [nvarchar](11) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kullanici_1] PRIMARY KEY CLUSTERED 
(
	[KullaniciKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Poliklinik]    Script Date: 4.01.2019 00:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Poliklinik](
	[PoliklinikId] [int] IDENTITY(1,1) NOT NULL,
	[PoliklinikAdi] [nvarchar](50) NOT NULL,
	[Durum] [bit] NOT NULL,
	[Aciklama] [nvarchar](255) NULL,
 CONSTRAINT [PK_Poliklinik] PRIMARY KEY CLUSTERED 
(
	[PoliklinikId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sevk]    Script Date: 4.01.2019 00:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sevk](
	[SevkId] [int] IDENTITY(1,1) NOT NULL,
	[DosyaNo] [int] NOT NULL,
	[PoliklinikId] [int] NOT NULL,
	[IslemId] [int] NULL,
	[SevkTarihi] [nvarchar](50) NOT NULL,
	[Saat] [nvarchar](10) NULL,
	[DrKod] [int] NULL,
	[Miktar] [int] NULL,
	[BirimFiyat] [nvarchar](20) NULL,
	[Sira] [int] NULL,
	[ToplamTutar] [nvarchar](50) NULL,
	[Taburcu] [bit] NULL,
 CONSTRAINT [PK_Sevk] PRIMARY KEY CLUSTERED 
(
	[SevkId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Hasta] ON 

INSERT [dbo].[Hasta] ([DosyaNo], [TckimlikNo], [Ad], [Soyad], [DogumYeri], [DogumTarihi], [BabaAdi], [AnneAdi], [Cinsiyet], [KanGrubu], [MedeniHal], [Adres], [Tel], [KurumSicilNo], [KurumAdi], [YakinTel], [YakinKurumSicilNo], [YakinKurumAdi]) VALUES (1, N'24444444444', N'James', N'Brown', N'Ankara', CAST(N'2019-01-01T15:35:07.040' AS DateTime), NULL, NULL, N'Erkek', N'ABrh-', N'Evli', NULL, NULL, NULL, N'SSK', NULL, NULL, NULL)
INSERT [dbo].[Hasta] ([DosyaNo], [TckimlikNo], [Ad], [Soyad], [DogumYeri], [DogumTarihi], [BabaAdi], [AnneAdi], [Cinsiyet], [KanGrubu], [MedeniHal], [Adres], [Tel], [KurumSicilNo], [KurumAdi], [YakinTel], [YakinKurumSicilNo], [YakinKurumAdi]) VALUES (6, N'33333333333', N'Ali', N'Beter', N'İstanbul', CAST(N'2019-01-01T21:50:20.967' AS DateTime), N'Süleyman', N'Ayşe', N'Erkek', N'Arh-', N'Bekar', NULL, N'05555555555', NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Hasta] OFF
SET IDENTITY_INSERT [dbo].[Islem] ON 

INSERT [dbo].[Islem] ([IslemId], [IslemAdi], [BirimFiyat]) VALUES (1, N'Kan Tahlili', N'20')
INSERT [dbo].[Islem] ([IslemId], [IslemAdi], [BirimFiyat]) VALUES (2, N'a tahlili', N'25')
INSERT [dbo].[Islem] ([IslemId], [IslemAdi], [BirimFiyat]) VALUES (3, N'b tahlili', N'28')
INSERT [dbo].[Islem] ([IslemId], [IslemAdi], [BirimFiyat]) VALUES (4, N'c tahlili', N'35')
INSERT [dbo].[Islem] ([IslemId], [IslemAdi], [BirimFiyat]) VALUES (5, N'Muayene', N'50')
SET IDENTITY_INSERT [dbo].[Islem] OFF
SET IDENTITY_INSERT [dbo].[Kullanici] ON 

INSERT [dbo].[Kullanici] ([KullaniciKodu], [Ad], [Soyad], [Sifre], [Yetki], [EvTel], [CepTel], [Adres], [Unvan], [IseBaslama], [Maas], [DogumYeri], [AnneAdi], [BabaAdi], [Cinsiyet], [KanGrubu], [MedeniHal], [DogumTarihi], [TckimlikNo], [Username]) VALUES (7, N'Furkan', N'Arslan', N'12345', 1, NULL, NULL, NULL, N'Operatör', CAST(N'2019-01-01T21:53:06.117' AS DateTime), NULL, NULL, NULL, NULL, N'Erkek', N'Arh+', N'Bekar', CAST(N'2019-01-01T21:53:06.117' AS DateTime), N'12345678912', N'frkn12345')
INSERT [dbo].[Kullanici] ([KullaniciKodu], [Ad], [Soyad], [Sifre], [Yetki], [EvTel], [CepTel], [Adres], [Unvan], [IseBaslama], [Maas], [DogumYeri], [AnneAdi], [BabaAdi], [Cinsiyet], [KanGrubu], [MedeniHal], [DogumTarihi], [TckimlikNo], [Username]) VALUES (9, N'Aycan', N'Adıgüzel', N'1212', 1, N'121212', N'01115552244', N'Maltepe', N'Sağlık Personeli', CAST(N'2010-02-11T15:02:05.000' AS DateTime), N'2500', N'Adana', N'Ayşe', N'Ahmet', N'Erkek', N'0rh+', N'Bekar', CAST(N'1997-09-23T15:02:05.000' AS DateTime), N'11223344550', N'aycan1212')
INSERT [dbo].[Kullanici] ([KullaniciKodu], [Ad], [Soyad], [Sifre], [Yetki], [EvTel], [CepTel], [Adres], [Unvan], [IseBaslama], [Maas], [DogumYeri], [AnneAdi], [BabaAdi], [Cinsiyet], [KanGrubu], [MedeniHal], [DogumTarihi], [TckimlikNo], [Username]) VALUES (11, N'Mert', N'Çetin', N'11', 0, NULL, N'01112223344', NULL, N'Doktor', CAST(N'2018-12-13T23:20:53.000' AS DateTime), N'4000', N'Üsküdar', N'Ayla', N'Cemil', N'Erkek', N'Arh+', N'Bekar', CAST(N'1995-07-14T23:20:53.000' AS DateTime), N'11111222225', N'mertcetin_11')
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
SET IDENTITY_INSERT [dbo].[Poliklinik] ON 

INSERT [dbo].[Poliklinik] ([PoliklinikId], [PoliklinikAdi], [Durum], [Aciklama]) VALUES (1, N'Poliklinik 1', 1, N'Bu poliklinik 1''dir.')
INSERT [dbo].[Poliklinik] ([PoliklinikId], [PoliklinikAdi], [Durum], [Aciklama]) VALUES (2, N'Poliklinik 2', 1, N'Bu Poliklinik 2''dir.')
INSERT [dbo].[Poliklinik] ([PoliklinikId], [PoliklinikAdi], [Durum], [Aciklama]) VALUES (3, N'Poliklinik 3', 1, NULL)
INSERT [dbo].[Poliklinik] ([PoliklinikId], [PoliklinikAdi], [Durum], [Aciklama]) VALUES (4, N'Poliklinik 4', 0, NULL)
SET IDENTITY_INSERT [dbo].[Poliklinik] OFF
SET IDENTITY_INSERT [dbo].[Sevk] ON 

INSERT [dbo].[Sevk] ([SevkId], [DosyaNo], [PoliklinikId], [IslemId], [SevkTarihi], [Saat], [DrKod], [Miktar], [BirimFiyat], [Sira], [ToplamTutar], [Taburcu]) VALUES (1, 6, 1, 2, N'2019:1:3', N'16:44', 11, 1, N'25', 1, N'25', 0)
INSERT [dbo].[Sevk] ([SevkId], [DosyaNo], [PoliklinikId], [IslemId], [SevkTarihi], [Saat], [DrKod], [Miktar], [BirimFiyat], [Sira], [ToplamTutar], [Taburcu]) VALUES (2, 6, 1, 3, N'2019:1:3', N'16:44', 11, 1, N'28', 2, N'28', 0)
INSERT [dbo].[Sevk] ([SevkId], [DosyaNo], [PoliklinikId], [IslemId], [SevkTarihi], [Saat], [DrKod], [Miktar], [BirimFiyat], [Sira], [ToplamTutar], [Taburcu]) VALUES (3, 6, 2, 3, N'2019:1:3', N'16:44', 11, 1, N'28', 1, N'28', 0)
INSERT [dbo].[Sevk] ([SevkId], [DosyaNo], [PoliklinikId], [IslemId], [SevkTarihi], [Saat], [DrKod], [Miktar], [BirimFiyat], [Sira], [ToplamTutar], [Taburcu]) VALUES (4, 1, 1, 3, N'2018:12:13', N'17:12', 11, 1, N'28', 1, N'28', 1)
INSERT [dbo].[Sevk] ([SevkId], [DosyaNo], [PoliklinikId], [IslemId], [SevkTarihi], [Saat], [DrKod], [Miktar], [BirimFiyat], [Sira], [ToplamTutar], [Taburcu]) VALUES (9, 1, 1, 1, N'2019:1:3', N'23:54', 11, 1, N'20', 3, N'20', 0)
SET IDENTITY_INSERT [dbo].[Sevk] OFF
ALTER TABLE [dbo].[Cikis]  WITH CHECK ADD  CONSTRAINT [FK_Cikis_Hasta] FOREIGN KEY([DosyaNo])
REFERENCES [dbo].[Hasta] ([DosyaNo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cikis] CHECK CONSTRAINT [FK_Cikis_Hasta]
GO
ALTER TABLE [dbo].[Sevk]  WITH CHECK ADD  CONSTRAINT [FK_Sevk_Hasta] FOREIGN KEY([DosyaNo])
REFERENCES [dbo].[Hasta] ([DosyaNo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sevk] CHECK CONSTRAINT [FK_Sevk_Hasta]
GO
ALTER TABLE [dbo].[Sevk]  WITH CHECK ADD  CONSTRAINT [FK_Sevk_Islem] FOREIGN KEY([IslemId])
REFERENCES [dbo].[Islem] ([IslemId])
GO
ALTER TABLE [dbo].[Sevk] CHECK CONSTRAINT [FK_Sevk_Islem]
GO
ALTER TABLE [dbo].[Sevk]  WITH CHECK ADD  CONSTRAINT [FK_Sevk_Kullanici] FOREIGN KEY([DrKod])
REFERENCES [dbo].[Kullanici] ([KullaniciKodu])
GO
ALTER TABLE [dbo].[Sevk] CHECK CONSTRAINT [FK_Sevk_Kullanici]
GO
ALTER TABLE [dbo].[Sevk]  WITH CHECK ADD  CONSTRAINT [FK_Sevk_Poliklinik] FOREIGN KEY([PoliklinikId])
REFERENCES [dbo].[Poliklinik] ([PoliklinikId])
GO
ALTER TABLE [dbo].[Sevk] CHECK CONSTRAINT [FK_Sevk_Poliklinik]
GO
USE [master]
GO
ALTER DATABASE [SOHATS] SET  READ_WRITE 
GO
