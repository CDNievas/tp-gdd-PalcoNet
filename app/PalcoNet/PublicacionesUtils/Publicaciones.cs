using PalcoNet.DataBasePackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.PublicacionesUtils
{
    class Publicaciones
    {
        public static List<Publicacion> TraerTodas() {
            var dt = DataBase.GetInstance().query("select * from COMPUMUNDOHIPERMEGARED.PublicacionesView");
            return PublicacionesFromDataTable(dt);
        }

        public static List<Publicacion> PublicacionesByEmpresaId(long idEmpresa, Pagina pag) {
            String sql = String.Format( @"select * from COMPUMUNDOHIPERMEGARED.PublicacionesView where id_empresa = {0}
                                        ORDER BY id_publicacion desc, fecha_espectaculo desc OFFSET {1} ROWS FETCH NEXT {2} ROWS ONLY",
                                        idEmpresa, pag.FirstResultIndex(), pag.pageSize);
            var dt = DataBase.GetInstance().query(sql);
            return PublicacionesFromDataTable(dt);
        }

        public static List<Publicacion> FiltrarPublicacionesAComprar(String descripcion = null, RangoFechas rango = null, List<Rubro> rubros = null, Pagina pag = null)
        {
            if (pag == null)
                pag = new Pagina(1, 10);

            String sql = GetBusquedaQuery(descripcion, rango, rubros, pag);
            var dt = DataBase.GetInstance().query(sql);
            return PublicacionesFromDataTable(dt);
        }

        public static String GetBusquedaQuery(String descripcion, RangoFechas rango, List<Rubro> rubros, Pagina pag)
        {
            var condiciones = new List<String>();

            if (descripcion != null && !descripcion.Trim().Equals(""))
            {
                var condicion = String.Format("upper(descripcion) like '%{0}%'", descripcion.ToUpper());
                condiciones.Add(condicion);
            }
            if (rango != null)
            {
                var condicion = String.Format("fecha_espectaculo between '{0}' and '{1}'", rango.inicio, rango.fin);
                condiciones.Add(condicion);
            }
            if (rubros != null && rubros.Count != 0)
            {
                var filtrosRubro = new List<String>();

                foreach (Rubro r in rubros)
                {
                    var s = String.Format("rubro_id = {0}", r.id);
                    filtrosRubro.Add(s);
                }
                var condicion = "(" + filtrosRubro.Aggregate((x, y) => x + " or " + y) + ")";

                condiciones.Add(condicion);
            }

            String condicionWhere = "";
            if (condiciones.Count != 0)
                condicionWhere = "where " + condiciones.Aggregate((prod, next) => prod + " and " + next);

            var sql = String.Format("select * from COMPUMUNDOHIPERMEGARED.PublicacionesView "
                + condicionWhere
                + " order by prioridad desc"
                + " OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY", pag.FirstResultIndex(), pag.pageSize);

            return sql;
        }

        private static List<Publicacion> PublicacionesFromDataTable(DataTable dt)
        {
            var publicaciones = new List<Publicacion>();
            foreach (DataRow dr in dt.Rows)
            {
                publicaciones.Add(Publicacion.FromDataRow(dr));
            }
            return publicaciones;
        }
    }
}
