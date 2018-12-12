USE GD2C2018
GO

----------------------------------------------------------------------------------------------
								/** ELIMINACIÓN DE CONSTRAINS DE TABLAS ANTERIORES **/
----------------------------------------------------------------------------------------------
drop procedure COMPUMUNDOHIPERMEGARED.crearNuevoRol
drop procedure COMPUMUNDOHIPERMEGARED.actualizarRol
drop procedure COMPUMUNDOHIPERMEGARED.crear_nuevo_usuario
drop procedure COMPUMUNDOHIPERMEGARED.intentar_logear
drop procedure COMPUMUNDOHIPERMEGARED.crear_usuario_cliente
drop procedure COMPUMUNDOHIPERMEGARED.crear_usuario_empresa
drop procedure COMPUMUNDOHIPERMEGARED.eliminar_rol
drop procedure COMPUMUNDOHIPERMEGARED.crear_borrador
drop procedure COMPUMUNDOHIPERMEGARED.generar_ubicaciones_de
drop procedure COMPUMUNDOHIPERMEGARED.update_datos_borrador
drop procedure COMPUMUNDOHIPERMEGARED.publicar_fecha
drop procedure COMPUMUNDOHIPERMEGARED.realizarCanje
drop procedure COMPUMUNDOHIPERMEGARED.AsignarTarjetaA
drop procedure COMPUMUNDOHIPERMEGARED.ComprarUbicaciones
drop procedure COMPUMUNDOHIPERMEGARED.RegistrarPuntosDeCompra

drop function COMPUMUNDOHIPERMEGARED.find_funcionalidades_de_rol
drop function COMPUMUNDOHIPERMEGARED.find_funcionalidades_de_usuario
drop function COMPUMUNDOHIPERMEGARED.get_espectaculo_id_de_publicacion
drop function COMPUMUNDOHIPERMEGARED.puntosDeCliente

drop trigger COMPUMUNDOHIPERMEGARED.PubliTrigger

drop type COMPUMUNDOHIPERMEGARED.FuncionalidadList
drop TYPE UbicacionTableType

drop view COMPUMUNDOHIPERMEGARED.PublicacionesView

drop SEQUENCE COMPUMUNDOHIPERMEGARED.CompraSequence
drop SEQUENCE COMPUMUNDOHIPERMEGARED.UbicacionSequence


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
	PRINT('Eliminacion HECHA') 
	/*

	*/
-------------------------------------
--		ELIMINACION DE TABLAS
-------------------------------------
PRINT('Eliminacion de tablas existentes') 
	DECLARE @SqlStatement NVARCHAR(MAX)
	SELECT @SqlStatement = COALESCE(@SqlStatement, N'') + N'DROP TABLE [COMPUMUNDOHIPERMEGARED].' + QUOTENAME(TABLE_NAME) + N';' + CHAR(13)
	FROM INFORMATION_SCHEMA.TABLES
	WHERE TABLE_SCHEMA = 'COMPUMUNDOHIPERMEGARED' AND TABLE_TYPE = 'BASE TABLE'
	PRINT @SqlStatement
	EXEC  (@SqlStatement)
	DROP SCHEMA COMPUMUNDOHIPERMEGARED
END
GO
PRINT('Eliminacion HECHA') 

/*
DROP TABLE COMPUMUNDOHIPERMEGARED.Usuario 
DROP TABLE COMPUMUNDOHIPERMEGARED.Rol_Usuario
DROP TABLE COMPUMUNDOHIPERMEGARED.Cliente
DROP TABLE COMPUMUNDOHIPERMEGARED.Empresa
DROP TABLE COMPUMUNDOHIPERMEGARED.Rol_Funcionalidad
DROP TABLE COMPUMUNDOHIPERMEGARED.Funcionalidad
DROP TABLE COMPUMUNDOHIPERMEGARED.Tarjeta
DROP TABLE COMPUMUNDOHIPERMEGARED.Ubicacion
DROP TABLE COMPUMUNDOHIPERMEGARED.TipoUbicacion
DROP TABLE COMPUMUNDOHIPERMEGARED.Compra
DROP TABLE COMPUMUNDOHIPERMEGARED.Puntos
DROP TABLE COMPUMUNDOHIPERMEGARED.Grado
DROP TABLE COMPUMUNDOHIPERMEGARED.Publicacion
DROP TABLE COMPUMUNDOHIPERMEGARED.Rol
DROP TABLE COMPUMUNDOHIPERMEGARED.PremioDisponible
DROP TABLE COMPUMUNDOHIPERMEGARED.CanjeUsuario
DROP TABLE COMPUMUNDOHIPERMEGARED.Factura
DROP TABLE COMPUMUNDOHIPERMEGARED.Item_Factura
DROP TABLE COMPUMUNDOHIPERMEGARED.Rubro
DROP TABLE COMPUMUNDOHIPERMEGARED.Sector
DROP TABLE COMPUMUNDOHIPERMEGARED.Espectaculo

drop table COMPUMUNDOHIPERMEGARED.##UbicacionTemp
drop table COMPUMUNDOHIPERMEGARED.##CompraTemp

drop procedure COMPUMUNDOHIPERMEGARED.crearNuevoRol
drop procedure COMPUMUNDOHIPERMEGARED.actualizarRol
drop procedure COMPUMUNDOHIPERMEGARED.crear_nuevo_usuario
drop procedure COMPUMUNDOHIPERMEGARED.intentar_logear
drop procedure COMPUMUNDOHIPERMEGARED.crear_usuario_cliente
drop procedure COMPUMUNDOHIPERMEGARED.crear_usuario_empresa
drop procedure COMPUMUNDOHIPERMEGARED.eliminar_rol
drop procedure COMPUMUNDOHIPERMEGARED.crear_borrador
drop procedure COMPUMUNDOHIPERMEGARED.generar_ubicaciones_de
drop procedure COMPUMUNDOHIPERMEGARED.update_datos_borrador
drop procedure COMPUMUNDOHIPERMEGARED.publicar_fecha

drop function COMPUMUNDOHIPERMEGARED.find_funcionalidades_de_rol
drop function COMPUMUNDOHIPERMEGARED.find_funcionalidades_de_usuario
drop function COMPUMUNDOHIPERMEGARED.get_espectaculo_id_de_publicacion

drop trigger COMPUMUNDOHIPERMEGARED.PubliTrigger

drop type COMPUMUNDOHIPERMEGARED.FuncionalidadList 

drop view COMPUMUNDOHIPERMEGARED.PublicacionesView

drop SEQUENCE COMPUMUNDOHIPERMEGARED.CompraSequence
drop SEQUENCE COMPUMUNDOHIPERMEGARED.UbicacionSequence

DROP SCHEMA COMPUMUNDOHIPERMEGARED
*/
