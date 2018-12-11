use GD2C2018
select * from COMPUMUNDOHIPERMEGARED.Ubicacion

select * from COMPUMUNDOHIPERMEGARED.Sector s
                  inner join COMPUMUNDOHIPERMEGARED.TipoUbicacion t
                  on t.id_tipo_ubicacion = s.tipo_ubicacion_id

select * from COMPUMUNDOHIPERMEGARED.Empresa

select * from COMPUMUNDOHIPERMEGARED.Cliente

select * from COMPUMUNDOHIPERMEGARED.Empresa e
inner join COMPUMUNDOHIPERMEGARED.Publicacion p
on e.id_empresa = p.empresa_id
order by empresa_id asc

update COMPUMUNDOHIPERMEGARED.Publicacion
set estado = 'BORRADOR'
where id_publicacion = 552

select * from COMPUMUNDOHIPERMEGARED.Publicacion p where estado like 'BORRA%'

update COMPUMUNDOHIPERMEGARED.Publicacion
set estado = 'borrador'
where estado like 'publi%'

select * from COMPUMUNDOHIPERMEGARED.Publicacion p
where p.descripcion like 'la mejor%'

select * from COMPUMUNDOHIPERMEGARED.Ubicacion u
inner join COMPUMUNDOHIPERMEGARED.TipoUbicacion t
on t.id_tipo_ubicacion = u.tipo_ubicacion_id
where u.publicacion_id = 7804

select * from COMPUMUNDOHIPERMEGARED.Puntos

select * from COMPUMUNDOHIPERMEGARED.PremioDisponible order by cant_puntos desc

select * from COMPUMUNDOHIPERMEGARED.Canje c
inner join COMPUMUNDOHIPERMEGARED.PremioDisponible p
on c.premio_id = p.id_premio
inner join COMPUMUNDOHIPERMEGARED.Puntos_Canje pc
on c.id_canje = pc.id_canje

select sum(puntos_canjeados) from COMPUMUNDOHIPERMEGARED.Puntos_Canje

