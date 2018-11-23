USE GD2C2018
GO


/* DROP FOREIGN KEYS */
PRINT '----- Empezando a borrar constraints/foreign keys -----'

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Rol_Usuario', 'U') IS NOT NULL
	BEGIN
		ALTER TABLE COMPUMUNDOHIPERMEGARED.Rol_Usuario
		DROP CONSTRAINT FK_ROLUSUARIO_USUARIO, FK_ROLUSUARIO_ROL
		PRINT 'Borre Constraint Rol_Usuario'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Rol_Funcionalidad', 'U') IS NOT NULL
	BEGIN
		ALTER TABLE COMPUMUNDOHIPERMEGARED.Rol_Funcionalidad
		DROP CONSTRAINT FK_ROLFUNCIONALIDAD_ROL, FK_ROLFUNCIONALIDAD_FUNCIONALIDAD
		PRINT 'Borre Constraint Rol_Funcionalidad'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Empresa', 'U') IS NOT NULL
	BEGIN
		ALTER TABLE COMPUMUNDOHIPERMEGARED.Empresa
		DROP CONSTRAINT FK_EMPRESA_ROLUSUARIO
		PRINT 'Borre Constraint Empresa'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Cliente', 'U') IS NOT NULL
	BEGIN
		ALTER TABLE COMPUMUNDOHIPERMEGARED.Cliente
		DROP CONSTRAINT FK_CLIENTE_ROLUSUARIO
		PRINT 'Borre Constraint Cliente'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Tarjeta', 'U') IS NOT NULL
	BEGIN
		ALTER TABLE COMPUMUNDOHIPERMEGARED.Tarjeta
		DROP CONSTRAINT FK_TARJETA_CLIENTE
		PRINT 'Borre Constraint Tarjeta'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Factura', 'U') IS NOT NULL
	BEGIN
		ALTER TABLE COMPUMUNDOHIPERMEGARED.Factura
		DROP CONSTRAINT FK_FACTURA_EMPRESA
		PRINT 'Borre Constraint Factura'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Item_Factura', 'U') IS NOT NULL
	BEGIN
		ALTER TABLE COMPUMUNDOHIPERMEGARED.Item_Factura
		DROP CONSTRAINT FK_ITEMFACTURA_FACTURA
		PRINT 'Borre Constraint Item_Factura'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Compra', 'U') IS NOT NULL
	BEGIN
		ALTER TABLE COMPUMUNDOHIPERMEGARED.Compra
		DROP CONSTRAINT FK_COMPRA_FACTURA, FK_COMPRA_CLIENTE, FK_COMPRA_TARJETA
		PRINT 'Borre Constraint Compra'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Canje', 'U') IS NOT NULL
	BEGIN
		ALTER TABLE COMPUMUNDOHIPERMEGARED.Canje
		DROP CONSTRAINT FK_CANJE_CLIENTE
		PRINT 'Borre Constraint Canje'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Puntos', 'U') IS NOT NULL
	BEGIN
		ALTER TABLE COMPUMUNDOHIPERMEGARED.Puntos
		DROP CONSTRAINT FK_PUNTOS_CLIENTE, FK_PUNTOS_COMPRA, FK_PUNTOS_CANJE
		PRINT 'Borre Constraint Puntos'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Publicacion', 'U') IS NOT NULL
	BEGIN
		ALTER TABLE COMPUMUNDOHIPERMEGARED.Publicacion
		DROP CONSTRAINT FK_PUBLICACION_EMPRESA, FK_PUBLICACION_RUBRO, FK_PUBLICACION_GRADO
		PRINT 'Borre Constraint Publicacion'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Ubicacion', 'U') IS NOT NULL
	BEGIN
		ALTER TABLE COMPUMUNDOHIPERMEGARED.Ubicacion
		DROP CONSTRAINT FK_UBICACION_TIPOUBICACION, FK_UBICACION_COMPRA, FK_UBICACION_PUBLICACION
		PRINT 'Borre Constraint Ubicacion'
END

