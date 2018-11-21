USE GD2C2018
GO

CREATE SCHEMA COMPUMUNDOHIPERMEGARED
GO

/* CREACION TABLAS */
PRINT '----- Empezando a crear tablas -----'
CREATE TABLE COMPUMUNDOHIPERMEGARED.Usuario(
	id_usuario int IDENTITY(1,1) PRIMARY KEY,
	username nvarchar(50) NOT NULL,
	password varbinary(32) NOT NULL, -- HASHBYTES ('SHA2_256',var)
	intentos tinyint DEFAULT 0,
	habilitado bit DEFAULT 1,
	eliminado bit DEFAULT 0
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Funcionalidad(
	id_funcionalidad int IDENTITY(1,1) PRIMARY KEY,
	descripcion nvarchar(50) NOT NULL
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Rol(
	id_rol int IDENTITY(1,1) PRIMARY KEY,
	nombre nvarchar(50) UNIQUE NOT NULL,
	habilitado bit DEFAULT 1
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Rol_Usuario(
	id_rol_usuario int IDENTITY(1,1) PRIMARY KEY,
	usuario_id int CONSTRAINT FK_ROLUSUARIO_USUARIO REFERENCES COMPUMUNDOHIPERMEGARED.Usuario(id_usuario),
	rol_id int CONSTRAINT FK_ROLUSUARIO_ROL REFERENCES COMPUMUNDOHIPERMEGARED.Rol(id_rol),
	habilitado bit DEFAULT 1,
	eliminado bit  DEFAULT 0	
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Rol_Funcionalidad(
	id_rol_funcionalidad int IDENTITY(1,1) PRIMARY KEY,
	rol_id int CONSTRAINT FK_ROLFUNCIONALIDAD_ROL REFERENCES COMPUMUNDOHIPERMEGARED.Rol(id_rol),
	funcionalidad_id int CONSTRAINT FK_ROLFUNCIONALIDAD_FUNCIONALIDAD REFERENCES COMPUMUNDOHIPERMEGARED.Funcionalidad(id_funcionalidad)
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Empresa(
	id_empresa int IDENTITY(1,1) PRIMARY KEY,
	cuit nvarchar(255) UNIQUE NOT NULL,
	razon_social nvarchar(255) NOT NULL,
	mail nvarchar(50),
	telefono nvarchar(30),
	ciudad nvarchar(255),
	localidad nvarchar(255),
	dom_calle nvarchar(50),
	nro_calle numeric(18,0),
	piso numeric(18,0),
	depto nvarchar(50),
	cod_postal nvarchar(50),
	fecha_creacion datetime NOT NULL,
	rol_usuario_id int CONSTRAINT FK_EMPRESA_ROLUSUARIO REFERENCES COMPUMUNDOHIPERMEGARED.Rol_Usuario(id_rol_usuario)
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Cliente(
	id_cliente int IDENTITY(1,1) PRIMARY KEY,
	cuil nvarchar(13),
	nombre nvarchar(255),
	apellido nvarchar(255),
	tipo_documento nvarchar(3) CHECK(tipo_documento IN('DNI','LC')) NOT NULL,
	nro_documento nvarchar(30) NOT NULL,
	mail nvarchar(255),
	telefono nvarchar(30),
	ciudad nvarchar(255),
	localidad nvarchar(255),
	dom_calle nvarchar(255),
	num_calle numeric(18,0),
	depto nvarchar(255),
	piso numeric(18,0),
	cod_postal nvarchar(255),
	cant_puntos int DEFAULT 0,
	fecha_nacimiento datetime,
	fecha_creacion datetime,
	rol_usuario_id int CONSTRAINT FK_CLIENTE_ROLUSUARIO REFERENCES COMPUMUNDOHIPERMEGARED.Rol_Usuario(id_rol_usuario)
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Rubro(
	id_rubro int IDENTITY(1,1) PRIMARY KEY,
	descripcion nvarchar(255) NOT NULL
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Grado(
	id_grado int IDENTITY(1,1) PRIMARY KEY,
	descripcion nvarchar(10) NOT NULL,
	comision numeric(5,2) DEFAULT 0,
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Tarjeta(
	id_tarjeta int IDENTITY(1,1) PRIMARY KEY,
	nro_tarjeta nvarchar(50) NOT NULL,
	tipo nvarchar(10) NOT NULL CHECK(tipo IN('DEBITO','CREDITO')),
	ccv nvarchar(5) NOT NULL,
	fecha_vencimiento date NOT NULL,
	eliminado bit DEFAULT 0,
	cliente_id int CONSTRAINT FK_TARJETA_CLIENTE references COMPUMUNDOHIPERMEGARED.Cliente(id_cliente)
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Factura(
	id_factura int IDENTITY(1,1) PRIMARY KEY,
	numero numeric(18,0),
	fecha datetime,
	total numeric(18,2),
	desc_comision numeric(18,2),
	forma_pago varchar(255),
	pagoEmpresa bit DEFAULT 0,
	empresa_id int CONSTRAINT FK_FACTURA_EMPRESA references COMPUMUNDOHIPERMEGARED.Empresa
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Item_Factura(
	id_item_factura int IDENTITY(1,1) PRIMARY KEY,
	item_factura_monto numeric(18,2),
	item_factura_cantidad numeric(18),
	item_factura_descripcion varchar(60),
	factura_id int CONSTRAINT FK_ITEMFACTURA_FACTURA references COMPUMUNDOHIPERMEGARED.Factura(id_factura),
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Compra(
	id_compra int IDENTITY(1,1) PRIMARY KEY,
	factura_id int CONSTRAINT FK_COMPRA_FACTURA references COMPUMUNDOHIPERMEGARED.Factura(id_factura),
	cliente_id int CONSTRAINT FK_COMPRA_CLIENTE references COMPUMUNDOHIPERMEGARED.Cliente(id_cliente),
	tarjeta_id int CONSTRAINT FK_COMPRA_TARJETA references COMPUMUNDOHIPERMEGARED.Tarjeta(id_tarjeta)
)

CREATE TABLE  COMPUMUNDOHIPERMEGARED.Canje(
	id_canje int IDENTITY(1,1) PRIMARY KEY,
	descripcion nvarchar(50),
	codigo nvarchar(10) DEFAULT CONVERT(nvarchar(10), NEWID()),
	usado bit DEFAULT 0,
	fecha_generado datetime,
	fecha_usado datetime,
	cliente_id int CONSTRAINT FK_CANJE_CLIENTE references COMPUMUNDOHIPERMEGARED.Cliente(id_cliente),
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Puntos(
	id_puntos int IDENTITY(1,1) primary key,
	cant_puntos int DEFAULT 0,
	cliente_id int CONSTRAINT FK_PUNTOS_CLIENTE references COMPUMUNDOHIPERMEGARED.Cliente(id_cliente),
	compra_id int CONSTRAINT FK_PUNTOS_COMPRA references COMPUMUNDOHIPERMEGARED.Compra(id_compra),
	canje_id int CONSTRAINT FK_PUNTOS_CANJE references COMPUMUNDOHIPERMEGARED.Canje(id_canje)
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Publicacion(
	id_publicacion int IDENTITY(1,1) PRIMARY KEY,
	descripcion nvarchar(255),
	fecha_creacion datetime,
	fecha_vencimiento datetime,
	fecha_espectaculo datetime,
	estado nvarchar(10) NOT NULL CHECK(estado IN('BORRADOR','PUBLICADA','FINALIZADA')),
	ciudad nvarchar(255),
	localidad nvarchar(255),
	dom_calle nvarchar(50),
	num_calle numeric(18,0),
	cod_postal nvarchar(50),
	empresa_id int CONSTRAINT FK_PUBLICACION_EMPRESA references COMPUMUNDOHIPERMEGARED.Empresa(id_empresa),
	rubro_id int CONSTRAINT FK_PUBLICACION_RUBRO references COMPUMUNDOHIPERMEGARED.Rubro(id_rubro),
	grado_id int CONSTRAINT FK_PUBLICACION_GRADO references COMPUMUNDOHIPERMEGARED.Grado(id_grado)
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.TipoUbicacion(
	id_tipo_ubicacion numeric(18) PRIMARY KEY,
	descripcion nvarchar(255)
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Ubicacion(
	id_ubicacion int IDENTITY(1,1) PRIMARY KEY,
	fila varchar(3),
	asiento numeric(18,0),
	precio numeric(18,0),
	sin_numerar bit,
	ocupado bit default 0,
	tipo_ubicacion_id numeric(18) CONSTRAINT FK_UBICACION_TIPOUBICACION references COMPUMUNDOHIPERMEGARED.TipoUbicacion(id_tipo_ubicacion),
	compra_id int CONSTRAINT FK_UBICACION_COMPRA references COMPUMUNDOHIPERMEGARED.Compra(id_compra),
	publicacion_id int CONSTRAINT FK_UBICACION_PUBLICACION references COMPUMUNDOHIPERMEGARED.Publicacion(id_publicacion)
)

/* MIGRACION DATOS */
PRINT '----- Empezando a migrar datos -----'
DECLARE @fecha_creacion datetime = GETUTCDATE()
INSERT INTO COMPUMUNDOHIPERMEGARED.Cliente (tipo_documento, nro_documento, apellido, nombre, fecha_nacimiento, fecha_creacion, mail, dom_calle, num_calle, piso, depto, cod_postal)
	SELECT DISTINCT 'DNI', m.Cli_Dni, m.Cli_Apeliido, m.Cli_Nombre, m.Cli_Fecha_Nac, @fecha_creacion, m.Cli_Mail, m.Cli_Dom_Calle, m.Cli_Nro_Calle, m.Cli_Piso, m.Cli_Depto, m.Cli_Cod_Postal
		FROM gd_esquema.Maestra m
		ORDER BY m.Cli_Dni
		OFFSET 1 ROWS
PRINT 'Migre Clientes'
GO
