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
        short id { get; set; }
        String descripcion;

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
