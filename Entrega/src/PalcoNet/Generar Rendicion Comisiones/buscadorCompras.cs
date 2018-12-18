using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Comprar;
using PalcoNet.DataBasePackage;

namespace PalcoNet.Generar_Rendicion_Comisiones
{
    class buscadorCompras
    {
        public DataTable filtrarCompras(long idEmpresa, int cantidadTop)
        {
            var dt = DataBase.GetInstance().TypedQuery(this.getBusquedaQuery(idEmpresa, cantidadTop));

            return dt;
        }

        private String getBusquedaQuery(long idEmpresa, int cantidadTop)
        {
            var sql = @"SELECT top " + cantidadTop + @" c.id_compra AS compra_ID, c.precio_total AS [Precio total],
                c.fecha AS [Fecha compra], e.empresa_id AS empresa_ID, e.descripcion as [Descripción], p.fecha_espectaculo as [Fecha Espectáculo],
                SUM(CAST ((c.precio_total*p.porcentaje_comision/100.0) AS decimal(6,2))) AS [Comisión a cobrar]
                FROM COMPUMUNDOHIPERMEGARED.Compra c INNER JOIN COMPUMUNDOHIPERMEGARED.Ubicacion u ON u.compra_id = c.id_compra
                INNER JOIN COMPUMUNDOHIPERMEGARED.Publicacion p ON p.id_publicacion = u.publicacion_id
                INNER JOIN COMPUMUNDOHIPERMEGARED.Espectaculo e ON e.id_espectaculo = p.espectaculo_id " +
                String.Format(@"WHERE empresa_ID = {0}
                GROUP BY c.fecha, e.empresa_id, c.precio_total, c.fecha,c.id_compra, p.fecha_espectaculo, e.descripcion
                ORDER BY [Fecha compra] asc", idEmpresa);             

            return sql;

        }
    }
}
