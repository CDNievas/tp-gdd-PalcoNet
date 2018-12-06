using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PalcoNet.DataBasePackage
{
    public class QueryParameter
    {
        String name;
        SqlDbType tipo;
        Object value;

        public QueryParameter(String name, SqlDbType tipo, Object value)
        {
            this.name = "@" + name;
            this.tipo = tipo;
            this.value = value;
        }

        public void AgregateA(SqlCommand cmd)
        {
            cmd.Parameters.Add(name, tipo).Value = value != null ? value : DBNull.Value;
        }
    }
}
