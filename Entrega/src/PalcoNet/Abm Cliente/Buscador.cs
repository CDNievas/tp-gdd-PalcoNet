using PalcoNet.DataBasePackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Abm_Cliente
{
    public class Buscador
    {
        public List<Cliente> filtrarClientes(String nombre = null, String apellido = null, String dni = null, String email = null, Pagina pag = null)
        {
            pag = pag == null ? new Pagina(1, 10) : pag;

            var parametros = new List<QueryParameter>();

            var sql = "select * " + this.getBusquedaQuery(nombre, apellido, dni, email, parametros)
                + String.Format(" ORDER BY id_cliente OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY",
                pag.FirstResultIndex(), pag.pageSize);

            var dt = DataBase.GetInstance().TypedQuery(sql, parametros.ToArray());

            var lista = new List<Cliente>();

            foreach (DataRow dr in dt.Rows)
            {
                lista.Add(Cliente.traerDe(dr));
            }

            return lista;
        }

        public int CantidadDeClientesAFiltrar(String nombre = null, String apellido = null, String dni = null, String email = null)
        {
            var parametros = new List<QueryParameter>();
            var sql = "select count(*) as cantidad " + this.getBusquedaQuery(nombre, apellido, dni, email, parametros);
            var dt = DataBase.GetInstance().TypedQuery(sql, parametros.ToArray());

            return Convert.ToInt32(dt.Rows[0]["cantidad"]);
        }

        private String getBusquedaQuery(String nombre, String apellido, String dni, String email, List<QueryParameter> parametros)
        {
            var condiciones = new List<String>();
            if (nombre != null && !String.IsNullOrWhiteSpace(nombre))
            {
                var condicion = "nombre like @nombre";
                condiciones.Add(condicion);
                parametros.Add(new QueryParameter("nombre", SqlDbType.NVarChar, "%" + nombre + "%"));
            }
            if (apellido != null && !String.IsNullOrWhiteSpace(apellido))
            {
                var condicion = "apellido like @apellido";
                condiciones.Add(condicion);
                parametros.Add(new QueryParameter("apellido", SqlDbType.NVarChar, "%" + apellido + "%"));
            }
            if (dni != null && !String.IsNullOrWhiteSpace(dni))
            {
                var condicion = "nro_documento = @documento";
                condiciones.Add(condicion);
                parametros.Add(new QueryParameter("documento", SqlDbType.NVarChar, dni));
            }
            if (email != null && !String.IsNullOrWhiteSpace(email))
            {
                var condicion = "mail like @email";
                condiciones.Add(condicion);
                parametros.Add(new QueryParameter("email", SqlDbType.NVarChar, "%" + email + "%"));
            }

            String condicionWhere = "";
            if (condiciones.Count != 0)
                condicionWhere = "where " + condiciones.Aggregate((prod, next) => prod + " and " + next);

            var sql = " from COMPUMUNDOHIPERMEGARED.Cliente " + condicionWhere;

            return sql;
        }
    }
}
