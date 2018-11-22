use GD2C2018
GO

create schema COMPUMUNDOHIPERMEGARED
GO

create table COMPUMUNDOHIPERMEGARED.Usuario(
	id_usuario int identity(1,1) primary key,
	username nvarchar(50) unique,
	password nvarchar(64),
	intentos tinyint,
	habilitado bit,
	eliminado bit default 0
)

create table COMPUMUNDOHIPERMEGARED.Funcionalidad(
	id_funcionalidad tinyint primary key,
	descripcion varchar(30) unique
)

create table COMPUMUNDOHIPERMEGARED.Rol(
	id_rol smallint identity(1,1) primary key,
	nombre nvarchar(50) unique,
	habilitado bit default 1
)

create table COMPUMUNDOHIPERMEGARED.Rol_Funcionalidad(
	rol_id smallint constraint FK_ROLFUNCIONALIDAD_ROL references COMPUMUNDOHIPERMEGARED.Rol,
	funcionalidad_id tinyint constraint FK_ROLFUNCIONALIDAD_FUNCIONALIDAD references COMPUMUNDOHIPERMEGARED.Funcionalidad
)

create table COMPUMUNDOHIPERMEGARED.Rol_Usuario(
	id_rol_usuario int identity(1,1) primary key,
	id_usario int constraint FK__USUARIO references COMPUMUNDOHIPERMEGARED.Usuario,
	id_rol smallint constraint FK_ROL references COMPUMUNDOHIPERMEGARED.Rol,
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
	comision numeric(5,2),
	prioridad smallint not null
)

