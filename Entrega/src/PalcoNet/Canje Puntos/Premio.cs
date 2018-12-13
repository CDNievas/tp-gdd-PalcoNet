using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace PalcoNet.Canje_Puntos
{
    public class Premio
    {
        public int Id { get; private set; }
        [DisplayName("Descripción")]
        public String Descripcion { get; private set; }
        [DisplayName("Puntos requeridos")]
        public int puntosRequeridos { get; private set; }


        public static IList<Premio> GetPremiosPorCantPuntos(long cantPuntos, bool soloDisponibles = true)
        {
            String sql = "select * from COMPUMUNDOHIPERMEGARED.PremioDisponible ";
            if (soloDisponibles)
                sql += "where cant_puntos <= " + cantPuntos + " ";
            sql += "order by cant_puntos desc";
            var dt = DataBase.GetInstance().Query(sql);
            var premios = new List<Premio>();
            foreach (DataRow dr in dt.Rows)
            {
                premios.Add(FromDataRow(dr));
            }
            return premios;
        }

        private static Premio FromDataRow(DataRow dr)
        {
            var dre = new DataRowExtended(dr);
            var premio = new Premio();
            premio.Id = dre.IntValue("id_premio");
            premio.Descripcion = dre.StringValue("descripcion");
            premio.puntosRequeridos = dre.IntValue("cant_puntos");
            return premio;
        }
    }
}
