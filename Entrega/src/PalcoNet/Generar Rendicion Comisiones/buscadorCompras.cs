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
        public DataTable filtrarCompras(long idEmpresa, Pagina pag = null)
        {
            pag = pag == null ? new Pagina(1, 10) : pag;

            var dt = DataBase.GetInstance().TypedQuery(this.getBusquedaQuery(pag, idEmpresa));

            return dt;
        }

        private String getBusquedaQuery(Pagina pag, long idEmpresa)
        {
            var sql = "SELECT c.id_compra AS compra_ID, c.precio_total AS precioTotal, c.fecha AS fechaCompra, e.empresa_id AS empresa_ID, SUM(CAST ((c.precio_total*comision/100.0) AS decimal(6,2))) AS comision_cobrada FROM COMPUMUNDOHIPERMEGARED.Compra c INNER JOIN COMPUMUNDOHIPERMEGARED.Ubicacion u ON u.compra_id = c.id_compra INNER JOIN COMPUMUNDOHIPERMEGARED.Publicacion p ON p.id_publicacion = u.publicacion_id INNER JOIN COMPUMUNDOHIPERMEGARED.Grado g ON g.id_grado = p.grado_id INNER JOIN COMPUMUNDOHIPERMEGARED.Espectaculo e ON e.id_espectaculo = p.espectaculo_id " +
                String.Format("WHERE empresa_ID = {0} GROUP BY c.fecha, e.empresa_id, c.precio_total, c.fecha,c.id_compra ORDER BY fechaCompra OFFSET {1} ROWS FETCH NEXT {2} ROWS ONLY",
                idEmpresa,pag.FirstResultIndex(), pag.pageSize);             

            return sql;

        }
    }
}
