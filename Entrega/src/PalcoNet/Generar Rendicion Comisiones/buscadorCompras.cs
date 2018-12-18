using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using PalcoNet.Comprar;
using PalcoNet.DataBasePackage;

namespace PalcoNet.Generar_Rendicion_Comisiones
{
    public class BuscadorCompras
    {
        public DataTable filtrarCompras(long idEmpresa, int cantidadTop)
        {
            var dt = DataBase.GetInstance()
                .TypedQuery("SELECT * from COMPUMUNDOHIPERMEGARED.TopComprasDeEmpresa(@idEmpresa, @cantidadTop)"
                , new QueryParameter("idEmpresa", SqlDbType.Int, idEmpresa)
                , new QueryParameter("cantidadTop", SqlDbType.Int, cantidadTop));

            return dt;
        }

    }
}
