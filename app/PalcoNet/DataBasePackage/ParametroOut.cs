using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.DataBasePackage
{
    class ParametroOut:Parametro
    {
        private String nombre;
        private SqlDbType tipo;
        public Object valorRetorno;

        public ParametroOut(String nombre, SqlDbType tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
        }

        public String ParameterName()
        {
            return "@" + nombre;
        }

        public void AgregateA(SqlCommand cmd)
        {
            var self = new SqlParameter(ParameterName(), tipo);
            self.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(self);
        }

        public void ObteneResultadoDe(SqlCommand cmd)
        {
            try
            {
                this.valorRetorno = cmd.Parameters[ParameterName()].Value;
            }
            catch (Exception)
            {
                this.valorRetorno = null;
            }
        }
    }
}
