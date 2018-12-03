using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Editar_Publicacion
{
    public class Ubicacion
    {
        public long Id { get; private set; }

        [DisplayName("Fila")]
        public String Fila { get; set; }

        [DisplayName("Asiento")]
        public String Asiento { get; set; }

        [DisplayName("Precio")]
        public String Precio { get; set; }

        [DisplayName("Sin numerar?")]
        public Boolean SinNumerar { get; set; }

        public TipoUbicacion Tipo { get; set; }

        [DisplayName("Ocupado?")]
        public Boolean Ocupado { get; set; }

        private static Ubicacion FromDataRow(DataRow _dr)
        {
            var dr = new DataRowExtended(_dr);
            var ubicacion = new Ubicacion();

            ubicacion.Fila = dr.StringValue("fila");
            ubicacion.Asiento = dr.TryGet<String>("", _ => _.StringValue("asiento"));
            ubicacion.Precio = dr.TryGet<String>("", _ => _.StringValue("precio"));
            ubicacion.SinNumerar = dr.BoolValue("sin_numerar");
            ubicacion.Ocupado = dr.BoolValue("ocupado");

            ubicacion.Tipo = new TipoUbicacion(dr.IntValue("id_tipo_ubicacion"), dr.LongValue("codigo"), dr.StringValue("descripcion"));

            return ubicacion;
        }


        public void Persist()
        {
            if (Id == null)
            {
                this.Guadarse();
            }
            else
            {
                this.Actualizarse();
            }
        }

        private void Actualizarse()
        {
            var sql = String.Format(@"
            update COMPUMUNDOHIPERMEGARED.Ubicacion
            set fila = {0}, asiento = {1}, precio = {2}, sin_numerar = {3}
            where id_ubicacion = {4}
            ", Fila.Trim().Equals("") ? "null" : "'" + Fila + "'",
             Asiento == null ? "null" : Asiento,
             Precio,
             SinNumerar ? "1" : "0",
             this.Id);

            DataBase.GetInstance().Query(sql);
        }

        private void Guadarse()
        {
            throw new NotImplementedException();
        }

        public static List<Ubicacion> FindUbicacionesDePublicacion(long publicacionId)
        {
            var sql = String.Format(@"
            select * from COMPUMUNDOHIPERMEGARED.Ubicacion u
            left join COMPUMUNDOHIPERMEGARED.TipoUbicacion t on u.tipo_ubicacion_id = t.id_tipo_ubicacion
            where u.publicacion_id = {0}", publicacionId);
            var dt = DataBase.GetInstance().Query(sql);

            var ubicaciones = new List<Ubicacion>();
            foreach (DataRow dr in dt.Rows)
            {
                ubicaciones.Add(FromDataRow(dr));
            }
            return ubicaciones;
        }

        

    }
}
