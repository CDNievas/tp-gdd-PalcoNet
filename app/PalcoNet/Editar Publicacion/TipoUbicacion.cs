using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalcoNet.Editar_Publicacion
{
    public class TipoUbicacion
    {
        private int id;
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
    }
}
