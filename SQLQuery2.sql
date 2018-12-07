insert into COMPUMUNDOHIPERMEGARED.Espectaculo(codigo, descripcion)
select distinct m.Espectaculo_Cod, m.Espectaculo_Descripcion
from gd_esquema.Maestra m

insert into COMPUMUNDOHIPERMEGARED.Publicacion(espectaculo_id, fecha_espectaculo, fecha_vencimiento, estado)
select e.id_espectaculo, m.Espectaculo_Fecha, m.Espectaculo_Fecha_Venc,
case when lower(m.Espectaculo_Estado) like 'publicada' then 'P'
when lower(m.Espectaculo_Estado) like 'borrador' then 'B'
when lower(m.Espectaculo_Estado) like 'finalizada' then 'F' end
from gd_esquema.Maestra m
inner join COMPUMUNDOHIPERMEGARED.Espectaculo e
on e.codigo = m.Espectaculo_Cod
group by e.id_espectaculo, m.Espectaculo_Fecha, m.Espectaculo_Fecha_Venc, m.Espectaculo_Estado

select count(*) from COMPUMUNDOHIPERMEGARED.Espectaculo
select count(*) from COMPUMUNDOHIPERMEGARED.Publicacion