using PalcoNet.DataBasePackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Abm_Cliente
{
    class Buscador
    {
        public List<Cliente> filtrarClientes(String nombre = null, String apellido = null, String dni = null, String email = null, Pagina pag = null)
        {
            pag = pag == null ? new Pagina(1, 10) : pag;

            var dt = DataBase.GetInstance().query(this.getBusquedaQuery(nombre, apellido, dni, email, pag));

            var lista = new List<Cliente>();

            foreach (DataRow dr in dt.Rows)
            {
                lista.Add(Cliente.traerDe(dr));
            }

            return lista;
        }

        public String getBusquedaQuery(String nombre, String apellido, String dni, String email, Pagina pag)
        {
            var condiciones = new List<String>();
            if (nombre != null && !nombre.Trim().Equals(""))
            {
                var condicion = String.Format("nombre like '%{0}%'", nombre);
                condiciones.Add(condicion);
            }
            if (apellido != null && !apellido.Trim().Equals(""))
            {
                var condicion = String.Format("apellido like '%{0}%'", apellido);
                condiciones.Add(condicion);
            }
            if (dni != null && !dni.Trim().Equals(""))
            {
                var condicion = String.Format("nro_documento = '{0}'", dni);
                condiciones.Add(condicion);
            }
            if (email != null && email.Trim().Equals(""))
            {
                var condicion = String.Format("mail like '%{0}%'", email);
                condiciones.Add(condicion);
            }

            String condicionWhere = "";
            if (condiciones.Count != 0)
                condicionWhere = "where " + condiciones.Aggregate((prod, next) => prod + " and " + next);

            var sql = "select * from COMPUMUNDOHIPERMEGARED.Cliente " + condicionWhere
                + String.Format(" ORDER BY id_cliente OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY",
                pag.FirstResultIndex(), pag.pageSize);

            return sql;
        }
    }
}
