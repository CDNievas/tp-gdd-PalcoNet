using PalcoNet.DataBasePackage;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet
{
    class ParametroIn:Parametro
    {
        public String nombre;
        public Object valor;

        public ParametroIn(String nombre, Object valor) {
            this.nombre = nombre;
            this.valor = valor;
        }

        public void AgregateA(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@" + nombre, valor);
        }

        public void ObteneResultadoDe(SqlCommand cmd)
        {
            //No hace nada
        }
    }
}
