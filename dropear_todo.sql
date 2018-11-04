use GD2C2018
GO

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Publicacion', 'U') IS NOT NULL 
	drop table COMPUMUNDOHIPERMEGARED.Publicacion
IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Rol', 'U') IS NOT NULL 
	drop table COMPUMUNDOHIPERMEGARED.Rol
IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Rol_Usuario', 'U') IS NOT NULL 
	drop table COMPUMUNDOHIPERMEGARED.Rol_Usuario
IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Empresa', 'U') IS NOT NULL 
	drop table COMPUMUNDOHIPERMEGARED.Empresa
IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Cliente', 'U') IS NOT NULL 
	drop table COMPUMUNDOHIPERMEGARED.Cliente
IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Usuario', 'U') IS NOT NULL 
	drop table COMPUMUNDOHIPERMEGARED.Usuario

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Tarjeta', 'U') IS NOT NULL 
	drop table COMPUMUNDOHIPERMEGARED.Tarjeta

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Compras', 'U') IS NOT NULL 
	drop table COMPUMUNDOHIPERMEGARED.Compras

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Puntos', 'U') IS NOT NULL 
	drop table COMPUMUNDOHIPERMEGARED.Puntos

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Facturas', 'U') IS NOT NULL 
	drop table COMPUMUNDOHIPERMEGARED.Facturas

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Pagos', 'U') IS NOT NULL 
	drop table COMPUMUNDOHIPERMEGARED.Pagos

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.TipoUbicacion', 'U') IS NOT NULL 
	drop table COMPUMUNDOHIPERMEGARED.TipoUbicacion

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Ubicacion', 'U') IS NOT NULL 
	drop table COMPUMUNDOHIPERMEGARED.Ubicacion

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Rubro', 'U') IS NOT NULL 
	drop table COMPUMUNDOHIPERMEGARED.Rubro

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Grado', 'U') IS NOT NULL 
	drop table COMPUMUNDOHIPERMEGARED.Grado

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Item_Factura', 'U') IS NOT NULL 
	drop table COMPUMUNDOHIPERMEGARED.Item_Factura


IF EXISTS (SELECT 1 FROM sys.schemas WHERE name = 'COMPUMUNDOHIPERMEGARED')
	drop schema COMPUMUNDOHIPERMEGARED
GO
