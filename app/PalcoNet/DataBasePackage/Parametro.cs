using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.DataBasePackage
{
    interface Parametro
    {
        void AgregateA(SqlCommand cmd);
        void ObteneResultadoDe(SqlCommand cmd);
    }
}
