use GD2C2018
GO

create schema COMPUMUNDOHIPERMEGARED
GO

create table COMPUMUNDOHIPERMEGARED.Usuario(
	id_usuario int identity(1,1) primary key,
	username nvarchar(50),
	password nvarchar(50),
	intentos tinyint,
	habilitado bit
)

create table COMPUMUNDOHIPERMEGARED.Rol(
	id_rol int identity(1,1) primary key,
	nombre nvarchar(50),
	listaFuncionalidad binary(20),
	habilitado bit
)

create table COMPUMUNDOHIPERMEGARED.Rol_Usuario(
	id_rol_usuario int identity(1,1) primary key,
	id_usario int constraint FK__USUARIO references COMPUMUNDOHIPERMEGARED.Usuario,
	id_rol int constraint FK_ROL references COMPUMUNDOHIPERMEGARED.Rol,
	habilitado bit,
	eliminado bit  -- NO entiendo si habilitado/eliminado representan lo mismo o cosas distintas	
)

create table COMPUMUNDOHIPERMEGARED.Empresa(
	id_empresa int identity(1,1) primary key,
	cuit nvarchar(255) unique, -- en la tabla original estaba así
	razon_social nvarchar(255),
	mail nvarchar(50),
	telefono varchar(10),
	ciudad nvarchar(255),
	localidad nvarchar(255),
	dom_calle nvarchar(50), --estoy siendo consistente con que todo sea en snake case(?
	nro_calle numeric(18),
	piso numeric(18),
	depto nvarchar(50),
	cod_postal nvarchar(50),
	fecha_creacion datetime,
	rol_usuario_id int constraint FK_EMPRESA_ROLUSUARIO references COMPUMUNDOHIPERMEGARED.Rol_Usuario
)

create table COMPUMUNDOHIPERMEGARED.Cliente(
	id_cliente int identity(1,1) primary key,
	cuil char(1), --wtf
	tipo_documento char(1),
	nro_documento nvarchar(15) unique,
	nombre nvarchar(255),
	apellido nvarchar(255),
	mail nvarchar(255),
	telefono nvarchar(10),
	ciudad nvarchar(25),
	localidad nvarchar(255),
	dom_calle nvarchar(255),
	num_calle numeric(18),
	depto nvarchar(255),
	piso numeric(18),
	cod_postal nvarchar(255),
	fecha_nacimiento date,
	fecha_creacion datetime,
	rol_usuario_id int constraint FK_CLIENTE_ROLUSUARIO references COMPUMUNDOHIPERMEGARED.Rol_Usuario
)


create table COMPUMUNDOHIPERMEGARED.Rubro(
	id_rubro int identity(1,1) primary key,
	descripcion nvarchar(255)
)

create table COMPUMUNDOHIPERMEGARED.Grado(
	id_grado int identity(1,1) primary key,
	descripcion nvarchar(50),
	comisioni numeric(5,2)
)

create table COMPUMUNDOHIPERMEGARED.Publicacion(
	id_publicacion numeric(18,0) primary key,
	desrcipcion nvarchar(255),
	fecha_publicacion datetime,
	fecha_vencimiento datetime,
	fecha_espectaculo datetime,
	estado nvarchar(255),
	ciudad nvarchar(255),
	localidad nvarchar(255),
	dom_calle nvarchar(50),
	num_calle numeric(18),
	cod_postal nvarchar(50),
	id_empresa int constraint FK_PUBLICACION_EMPRESA references COMPUMUNDOHIPERMEGARED.Empresa,
	rubro_id int constraint FK_PUBLICACION_RUBRO references COMPUMUNDOHIPERMEGARED.Rubro,
	grado_id int constraint FK_PUBLICACION_GRADO references COMPUMUNDOHIPERMEGARED.Grado
)

create table COMPUMUNDOHIPERMEGARED.Tarjeta(
	id_tarjeta int identity(1,1) primary key,
	nro_tarjeta nvarchar(50),
	tipo_tarjeta nvarchar(50),
	ccv nvarchar(5),
	fecha_vencimiento date,
	habilitado bit,
	id_cliente int constraint FK_TARJETA_CLIENTE references COMPUMUNDOHIPERMEGARED.Cliente
)

create table COMPUMUNDOHIPERMEGARED.Compras(
	compra_id int identity(1,1) primary key,
	compra_fecha datetime,
	compra_cantidad numeric(18),
	tarjeta_id int constraint FK_COMPRAS_TARJETA references COMPUMUNDOHIPERMEGARED.Tarjeta,
	cliente_id int constraint FK_COMPRAS_CLIENTE references COMPUMUNDOHIPERMEGARED.Cliente,
	ubicacion_id int
)

create table COMPUMUNDOHIPERMEGARED.Puntos(
	puntos_id int identity(1,1) primary key,
	cliente_id int constraint FK_PUNTOS_CLIENTE references COMPUMUNDOHIPERMEGARED.Cliente,
	fecha_alta date,
	canjeado bit,
	cantidad_puntos numeric(10)
)

create table COMPUMUNDOHIPERMEGARED.Facturas(
	factura_id int identity(1,1) primary key,
	factura_numero numeric(18),
	factura_fecha datetime,
	factura_total numeric(18,2),
	forma_pago_desc varchar(255),
	factura_compra_total numeric(18,2),
	empresa_id int not null constraint FK_FACTURAS_EMPRESA references COMPUMUNDOHIPERMEGARED.Empresa
)

create table COMPUMUNDOHIPERMEGARED.Pagos(
	pago_id int identity(1,1) primary key,
	monto_pago numeric(18,2),
	empresa_id int constraint FK_PAGOS_EMPRESA references COMPUMUNDOHIPERMEGARED.Empresa,
	factura_id int constraint FK_PAGOS_FACTURAS references COMPUMUNDOHIPERMEGARED.Facturas
)

create table COMPUMUNDOHIPERMEGARED.TipoUbicacion(
	codigo numeric(18) primary key,
	descripcion nvarchar(255)
)

create table COMPUMUNDOHIPERMEGARED.Ubicacion(
	id_ubicacion int identity(1,1) primary key,
	fila varchar(3),
	asiento numeric(18),
	precio numeric(18),
	sin_numerar bit,
	ocupado bit default 0,
	tipo_ubicacion_id numeric(18) constraint FK_UBICACION_TIPOUBICACION references COMPUMUNDOHIPERMEGARED.TipoUbicacion,
	compra_id int constraint FK_UBICACION_COMPRAS references COMPUMUNDOHIPERMEGARED.Compras,
	publicacion_id numeric(18,0) constraint FK_UBICACION_PUBLICACION references COMPUMUNDOHIPERMEGARED.Publicacion
)

create table COMPUMUNDOHIPERMEGARED.Item_Factura(
	ubicacion_id int constraint FK_ITEMFACTURA_UBICACION references COMPUMUNDOHIPERMEGARED.Ubicacion,
	factura_id int constraint FK_ITEMFACTURA_FACTURAS references COMPUMUNDOHIPERMEGARED.Facturas,
	item_factura_monto numeric(18,2),
	item_factura_cantidad numeric(18),
	item_factura_descripcion varchar(60)
)

alter table COMPUMUNDOHIPERMEGARED.Compras
add constraint fk_compra_ubicacion foreign key (ubicacion_id) references COMPUMUNDOHIPERMEGARED.Ubicacion
go
/*
		FIN DE LA CREACION DE TABLAS
*/

CREATE UNIQUE INDEX index_dni
ON COMPUMUNDOHIPERMEGARED.Cliente (nro_documento)
go

create index index_ubicacion
on gd_esquema.Maestra(Ubicacion_Fila, Ubicacion_Asiento, Ubicacion_Sin_numerar,
Ubicacion_Precio, Ubicacion_Tipo_Codigo)
go

insert into COMPUMUNDOHIPERMEGARED.Cliente(nro_documento, apellido, nombre, fecha_nacimiento, mail, dom_calle,
num_calle, piso, depto, cod_postal)
select distinct m.Cli_Dni, m.Cli_Apeliido, m.Cli_Nombre, m.Cli_Fecha_Nac, m.Cli_Mail, m.Cli_Dom_Calle,
m.Cli_Nro_Calle, m.Cli_Piso, m.Cli_Depto, m.Cli_Cod_Postal
from gd_esquema.Maestra m
where m.Cli_Dni is not null

--select * from COMPUMUNDOHIPERMEGARED.Cliente
go

insert into COMPUMUNDOHIPERMEGARED.Empresa(razon_social, cuit, fecha_creacion, mail, dom_calle, nro_calle, piso, depto, cod_postal)
select distinct m.Espec_Empresa_Razon_Social, m.Espec_Empresa_Cuit, m.Espec_Empresa_Fecha_Creacion,
m.Espec_Empresa_Mail, m.Espec_Empresa_Dom_Calle, m.Espec_Empresa_Nro_Calle, m.Espec_Empresa_Piso,
m.Espec_Empresa_Depto, m.Espec_Empresa_Cod_Postal
from gd_esquema.Maestra m

--select * from COMPUMUNDOHIPERMEGARED.Empresa
go

insert into COMPUMUNDOHIPERMEGARED.Rubro(descripcion)
select distinct Espectaculo_Rubro_Descripcion from gd_esquema.Maestra

--select * from COMPUMUNDOHIPERMEGARED.Rubro
go

insert into COMPUMUNDOHIPERMEGARED.TipoUbicacion(codigo, descripcion)
select distinct m.Ubicacion_Tipo_Codigo, m.Ubicacion_Tipo_Descripcion
from gd_esquema.Maestra m

--select * from COMPUMUNDOHIPERMEGARED.TipoUbicacion
go

insert into COMPUMUNDOHIPERMEGARED.Publicacion
(id_empresa, id_publicacion, desrcipcion, fecha_espectaculo, fecha_vencimiento, rubro_id)
select e.id_empresa, m.Espectaculo_Cod, m.Espectaculo_Descripcion, m.Espectaculo_Fecha, m.Espectaculo_Fecha_Venc,
(select r.id_rubro from COMPUMUNDOHIPERMEGARED.Rubro r where r.descripcion like m.Espectaculo_Rubro_Descripcion)
from COMPUMUNDOHIPERMEGARED.Empresa e
inner join gd_esquema.Maestra m
on e.cuit = m.Espec_Empresa_Cuit and e.razon_social = m.Espec_Empresa_Razon_Social
group by e.id_empresa, m.Espectaculo_Cod, m.Espectaculo_Descripcion, m.Espectaculo_Fecha,
m.Espectaculo_Fecha_Venc, m.Espectaculo_Rubro_Descripcion

--select * from COMPUMUNDOHIPERMEGARED.Publicacion
go

insert into COMPUMUNDOHIPERMEGARED.Facturas(factura_numero, factura_fecha, factura_total, empresa_id)
select f.nro, f.fecha, f.total,
(select e.id_empresa from COMPUMUNDOHIPERMEGARED.Empresa e where e.cuit = f.cuit)
from
(
select m.Factura_Fecha as fecha, m.Factura_Nro as nro, m.Factura_Total as total, m.Espec_Empresa_Cuit as cuit
from gd_esquema.Maestra m
where m.Factura_Nro is not null
group by m.Factura_Fecha, m.Factura_Nro, m.Factura_Total, m.Espec_Empresa_Cuit
) f

go

-- INSERTANDO UBICACIONES
insert into COMPUMUNDOHIPERMEGARED.Ubicacion(fila, asiento, sin_numerar, precio, tipo_ubicacion_id, publicacion_id)
select m.Ubicacion_Fila, m.Ubicacion_Asiento, m.Ubicacion_Sin_numerar,
m.Ubicacion_Precio, m.Ubicacion_Tipo_Codigo, m.Espectaculo_Cod
from gd_esquema.Maestra m
group by m.Ubicacion_Fila, m.Ubicacion_Asiento, m.Ubicacion_Sin_numerar,
m.Ubicacion_Precio, m.Ubicacion_Tipo_Codigo, m.Espectaculo_Cod

--select * from COMPUMUNDOHIPERMEGARED.Ubicacion

go

/*
drop function COMPUMUNDOHIPERMEGARED.findIdClienteByDni
create function COMPUMUNDOHIPERMEGARED.findIdClienteByDni(@dni numeric(18,0))
returns int
as
begin
	return (select c.id_cliente from COMPUMUNDOHIPERMEGARED.Cliente c where c.nro_documento = @dni)
end
go
*/

insert into COMPUMUNDOHIPERMEGARED.Compras(ubicacion_id, compra_fecha, compra_cantidad, cliente_id)
select distinct u.id_ubicacion, m.Compra_Fecha, m.Compra_Cantidad, c.id_cliente
from COMPUMUNDOHIPERMEGARED.Ubicacion u
inner join gd_esquema.Maestra m
on m.Ubicacion_Fila = u.fila and m.Ubicacion_Asiento = u.asiento and m.Ubicacion_Precio = u.precio
and m.Ubicacion_Sin_numerar = u.sin_numerar and m.Ubicacion_Tipo_Codigo = u.tipo_ubicacion_id
and m.Espectaculo_Cod = u.publicacion_id
inner join COMPUMUNDOHIPERMEGARED.Cliente c
on c.nro_documento = m.Cli_Dni
where m.Compra_Cantidad is not null or m.Compra_Fecha is not null

/*
select * from COMPUMUNDOHIPERMEGARED.Compras order by cliente_id, ubicacion_id
delete from COMPUMUNDOHIPERMEGARED.Compras
*/
go

-- MIGRANDO ITEM_FACTURA
insert into COMPUMUNDOHIPERMEGARED.Item_Factura(item_factura_cantidad, item_factura_descripcion, item_factura_monto,
ubicacion_id, factura_id)
select m.Item_Factura_Cantidad, m.Item_Factura_Descripcion, m.Item_Factura_Monto, u.id_ubicacion, f.factura_id
from COMPUMUNDOHIPERMEGARED.Facturas f
inner join gd_esquema.Maestra m
on m.Factura_Nro = f.factura_numero
inner join COMPUMUNDOHIPERMEGARED.Ubicacion u
on m.Ubicacion_Fila = u.fila and m.Ubicacion_Asiento = u.asiento and m.Ubicacion_Precio = u.precio
and m.Ubicacion_Sin_numerar = u.sin_numerar and m.Ubicacion_Tipo_Codigo = u.tipo_ubicacion_id
and m.Espectaculo_Cod = u.publicacion_id

-- NO lo vamos a necesitar mas :(
drop index index_ubicacion on gd_esquema.Maestra


-- NO SE SI DEJAR ESTO PERO TIENE SENTIDO QUE SE CUMPLA
alter table COMPUMUNDOHIPERMEGARED.Compras
add constraint UQ_UBICACIONES unique(ubicacion_id)

alter table COMPUMUNDOHIPERMEGARED.Facturas
add constraint UQ_NUMERO unique(factura_numero)