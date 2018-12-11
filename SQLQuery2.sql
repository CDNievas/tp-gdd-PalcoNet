select count(*) from COMPUMUNDOHIPERMEGARED.Espectaculo
select count(*) from COMPUMUNDOHIPERMEGARED.Publicacion

select count(id_ubicacion), id_publicacion
from COMPUMUNDOHIPERMEGARED.Ubicacion u
inner join COMPUMUNDOHIPERMEGARED.PublicacionesView v
on v.id_publicacion = u.publicacion_id
group by id_publicacion

select count(*) from COMPUMUNDOHIPERMEGARED.Ubicacion

select * from COMPUMUNDOHIPERMEGARED.Empresa

select * from COMPUMUNDOHIPERMEGARED.PublicacionesView where descripcion = 'adfs'

select * from COMPUMUNDOHIPERMEGARED.Ubicacion
where publicacion_id = 7809