/* DROP TABLES */
PRINT '----- Empezando a borrar tablas -----'

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Usuario', 'U') IS NOT NULL
	BEGIN
		DROP TABLE COMPUMUNDOHIPERMEGARED.Usuario
		PRINT 'Borre Tabla Usuario'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Funcionalidad', 'U') IS NOT NULL
	BEGIN
		DROP TABLE COMPUMUNDOHIPERMEGARED.Funcionalidad
		PRINT 'Borre Tabla Funcionalidad'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Rol', 'U') IS NOT NULL
	BEGIN
		DROP TABLE COMPUMUNDOHIPERMEGARED.Rol
		PRINT 'Borre Tabla Rol'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Rol_Usuario', 'U') IS NOT NULL
	BEGIN
		DROP TABLE COMPUMUNDOHIPERMEGARED.Rol_Usuario
		PRINT 'Borre Tabla Rol_Usuario'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Rol_Funcionalidad', 'U') IS NOT NULL
	BEGIN
		DROP TABLE COMPUMUNDOHIPERMEGARED.Rol_Funcionalidad
		PRINT 'Borre Tabla Rol_Funcionalidad'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Empresa', 'U') IS NOT NULL
	BEGIN
		DROP TABLE COMPUMUNDOHIPERMEGARED.Empresa
		PRINT 'Borre Tabla Empresa'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Cliente', 'U') IS NOT NULL
	BEGIN
		DROP TABLE COMPUMUNDOHIPERMEGARED.Cliente
		PRINT 'Borre Tabla Cliente'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Rubro', 'U') IS NOT NULL
	BEGIN
		DROP TABLE COMPUMUNDOHIPERMEGARED.Rubro
		PRINT 'Borre Tabla Rubro'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Grado', 'U') IS NOT NULL
	BEGIN	
		DROP TABLE COMPUMUNDOHIPERMEGARED.Grado
		PRINT 'Borre Tabla Grado'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Tarjeta', 'U') IS NOT NULL
	BEGIN
		DROP TABLE COMPUMUNDOHIPERMEGARED.Tarjeta
		PRINT 'Borre Tabla Tarjeta'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Factura', 'U') IS NOT NULL
	BEGIN
		DROP TABLE COMPUMUNDOHIPERMEGARED.Factura
		PRINT 'Borre Tabla Factura'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Item_Factura', 'U') IS NOT NULL
	BEGIN
		DROP TABLE COMPUMUNDOHIPERMEGARED.Item_Factura
		PRINT 'Borre Tabla Item_Factura'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Compra', 'U') IS NOT NULL
	BEGIN
		DROP TABLE COMPUMUNDOHIPERMEGARED.Compra
		PRINT 'Borre Tabla Compra'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Canje', 'U') IS NOT NULL
	BEGIN
		DROP TABLE COMPUMUNDOHIPERMEGARED.Canje
		PRINT 'Borre Tabla Canje'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Puntos', 'U') IS NOT NULL
	BEGIN
		DROP TABLE COMPUMUNDOHIPERMEGARED.Puntos
		PRINT 'Borre Tabla Puntos'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Publicacion', 'U') IS NOT NULL
	BEGIN
		DROP TABLE COMPUMUNDOHIPERMEGARED.Publicacion
		PRINT 'Borre Tabla Publicacion'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.TipoUbicacion', 'U') IS NOT NULL
	BEGIN
		DROP TABLE COMPUMUNDOHIPERMEGARED.TipoUbicacion
		PRINT 'Borre Tabla TipoUbicacion'
END

IF OBJECT_ID('COMPUMUNDOHIPERMEGARED.Ubicacion', 'U') IS NOT NULL
	BEGIN
		DROP TABLE COMPUMUNDOHIPERMEGARED.Ubicacion
		PRINT 'Borre Tabla Ubicacion'
END

/* DROP SCHEMA */
PRINT '----- Empezando a borrar esquema -----'

IF EXISTS (SELECT name FROM sys.schemas WHERE name = 'COMPUMUNDOHIPERMEGARED')
	BEGIN
		DROP SCHEMA COMPUMUNDOHIPERMEGARED
		PRINT 'Borre Schema'
END
GO