using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PalcoNet.Editar_Publicacion
{
    public class TipoUbicacion
    {
        public int id;
        private long codigo;

        public String Descripcion{get; private set;}

        public TipoUbicacion(int id, long codigo, String descripcion)
        {
            this.id = id;
            this.codigo = codigo;
            this.Descripcion = descripcion;
        }

        public override bool Equals(object obj)
        {
            if(obj is TipoUbicacion)
                return ((TipoUbicacion)obj).id.Equals(this.id);
            return false;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public override string ToString()
        {
            return Descripcion;
        }

        public static List<TipoUbicacion> Todos()
        {
            var dt = DataBase.GetInstance().Query("select * from COMPUMUNDOHIPERMEGARED.TipoUbicacion");

            var lista = new List<TipoUbicacion>();
            foreach (DataRow _dr in dt.Rows)
            {
                var dr = new DataRowExtended(_dr);
                var tipo = new TipoUbicacion(
                    id: dr.IntValue("id_tipo_ubicacion"),
                    codigo: dr.LongValue("codigo"),
                    descripcion: dr.StringValue("descripcion"));
                lista.Add(tipo);
            }
            return lista;
        }

    }
}