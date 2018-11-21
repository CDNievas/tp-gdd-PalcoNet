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
