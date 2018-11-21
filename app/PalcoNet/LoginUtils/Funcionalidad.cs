using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.LoginUtils
{
    class Funcionalidad
    {
        public short id { get; set; }
        public String descripcion { get; set; }

        private Funcionalidad()
        {
        }

        public static Funcionalidad traerDe(DataRow dr)
        {
            var funcionalidad = new Funcionalidad();
            funcionalidad.id = Convert.ToInt16(dr["id_funcionalidad"]);
            funcionalidad.descripcion = dr["descripcion"].ToString();

            return funcionalidad;
        }

        public override string ToString()
        {
            return String.Format("Funcionalidad({0}, {1})", id, descripcion);
        }
    }
}
