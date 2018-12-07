USE GD2C2018
GO

CREATE SCHEMA COMPUMUNDOHIPERMEGARED
GO

/* CREACION TABLAS */
PRINT '----- Empezando a crear tablas -----'
CREATE TABLE COMPUMUNDOHIPERMEGARED.Usuario( -- MIGRADO
	id_usuario int IDENTITY(1,1) PRIMARY KEY,
	username nvarchar(50) UNIQUE NOT NULL,
	password binary(32) NOT NULL,
	intentos tinyint DEFAULT 0,
	habilitado bit DEFAULT 1,
	eliminado bit DEFAULT 0
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Funcionalidad( -- MIGRADO
	id_funcionalidad int PRIMARY KEY,
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
	usuario_id int CONSTRAINT FK_EMPRESA_USUARIO REFERENCES COMPUMUNDOHIPERMEGARED.Usuario(id_usuario)
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Cliente( -- MIGRADO
	id_cliente int IDENTITY(1,1) PRIMARY KEY,
	cuil nvarchar(13),
	nombre nvarchar(255),
	apellido nvarchar(255),
	tipo_documento char(1) CHECK(tipo_documento IN('D','C','E')) NOT NULL,
	nro_documento nvarchar(30) UNIQUE NOT NULL,
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
	usuario_id int CONSTRAINT FK_CLIENTE_USUARIO REFERENCES COMPUMUNDOHIPERMEGARED.Usuario(id_usuario)
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Rubro( -- MIGRADO
	id_rubro int IDENTITY(1,1) PRIMARY KEY,
	descripcion nvarchar(255) NOT NULL
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Grado( -- MIGRADO
	id_grado int IDENTITY(1,1) PRIMARY KEY,
	descripcion nvarchar(10) NOT NULL,
	comision numeric(5,2) DEFAULT 0,
	prioridad smallint not null
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Tarjeta( -- MIGRADO
	id_tarjeta int IDENTITY(1,1) PRIMARY KEY,
	nro_tarjeta nvarchar(50) NOT NULL,
	tipo nvarchar(1) NOT NULL CHECK(tipo IN('V','M','A')),
	ccv nvarchar(5) NOT NULL,
	fecha_vencimiento date NOT NULL,
	eliminado bit DEFAULT 0,
	cliente_id int CONSTRAINT FK_TARJETA_CLIENTE references COMPUMUNDOHIPERMEGARED.Cliente(id_cliente)
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Espectaculo( -- MIGRADO
	id_espectaculo int IDENTITY(1,1) PRIMARY KEY,
	codigo numeric(18,0),
	descripcion nvarchar(255),
	ciudad nvarchar(255),
	localidad nvarchar(255),
	dom_calle nvarchar(50),
	num_calle numeric(18,0),
	cod_postal nvarchar(50),
	empresa_id int CONSTRAINT FK_ESPECTACULO_EMPRESA references COMPUMUNDOHIPERMEGARED.Empresa(id_empresa),
	rubro_id int CONSTRAINT FK_ESPECTACULO_RUBRO references COMPUMUNDOHIPERMEGARED.Rubro(id_rubro),
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Publicacion(
	id_publicacion bigint IDENTITY(1,1) PRIMARY KEY,
	espectaculo_id int CONSTRAINT FK_PUBLICACION_ESPECTACULO references COMPUMUNDOHIPERMEGARED.Espectaculo,
	fecha_creacion datetime,
	fecha_vencimiento datetime,
	fecha_espectaculo datetime,
	estado char(1) not null check(estado in('B', 'P', 'F')),
	grado_id int CONSTRAINT FK_PUBLICACION_GRADO references COMPUMUNDOHIPERMEGARED.Grado(id_grado)
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.TipoUbicacion( -- MIGRADO
	id_tipo_ubicacion int IDENTITY(1,1) PRIMARY KEY,
	codigo numeric(18,0),
	descripcion nvarchar(255)
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Compra(
	id_compra int PRIMARY KEY,
	fecha datetime,
	cantidad numeric(18,0),
	cliente_id int CONSTRAINT FK_COMPRA_CLIENTE references COMPUMUNDOHIPERMEGARED.Cliente(id_cliente),
	tarjeta_id int CONSTRAINT FK_COMPRA_TARJETA references COMPUMUNDOHIPERMEGARED.Tarjeta(id_tarjeta)
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Ubicacion(
	id_ubicacion bigint PRIMARY KEY,
	fila varchar(3),
	asiento numeric(18,0),
	precio numeric(18,0),
	sin_numerar bit,
	ocupado bit default 0,
	compra_id int CONSTRAINT FK_UBICACION_COMPRA references COMPUMUNDOHIPERMEGARED.Compra(id_compra),
	tipo_ubicacion_id int CONSTRAINT FK_UBICACION_TIPOUBICACION references COMPUMUNDOHIPERMEGARED.TipoUbicacion(id_tipo_ubicacion),
	publicacion_id bigint CONSTRAINT FK_UBICACION_PUBLICACION references COMPUMUNDOHIPERMEGARED.Publicacion(id_publicacion)
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
	ubicacion_id bigint CONSTRAINT FK_ITEMFACTURA_UBICACION references COMPUMUNDOHIPERMEGARED.Ubicacion(id_ubicacion)
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

CREATE TABLE COMPUMUNDOHIPERMEGARED.Sector(
	id_borrador int CONSTRAINT FK_SECTOR_PUBLICACION references COMPUMUNDOHIPERMEGARED.Espectaculo,
	numerado bit,
	tipo_ubicacion_id int CONSTRAINT FK_SECTOR_TIPOUBICACION references COMPUMUNDOHIPERMEGARED.TipoUbicacion,
	fila_desde char(1),
	fila_hasta char(1),
	asiento_desde int,
	asiento_hasta int,
	cantidad int,
	precio numeric(18,0)
)

/* MIGRACION DATOS */
PRINT '----- Empezando a migrar datos -----'
DECLARE @fecha_creacion datetime = GETUTCDATE()
INSERT INTO COMPUMUNDOHIPERMEGARED.Cliente (tipo_documento, nro_documento, apellido, nombre, fecha_nacimiento, fecha_creacion, mail, dom_calle, num_calle, piso, depto, cod_postal)
	SELECT DISTINCT 'D', m.Cli_Dni, m.Cli_Apeliido, m.Cli_Nombre, m.Cli_Fecha_Nac, @fecha_creacion, m.Cli_Mail, m.Cli_Dom_Calle, m.Cli_Nro_Calle, m.Cli_Piso, m.Cli_Depto, m.Cli_Cod_Postal
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

INSERT INTO COMPUMUNDOHIPERMEGARED.Funcionalidad(descripcion, id_funcionalidad) VALUES
	('ABM ROL', 1),
	('ABM CLIENTES', 2),
	('ABM EMPRESA ESPECTACULOS', 3),
	('ABM RUBRO', 4),
	('ABM GRADO PUBLICACION', 5),
	('GENERAR PUBLICACION', 6),
	('EDITAR PUBLICACION', 7),
	('COMPRAR', 8),
	('HISTORIAL CLIENTE', 9),
	('CANJE PUNTOS', 10),
	('RENDICION COMISIONES', 11),
	('LISTADO ESTADÍSTICO', 12)
PRINT 'Migre Funcionalidad'
GO

create type COMPUMUNDOHIPERMEGARED.FuncionalidadList as table(
	funcionalidad_id tinyint
)
go

create procedure COMPUMUNDOHIPERMEGARED.crearNuevoRol(@nombre nvarchar(50), @listaFuncionalidad FuncionalidadList readonly, @id_generado smallint = null output)
as
begin
	insert into COMPUMUNDOHIPERMEGARED.Rol(habilitado, nombre)
	values(1, @nombre)

	set @id_generado = @@IDENTITY

	insert into COMPUMUNDOHIPERMEGARED.Rol_Funcionalidad(funcionalidad_id, rol_id)
	select l.funcionalidad_id, @id_generado from @listaFuncionalidad l
	
	return
end
go

declare @funcionalidades_cliente COMPUMUNDOHIPERMEGARED.FuncionalidadList
insert into @funcionalidades_cliente values (8),(9),(10)
exec COMPUMUNDOHIPERMEGARED.crearNuevoRol 'CLIENTE', @funcionalidades_cliente, null

declare @funcionalidades_admin COMPUMUNDOHIPERMEGARED.FuncionalidadList
insert into @funcionalidades_admin values (1),(2),(3),(4),(11),(12)
exec COMPUMUNDOHIPERMEGARED.crearNuevoRol 'ADMINISTRADOR', @funcionalidades_admin, null

declare @funcionalidades_empresa COMPUMUNDOHIPERMEGARED.FuncionalidadList
insert into @funcionalidades_empresa values (5),(6),(7)
exec COMPUMUNDOHIPERMEGARED.crearNuevoRol 'EMPRESA', @funcionalidades_empresa, null
PRINT 'Roles principales creados'
go

PRINT 'Creando usuarios de las empresas'
	declare @id_rol_empresa smallint = (select id_rol from COMPUMUNDOHIPERMEGARED.Rol where nombre = 'EMPRESA')
	declare c1 cursor for select e.cuit, e.id_empresa from COMPUMUNDOHIPERMEGARED.Empresa e
	open c1
	declare @cuit nvarchar(255), @empresa_id int
	fetch next from c1 into @cuit, @empresa_id

	while @@FETCH_STATUS = 0
	begin
		insert into COMPUMUNDOHIPERMEGARED.Usuario(username, password)
		values(@cuit, HASHBYTES('SHA2_256',@cuit))
		declare @id_usuario int = @@IDENTITY
		insert into COMPUMUNDOHIPERMEGARED.Rol_Usuario(rol_id, usuario_id)
		values(@id_rol_empresa, @id_usuario)
		update COMPUMUNDOHIPERMEGARED.Empresa
		set usuario_id = @id_usuario
		where id_empresa = @empresa_id

		fetch next from c1 into @cuit, @empresa_id
	end

	close c1
	deallocate c1
PRINT 'Usuarios y Rol_Usuarios de empresas creados'
go

PRINT 'Creando usuarios de los clientes'
	declare @id_rol_cliente smallint = (select id_rol from COMPUMUNDOHIPERMEGARED.Rol where nombre = 'CLIENTE')
	declare c1 cursor for select c.nro_documento, c.id_cliente from COMPUMUNDOHIPERMEGARED.Cliente c
	open c1
	declare @dni nvarchar(255), @cliente_id int
	fetch next from c1 into @dni, @cliente_id

	while @@FETCH_STATUS = 0
	begin
		insert into COMPUMUNDOHIPERMEGARED.Usuario(username, password)
		values(@dni, HASHBYTES('SHA2_256',@dni))
		declare @id_usuario int = @@IDENTITY
		insert into COMPUMUNDOHIPERMEGARED.Rol_Usuario(rol_id, usuario_id)
		values(@id_rol_cliente, @id_usuario)

		update COMPUMUNDOHIPERMEGARED.Cliente
		set usuario_id = @id_usuario
		where id_cliente = @cliente_id

		fetch next from c1 into @dni, @cliente_id
	end

	close c1
	deallocate c1
PRINT 'Usuarios y Rol_Usuarios de clientes creados'
go


INSERT INTO COMPUMUNDOHIPERMEGARED.Grado(descripcion, comision, prioridad) VALUES
	('NINGUNO',0, 1),
	('BAJA', 2.0, 2),
	('MEDIA', 5.0, 3),
	('ALTA', 10.0, 4)
PRINT 'Migre Grados'
GO

insert into COMPUMUNDOHIPERMEGARED.Rubro(descripcion)
select distinct Espectaculo_Rubro_Descripcion from gd_esquema.Maestra

PRINT 'Migre Rubro'
go

insert into COMPUMUNDOHIPERMEGARED.Espectaculo(codigo, descripcion, rubro_id)
select distinct m.Espectaculo_Cod, m.Espectaculo_Descripcion, r.id_rubro
from gd_esquema.Maestra m
left outer join COMPUMUNDOHIPERMEGARED.Rubro r
on r.descripcion = m.Espectaculo_Rubro_Descripcion
PRINT 'Migre Espectaculo'
GO

insert into COMPUMUNDOHIPERMEGARED.Publicacion(espectaculo_id, fecha_espectaculo, fecha_vencimiento, estado, grado_id)
select e.id_espectaculo, m.Espectaculo_Fecha, m.Espectaculo_Fecha_Venc,
case when lower(m.Espectaculo_Estado) like 'publicada' then 'P'
when lower(m.Espectaculo_Estado) like 'borrador' then 'B'
when lower(m.Espectaculo_Estado) like 'finalizada' then 'F' end,
1
from gd_esquema.Maestra m
inner join COMPUMUNDOHIPERMEGARED.Espectaculo e
on e.codigo = m.Espectaculo_Cod
group by e.id_espectaculo, m.Espectaculo_Fecha, m.Espectaculo_Fecha_Venc, m.Espectaculo_Estado
PRINT 'Migre Publicacion'
GO

create view COMPUMUNDOHIPERMEGARED.PublicacionesView as
SELECT p.id_publicacion as id_publicacion, e.descripcion as descripcion,
p.fecha_creacion as fecha_publicacion, p.fecha_vencimiento as fecha_vencimiento,
p.fecha_espectaculo as fecha_espectaculo, p.estado as estado, e.ciudad as ciudad,
e.localidad as localidad, e.dom_calle as dom_calle, e.num_calle as num_calle, e.cod_postal as cod_postal,
e.empresa_id as id_empresa, r.id_rubro as rubro_id, r.descripcion as rubro_descripcion,
g.id_grado as grado_id, g.descripcion as grado_descripcion, g.comision as grado_comision, g.prioridad as prioridad
FROM COMPUMUNDOHIPERMEGARED.Publicacion p
inner join COMPUMUNDOHIPERMEGARED.Espectaculo e
on e.id_espectaculo = p.id_publicacion
left outer join COMPUMUNDOHIPERMEGARED.Rubro r
on r.id_rubro = e.rubro_id
left outer join COMPUMUNDOHIPERMEGARED.Grado g
on g.id_grado = p.grado_id
WITH CHECK OPTION
go
PRINT 'View de publicaciones creadas'


INSERT INTO COMPUMUNDOHIPERMEGARED.TipoUbicacion(descripcion,codigo)
	SELECT DISTINCT m.Ubicacion_Tipo_Descripcion, m.Ubicacion_Tipo_Codigo
	FROM gd_esquema.Maestra m
PRINT 'Migre TipoUbicacion'
GO

create SEQUENCE COMPUMUNDOHIPERMEGARED.UbicacionSequence 
    AS int   
    START WITH 1
    INCREMENT BY 1  
    NO CYCLE
;
go

create table COMPUMUNDOHIPERMEGARED.##UbicacionTemp(
id_ubicacion bigint,
fila varchar(3),
asiento numeric(18,0),
precio numeric(18,0),
sin_numerar bit,
ubicacion_tipo_codigo int,
espectaculo_cod int,
dni_comprador varchar(13),
publicacion_id bigint)
PRINT 'Tabla temporal ubicaciones creada'
go

insert into COMPUMUNDOHIPERMEGARED.##UbicacionTemp(id_ubicacion, fila, asiento, sin_numerar, precio, ubicacion_tipo_codigo, espectaculo_cod, dni_comprador, publicacion_id)
select next value for COMPUMUNDOHIPERMEGARED.UbicacionSequence, m.Ubicacion_Fila, m.Ubicacion_Asiento, m.Ubicacion_Sin_numerar,
m.Ubicacion_Precio, m.Ubicacion_Tipo_Codigo, m.Espectaculo_Cod,
max(Cli_Dni), p.id_publicacion
from gd_esquema.Maestra m
inner join COMPUMUNDOHIPERMEGARED.Espectaculo e
on e.codigo = m.Espectaculo_Cod
inner join COMPUMUNDOHIPERMEGARED.Publicacion p
on p.espectaculo_id = e.id_espectaculo
group by m.Ubicacion_Fila, m.Ubicacion_Asiento, m.Ubicacion_Sin_numerar,
m.Ubicacion_Precio, m.Ubicacion_Tipo_Codigo, m.Espectaculo_Cod, m.Espectaculo_Fecha, m.Espectaculo_Fecha_Venc, p.id_publicacion
go

create SEQUENCE COMPUMUNDOHIPERMEGARED.CompraSequence 
    AS int   
    START WITH 1
    INCREMENT BY 1  
    NO CYCLE
;

go

create table COMPUMUNDOHIPERMEGARED.##CompraTemp(
compra_id int,
id_ubicacion bigint,
fecha datetime,
cantidad numeric(18),
cliente_id int
)

go

insert into COMPUMUNDOHIPERMEGARED.##CompraTemp
select next value for COMPUMUNDOHIPERMEGARED.CompraSequence, u.id_ubicacion ubicacion_id, m.Compra_Fecha fecha, m.Compra_Cantidad cantidad,
c.id_cliente id_cliente
from COMPUMUNDOHIPERMEGARED.##UbicacionTemp u
inner join gd_esquema.Maestra m
on m.Ubicacion_Fila = u.fila and m.Ubicacion_Asiento = u.asiento and m.Ubicacion_Precio = u.precio
and m.Ubicacion_Sin_numerar = u.sin_numerar and m.Ubicacion_Tipo_Codigo = u.ubicacion_tipo_codigo
and m.Espectaculo_Cod = u.espectaculo_cod
inner join COMPUMUNDOHIPERMEGARED.Cliente c
on c.nro_documento = m.Cli_Dni
where m.Compra_Cantidad is not null or m.Compra_Fecha is not null
group by u.id_ubicacion, m.Compra_Fecha, m.Compra_Cantidad, c.id_cliente

go

insert into COMPUMUNDOHIPERMEGARED.Compra(id_compra, fecha, cantidad, cliente_id)
select c.compra_id, c.fecha, c.cantidad, c.cliente_id
from COMPUMUNDOHIPERMEGARED.##CompraTemp c

go

insert into COMPUMUNDOHIPERMEGARED.Ubicacion(id_ubicacion, fila, asiento, precio, sin_numerar,
tipo_ubicacion_id, publicacion_id, compra_id, ocupado)
select t.id_ubicacion, t.fila, t.asiento, t.precio, t.sin_numerar,
tu.id_tipo_ubicacion, t.publicacion_id, c.compra_id, case when c.compra_id is null then 0 else 1 end
from COMPUMUNDOHIPERMEGARED.##UbicacionTemp t
left join COMPUMUNDOHIPERMEGARED.##CompraTemp c on c.id_ubicacion = t.id_ubicacion
join COMPUMUNDOHIPERMEGARED.TipoUbicacion tu on tu.codigo = t.ubicacion_tipo_codigo

drop table COMPUMUNDOHIPERMEGARED.##CompraTemp

PRINT 'Migre Ubicaciones y Compras'
go


INSERT INTO COMPUMUNDOHIPERMEGARED.Factura(numero, fecha, total, forma_pago, empresa_id)
	SELECT DISTINCT m.Factura_Nro, m.Factura_Fecha, m.Factura_Total, m.Forma_Pago_Desc,
		(SELECT e.id_empresa FROM COMPUMUNDOHIPERMEGARED.Empresa e WHERE e.cuit = m.Espec_Empresa_Cuit)
	FROM gd_esquema.Maestra m
	WHERE m.Factura_Nro IS NOT NULL
	ORDER BY m.Factura_Nro
PRINT 'Migre Facturas'
GO

INSERT INTO COMPUMUNDOHIPERMEGARED.Item_Factura(item_factura_monto, item_factura_cantidad, item_factura_descripcion, factura_id, ubicacion_id)
	SELECT m.Item_Factura_Monto, m.Item_Factura_Cantidad, m.Item_Factura_Descripcion,
	f.id_factura, u.id_ubicacion
	FROM gd_esquema.Maestra m
	join COMPUMUNDOHIPERMEGARED.Factura f on f.numero = m.Factura_Nro
	join COMPUMUNDOHIPERMEGARED.##UbicacionTemp u on u.fila = m.Ubicacion_Fila and u.asiento = m.Ubicacion_Asiento
	and u.precio = m.Ubicacion_Precio and u.sin_numerar = m.Ubicacion_Sin_numerar
	and u.ubicacion_tipo_codigo = m.Ubicacion_Tipo_Codigo and u.espectaculo_cod = m.Espectaculo_Cod
	WHERE m.Item_Factura_Cantidad IS NOT NULL

drop table COMPUMUNDOHIPERMEGARED.##UbicacionTemp
PRINT 'Migre Item_Factura'
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

/*
	CREANDO CONFIGURACIONES INICIALES
*/


create procedure COMPUMUNDOHIPERMEGARED.actualizarRol(@rol_id smallint, @listaFuncionalidad FuncionalidadList readonly)
as
begin
	delete from COMPUMUNDOHIPERMEGARED.Rol_Funcionalidad
	where rol_id = @rol_id

	insert into COMPUMUNDOHIPERMEGARED.Rol_Funcionalidad(funcionalidad_id, rol_id)
	select l.funcionalidad_id, @rol_id from @listaFuncionalidad l
end
go


create procedure COMPUMUNDOHIPERMEGARED.crear_nuevo_usuario
(@username nvarchar(50), @password nvarchar(50), @rol_id smallint, @usuario_id int output)
as
begin
	begin tran
	if(@password is null)
		rollback transaction

	insert into COMPUMUNDOHIPERMEGARED.Usuario(username, password, intentos, habilitado)
	values(@username, HASHBYTES('SHA2_256', @password), 0, 1)

	set @usuario_id = @@IDENTITY

	insert into COMPUMUNDOHIPERMEGARED.Rol_Usuario(rol_id, usuario_id)
	values(@rol_id, @usuario_id)

	commit tran
	return
end
go

create procedure COMPUMUNDOHIPERMEGARED.intentar_logear(@username nvarchar(50), @password nvarchar(50), @id_usuario int output)
as
begin
	declare @pass_usuario nvarchar(64), @esta_habilitado bit, @esta_eliminado bit, @intentos smallint

	select @id_usuario = u.id_usuario,
	@pass_usuario = u.password,
	@esta_habilitado = u.habilitado,
	@esta_eliminado = u.eliminado,
	@intentos = u.intentos
	from COMPUMUNDOHIPERMEGARED.Usuario u
	where u.username = @username

	if(@id_usuario is null)
	begin
		raiserror('El usuario no existe', 16, 1)
		return
	end

	if(@esta_eliminado = 1 or @esta_habilitado = 0)
	begin
		raiserror('El usuario está eliminado o no está habilitado', 16, 1)
		return
	end

	if(HASHBYTES('SHA2_256', @password) != @pass_usuario)
	begin
		if(@intentos + 1 >= 3)
		begin
			update COMPUMUNDOHIPERMEGARED.Usuario
			set intentos = 0, habilitado = 0
			where id_usuario = @id_usuario
		end
		else
		begin
			update COMPUMUNDOHIPERMEGARED.Usuario
			set intentos = @intentos + 1
			where id_usuario = @id_usuario
		end
		raiserror('El password es incorrecto', 16, 1)
		return
	end

	update COMPUMUNDOHIPERMEGARED.Usuario
	set intentos = 0
	where id_usuario = @id_usuario

	return
end
go

create procedure COMPUMUNDOHIPERMEGARED.crear_usuario_cliente
(@cuil nvarchar(13), @tipo_doc char(1), @nro_documento nvarchar(15), @nombre nvarchar(255),
@apellido nvarchar(255), @mail nvarchar(255), @telefono numeric(15), @ciudad nvarchar(25),
@localidad nvarchar(25), @dom_calle nvarchar(255), @num_calle numeric(18),
@depto nvarchar(255), @piso numeric(18), @cod_postal nvarchar(255), @fecha_nacimiento date,
@fecha_creacion datetime, @rol_id int, @username nvarchar(50), @pass nvarchar(64), @cliente_id int output)
as
begin
	begin tran
	declare @id_nuevo_usuario int
	exec COMPUMUNDOHIPERMEGARED.crear_nuevo_usuario @username, @pass, @rol_id, @usuario_id = @id_nuevo_usuario output
	insert into Cliente
	(cuil, tipo_documento, nro_documento, nombre, apellido, mail, telefono, ciudad, localidad,
	dom_calle, num_calle, depto, piso, cod_postal, fecha_nacimiento, fecha_creacion, usuario_id)
	values
	(@cuil, @tipo_doc, @nro_documento, @nombre, @apellido, @mail, @telefono, @ciudad, @localidad,
	@dom_calle, @num_calle, @depto, @piso, @cod_postal, @fecha_nacimiento, @fecha_creacion, @id_nuevo_usuario)
	commit tran
	set @cliente_id = @@IDENTITY
	return
end
go

create function COMPUMUNDOHIPERMEGARED.find_funcionalidades_de_rol(@rol_id smallint)
returns @funcionalidades table(id_funcionalidad tinyint, descripcion varchar(30))
as
begin
	insert into @funcionalidades
	select f.id_funcionalidad, f.descripcion
	from COMPUMUNDOHIPERMEGARED.Rol_Funcionalidad rf
	inner join COMPUMUNDOHIPERMEGARED.Funcionalidad f
	on rf.rol_id = @rol_id and f.id_funcionalidad = rf.funcionalidad_id
	return
end
go

create function COMPUMUNDOHIPERMEGARED.find_funcionalidades_de_usuario(@usuario_id int)
returns @funcionalidades table(id_funcionalidad tinyint, descripcion varchar(30))
as
begin
	declare c1 cursor for select r.rol_id from Rol_Usuario r
	where r.usuario_id = @usuario_id
	declare @id_rol smallint
	declare @funcionalidades_temp table(id_funcionalidad tinyint, descripcion varchar(30))

	open c1
	fetch next from c1 into @id_rol

	while @@FETCH_STATUS = 0
	begin
		insert into @funcionalidades_temp
		select * from COMPUMUNDOHIPERMEGARED.find_funcionalidades_de_rol(@id_rol)
		fetch next from c1 into @id_rol
	end

	close c1
	deallocate c1
	insert into @funcionalidades
	select distinct t.id_funcionalidad, t.descripcion from @funcionalidades_temp t
	return
	end
go

create procedure COMPUMUNDOHIPERMEGARED.crear_usuario_empresa
(	@cuit nvarchar(255),
	@razon_social nvarchar(255),
	@mail nvarchar(50),
	@telefono nvarchar(30),
	@ciudad nvarchar(255),
	@localidad nvarchar(255),
	@dom_calle nvarchar(50),
	@nro_calle numeric(18,0),
	@piso numeric(18,0),
	@depto nvarchar(50),
	@cod_postal nvarchar(50),
	@fecha_creacion datetime,
	@rol_id int,
	@pass nvarchar(64),
	@username nvarchar(50))
as
begin
	begin tran
	declare @id_nuevo_usuario int
	exec COMPUMUNDOHIPERMEGARED.crear_nuevo_usuario @username, @pass, @rol_id, @usuario_id = @id_nuevo_usuario output
	insert into Empresa(cuit, razon_social, mail, telefono, ciudad, localidad, dom_calle,
	nro_calle, piso, depto, cod_postal, fecha_creacion, usuario_id)
	values(@cuit, @razon_social, @mail, @telefono, @ciudad, @localidad, @dom_calle,
	@nro_calle, @piso, @depto, @cod_postal, @fecha_creacion, @id_nuevo_usuario)
	commit tran
end
go

create procedure COMPUMUNDOHIPERMEGARED.eliminar_rol(@id_rol smallint)
as
begin
	update Rol
	set habilitado = 0
	where id_rol = @id_rol

	delete from Rol_Usuario
	where rol_id = @id_rol
end
go

create procedure COMPUMUNDOHIPERMEGARED.crear_borrador(
	@descripcion nvarchar(255),
	@fecha_espectaculo datetime,
	@estado nvarchar(10),
	@ciudad nvarchar(255),
	@localidad nvarchar(255),
	@dom_calle nvarchar(50),
	@num_calle numeric(18,0),
	@cod_postal nvarchar(50),
	@empresa_id int,
	@rubro_id int,
	@grado_id int,
	@borrador_id int output)
as
begin
	insert into COMPUMUNDOHIPERMEGARED.Publicacion
	(descripcion, fecha_espectaculo, estado, ciudad, localidad, dom_calle,
	num_calle, cod_postal, empresa_id, rubro_id, grado_id)
	values(@descripcion, @fecha_espectaculo, @estado, @ciudad, @localidad, @dom_calle,
	@num_calle, @cod_postal, @empresa_id, @rubro_id, @grado_id)
	set @borrador_id = @@IDENTITY
	return
end
go

create procedure COMPUMUNDOHIPERMEGARED.generar_ubicaciones_de(@id_publicacion int)
as
begin
	declare c1 cursor for select numerado, tipo_ubicacion_id, fila_desde, fila_hasta, asiento_desde,
	asiento_hasta, cantidad, precio
	from COMPUMUNDOHIPERMEGARED.Sector s where s.id_borrador = @id_publicacion
	declare @numerado bit, @tipo_ubicacion_id int, @fila_desde char(1), @fila_hasta char(1), @asiento_desde int,
	@asiento_hasta int, @cantidad int, @precio numeric(18,0)

	open c1
	fetch next from c1 into @numerado, @tipo_ubicacion_id, @fila_desde, @fila_hasta, @asiento_desde,
	@asiento_hasta, @cantidad, @precio

	while @@FETCH_STATUS = 0
	begin
		if @numerado = 0
		begin
			declare @contador int = 0
			while @contador < @cantidad
			begin
				insert into Ubicacion(id_ubicacion, precio, sin_numerar, tipo_ubicacion_id, publicacion_id)
				values(next value for COMPUMUNDOHIPERMEGARED.UbicacionSequence, @precio, 1, @tipo_ubicacion_id, @id_publicacion)
				set @contador = @contador + 1
			end
		end
		else
		begin
			declare @letra_actual char(1) = @fila_desde
			while ASCII(@letra_actual) <= ASCII(@fila_hasta)
			begin
				declare @numero_actual int = @asiento_desde
				while @numero_actual <= @asiento_hasta
				begin
					insert into Ubicacion(id_ubicacion, fila, asiento, precio, sin_numerar, tipo_ubicacion_id, publicacion_id)
					values(next value for COMPUMUNDOHIPERMEGARED.UbicacionSequence, @letra_actual, @numero_actual, @precio, 0, @tipo_ubicacion_id, @id_publicacion)
					set @numero_actual = @numero_actual + 1
				end
				set @letra_actual = CHAR(ASCII(@letra_actual)+1) 
			end
		end
		fetch next from c1 into @numerado, @tipo_ubicacion_id, @fila_desde, @fila_hasta, @asiento_desde,
		@asiento_hasta, @cantidad, @precio
	end
	close c1
	deallocate c1
end
go

PRINT 'Todes les procedures y les funciones creades'

PRINT 'Creando al admin default'
declare @tablaFunciones COMPUMUNDOHIPERMEGARED.FuncionalidadList

insert into @tablaFunciones
select id_funcionalidad from COMPUMUNDOHIPERMEGARED.Funcionalidad

declare @idRol smallint

exec COMPUMUNDOHIPERMEGARED.crearNuevoRol 'Administrador General', @tablaFunciones, @id_generado = @idRol output 

exec COMPUMUNDOHIPERMEGARED.crear_nuevo_usuario 'admin', 'w23', @idRol, null
PRINT 'Administrador general creado'
go