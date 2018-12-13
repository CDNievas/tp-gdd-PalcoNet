using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.LoginUtils
{
    public class Funcionalidad
    {
        public short Id {get; private set;}
        public String Descripcion {get; private set; }

        private Funcionalidad(short unId, String d)
        {
            Id = unId;
            Descripcion = d;
        }

        public static Funcionalidad traerDe(DataRow dr)
        {
            var id = Convert.ToInt16(dr["id_funcionalidad"]);
            var desc = dr["descripcion"].ToString();
            var funcionalidad = new Funcionalidad(id, desc);
            
            return funcionalidad;
        }

        public override string ToString()
        {
            return String.Format("Funcionalidad({0}, {1})", Id, Descripcion);
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Funcionalidad))
                return false;
            return ((Funcionalidad)obj).Id.Equals(this.Id);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
