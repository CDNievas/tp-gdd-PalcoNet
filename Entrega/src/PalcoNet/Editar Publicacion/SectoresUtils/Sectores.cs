using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Editar_Publicacion
{
    public class Sectores
    {
        public static List<Sector> FindSectoresByPublicacionId(long publicacionId, bool numerados)
        {
            var sql = String.Format(
                @"select * from COMPUMUNDOHIPERMEGARED.Sector s
                  inner join COMPUMUNDOHIPERMEGARED.TipoUbicacion t
                  on t.id_tipo_ubicacion = s.tipo_ubicacion_id
                  where s.id_espectaculo = {0} and s.numerado = {1}", publicacionId, numerados? 1: 0);
            var dataTable = DataBase.GetInstance().Query(sql);

            var sectores = new List<Sector>();
            foreach (DataRow dr in dataTable.Rows)
            {
                sectores.Add(Sector.FromDataRow(dr));
            }
            return sectores;
        }

        public static List<SectorNumerado> FindSectoresNumeradosByPublicacionId(long publicacionId)
        {
            return FindSectoresByPublicacionId(publicacionId, true).Cast<SectorNumerado>().ToList();
        }

        public static List<SectorSinNumerar> FindSectoresSinNumerarByPublicacionId(long publicacionId)
        {
            return FindSectoresByPublicacionId(publicacionId, false).Cast<SectorSinNumerar>().ToList();
        }
    }
}
