using PalcoNet.Abm_Rol;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Abm_Cliente
{
    public class Cliente
    {
        public long id { get; set; }
        public String cuil { get; set; }
        public TipoDocumento tipoDocumento { get; set; }
        public String nroDocumento { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String mail { get; set; }
        public String telefono { get; set; }
        public String ciudad { get; set; }
        public String localidad { get; set; }
        public String domCalle { get; set; }
        public String nroCalle { get; set; }
        public int? piso { get; set; }
        public String depto { get; set; }
        public String codPostal { get; set; }
        public DateTime? fechaNacimiento { get; set; }
        public DateTime? fechaCreacion { get; set; }


        public override string ToString()
        {
            return String.Format("Cliente({0}, {1}, {2}, {3})", nombre + " " + apellido, nroDocumento, mail, fechaNacimiento);
        }

        public static Cliente traerDe(DataRow dr)
        {
            var cliente = new Cliente();
            var data = new DataRowExtended(dr);

            cliente.id = data.LongValue("id_cliente");

            try
            {
                var tipo = data.StringValue("tipo_documento")[0];
                cliente.tipoDocumento = TipoDocumento.Parse(tipo);
            }
            catch (Exception)
            {
                cliente.tipoDocumento = null;
            }
            
            cliente.nroDocumento = data.StringValue("nro_documento");
            cliente.nombre = data.StringValue("nombre");
            cliente.apellido = data.StringValue("apellido");
            cliente.mail = data.StringValue("mail");
            cliente.telefono = data.StringValue("telefono");
            cliente.ciudad = data.StringValue("ciudad");
            cliente.localidad = data.StringValue("localidad");
            cliente.domCalle = data.StringValue("dom_calle");
            cliente.nroCalle = data.StringValue("num_calle");
            cliente.depto = data.StringValue("depto");
            cliente.piso = data.IntValue("piso");
            cliente.codPostal = data.StringValue("cod_postal");
            cliente.fechaNacimiento = data.OrElse<DateTime?>("fecha_nacimiento", null);
            cliente.fechaCreacion = data.OrElse<DateTime?>("fecha_creacion", null);

            return cliente;
        }

    }
}
