using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Abm_Cliente
{
    class Cliente
    {
        long id { get; set; }
        String cuil { get; set; }
        Char tipoDocumento { get; set; }
        String nroDocumento { get; set; }
        String nombre { get; set; }
        String apellido { get; set; }
        String mail { get; set; }
        String telefono { get; set; }
        String ciudad { get; set; }
        String localidad { get; set; }
        String domCalle { get; set; }
        String nroCalle { get; set; }
        int piso { get; set; }
        String depto { get; set; }
        String codPostal { get; set; }
        DateTime? fechaNacimiento { get; set; }
        DateTime? fechaCreacion { get; set; }


        public override string ToString()
        {
            return String.Format("Cliente({0}, {1}, {2}, {3})", nombre + " " + apellido, nroDocumento, mail, fechaNacimiento);
        }

        public static Cliente traerDe(DataRow dr)
        {
            var cliente = new Cliente();

            cliente.id = Convert.ToInt64(dr["id_cliente"].ToString());
            var tipo = dr["tipo_documento"].ToString();
            if (tipo.Length != 0)
                cliente.tipoDocumento = tipo[0];
            else cliente.tipoDocumento = ' ';
            cliente.nroDocumento = dr["nro_documento"].ToString();
            cliente.nombre = dr["nombre"].ToString();
            cliente.apellido = dr["apellido"].ToString();
            cliente.mail = dr["mail"].ToString();
            cliente.telefono = dr["telefono"].ToString();
            cliente.ciudad = dr["ciudad"].ToString();
            cliente.localidad = dr["localidad"].ToString();
            cliente.domCalle = dr["dom_calle"].ToString();
            cliente.nroCalle = dr["num_calle"].ToString();
            cliente.depto = dr["depto"].ToString();
            cliente.piso = Convert.ToInt32(dr["piso"]);
            cliente.codPostal = dr["cod_postal"].ToString();
            cliente.fechaNacimiento = (DateTime?)dr["fecha_nacimiento"];
            cliente.fechaCreacion = (DateTime?) (dr.IsNull("fecha_creacion")? null : dr["fecha_creacion"]);

            return cliente;
        }

    }
}
