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
            var dt = DataBase.GetInstance().Query("select * from COMPUMUNDOHIPERMEGARED.PublicacionesView");
            return PublicacionesFromDataTable(dt);
        }

        public static List<Publicacion> PublicacionesByEmpresaId(long idEmpresa, Pagina pag, Boolean soloBorradores) {
            String condicionWhereBorrador = "";
            if (soloBorradores)
                condicionWhereBorrador = "and estado = '"+ new Borrador().Codigo() +"'";

            String sql = String.Format( @"select * from COMPUMUNDOHIPERMEGARED.PublicacionesView where id_empresa = {0}
                                        {3}
                                        ORDER BY case when estado like 'B' then 0 else 1 end, fecha_espectaculo desc
                                        OFFSET {1} ROWS FETCH NEXT {2} ROWS ONLY",
                                        idEmpresa, pag.FirstResultIndex(), pag.pageSize, condicionWhereBorrador);
            var dt = DataBase.GetInstance().Query(sql);
            return PublicacionesFromDataTable(dt);
        }

        public static List<Publicacion> FiltrarPublicacionesAComprar(String descripcion = null, RangoFechas rango = null, List<Rubro> rubros = null, Pagina pag = null)
        {
            if (pag == null)
                pag = new Pagina(1, 10);

            String sql = GetBusquedaQuery(descripcion, rango, rubros, pag);
            QueryParameter[] arr = { };
            if (rango != null)
            {
                arr = new QueryParameter[] {new QueryParameter("inicio", SqlDbType.DateTime, rango.inicio),
                new QueryParameter("fin", SqlDbType.DateTime, rango.fin)};
            }

            var dt = DataBase.GetInstance().TypedQuery(sql, arr);
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
                var condicion = String.Format("fecha_espectaculo between @inicio and @fin");
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
                + " order by grado_comision desc"
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
