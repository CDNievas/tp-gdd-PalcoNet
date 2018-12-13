using PalcoNet.DataBasePackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Abm_Empresa_Espectaculo
{
    public class BuscadorEmpresas
    {
        public List<Empresa> filtrarEmpresas(String razonSocial, String cuit, String email, Pagina pag)
        {
            var parametros = new List<QueryParameter>();
            var dt = DataBase.GetInstance()
                .TypedQuery(this.getBusquedaQuery(razonSocial, cuit, email, pag, parametros), parametros.ToArray());

            var lista = new List<Empresa>();

            foreach (DataRow dr in dt.Rows)
            {
                lista.Add(Empresa.traerDe(dr));
            }

            return lista;
        }

        public String getBusquedaQuery(String razonSocial, String cuit, String email, Pagina pag, List<QueryParameter> parametros)
        {
            var condiciones = new List<String>(); 
            if (razonSocial != null && !razonSocial.Trim().Equals(""))
            {
                var condicionRazonSocial = "razon_social like @razonSocial";
                condiciones.Add(condicionRazonSocial);
                parametros.Add(new QueryParameter("razonSocial", SqlDbType.NVarChar, "%" + razonSocial + "%"));
            }
            if (cuit != null  && !cuit.Trim().Equals(""))
            {
                var condicionCuit = "cuit = @cuit";
                condiciones.Add(condicionCuit);
                parametros.Add(new QueryParameter("cuit", SqlDbType.NVarChar, cuit));
            }
            if (email != null && !email.Trim().Equals(""))
            {
                var condicionMail = "mail like @email";
                condiciones.Add(condicionMail);
                parametros.Add(new QueryParameter("email", SqlDbType.NVarChar, "%" + email + "%"));
            }

            String condicion = "";
            if(condiciones.Count != 0)
            condicion = "where " + condiciones.Aggregate((prod, next) => prod + " and " + next);

            var sql = "select * from COMPUMUNDOHIPERMEGARED.Empresa e " + condicion
                + String.Format(" ORDER BY id_empresa OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY",
                pag.FirstResultIndex(), pag.pageSize);

            return sql;
        }

        public Empresa FindEmpresaById(int id)
        {
            var sql = String.Format("select * from COMPUMUNDOHIPERMEGARED.Empresa e where e.id_empresa = {0}", id);
            var dt = DataBase.GetInstance().Query(sql);
            return Empresa.traerDe(dt.Rows[0]);
        }

        public Empresa FindEmpresaByUsuarioId(int usuarioId)
        {
            var sql = String.Format("select * from COMPUMUNDOHIPERMEGARED.Empresa e where e.usuario_id = {0}", usuarioId);
            var dt = DataBase.GetInstance().Query(sql);
            return Empresa.traerDe(dt.Rows[0]);
        }
    }
}
