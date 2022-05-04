ALTER DATABASE [Clube_informatica] SET EMERGENCY;
GO
ALTER DATABASE [Clube_informatica] set single_user
GO
DBCC CHECKDB ([Clube_informatica], REPAIR_ALLOW_DATA_LOSS) WITH ALL_ERRORMSGS;
GO
ALTER DATABASE [Clube_informatica] set multi_user
GO