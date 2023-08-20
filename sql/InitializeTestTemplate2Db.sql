USE master
GO

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'TestTemplate2Db')
BEGIN
  CREATE DATABASE TestTemplate2Db;
END;
GO

USE TestTemplate2Db;
GO

IF NOT EXISTS (SELECT 1
                 FROM sys.server_principals
                WHERE [name] = N'TestTemplate2Db_Login' 
                  AND [type] IN ('C','E', 'G', 'K', 'S', 'U'))
BEGIN
    CREATE LOGIN TestTemplate2Db_Login
        WITH PASSWORD = '<DB_PASSWORD>';
END;
GO  

IF NOT EXISTS (select * from sys.database_principals where name = 'TestTemplate2Db_User')
BEGIN
    CREATE USER TestTemplate2Db_User FOR LOGIN TestTemplate2Db_Login;
END;
GO  


EXEC sp_addrolemember N'db_datareader', N'TestTemplate2Db_User';
GO

EXEC sp_addrolemember N'db_datawriter', N'TestTemplate2Db_User';
GO

EXEC sp_addrolemember N'db_ddladmin', N'TestTemplate2Db_User';
GO
