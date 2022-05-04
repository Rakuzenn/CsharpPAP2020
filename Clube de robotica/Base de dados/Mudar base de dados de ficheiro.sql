
ALTER DATABASE Clube_informatica SET OFFLINE;  
GO

ALTER DATABASE Clube_informatica   
    MODIFY FILE ( NAME = Clube_informatica,   
                  FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Clube_informatica.mdf');  
GO
ALTER DATABASE Clube_informatica   
    MODIFY FILE ( NAME = Clube_informatica_Log,   
                  FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Clube_informatica_log.ldf');  
GO