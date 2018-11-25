USE GD2C2018
GO

CREATE SCHEMA COMPUMUNDOHIPERMEGARED
GO

/* CREACION TABLAS */
PRINT '----- Empezando a crear tablas -----'
CREATE TABLE COMPUMUNDOHIPERMEGARED.Usuario( -- MIGRADO
	id_usuario int IDENTITY(1,1) PRIMARY KEY,
	username nvarchar(50) NOT NULL,
	password varbinary(32) NOT NULL,
	intentos tinyint DEFAULT 0,
	habilitado bit DEFAULT 1,
	eliminado bit DEFAULT 0
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Funcionalidad( -- MIGRADO
	id_funcionalidad int IDENTITY(1,1) PRIMARY KEY,
	descripcion nvarchar(50) NOT NULL
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Rol( -- MIGRADO
	id_rol int IDENTITY(1,1) PRIMARY KEY,
	nombre nvarchar(50) UNIQUE NOT NULL,
	habilitado bit DEFAULT 1
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Rol_Usuario( -- MIGRADO
	id_rol_usuario int IDENTITY(1,1) PRIMARY KEY,
	usuario_id int CONSTRAINT FK_ROLUSUARIO_USUARIO REFERENCES COMPUMUNDOHIPERMEGARED.Usuario(id_usuario),
	rol_id int CONSTRAINT FK_ROLUSUARIO_ROL REFERENCES COMPUMUNDOHIPERMEGARED.Rol(id_rol),
	habilitado bit DEFAULT 1,
	eliminado bit  DEFAULT 0	
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Rol_Funcionalidad( -- MIGRADO
	id_rol_funcionalidad int IDENTITY(1,1) PRIMARY KEY,
	rol_id int CONSTRAINT FK_ROLFUNCIONALIDAD_ROL REFERENCES COMPUMUNDOHIPERMEGARED.Rol(id_rol),
	funcionalidad_id int CONSTRAINT FK_ROLFUNCIONALIDAD_FUNCIONALIDAD REFERENCES COMPUMUNDOHIPERMEGARED.Funcionalidad(id_funcionalidad)
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Empresa( -- MIGRADO
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

CREATE TABLE COMPUMUNDOHIPERMEGARED.Cliente( -- MIGRADO
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

CREATE TABLE COMPUMUNDOHIPERMEGARED.Rubro( -- MIGRADO
	id_rubro int IDENTITY(1,1) PRIMARY KEY,
	descripcion nvarchar(255) NOT NULL
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Grado( -- MIGRADO
	id_grado int IDENTITY(1,1) PRIMARY KEY,
	descripcion nvarchar(10) NOT NULL,
	comision numeric(5,2) DEFAULT 0,
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Tarjeta( -- MIGRADO
	id_tarjeta int IDENTITY(1,1) PRIMARY KEY,
	nro_tarjeta nvarchar(50) NOT NULL,
	tipo nvarchar(10) NOT NULL CHECK(tipo IN('DEBITO','CREDITO')),
	ccv nvarchar(5) NOT NULL,
	fecha_vencimiento date NOT NULL,
	eliminado bit DEFAULT 0,
	cliente_id int CONSTRAINT FK_TARJETA_CLIENTE references COMPUMUNDOHIPERMEGARED.Cliente(id_cliente)
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Factura( -- MIGRADO
	id_factura int IDENTITY(1,1) PRIMARY KEY,
	numero numeric(18,0),
	fecha datetime,
	total numeric(18,2), -- (sumatoria monto_total de compras)
	forma_pago varchar(255),
	empresa_id int CONSTRAINT FK_FACTURA_EMPRESA references COMPUMUNDOHIPERMEGARED.Empresa
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Item_Factura( -- MIGRADO
	id_item_factura int IDENTITY(1,1) PRIMARY KEY,
	item_factura_monto numeric(18,2), -- (comision descontada por cada compra)
	item_factura_cantidad numeric(18,0), -- (1)
	item_factura_descripcion nvarchar(60), -- ('Comision por compra')
	factura_id int CONSTRAINT FK_ITEMFACTURA_FACTURA references COMPUMUNDOHIPERMEGARED.Factura(id_factura),
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Publicacion( -- MIGRADO
	id_publicacion int IDENTITY(1,1) PRIMARY KEY,
	codigo numeric(18,0),
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

CREATE TABLE COMPUMUNDOHIPERMEGARED.TipoUbicacion( -- MIGRADO
	id_tipo_ubicacion int IDENTITY(1,1) PRIMARY KEY,
	codigo numeric(18,0),
	descripcion nvarchar(255)
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Ubicacion(
	id_ubicacion int IDENTITY(1,1) PRIMARY KEY,
	fila varchar(3),
	asiento numeric(18,0),
	precio numeric(18,0),
	sin_numerar bit,
	ocupado bit default 0,
	tipo_ubicacion_id int CONSTRAINT FK_UBICACION_TIPOUBICACION references COMPUMUNDOHIPERMEGARED.TipoUbicacion(id_tipo_ubicacion),
	publicacion_id int CONSTRAINT FK_UBICACION_PUBLICACION references COMPUMUNDOHIPERMEGARED.Publicacion(id_publicacion)
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Compra(
	id_compra int IDENTITY(1,1) PRIMARY KEY,
	fecha datetime,
	factura_id int CONSTRAINT FK_COMPRA_FACTURA references COMPUMUNDOHIPERMEGARED.Factura(id_factura),
	cliente_id int CONSTRAINT FK_COMPRA_CLIENTE references COMPUMUNDOHIPERMEGARED.Cliente(id_cliente),
	publicacion_id int CONSTRAINT FK_COMPRA_PUBLICACION references COMPUMUNDOHIPERMEGARED.Publicacion(id_publicacion),
	ubicacion_id int CONSTRAINT FK_COMPRA_UBICACION references COMPUMUNDOHIPERMEGARED.Ubicacion(id_ubicacion),
	tarjeta_id int CONSTRAINT FK_COMPRA_TARJETA references COMPUMUNDOHIPERMEGARED.Tarjeta(id_tarjeta)
)


CREATE TABLE COMPUMUNDOHIPERMEGARED.CanjeDisponible( -- MIGRADO
	id_canje_disponible int IDENTITY(1,1) PRIMARY KEY,
	descripcion nvarchar(60),
	cant_puntos int DEFAULT 0
)

CREATE TABLE  COMPUMUNDOHIPERMEGARED.CanjeUsuario( -- MIGRADO
	id_canje_usuario int IDENTITY(1,1) PRIMARY KEY,
	fecha_generado datetime,
	fecha_usado datetime,
	cliente_id int CONSTRAINT FK_CANJEUSUARIO_CLIENTE references COMPUMUNDOHIPERMEGARED.Cliente(id_cliente),
	canje_disponible_id int CONSTRAINT FK_CANJEUSUARIO_CANJEDISPONIBLE references COMPUMUNDOHIPERMEGARED.CanjeDisponible(id_canje_disponible)
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Puntos( 
	id_puntos int IDENTITY(1,1) primary key,
	cant_puntos int DEFAULT 0,
	cliente_id int CONSTRAINT FK_PUNTOS_CLIENTE references COMPUMUNDOHIPERMEGARED.Cliente(id_cliente),
	compra_id int CONSTRAINT FK_PUNTOS_COMPRA references COMPUMUNDOHIPERMEGARED.Compra(id_compra),
	canje_id int CONSTRAINT FK_PUNTOS_CANJEUSUARIO references COMPUMUNDOHIPERMEGARED.CanjeUsuario(id_canje_usuario)
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

DECLARE @fecha_creacion datetime = GETUTCDATE()
INSERT INTO COMPUMUNDOHIPERMEGARED.Empresa (cuit, razon_social, mail, dom_calle, nro_calle, piso, depto, cod_postal, fecha_creacion)
	SELECT DISTINCT m.Espec_Empresa_Cuit, m.Espec_Empresa_Razon_Social, m.Espec_Empresa_Mail, m.Espec_Empresa_Dom_Calle, m.Espec_Empresa_Nro_Calle, m.Espec_Empresa_Piso, m.Espec_Empresa_Depto, m.Espec_Empresa_Cod_Postal, @fecha_creacion
		FROM gd_esquema.Maestra m
		ORDER BY m.Espec_Empresa_Cuit
PRINT 'Migre Empresas'
GO

INSERT INTO COMPUMUNDOHIPERMEGARED.Usuario (username, password)
	SELECT m.nro_documento, HASHBYTES('SHA2_256',m.nro_documento)
		FROM COMPUMUNDOHIPERMEGARED.Cliente m
		ORDER BY m.nro_documento

INSERT INTO COMPUMUNDOHIPERMEGARED.Usuario (username, password)
	SELECT m.cuit , HASHBYTES('SHA2_256',m.cuit)
		FROM COMPUMUNDOHIPERMEGARED.Empresa m
		ORDER BY m.cuit
PRINT 'Migre Usuarios'
GO

INSERT INTO COMPUMUNDOHIPERMEGARED.Funcionalidad(descripcion) VALUES
	('REGISTRO'),
	('ABM USUARIOS'),
	('ABM CLIENTES'),
	('ABM ROL'),
	('ABM EMPRESA ESPECTACULOS'),
	('ABM RUBRO'),
	('ABM GRADO PUBLICACION'),
	('AM PUBLICACION'),
	('COMPRAR'),
	('HISTORIAL COMPRAS'),
	('CANJE'),
	('RENDICION COMISIONES'),
	('LISTADO ESTADISTICO')
PRINT 'Migre Funcionalidad'
GO

INSERT INTO COMPUMUNDOHIPERMEGARED.Rol(nombre) VALUES
	('Cliente'),
	('Empresa'),
	('Administrador')
PRINT 'Migre Roles'
GO

INSERT INTO COMPUMUNDOHIPERMEGARED.Rol_Funcionalidad(rol_id, funcionalidad_id) VALUES
	(1,1), (1,9), (1,10), (1,11),
	(2,1), (2,8),
	(3,2), (3,3), (3,4), (3,5), (3,6), (3,7), (3,12), (3,13)
PRINT 'Migre Roles_Funcionalidad'
GO

INSERT INTO COMPUMUNDOHIPERMEGARED.Rol_Usuario(usuario_id, rol_id)
	SELECT u.id_usuario, 1
	FROM COMPUMUNDOHIPERMEGARED.Usuario u
	WHERE u.username IN (SELECT m.nro_documento FROM COMPUMUNDOHIPERMEGARED.Cliente m)

INSERT INTO COMPUMUNDOHIPERMEGARED.Rol_Usuario(usuario_id, rol_id)
	SELECT u.id_usuario, 2
	FROM COMPUMUNDOHIPERMEGARED.Usuario u
	WHERE u.username IN (SELECT m.cuit FROM COMPUMUNDOHIPERMEGARED.Empresa m)
PRINT 'Migre Rol_Usuario'
GO

INSERT INTO COMPUMUNDOHIPERMEGARED.Grado(descripcion, comision) VALUES
	('NINGUNO',0),
	('BAJA', 2.0),
	('MEDIA', 5.0),
	('ALTA', 10.0)
PRINT 'Migre Grados'
GO

INSERT INTO COMPUMUNDOHIPERMEGARED.Factura(numero, fecha, total, forma_pago, empresa_id)
	SELECT DISTINCT m.Factura_Nro, m.Factura_Fecha, m.Factura_Total, m.Forma_Pago_Desc,
		(SELECT e.id_empresa FROM COMPUMUNDOHIPERMEGARED.Empresa e WHERE e.cuit = m.Espec_Empresa_Cuit)
	FROM gd_esquema.Maestra m
	WHERE m.Factura_Nro IS NOT NULL
	ORDER BY m.Factura_Nro
PRINT 'Migre Facturas'
GO

INSERT INTO COMPUMUNDOHIPERMEGARED.Item_Factura(item_factura_monto, item_factura_cantidad, item_factura_descripcion, factura_id)
	SELECT m.Item_Factura_Monto, m.Item_Factura_Cantidad, m.Item_Factura_Descripcion,
		(SELECT f.id_factura FROM COMPUMUNDOHIPERMEGARED.Factura f WHERE  f.numero = m.Factura_Nro)
	FROM gd_esquema.Maestra m
	WHERE m.Item_Factura_Cantidad IS NOT NULL
PRINT 'Migre Item_Factura'
GO

DECLARE @fecha_creacion datetime = GETUTCDATE()
INSERT INTO COMPUMUNDOHIPERMEGARED.Publicacion(codigo, descripcion, fecha_creacion, fecha_vencimiento, fecha_espectaculo, estado, empresa_id, grado_id)
	SELECT DISTINCT m.Espectaculo_Cod, m.Espectaculo_Descripcion, @fecha_creacion, m.Espectaculo_Fecha_Venc, m.Espectaculo_Fecha, UPPER(m.Espectaculo_Estado),
		(SELECT e.id_empresa FROM COMPUMUNDOHIPERMEGARED.Empresa e WHERE m.Espec_Empresa_Cuit = e.cuit), 
		1
	FROM gd_esquema.Maestra m
PRINT 'Migre Publicacion'
GO

INSERT INTO COMPUMUNDOHIPERMEGARED.TipoUbicacion(descripcion,codigo)
	SELECT DISTINCT m.Ubicacion_Tipo_Descripcion, m.Ubicacion_Tipo_Codigo
	FROM gd_esquema.Maestra m
PRINT 'Migre TipoUbicacion'
GO

INSERT INTO COMPUMUNDOHIPERMEGARED.Ubicacion(fila, asiento,precio, sin_numerar, tipo_ubicacion_id, publicacion_id,ocupado)
	SELECT m.Ubicacion_Fila, m.Ubicacion_Asiento, m.Ubicacion_Precio, m.Ubicacion_Sin_numerar, t.id_tipo_ubicacion, p.id_publicacion, CASE WHEN m.Cli_Dni IS NULL THEN 0 ELSE 1 END as columnaCase
	FROM gd_esquema.Maestra m
	JOIN COMPUMUNDOHIPERMEGARED.TipoUbicacion t ON m.Ubicacion_Tipo_Codigo = t.codigo
	JOIN COMPUMUNDOHIPERMEGARED.Publicacion p ON m.Espectaculo_Cod = p.codigo
	GROUP BY m.Ubicacion_Fila, m.Ubicacion_Asiento, m.Ubicacion_Precio, m.Ubicacion_Sin_numerar, t.id_tipo_ubicacion, p.id_publicacion, CASE WHEN m.Cli_Dni IS NULL THEN 0 ELSE 1 END
PRINT 'Migre Ubicaciones'
GO

INSERT INTO COMPUMUNDOHIPERMEGARED.Compra(fecha, factura_id, cliente_id, publicacion_id, ubicacion_id)
	SELECT m.Compra_Fecha, f.id_factura, c.id_cliente, p.id_publicacion,
		(SELECT u.id_ubicacion 
			FROM COMPUMUNDOHIPERMEGARED.Ubicacion u
			JOIN COMPUMUNDOHIPERMEGARED.TipoUbicacion t ON u.tipo_ubicacion_id = t.id_tipo_ubicacion 
			WHERE p.id_publicacion = u.publicacion_id AND u.asiento = m.Ubicacion_Asiento AND u.fila=m.Ubicacion_Fila AND t.descripcion = m.Ubicacion_Tipo_Descripcion)
	FROM gd_esquema.Maestra m
	JOIN COMPUMUNDOHIPERMEGARED.Factura f ON m.Factura_Nro = f.numero
	JOIN COMPUMUNDOHIPERMEGARED.Cliente c ON m.Cli_Dni = c.nro_documento
	JOIN COMPUMUNDOHIPERMEGARED.Publicacion p ON m.Espectaculo_Cod = p.codigo
	WHERE m.Compra_Fecha IS NOT NULL
	PRINT 'Migre Compras'
GO

INSERT INTO COMPUMUNDOHIPERMEGARED.CanjeDisponible(descripcion,cant_puntos) VALUES
	('Lavadora automatica que nos muestra el adorable Smithers', 20000),
	('La caja', 20000)
PRINT 'Migre CanjeDisponible'
GO

INSERT INTO COMPUMUNDOHIPERMEGARED.Puntos(cant_puntos,cliente_id,compra_id)
	SELECT u.precio, c.cliente_id, c.id_compra
	FROM COMPUMUNDOHIPERMEGARED.Compra c
	JOIN COMPUMUNDOHIPERMEGARED.Ubicacion u ON c.id_compra = u.compra_id
	WHERE u.compra_id IS NOT NULL
PRINT 'Migre Puntos'
GO
