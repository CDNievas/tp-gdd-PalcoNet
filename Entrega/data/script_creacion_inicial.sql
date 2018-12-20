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
	intentos tinyint DEFAULT 0 not null,
	habilitado bit DEFAULT 1,
	eliminado bit DEFAULT 0,
	solicitud_cambio_pass bit default 0 not null
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
	rol_id int CONSTRAINT FK_ROLUSUARIO_ROL REFERENCES COMPUMUNDOHIPERMEGARED.Rol(id_rol)
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
	usuario_id int CONSTRAINT FK_EMPRESA_USUARIO REFERENCES COMPUMUNDOHIPERMEGARED.Usuario(id_usuario),
	habilitado bit default 1 not null
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
	usuario_id int CONSTRAINT FK_CLIENTE_USUARIO REFERENCES COMPUMUNDOHIPERMEGARED.Usuario(id_usuario),
	habilitado bit default 1 not null,
	tarjeta_actual_id int
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Rubro( -- MIGRADO
	id_rubro int IDENTITY(1,1) PRIMARY KEY,
	descripcion nvarchar(255) UNIQUE NOT NULL
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Grado( -- MIGRADO
	id_grado int IDENTITY(1,1) PRIMARY KEY,
	descripcion nvarchar(25) NOT NULL,
	comision numeric(5,2) NOT NULL,
	eliminado bit default 0 NOT NULL
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Tarjeta( -- MIGRADO
	id_tarjeta int IDENTITY(1,1) PRIMARY KEY,
	nro_tarjeta nvarchar(50) NOT NULL,
	tipo char(1) NOT NULL CHECK(tipo IN('V','M','A')),
	ccv numeric(5, 0) NOT NULL,
	fecha_vencimiento date NOT NULL,
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
	porcentaje_comision numeric(5,2),
	cant_ubicaciones_total int,
	cant_ubicaciones_vendidas int,
	grado_id int CONSTRAINT FK_PUBLICACION_GRADO references COMPUMUNDOHIPERMEGARED.Grado(id_grado),
	CONSTRAINT CHECK_UBICACIONES_VENDIDAS check(cant_ubicaciones_total >= cant_ubicaciones_vendidas)
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
	precio_total numeric(18,0),
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
	publicacion_id bigint CONSTRAINT FK_UBICACION_PUBLICACION references COMPUMUNDOHIPERMEGARED.Publicacion(id_publicacion) not null
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Factura( -- MIGRADO
	id_factura int IDENTITY(1,1) PRIMARY KEY,
	numero numeric(18,0) unique,
	fecha datetime,
	total numeric(18,2),
	forma_pago nvarchar(255),
	empresa_id int CONSTRAINT FK_FACTURA_EMPRESA references COMPUMUNDOHIPERMEGARED.Empresa
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Item_Factura( -- MIGRADO
	item_factura_monto numeric(18,2), -- (comision descontada por cada compra)
	item_factura_cantidad numeric(18,0), -- (1)
	item_factura_descripcion nvarchar(60), -- ('Comision por compra')
	factura_id int CONSTRAINT FK_ITEMFACTURA_FACTURA references COMPUMUNDOHIPERMEGARED.Factura(id_factura),
	compra_id int CONSTRAINT FK_ITEMFACTURA_COMPRA references COMPUMUNDOHIPERMEGARED.Compra(id_compra),
	primary key(factura_id, compra_id)
)


CREATE TABLE COMPUMUNDOHIPERMEGARED.PremioDisponible( -- MIGRADO
	id_premio int IDENTITY(1,1) PRIMARY KEY,
	descripcion nvarchar(60),
	cant_puntos int
)

CREATE TABLE  COMPUMUNDOHIPERMEGARED.Canje( -- MIGRADO
	id_canje int IDENTITY(1,1) PRIMARY KEY,
	fecha_canjeado datetime not null,
	cliente_id int CONSTRAINT FK_Canje_CLIENTE references COMPUMUNDOHIPERMEGARED.Cliente not null,
	premio_id int CONSTRAINT FK_Canje_PremioDisponible references COMPUMUNDOHIPERMEGARED.PremioDisponible not null
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Puntos( 
	id_puntos int IDENTITY(1,1) primary key,
	cant_puntos int not null,
	cant_usada int default 0 not null,
	fecha_creacion datetime not null,
	fecha_vencimiento datetime not null,
	cliente_id int CONSTRAINT FK_PUNTOS_CLIENTE references COMPUMUNDOHIPERMEGARED.Cliente not null,
	compra_id int CONSTRAINT FK_PUNTOS_COMPRA references COMPUMUNDOHIPERMEGARED.Compra
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Puntos_Canje(
	id_puntos int CONSTRAINT FK_PUNTOSCANJE_PUNTOS references COMPUMUNDOHIPERMEGARED.Puntos not null,
	id_canje int CONSTRAINT FK_PUNTOSCANJE_CANJE references COMPUMUNDOHIPERMEGARED.Canje not null,
	puntos_canjeados int not null
)

CREATE TABLE COMPUMUNDOHIPERMEGARED.Sector(
	id_espectaculo int CONSTRAINT FK_SECTOR_ESPECTACULO references COMPUMUNDOHIPERMEGARED.Espectaculo,
	numerado bit,
	tipo_ubicacion_id int CONSTRAINT FK_SECTOR_TIPOUBICACION references COMPUMUNDOHIPERMEGARED.TipoUbicacion,
	fila_desde char(1),
	fila_hasta char(1),
	asiento_desde int,
	asiento_hasta int,
	cantidad int,
	precio numeric(18,0)
)

alter table COMPUMUNDOHIPERMEGARED.Cliente
add constraint FK_CLIENTE_TARJETA foreign key(tarjeta_actual_id) references COMPUMUNDOHIPERMEGARED.Tarjeta

/* MIGRACION DATOS */
PRINT '----- Empezando a migrar datos -----'
DECLARE @fecha_creacion datetime = GETUTCDATE()
INSERT INTO COMPUMUNDOHIPERMEGARED.Cliente (tipo_documento, nro_documento, apellido, nombre, fecha_nacimiento, fecha_creacion, mail, dom_calle, num_calle, piso, depto, cod_postal)
	SELECT DISTINCT 'D', m.Cli_Dni, m.Cli_Apeliido, m.Cli_Nombre, m.Cli_Fecha_Nac, @fecha_creacion, m.Cli_Mail, m.Cli_Dom_Calle, m.Cli_Nro_Calle, m.Cli_Piso, m.Cli_Depto, m.Cli_Cod_Postal
		FROM gd_esquema.Maestra m
		WHERE m.Cli_Dni is not null
		ORDER BY m.Cli_Dni
PRINT 'Migre Clientes'
GO

DECLARE @fecha_creacion datetime = GETUTCDATE()
INSERT INTO COMPUMUNDOHIPERMEGARED.Empresa (cuit, razon_social, mail, dom_calle, nro_calle, piso, depto, cod_postal, fecha_creacion)
	SELECT DISTINCT m.Espec_Empresa_Cuit, m.Espec_Empresa_Razon_Social, m.Espec_Empresa_Mail, m.Espec_Empresa_Dom_Calle, m.Espec_Empresa_Nro_Calle, m.Espec_Empresa_Piso, m.Espec_Empresa_Depto, m.Espec_Empresa_Cod_Postal, @fecha_creacion
		FROM gd_esquema.Maestra m
		where m.Espec_Empresa_Cuit is not null
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
	('LISTADO ESTADÍSTICO', 12),
	('Habilitación/Inhabilitación de USUARIOS', 13)
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
insert into @funcionalidades_admin values (1),(2),(3),(4),(5),(11),(12), (13)
exec COMPUMUNDOHIPERMEGARED.crearNuevoRol 'ADMINISTRADOR', @funcionalidades_admin, null

declare @funcionalidades_empresa COMPUMUNDOHIPERMEGARED.FuncionalidadList
insert into @funcionalidades_empresa values (6),(7)
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


INSERT INTO COMPUMUNDOHIPERMEGARED.Grado(descripcion, comision) VALUES
	('BAJA', 2.0),
	('MEDIA', 5.0),
	('ALTA', 10.0)
PRINT 'Migre Grados'
GO

create function COMPUMUNDOHIPERMEGARED.DescripcionOrElse(@string nvarchar(255), @orElse nvarchar(255))
returns nvarchar(255)
as
begin
return (select case when RTRIM(LTRIM(@string)) like '' then @orElse else @string end)
end
go

insert into COMPUMUNDOHIPERMEGARED.Rubro(descripcion)
select distinct COMPUMUNDOHIPERMEGARED.DescripcionOrElse(Espectaculo_Rubro_Descripcion, 'Sin rubro')
from gd_esquema.Maestra

PRINT 'Migre Rubro'
go

insert into COMPUMUNDOHIPERMEGARED.Espectaculo(codigo, descripcion, rubro_id, empresa_id)
select distinct m.Espectaculo_Cod, m.Espectaculo_Descripcion, r.id_rubro, e.id_empresa
from gd_esquema.Maestra m
left outer join COMPUMUNDOHIPERMEGARED.Rubro r
on r.descripcion = COMPUMUNDOHIPERMEGARED.DescripcionOrElse(m.Espectaculo_Rubro_Descripcion, 'Sin rubro')
inner join COMPUMUNDOHIPERMEGARED.Empresa e
on m.Espec_Empresa_Cuit = e.cuit
PRINT 'Migre Espectaculo'
GO

insert into COMPUMUNDOHIPERMEGARED.Publicacion(espectaculo_id, fecha_espectaculo, fecha_vencimiento, estado, grado_id, porcentaje_comision)
select e.id_espectaculo, m.Espectaculo_Fecha, m.Espectaculo_Fecha_Venc,
case when lower(m.Espectaculo_Estado) like 'publicada' then 'P'
when lower(m.Espectaculo_Estado) like 'borrador' then 'B'
when lower(m.Espectaculo_Estado) like 'finalizada' then 'F' end,
3, 10.00
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
g.id_grado as grado_id, g.descripcion as grado_descripcion, g.comision as grado_comision,
g.eliminado as grado_eliminado, e.id_espectaculo as id_espectaculo
FROM COMPUMUNDOHIPERMEGARED.Publicacion p
inner join COMPUMUNDOHIPERMEGARED.Espectaculo e
on e.id_espectaculo = p.espectaculo_id
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
    AS bigint   
    START WITH 1
    INCREMENT BY 1  
    NO CYCLE
;
go

create SEQUENCE COMPUMUNDOHIPERMEGARED.CompraSequence 
    AS int   
    START WITH 1
    INCREMENT BY 1  
    NO CYCLE
;
go

create table COMPUMUNDOHIPERMEGARED.##UbicacionTemp(
id_ubicacion bigint,
compra_id int,
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

insert into COMPUMUNDOHIPERMEGARED.##UbicacionTemp(id_ubicacion, compra_id, fila, asiento, sin_numerar, precio, ubicacion_tipo_codigo, espectaculo_cod, dni_comprador, publicacion_id)
select next value for COMPUMUNDOHIPERMEGARED.UbicacionSequence, next value for COMPUMUNDOHIPERMEGARED.CompraSequence,
m.Ubicacion_Fila, m.Ubicacion_Asiento, m.Ubicacion_Sin_numerar,
m.Ubicacion_Precio, m.Ubicacion_Tipo_Codigo, m.Espectaculo_Cod,
max(Cli_Dni), p.id_publicacion
from gd_esquema.Maestra m
inner join COMPUMUNDOHIPERMEGARED.Espectaculo e
on e.codigo = m.Espectaculo_Cod
inner join COMPUMUNDOHIPERMEGARED.Publicacion p
on p.espectaculo_id = e.id_espectaculo
group by m.Ubicacion_Fila, m.Ubicacion_Asiento, m.Ubicacion_Sin_numerar,
m.Ubicacion_Precio, m.Ubicacion_Tipo_Codigo, m.Espectaculo_Cod, m.Espectaculo_Fecha, m.Espectaculo_Fecha_Venc, p.id_publicacion
PRINT 'Insertados en UbicacionTemp'
go



create table COMPUMUNDOHIPERMEGARED.##CompraTemp(
compra_id int,
id_ubicacion bigint,
fecha datetime,
cantidad numeric(18),
cliente_id int,
precio_total numeric(18,0)
)

go

insert into COMPUMUNDOHIPERMEGARED.##CompraTemp
select u.compra_id, u.id_ubicacion ubicacion_id, m.Compra_Fecha fecha, m.Compra_Cantidad cantidad,
c.id_cliente id_cliente, u.precio
from COMPUMUNDOHIPERMEGARED.##UbicacionTemp u
inner join gd_esquema.Maestra m
on m.Ubicacion_Fila = u.fila and m.Ubicacion_Asiento = u.asiento and m.Ubicacion_Precio = u.precio
and m.Ubicacion_Sin_numerar = u.sin_numerar and m.Ubicacion_Tipo_Codigo = u.ubicacion_tipo_codigo
and m.Espectaculo_Cod = u.espectaculo_cod
inner join COMPUMUNDOHIPERMEGARED.Cliente c
on c.nro_documento = m.Cli_Dni
where m.Compra_Cantidad is not null or m.Compra_Fecha is not null
group by u.id_ubicacion, m.Compra_Fecha, m.Compra_Cantidad, c.id_cliente, u.precio, u.compra_id
PRINT 'Insertados en CompraTemp'
go

insert into COMPUMUNDOHIPERMEGARED.Compra(id_compra, fecha, cantidad, cliente_id, precio_total)
select c.compra_id, c.fecha, c.cantidad, c.cliente_id, c.precio_total
from COMPUMUNDOHIPERMEGARED.##CompraTemp c
PRINT 'Insertados en Compra'
go

insert into COMPUMUNDOHIPERMEGARED.Ubicacion(id_ubicacion, fila, asiento, precio, sin_numerar,
tipo_ubicacion_id, publicacion_id, compra_id, ocupado)
select t.id_ubicacion, t.fila, t.asiento, t.precio, t.sin_numerar,
tu.id_tipo_ubicacion, t.publicacion_id, c.compra_id, case when c.compra_id is null then 0 else 1 end
from COMPUMUNDOHIPERMEGARED.##UbicacionTemp t
left join COMPUMUNDOHIPERMEGARED.##CompraTemp c on c.id_ubicacion = t.id_ubicacion
join COMPUMUNDOHIPERMEGARED.TipoUbicacion tu on tu.codigo = t.ubicacion_tipo_codigo
PRINT 'Insertados en Ubicación'
go

PRINT 'Migre Ubicaciones y Compras'

INSERT INTO COMPUMUNDOHIPERMEGARED.Factura(numero, fecha, total, forma_pago, empresa_id)
	SELECT DISTINCT m.Factura_Nro, m.Factura_Fecha, m.Factura_Total, m.Forma_Pago_Desc,
		(SELECT e.id_empresa FROM COMPUMUNDOHIPERMEGARED.Empresa e WHERE e.cuit = m.Espec_Empresa_Cuit)
	FROM gd_esquema.Maestra m
	WHERE m.Factura_Nro IS NOT NULL
	ORDER BY m.Factura_Nro
PRINT 'Migre Facturas'
GO

INSERT INTO COMPUMUNDOHIPERMEGARED.Item_Factura(item_factura_monto, item_factura_cantidad, item_factura_descripcion, factura_id, compra_id)
	SELECT m.Item_Factura_Monto, m.Item_Factura_Cantidad, m.Item_Factura_Descripcion,
	f.id_factura, u.compra_id
	FROM gd_esquema.Maestra m
	join COMPUMUNDOHIPERMEGARED.Factura f on f.numero = m.Factura_Nro
	join COMPUMUNDOHIPERMEGARED.##UbicacionTemp u on u.fila = m.Ubicacion_Fila and u.asiento = m.Ubicacion_Asiento
	and u.precio = m.Ubicacion_Precio and u.sin_numerar = m.Ubicacion_Sin_numerar
	and u.ubicacion_tipo_codigo = m.Ubicacion_Tipo_Codigo and u.espectaculo_cod = m.Espectaculo_Cod
	WHERE m.Item_Factura_Cantidad IS NOT NULL

drop table COMPUMUNDOHIPERMEGARED.##CompraTemp
drop table COMPUMUNDOHIPERMEGARED.##UbicacionTemp
PRINT 'Migre Item_Factura'
GO

INSERT INTO COMPUMUNDOHIPERMEGARED.PremioDisponible(descripcion,cant_puntos) VALUES
	('Lavadora automatica que nos muestra el adorable Smithers', 20000),
	('La caja', 20000),
	('Llavero especial PalcoNET', 1000)
PRINT 'Migre PremioDisponible'
GO

INSERT INTO COMPUMUNDOHIPERMEGARED.Puntos(cant_puntos, fecha_creacion, fecha_vencimiento, cliente_id, compra_id)
	SELECT ROUND(u.precio/3, 0, 1), c.fecha, DATEADD(MONTH, 3, c.fecha), c.cliente_id, c.id_compra
	FROM COMPUMUNDOHIPERMEGARED.Compra c
	JOIN COMPUMUNDOHIPERMEGARED.Ubicacion u ON c.id_compra = u.compra_id
	WHERE u.compra_id IS NOT NULL
PRINT 'Migre Puntos'
GO

declare c1 cursor for select p.id_publicacion, sum(cast(ocupado as int)) as ocupadas, count(*) as totales
from COMPUMUNDOHIPERMEGARED.Publicacion p
inner join COMPUMUNDOHIPERMEGARED.Ubicacion u on u.publicacion_id = p.id_publicacion
group by p.id_publicacion

declare @id_publicacion bigint, @ocupadas int, @totales int
open c1
fetch next from c1 into @id_publicacion, @ocupadas, @totales
while @@FETCH_STATUS = 0
begin
	if @totales = @ocupadas
	begin
		update COMPUMUNDOHIPERMEGARED.Publicacion
		set cant_ubicaciones_total = @totales, cant_ubicaciones_vendidas = @ocupadas, estado = 'F'
		where id_publicacion = @id_publicacion
	end
	else
	begin
		update COMPUMUNDOHIPERMEGARED.Publicacion
		set cant_ubicaciones_total = @totales, cant_ubicaciones_vendidas = @ocupadas
		where id_publicacion = @id_publicacion
	end

	fetch next from c1 into @id_publicacion, @ocupadas, @totales
end
close c1
deallocate c1
PRINT 'Actualizadas ubicaciones de publicaciones'
go


/*
	CREANDO CONFIGURACIONES INICIALES
*/


create procedure COMPUMUNDOHIPERMEGARED.actualizarRol(@nombre_rol nvarchar(50), @rol_id smallint, @listaFuncionalidad FuncionalidadList readonly)
as
begin
	delete from COMPUMUNDOHIPERMEGARED.Rol_Funcionalidad
	where rol_id = @rol_id

	update COMPUMUNDOHIPERMEGARED.Rol set nombre = @nombre_rol where id_rol = @rol_id

	insert into COMPUMUNDOHIPERMEGARED.Rol_Funcionalidad(funcionalidad_id, rol_id)
	select l.funcionalidad_id, @rol_id from @listaFuncionalidad l
end
go


create procedure COMPUMUNDOHIPERMEGARED.crear_nuevo_usuario
(@username nvarchar(50), @password nvarchar(50), @rol_id smallint, @solicitud_cambio_pass bit = 0, @usuario_id int = null output)
as
begin
	begin tran
	if(@password is null)
		rollback transaction

	insert into COMPUMUNDOHIPERMEGARED.Usuario(username, password, intentos, habilitado, solicitud_cambio_pass)
	values(@username, HASHBYTES('SHA2_256', @password), 0, 1, @solicitud_cambio_pass)

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
@fecha_creacion datetime, @rol_id int, @username nvarchar(50), @pass nvarchar(64), @solicitud_cambio_pass bit,
@cliente_id int output)
as
begin
	begin tran
	declare @id_nuevo_usuario int
	exec COMPUMUNDOHIPERMEGARED.crear_nuevo_usuario @username, @pass, @rol_id, @solicitud_cambio_pass, @usuario_id = @id_nuevo_usuario output
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
returns @funcionalidades table(id_funcionalidad tinyint, descripcion nvarchar(50))
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
returns @funcionalidades table(id_funcionalidad tinyint, descripcion nvarchar(50))
as
begin
	declare c1 cursor for select r.rol_id from Rol_Usuario r
	where r.usuario_id = @usuario_id
	declare @id_rol smallint
	declare @funcionalidades_temp table(id_funcionalidad tinyint, descripcion varchar(50))

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
	@username nvarchar(50),
	@solicitud_cambio_pass bit)
as
begin
	begin tran
	declare @id_nuevo_usuario int
	exec COMPUMUNDOHIPERMEGARED.crear_nuevo_usuario @username, @pass, @rol_id, @solicitud_cambio_pass, @usuario_id = @id_nuevo_usuario output
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

create function COMPUMUNDOHIPERMEGARED.get_espectaculo_id_de_publicacion(@publicacion_id bigint)
returns int
as
begin
	return (select e.id_espectaculo
			from COMPUMUNDOHIPERMEGARED.Publicacion p
			join COMPUMUNDOHIPERMEGARED.Espectaculo e
			on e.id_espectaculo = p.espectaculo_id
			and p.id_publicacion = @publicacion_id)
end
go

create procedure COMPUMUNDOHIPERMEGARED.crear_borrador(
	@descripcion nvarchar(255),
	@fecha_espectaculo datetime,
	@estado nvarchar(10) = null,-- warning esto está ignorado
	@ciudad nvarchar(255),
	@localidad nvarchar(255),
	@dom_calle nvarchar(50),
	@num_calle numeric(18,0),
	@cod_postal nvarchar(50),
	@empresa_id int,
	@rubro_id int,
	@grado_id int,
	@publicacion_id_generado bigint output)
as
begin
	begin tran
	insert into COMPUMUNDOHIPERMEGARED.Espectaculo
	(descripcion, ciudad, localidad, dom_calle, num_calle, cod_postal, empresa_id, rubro_id)
	values(@descripcion, @ciudad, @localidad, @dom_calle, @num_calle, @cod_postal, @empresa_id, @rubro_id)
	declare @id_espectaculo int = @@IDENTITY
	
	insert into COMPUMUNDOHIPERMEGARED.Publicacion
	(espectaculo_id, fecha_espectaculo, estado, grado_id)
	values(@id_espectaculo, @fecha_espectaculo, 'B', @grado_id)

	set @publicacion_id_generado = @@IDENTITY
	commit tran
	return
end
go

create procedure COMPUMUNDOHIPERMEGARED.generar_ubicaciones_de(@id_publicacion int)
as
begin
	declare c1 cursor for select numerado, tipo_ubicacion_id, fila_desde, fila_hasta, asiento_desde,
	asiento_hasta, cantidad, precio
	from COMPUMUNDOHIPERMEGARED.Sector s where s.id_espectaculo = COMPUMUNDOHIPERMEGARED.get_espectaculo_id_de_publicacion(@id_publicacion)
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

	update COMPUMUNDOHIPERMEGARED.Publicacion
	set cant_ubicaciones_total = (select count(id_ubicacion) from COMPUMUNDOHIPERMEGARED.Ubicacion where publicacion_id = @id_publicacion), cant_ubicaciones_vendidas = 0
	where id_publicacion = @id_publicacion

end
go

create procedure COMPUMUNDOHIPERMEGARED.update_datos_borrador(
	@descripcion nvarchar(255),
	@fecha_espectaculo datetime,
	@ciudad nvarchar(255),
	@localidad nvarchar(255),
	@dom_calle nvarchar(50),
	@num_calle numeric(18,0),
	@cod_postal nvarchar(50),
	@empresa_id int,
	@rubro_id int,
	@grado_id int,
	@id_publicacion bigint
)
as
	update COMPUMUNDOHIPERMEGARED.Publicacion
	set fecha_espectaculo = @fecha_espectaculo, estado = 'B', grado_id = @grado_id
	where id_publicacion = @id_publicacion

	declare @id_espectaculo int = COMPUMUNDOHIPERMEGARED.get_espectaculo_id_de_publicacion(@id_publicacion)

	update COMPUMUNDOHIPERMEGARED.Espectaculo
	set descripcion = @descripcion, ciudad = @ciudad, localidad = @localidad, dom_calle = @dom_calle,
	num_calle = @num_calle, cod_postal = @cod_postal, empresa_id = @empresa_id, rubro_id = @rubro_id
	where id_espectaculo = @id_espectaculo
go

create procedure COMPUMUNDOHIPERMEGARED.publicar_fecha(
	@fecha_creacion datetime,
	@fecha_espectaculo datetime,
	@grado_id int,
	@id_publicacion bigint = null,
	@id_espectaculo int,
	@id_publicacion_generado bigint output
)
as
	declare @porcentaje_comision numeric(5,2) = (select g.comision from COMPUMUNDOHIPERMEGARED.Grado g where g.id_grado = @grado_id)
	if @id_publicacion is not null
	begin
		update COMPUMUNDOHIPERMEGARED.Publicacion
		set espectaculo_id = @id_espectaculo, fecha_creacion = @fecha_creacion, fecha_espectaculo = @fecha_espectaculo,
		estado = 'P', grado_id = @grado_id, porcentaje_comision = @porcentaje_comision
		where id_publicacion = @id_publicacion

		set @id_publicacion_generado = @id_publicacion
		return
	end

	insert into COMPUMUNDOHIPERMEGARED.Publicacion(espectaculo_id, fecha_creacion, fecha_espectaculo, estado, grado_id, porcentaje_comision)
	values (@id_espectaculo, @fecha_creacion, @fecha_espectaculo, 'P', @grado_id, @porcentaje_comision)

	set @id_publicacion_generado = @@IDENTITY
	return
go

--=================================================
--|			CANJE DE PUNTOS                       |
--=================================================

create function COMPUMUNDOHIPERMEGARED.puntosDeCliente(@cliente_id int, @fecha datetime)
returns int
as
begin
	return isnull((select isnull(sum(p.cant_puntos - p.cant_usada), 0) from COMPUMUNDOHIPERMEGARED.Puntos p
			where p.fecha_creacion <= @fecha and
			@fecha <= p.fecha_vencimiento and p.cant_puntos > p.cant_usada
			and p.cliente_id = @cliente_id
			group by p.cliente_id), 0)
end
go

create procedure COMPUMUNDOHIPERMEGARED.realizarCanje(@cliente_id int, @premio_id int, @fecha_actual datetime)
as
	declare @puntos_a_gastar int = (select cant_puntos from PremioDisponible where id_premio = @premio_id)
	declare @puntos_disponibles int = COMPUMUNDOHIPERMEGARED.puntosDeCliente(@cliente_id, @fecha_actual)
	if(@puntos_a_gastar > @puntos_disponibles)
	begin
		raiserror('El cliente no tiene suficientes puntos', 13, 1)
		rollback tran
		return
	end
	
	declare c1 cursor for
	select id_puntos, cant_puntos - cant_usada from Puntos p
	where p.fecha_creacion <= @fecha_actual and
	DATEDIFF(MONTH, p.fecha_creacion, @fecha_actual) <= 3 and p.cant_puntos > p.cant_usada
	and p.cliente_id = @cliente_id
	order by p.fecha_creacion asc

	insert into Canje(fecha_canjeado, cliente_id, premio_id)
	values(@fecha_actual, @cliente_id, @premio_id)

	declare @canje_id int = @@IDENTITY

	declare @id_puntos int, @cant_puntos int
	declare @cant_restante int = @puntos_a_gastar

	open c1
	fetch next from c1 into @id_puntos, @cant_puntos
	while @@FETCH_STATUS = 0 and @cant_restante > 0
	begin
		declare @a_gastar int
		if @cant_restante >= @cant_puntos
			set @a_gastar = @cant_puntos
		else
			set @a_gastar = @cant_restante
		update Puntos
		set cant_usada = cant_usada + @a_gastar
		where id_puntos = @id_puntos

		insert into Puntos_Canje(id_puntos, id_canje, puntos_canjeados)
		values(@id_puntos, @canje_id, @a_gastar)

		set @cant_restante = @cant_restante - @a_gastar
		fetch next from c1 into @id_puntos, @cant_puntos
	end
	close c1
	deallocate c1
go

create procedure COMPUMUNDOHIPERMEGARED.AsignarTarjetaA(
	@cliente_id int,
	@nro_tarjeta nvarchar(50),
	@tipo char(1),
	@ccv numeric(5, 0),
	@fecha_vencimiento date,
	@tarjeta_id int output
)
as
begin
	begin tran
	insert into COMPUMUNDOHIPERMEGARED.Tarjeta(nro_tarjeta, tipo, ccv, fecha_vencimiento, cliente_id)
	values (@nro_tarjeta, @tipo, @ccv, @fecha_vencimiento, @cliente_id)

	set @tarjeta_id = @@IDENTITY

	update COMPUMUNDOHIPERMEGARED.Cliente
	set tarjeta_actual_id = @tarjeta_id
	where id_cliente = @cliente_id

	commit tran
	return
end
go

create function COMPUMUNDOHIPERMEGARED.StockDePublicacion(@publicacion_id bigint)
returns int
as
begin
	return (select count(*) from COMPUMUNDOHIPERMEGARED.Ubicacion u where u.publicacion_id = @publicacion_id and u.ocupado = 0)
end
go


CREATE TYPE COMPUMUNDOHIPERMEGARED.UbicacionTableType AS TABLE   
( ubicacion_id bigint);  
GO 

create procedure COMPUMUNDOHIPERMEGARED.ComprarUbicaciones(
	@ubicaciones_table UbicacionTableType READONLY,
	@publicacion_id bigint,
	@cliente_id int,
	@tarjeta_id int,
	@fecha datetime,
	@compra_id int output
)
as
begin
	begin tran
	if not exists (select ubicacion_id from @ubicaciones_table)
	begin
		raiserror('Debe comprar al menos una ubicación', 11, 1)
		rollback tran
		return
	end

	if exists (select * from COMPUMUNDOHIPERMEGARED.Ubicacion u
	where u.id_ubicacion in (select ubicacion_id from @ubicaciones_table) and u.ocupado = 1)
	begin
		raiserror('No se puede comprar ubicaciones ocupadas', 11, 1)
		rollback tran
		return
	end

	declare @total numeric(12,0) = (select sum(u.precio) from COMPUMUNDOHIPERMEGARED.Ubicacion u
	where u.id_ubicacion in (select ubicacion_id from @ubicaciones_table))

	if @total < 0
	begin
		raiserror('No puede haber compras con importe negativo', 11, 1)
		rollback tran
		return
	end

	declare @cantidad int = (select COUNT(*) from @ubicaciones_table)
	select @compra_id = next value for COMPUMUNDOHIPERMEGARED.CompraSequence
	
	insert into COMPUMUNDOHIPERMEGARED.Compra(id_compra, fecha, cantidad, cliente_id, tarjeta_id, precio_total)
	values(@compra_id, @fecha, @cantidad, @cliente_id, @tarjeta_id, @total)

	update COMPUMUNDOHIPERMEGARED.Ubicacion
	set ocupado = 1, compra_id = @compra_id
	where id_ubicacion in (select ubicacion_id from @ubicaciones_table)
	
	-- Actualizando localidades restantes
	update COMPUMUNDOHIPERMEGARED.Publicacion
	set cant_ubicaciones_vendidas = cant_ubicaciones_vendidas + @cantidad
	where id_publicacion = @publicacion_id
	
	update COMPUMUNDOHIPERMEGARED.Publicacion
	set estado = 'F', fecha_vencimiento = @fecha
	where id_publicacion = @publicacion_id and cant_ubicaciones_vendidas = cant_ubicaciones_total

	commit tran
	return
end
go

create procedure COMPUMUNDOHIPERMEGARED.RegistrarPuntosDeCompra(@compra_id int)
as
begin
	declare @precio_total numeric(18,0), @cliente_id int, @fecha datetime
	
	select @precio_total = c.precio_total, @cliente_id = c.cliente_id, @fecha = c.fecha 
	from COMPUMUNDOHIPERMEGARED.Compra c where c.id_compra = @compra_id

	insert into COMPUMUNDOHIPERMEGARED.Puntos(cant_puntos, fecha_creacion, fecha_vencimiento, cliente_id, compra_id)
	values(ROUND(@precio_total/3, 0, 1), @fecha, DATEADD(MONTH, 3, @fecha), @cliente_id, @compra_id)
end
go

/*
		PARA el  LISTADO ESTADÍSTICO
*/

create function COMPUMUNDOHIPERMEGARED.EmpresasConMenosVentas(@anio int, @mes int, @grado_id int)
returns table
as
	return (
		select top 5 sum(p.cant_ubicaciones_total - p.cant_ubicaciones_vendidas) as [Cantidad no vendida],
		emp.razon_social as [Razón social],
		emp.cuit as [CUIT],
		emp.mail as [E-mail],
		emp.telefono as [Nro. Teléfono]
		from COMPUMUNDOHIPERMEGARED.Empresa emp
		inner join COMPUMUNDOHIPERMEGARED.Espectaculo esp
		on emp.id_empresa = esp.empresa_id
		inner join COMPUMUNDOHIPERMEGARED.Publicacion p
		on p.espectaculo_id = esp.id_espectaculo
		inner join COMPUMUNDOHIPERMEGARED.Grado g
		on g.id_grado = p.grado_id
		where YEAR(p.fecha_espectaculo) = @anio
		and MONTH(p.fecha_espectaculo) = @mes
		and p.grado_id = @grado_id
		group by emp.id_empresa, emp.razon_social, emp.cuit, emp.mail, emp.telefono,
		p.id_publicacion, p.fecha_espectaculo, g.comision
		order by sum(p.cant_ubicaciones_total - p.cant_ubicaciones_vendidas) desc,
		p.fecha_espectaculo, g.comision desc
		)
GO

create function COMPUMUNDOHIPERMEGARED.GetTipoDocumento(@char char(1))
returns nvarchar(25)
as
begin
	return (select case when @char like 'D' then 'DNI'
						when @char like 'C' then 'Libreta Cívica'
						when @char like 'E' then 'Libreta de enrolamiento' end)
end
go

create function COMPUMUNDOHIPERMEGARED.ClientesConMasPuntosVencidos(@anio int, @trimestre int)
returns table
as
	return (
		select top 5 sum(p.cant_puntos - p.cant_usada) as [Puntos vencidos],
		c.id_cliente as [Id],
		c.nombre + ' ' + c.apellido as [Nombre y Apellido],
		COMPUMUNDOHIPERMEGARED.GetTipoDocumento(c.tipo_documento) as [Tipo Documento],
		c.nro_documento as [Nro. Documento],
		c.mail as [E-mail],
		c.telefono as [Teléfono]
		from COMPUMUNDOHIPERMEGARED.Cliente c
		left join COMPUMUNDOHIPERMEGARED.Puntos p
		on p.cliente_id = c.id_cliente
		where year(p.fecha_vencimiento) = @anio and datepart(QUARTER, p.fecha_vencimiento) = @trimestre
		group by c.id_cliente, c.nombre + ' ' + c.apellido, COMPUMUNDOHIPERMEGARED.GetTipoDocumento(c.tipo_documento), c.nro_documento, c.mail, c.telefono
		order by [Puntos vencidos] desc
	)
go

create function COMPUMUNDOHIPERMEGARED.ClientesConMasComprasDeEmpresa(@anio int, @trimestre int, @empresa_id int)
returns table
as
	return (
		select top 5
		COUNT(distinct com.id_compra) as [Cantidad de compras],
		cli.id_cliente as [Id],
		cli.nombre + ' ' + cli.apellido as [Nombre y Apellido],
		COMPUMUNDOHIPERMEGARED.GetTipoDocumento(cli.tipo_documento) as [Tipo Documento],
		cli.nro_documento as [Nro. Documento],
		cli.mail as [E-mail],
		cli.telefono as [Teléfono]
		from COMPUMUNDOHIPERMEGARED.Cliente cli
		inner join COMPUMUNDOHIPERMEGARED.Compra com on com.cliente_id = cli.id_cliente
		and year(com.fecha) = @anio and DATEPART(QUARTER, com.fecha) = @trimestre
		inner join COMPUMUNDOHIPERMEGARED.Ubicacion u on u.compra_id = com.id_compra
		inner join COMPUMUNDOHIPERMEGARED.Publicacion p on p.id_publicacion = u.publicacion_id
		inner join COMPUMUNDOHIPERMEGARED.Espectaculo e on e.id_espectaculo = p.espectaculo_id
		where e.empresa_id = @empresa_id
		group by cli.id_cliente, cli.nombre + ' ' + cli.apellido,
		COMPUMUNDOHIPERMEGARED.GetTipoDocumento(cli.tipo_documento), cli.nro_documento,
		cli.mail, cli.telefono,
		p.id_publicacion, e.empresa_id
		order by [Cantidad de compras] desc)
go

create function COMPUMUNDOHIPERMEGARED.ComprasDeCliente(@cliente_id int)
returns table
as
	return (select c.id_compra as [Id Compra], c.precio_total as [Precio Total], c.fecha as [Fecha], c.cantidad as [Cantidad de entradas],
			t.nro_tarjeta as [Nro. tarjeta],
			case when t.tipo like 'M' then 'Mastercard' when t.tipo like 'V' then 'Visa' when t.tipo like 'A' then 'American Express' end as [Tipo Tarjeta],
			t.fecha_vencimiento as [Vencimiento tarjeta]
			from COMPUMUNDOHIPERMEGARED.Compra c
			left join COMPUMUNDOHIPERMEGARED.Tarjeta t on c.tarjeta_id = t.id_tarjeta
			where c.cliente_id = @cliente_id)

go

create function COMPUMUNDOHIPERMEGARED.TopComprasDeEmpresa(@empresa_id int, @cantidad_top int)
returns table
as
return (SELECT top (@cantidad_top) c.id_compra AS compra_ID, c.precio_total AS [Precio total], c.cantidad as [Cantidad],
                c.fecha AS [Fecha compra], e.empresa_id AS empresa_ID, e.descripcion as [Descripción], p.fecha_espectaculo as [Fecha Espectáculo],
                CAST ((c.precio_total*p.porcentaje_comision/100.0) AS decimal(6,2)) AS [Comisión a cobrar]
                FROM COMPUMUNDOHIPERMEGARED.Compra c INNER JOIN COMPUMUNDOHIPERMEGARED.Ubicacion u ON u.compra_id = c.id_compra
                INNER JOIN COMPUMUNDOHIPERMEGARED.Publicacion p ON p.id_publicacion = u.publicacion_id
                INNER JOIN COMPUMUNDOHIPERMEGARED.Espectaculo e ON e.id_espectaculo = p.espectaculo_id
				left outer join COMPUMUNDOHIPERMEGARED.Item_Factura itf on itf.compra_id = c.id_compra
				WHERE empresa_ID = @empresa_id and itf.compra_id is null
                GROUP BY c.fecha, e.empresa_id, c.precio_total, c.fecha, c.id_compra, p.fecha_espectaculo, e.descripcion, c.cantidad, p.porcentaje_comision
                ORDER BY [Fecha compra] asc)
go

create procedure COMPUMUNDOHIPERMEGARED.RendirComisionesDeEmpresa(@empresa_id int, @cantidad_a_rendir int, @fecha_actual datetime)
as
	declare @numero_factura numeric(18,0) = (select MAX(f.numero) + 1 from COMPUMUNDOHIPERMEGARED.Factura f)

	begin tran
	insert into COMPUMUNDOHIPERMEGARED.Factura(numero, fecha, empresa_id, forma_pago)
	values (@numero_factura, @fecha_actual, @empresa_id, 'Efectivo')

	declare @id_factura int = @@IDENTITY

	insert into COMPUMUNDOHIPERMEGARED.Item_Factura(item_factura_cantidad, item_factura_descripcion, item_factura_monto,
	factura_id, compra_id)
	select t.Cantidad, 'Comisión por venta', t.[Comisión a cobrar], @id_factura, t.compra_ID
	from COMPUMUNDOHIPERMEGARED.TopComprasDeEmpresa(@empresa_id, @cantidad_a_rendir) t

	declare @total numeric(18,2) = (select sum(itf.item_factura_monto) from COMPUMUNDOHIPERMEGARED.Item_Factura itf where itf.factura_id = @id_factura)

	update COMPUMUNDOHIPERMEGARED.Factura
	set total = @total
	where id_factura = @id_factura

	commit tran
go

PRINT 'Todos los procedures y las funciones creados'

PRINT 'Creando al admin default'
declare @tablaFunciones COMPUMUNDOHIPERMEGARED.FuncionalidadList

insert into @tablaFunciones
select id_funcionalidad from COMPUMUNDOHIPERMEGARED.Funcionalidad

declare @idRol smallint

exec COMPUMUNDOHIPERMEGARED.crearNuevoRol 'Administrador General', @tablaFunciones, @id_generado = @idRol output 

exec COMPUMUNDOHIPERMEGARED.crear_nuevo_usuario 'admin', 'w23e', @idRol
PRINT 'Administrador general creado'
go

declare @id_rol smallint
select @id_rol = id_rol from COMPUMUNDOHIPERMEGARED.Rol where nombre like 'ADMINISTRADOR'
exec COMPUMUNDOHIPERMEGARED.crear_nuevo_usuario 'administrador', 'administrador', @id_rol
PRINT 'Administrador estándar creado'
go

create trigger COMPUMUNDOHIPERMEGARED.PubliTrigger
on COMPUMUNDOHIPERMEGARED.Publicacion
after update
as
	if exists ( select 1 from inserted i join deleted d on i.id_publicacion = d.id_publicacion
				where (d.estado like 'P' and i.estado like 'B')
				or (d.estado like 'F' and i.estado not like 'F'))
	begin
		raiserror('Transición de estados no válida', 16, 1)
		rollback transaction
	end
go

insert into COMPUMUNDOHIPERMEGARED.Rubro(descripcion)
values ('Comedia'),('Acción'),('Drama')