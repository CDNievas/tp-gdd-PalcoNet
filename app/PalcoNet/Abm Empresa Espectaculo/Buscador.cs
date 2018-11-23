using PalcoNet.DataBasePackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Abm_Empresa_Espectaculo
{
    class Buscador
    {
        public List<Empresa> filtrarEmpresas(String razonSocial, String cuit, String email, Pagina pag)
        {
            var dt = DataBase.GetInstance().query(this.getBusquedaQuery(razonSocial, cuit, email, pag));

            var lista = new List<Empresa>();

            foreach (DataRow dr in dt.Rows)
            {
                lista.Add(Empresa.traerDe(dr));
            }

            return lista;
        }

        public String getBusquedaQuery(String razonSocial, String cuit, String email, Pagina pag)
        {
            var condiciones = new List<String>(); 
            if (razonSocial != null && !razonSocial.Trim().Equals(""))
            {
                var condicionRazonSocial = String.Format("razon_social like '%{0}%'", razonSocial);
                condiciones.Add(condicionRazonSocial);
            }
            if (cuit != null  && !cuit.Trim().Equals(""))
            {
                var condicionCuit = String.Format("cuit = '{0}'", cuit);
                condiciones.Add(condicionCuit);
            }
            if (email != null && !email.Trim().Equals(""))
            {
                var condicionMail = String.Format("mail like '%{0}%'", email);
                condiciones.Add(condicionMail);
            }

            String condicion = "";
            if(condiciones.Count != 0)
            condicion = "where " + condiciones.Aggregate((prod, next) => prod + " and " + next);

            var sql = "select * from COMPUMUNDOHIPERMEGARED.Empresa e " + condicion
                + String.Format(" ORDER BY id_empresa OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY",
                pag.FirstResultIndex(), pag.pageSize);

            return sql;
        }
    }
}