create table COMPUMUNDOHIPERMEGARED.Publicacion(
	id_publicacion numeric(18,0) primary key,
	descripcion nvarchar(255),
	fecha_publicacion datetime,
	fecha_vencimiento datetime,
	fecha_espectaculo datetime,
	estado nvarchar(255),
	cod_estado char(1) not null,
	ciudad nvarchar(255),
	localidad nvarchar(255),
	dom_calle nvarchar(50),
	num_calle numeric(18),
	cod_postal nvarchar(50),
	id_empresa int constraint FK_PUBLICACION_EMPRESA references COMPUMUNDOHIPERMEGARED.Empresa,
	rubro_id int constraint FK_PUBLICACION_RUBRO references COMPUMUNDOHIPERMEGARED.Rubro,
	grado_id int constraint FK_PUBLICACION_GRADO references COMPUMUNDOHIPERMEGARED.Grado,
	constraint CHECK_ESTADO check(cod_estado in ('B', 'P', 'F', 'U'))
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
(id_empresa, id_publicacion, descripcion, fecha_espectaculo, fecha_vencimiento, rubro_id, cod_estado, estado)
select e.id_empresa, m.Espectaculo_Cod, m.Espectaculo_Descripcion, m.Espectaculo_Fecha, m.Espectaculo_Fecha_Venc,
(select r.id_rubro from COMPUMUNDOHIPERMEGARED.Rubro r where r.descripcion like m.Espectaculo_Rubro_Descripcion),
case when lower(m.Espectaculo_Estado) like 'publicada' then 'P'
when lower(m.Espectaculo_Estado) like 'borrador' then 'B'
when lower(m.Espectaculo_Estado) like 'finalizada' then 'F'
else 'U' end,
m.Espectaculo_Estado
from COMPUMUNDOHIPERMEGARED.Empresa e
inner join gd_esquema.Maestra m
on e.cuit = m.Espec_Empresa_Cuit and e.razon_social = m.Espec_Empresa_Razon_Social
group by e.id_empresa, m.Espectaculo_Cod, m.Espectaculo_Descripcion, m.Espectaculo_Fecha,
m.Espectaculo_Fecha_Venc, m.Espectaculo_Rubro_Descripcion, m.Espectaculo_Estado

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


-- NO SE SI DEJAR ESTO PERO TIENE SENTIDO QUE SE CUMPLA
alter table COMPUMUNDOHIPERMEGARED.Compras
add constraint UQ_UBICACIONES unique(ubicacion_id)

alter table COMPUMUNDOHIPERMEGARED.Facturas
add constraint UQ_NUMERO unique(factura_numero)


insert into COMPUMUNDOHIPERMEGARED.Funcionalidad(id_funcionalidad, descripcion)
values
(1, 'ABM ROL'),
(2, 'ABM CLIENTES'),
(3, 'ABM EMPRESA ESPECTACULOS'),
(4, 'ABM RUBRO'),
(5, 'ABM GRADO PUBLICACION'),
(6, 'GENERAR PUBLICACION'),
(7, 'EDITAR PUBLICACION'),
(8, 'COMPRAR'),
(9, 'HISTORIAL CLIENTE'),
(10, 'PUNTOS CLIENTE'),
(11, 'RENDICION COMISIONES'),
(12, 'LISTADO ESTADISTICO')

--select * from COMPUMUNDOHIPERMEGARED.Funcionalidad

create type COMPUMUNDOHIPERMEGARED.FuncionalidadList as table(
	funcionalidad_id tinyint
)
go

create procedure COMPUMUNDOHIPERMEGARED.crearNuevoRol(@nombre nvarchar(50), @listaFuncionalidad FuncionalidadList readonly, @id_generado smallint output)
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

create procedure COMPUMUNDOHIPERMEGARED.actualizarRol(@rol_id smallint, @listaFuncionalidad FuncionalidadList readonly)
as
begin
	delete from COMPUMUNDOHIPERMEGARED.Rol_Funcionalidad
	where rol_id = @rol_id

	insert into COMPUMUNDOHIPERMEGARED.Rol_Funcionalidad(funcionalidad_id, rol_id)
	select l.funcionalidad_id, @rol_id from @listaFuncionalidad l
end
go



create procedure COMPUMUNDOHIPERMEGARED.crearRolesPrincipales
as
begin
	declare @funcionalidades_cliente COMPUMUNDOHIPERMEGARED.FuncionalidadList
	insert into @funcionalidades_cliente values (8),(9),(10)
	exec COMPUMUNDOHIPERMEGARED.crearNuevoRol 'CLIENTE', @funcionalidades_cliente, null

	declare @funcionalidades_admin COMPUMUNDOHIPERMEGARED.FuncionalidadList
	insert into @funcionalidades_admin values (1),(2),(3),(4),(11),(12)
	exec COMPUMUNDOHIPERMEGARED.crearNuevoRol 'ADMINISTRADOR', @funcionalidades_admin, null

	declare @funcionalidades_empresa COMPUMUNDOHIPERMEGARED.FuncionalidadList
	insert into @funcionalidades_empresa values (5),(6),(7)
	exec COMPUMUNDOHIPERMEGARED.crearNuevoRol 'EMPRESA', @funcionalidades_empresa, null

end
go

exec COMPUMUNDOHIPERMEGARED.crearRolesPrincipales
drop procedure COMPUMUNDOHIPERMEGARED.crearRolesPrincipales

select * from COMPUMUNDOHIPERMEGARED.Rol r
inner join COMPUMUNDOHIPERMEGARED.Rol_Funcionalidad rf on rf.rol_id = r.id_rol
inner join COMPUMUNDOHIPERMEGARED.Funcionalidad f on f.id_funcionalidad = rf.funcionalidad_id
go

create procedure COMPUMUNDOHIPERMEGARED.crear_usuarios_de_empresas
as
begin
	declare @id_rol_empresa smallint = (select id_rol from Rol where nombre = 'EMPRESA')
	declare c1 cursor for select e.cuit from COMPUMUNDOHIPERMEGARED.Empresa e
	open c1
	declare @cuit nvarchar(255)
	fetch next from c1 into @cuit

	while @@FETCH_STATUS = 0
	begin
		insert into Usuario(username, intentos, habilitado)
		values('E-' + @cuit, 0, 0)
		declare @id_usuario int = @@IDENTITY
		insert into Rol_Usuario(id_rol, id_usario)
		values(@id_rol_empresa, @id_usuario)

		fetch next from c1 into @cuit
	end

	close c1
	deallocate c1
end
go

exec COMPUMUNDOHIPERMEGARED.crear_usuarios_de_empresas
drop procedure COMPUMUNDOHIPERMEGARED.crear_usuarios_de_empresas
go

create procedure COMPUMUNDOHIPERMEGARED.crear_usuarios_de_clientes
as
begin
	declare @id_rol_cliente smallint = (select id_rol from Rol where nombre = 'CLIENTE')
	declare c1 cursor for select c.nro_documento from COMPUMUNDOHIPERMEGARED.Cliente c
	open c1
	declare @dni nvarchar(255)
	fetch next from c1 into @dni

	while @@FETCH_STATUS = 0
	begin
		insert into Usuario(username, intentos, habilitado)
		values('C-' + @dni, 0, 0)
		declare @id_usuario int = @@IDENTITY
		insert into Rol_Usuario(id_rol, id_usario)
		values(@id_rol_cliente, @id_usuario)

		fetch next from c1 into @dni
	end

	close c1
	deallocate c1
end
go

exec COMPUMUNDOHIPERMEGARED.crear_usuarios_de_clientes
drop procedure COMPUMUNDOHIPERMEGARED.crear_usuarios_de_clientes
go


select * from COMPUMUNDOHIPERMEGARED.Usuario
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

select * from COMPUMUNDOHIPERMEGARED.find_funcionalidades_de_rol(1)
go

create function COMPUMUNDOHIPERMEGARED.find_funcionalidades_de_usuario(@usuario_id int)
returns @funcionalidades table(id_funcionalidad tinyint, descripcion varchar(30))
as
begin
	declare c1 cursor for select r.id_rol from Rol_Usuario r
	where r.id_usario = @usuario_id
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

select * from COMPUMUNDOHIPERMEGARED.find_funcionalidades_de_usuario(771)
go

create procedure COMPUMUNDOHIPERMEGARED.eliminar_rol(@id_rol smallint)
as
begin
	update Rol
	set habilitado = 0
	where id_rol = @id_rol

	delete from Rol_Usuario
	where id_rol = @id_rol
end
go

/*
exec COMPUMUNDOHIPERMEGARED.eliminar_rol 1

select * from COMPUMUNDOHIPERMEGARED.Rol_Usuario 
select * from COMPUMUNDOHIPERMEGARED.Rol
*/

create procedure COMPUMUNDOHIPERMEGARED.crear_nuevo_usuario(@username nvarchar(50), @password nvarchar(50), @rol_id smallint)
as
begin
	begin tran
	if(@password is null)
		rollback transaction

	insert into COMPUMUNDOHIPERMEGARED.Usuario(username, password, intentos, habilitado)
	values(@username, HASHBYTES('SHA2_256', @password), 0, 1)

	declare @usuario_id int = @@IDENTITY

	insert into COMPUMUNDOHIPERMEGARED.Rol_Usuario(id_rol, id_usario)
	values(@rol_id, @usuario_id)

	commit tran
end
go

create procedure COMPUMUNDOHIPERMEGARED.intentar_logear(@username nvarchar(50), @password nvarchar(50))
as
begin
	declare @id_usuario int, @pass_usuario nvarchar(64), @esta_habilitado bit, @esta_eliminado bit, @intentos smallint

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
end
go

create view COMPUMUNDOHIPERMEGARED.PublicacionesView as
SELECT p.id_publicacion, p.descripcion, p.fecha_publicacion, p.fecha_vencimiento, p.fecha_espectaculo,
p.estado, p.ciudad, p.localidad, p.dom_calle, p.num_calle, p.cod_postal,
p.id_empresa, p.cod_estado,
r.id_rubro as rubro_id, r.descripcion as rubro_descripcion,
g.id_grado as grado_id, g.descripcion as grado_descripcion, g.comision as grado_comision, g.prioridad
FROM COMPUMUNDOHIPERMEGARED.Publicacion p
left join COMPUMUNDOHIPERMEGARED.Rubro r
on r.id_rubro = p.rubro_id
left join COMPUMUNDOHIPERMEGARED.Grado g
on g.id_grado = p.grado_id
WITH CHECK OPTION
go

insert into COMPUMUNDOHIPERMEGARED.Grado(descripcion, comision, prioridad)
values
('Alta', 25.00, 3),
('Media', 17.50, 2),
('Baja', 12.10, 1)
go


/*
Creando al administrador General
*/
declare @tablaFunciones COMPUMUNDOHIPERMEGARED.FuncionalidadList

insert into @tablaFunciones
select id_funcionalidad from COMPUMUNDOHIPERMEGARED.Funcionalidad

declare @id smallint

exec COMPUMUNDOHIPERMEGARED.crearNuevoRol 'Administrador General', @tablaFunciones, @id_generado = @id output 

exec COMPUMUNDOHIPERMEGARED.crear_nuevo_usuario 'admin', 'w23', @id

go