USE GD2C2018
GO

PRINT('Eliminacion de Schema anterior') 
IF EXISTS (SELECT * FROM SYS.SCHEMAS WHERE name = 'COMPUMUNDOHIPERMEGARED')
BEGIN
	DECLARE @Sql NVARCHAR(MAX) = '';

-------------------------------------
--		ELIMINACION DE CONSTRAINTS
-------------------------------------
PRINT('Eliminacion de Constraints anteriores') 
	SELECT @Sql = @Sql + 'ALTER TABLE ' + QUOTENAME('COMPUMUNDOHIPERMEGARED') + '.' + QUOTENAME(t.name) + ' DROP CONSTRAINT ' 
																		+ QUOTENAME(f.name)  + ';' + CHAR(13)
	FROM SYS.TABLES t 
	INNER JOIN SYS.FOREIGN_KEYS f ON f.parent_object_id = t.object_id 
	INNER JOIN SYS.SCHEMAS s ON t.SCHEMA_ID = s.SCHEMA_ID
	WHERE s.name = 'COMPUMUNDOHIPERMEGARED'
	ORDER BY t.name;
	PRINT @Sql
	EXEC  (@Sql)

declare @SqlStatement nvarchar(max) = ''
PRINT('Eliminando procedures') 
SELECT @SqlStatement = COALESCE(@SqlStatement, N'') + N'DROP PROCEDURE [COMPUMUNDOHIPERMEGARED].' + QUOTENAME(name) + N';' + CHAR(13)
FROM sys.procedures
WHERE schema_id = SCHEMA_ID('COMPUMUNDOHIPERMEGARED')
PRINT @SqlStatement
EXEC  (@SqlStatement)

PRINT('Eliminando funciones') 
set @SqlStatement = ''
SELECT @SqlStatement = COALESCE(@SqlStatement, N'') + N'DROP FUNCTION [COMPUMUNDOHIPERMEGARED].' + QUOTENAME(name) + N';' + CHAR(13)
FROM sys.objects
WHERE schema_id = SCHEMA_ID('COMPUMUNDOHIPERMEGARED') and type_desc like '%FUNC%'
PRINT @SqlStatement
EXEC  (@SqlStatement)


PRINT('Eliminando views') 
set @SqlStatement = ''
SELECT @SqlStatement = COALESCE(@SqlStatement, N'') + N'DROP VIEW [COMPUMUNDOHIPERMEGARED].' + QUOTENAME(name) + N';' + CHAR(13)
FROM sys.objects
WHERE schema_id = SCHEMA_ID('COMPUMUNDOHIPERMEGARED') and type = 'V'
PRINT @SqlStatement
EXEC  (@SqlStatement)

PRINT('Eliminando secuencias') 
set @SqlStatement = ''
SELECT @SqlStatement = COALESCE(@SqlStatement, N'') + N'DROP SEQUENCE [COMPUMUNDOHIPERMEGARED].' + QUOTENAME(name) + N';' + CHAR(13)
FROM sys.objects
WHERE schema_id = SCHEMA_ID('COMPUMUNDOHIPERMEGARED') and type = 'SO'
PRINT @SqlStatement
EXEC  (@SqlStatement)

PRINT('Eliminando triggers') 
set @SqlStatement = ''
SELECT @SqlStatement = COALESCE(@SqlStatement, N'') + N'DROP TRIGGER [COMPUMUNDOHIPERMEGARED].' + QUOTENAME(name) + N';' + CHAR(13)
FROM sys.objects
WHERE schema_id = SCHEMA_ID('COMPUMUNDOHIPERMEGARED') and type = 'TR'
PRINT @SqlStatement
EXEC  (@SqlStatement)

PRINT('Eliminando types') 
set @SqlStatement = ''
SELECT @SqlStatement = COALESCE(@SqlStatement, N'') + N'DROP TYPE [COMPUMUNDOHIPERMEGARED].' + QUOTENAME(name) + N';' + CHAR(13)
from sys.types
WHERE schema_id = SCHEMA_ID('COMPUMUNDOHIPERMEGARED')
PRINT @SqlStatement
EXEC  (@SqlStatement)

-------------------------------------
--		ELIMINACION DE TABLAS
-------------------------------------
PRINT('Eliminacion de tablas existentes') 
set @SqlStatement = ''
	SELECT @SqlStatement = COALESCE(@SqlStatement, N'') + N'DROP TABLE [COMPUMUNDOHIPERMEGARED].' + QUOTENAME(TABLE_NAME) + N';' + CHAR(13)
	FROM INFORMATION_SCHEMA.TABLES
	WHERE TABLE_SCHEMA = 'COMPUMUNDOHIPERMEGARED' AND TABLE_TYPE = 'BASE TABLE'
	PRINT @SqlStatement
	EXEC  (@SqlStatement)
	DROP SCHEMA COMPUMUNDOHIPERMEGARED
END
PRINT('Eliminacion HECHA') 


