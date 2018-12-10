using PalcoNet.Abm_Rol;
using PalcoNet.DataBasePackage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Abm_Cliente
{
    public class Cliente
    {
        public long id { get; set; }

        [DisplayName("CUIL")]
        public String cuil { get; set; }

        [DisplayName("Tipo Documento")]
        public TipoDocumento tipoDocumento { get; set; }

        [DisplayName("Nro. Documento")]
        public String nroDocumento { get; set; }

        [DisplayName("Nombre")]
        public String nombre { get; set; }

        [DisplayName("Apellido")]
        public String apellido { get; set; }

        [DisplayName("E-mail")]
        public String mail { get; set; }

        [DisplayName("Teléfono")]
        public String telefono { get; set; }

        [DisplayName("Ciudad")]
        public String ciudad { get; set; }

        [DisplayName("Localidad")]
        public String localidad { get; set; }

        [DisplayName("Calle")]
        public String domCalle { get; set; }

        [DisplayName("Número")]
        public String nroCalle { get; set; }

        [DisplayName("Piso")]
        public int? piso { get; set; }

        [DisplayName("Depto")]
        public String depto { get; set; }

        [DisplayName("C.P.")]
        public String codPostal { get; set; }

        [DisplayName("Nacimiento")]
        public DateTime? fechaNacimiento { get; set; }

        [DisplayName("Creación")]
        public DateTime? fechaCreacion { get; set; }

        public Boolean Habilitado { get; set; }


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

            cliente.cuil = data.StringValue("cuil");
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
            cliente.piso = data.Fold<int?>("piso", null, x => Convert.ToInt32(x.ToString()));
            cliente.codPostal = data.StringValue("cod_postal");
            cliente.fechaNacimiento = data.OrElse<DateTime?>("fecha_nacimiento", null);
            cliente.fechaCreacion = data.OrElse<DateTime?>("fecha_creacion", null);
            cliente.Habilitado = data.BoolValue("habilitado");

            return cliente;
        }


        public void Update()
        {
            DataBase.GetInstance()
                .TypedQuery(@" update COMPUMUNDOHIPERMEGARED.Cliente
                    set cuil = @cuil, tipo_documento = @tipoDocumento, nro_documento = @nroDocumento,
                    nombre = @nombre, apellido = @apellido, mail = @mail, telefono = @telefono,
                    ciudad = @ciudad, localidad = @localidad, dom_calle = @domCalle, num_calle = @nroCalle,
                    depto = @depto, piso = @piso, cod_postal = @codPostal, fecha_nacimiento = @fechaNacimiento,
                    fecha_creacion = @fechaCreacion, habilitado = @habilitado
                    where id_cliente = @id"
                , new QueryParameter("cuil", SqlDbType.NVarChar, cuil)
                , new QueryParameter("tipoDocumento", SqlDbType.Char, tipoDocumento.discriminator)
                , new QueryParameter("nroDocumento", SqlDbType.NVarChar, nroDocumento)
                , new QueryParameter("nombre", SqlDbType.NVarChar, nombre)
                , new QueryParameter("apellido", SqlDbType.NVarChar, apellido)
                , new QueryParameter("mail", SqlDbType.NVarChar, mail)
                , new QueryParameter("telefono", SqlDbType.NVarChar, telefono)
                , new QueryParameter("ciudad", SqlDbType.NVarChar, ciudad)
                , new QueryParameter("localidad", SqlDbType.NVarChar, localidad)
                , new QueryParameter("domCalle", SqlDbType.NVarChar, domCalle)
                , new QueryParameter("nroCalle", SqlDbType.NVarChar, nroCalle)
                , new QueryParameter("depto", SqlDbType.NVarChar, depto)
                , new QueryParameter("piso", SqlDbType.Decimal, piso)
                , new QueryParameter("codPostal", SqlDbType.NVarChar, codPostal)
                , new QueryParameter("fechaNacimiento", SqlDbType.DateTime, fechaNacimiento)
                , new QueryParameter("fechaCreacion", SqlDbType.DateTime, fechaCreacion)
                , new QueryParameter("habilitado", SqlDbType.Bit, Habilitado ? 1 : 0)
                , new QueryParameter("id", SqlDbType.Int, id));

        }
    }
}
