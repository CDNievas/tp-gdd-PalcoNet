create table Usuario (
	id_usuario int primary key,
	username nvarchar(50),
	password nvarchar(50),
	intentos tinyint not null default 0,
	habilitado bit not null,
	eliminado bit not null
)

create table Rol (
	id_rol int primary key,
	nombre nvarchar(50),
	listaFuncionalidad varbinary(20),
	habilitado bit not null,
	eliminado bit not null
)

create table Rol_Usuario (
	id_rol_usuario int primary key
	id_usuario int foreign key references Usuarios.id_usuario
	id_rol int foreign key references Rol.id_rol
	habilitado bit not null
	eliminado bit not null
)
