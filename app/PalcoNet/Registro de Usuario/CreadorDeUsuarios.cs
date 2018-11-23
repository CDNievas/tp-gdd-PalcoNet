using PalcoNet.Abm_Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Registro_de_Usuario
{
    class CreadorDeUsuarios
    {
        public static void CrearNuevoCliente(Cliente cliente, String username, String pass, int rolID){
            DataBase.GetInstance().procedure("crear_usuario",
                new ParametroIn("cuil", cliente.cuil),
                new ParametroIn("tipo_doc", cliente.tipoDocumento.discriminator),
                new ParametroIn("nro_documento", cliente.nroDocumento),
                new ParametroIn("nombre", cliente.nombre),
                new ParametroIn("apellido", cliente.apellido),
                new ParametroIn("mail", cliente.mail),
                new ParametroIn("telefono", Convert.ToInt64(cliente.telefono)),
                new ParametroIn("ciudad", cliente.ciudad),
                new ParametroIn("localidad", cliente.localidad),
                new ParametroIn("dom_calle", cliente.domCalle),
                new ParametroIn("num_calle", cliente.nroCalle),
                new ParametroIn("depto", cliente.depto),
                new ParametroIn("piso", cliente.piso),
                new ParametroIn("cod_postal", cliente.codPostal),
                new ParametroIn("fecha_nacimiento", cliente.fechaNacimiento),
                new ParametroIn("fecha_creacion", cliente.fechaCreacion),
                new ParametroIn("rol_id", rolID),
                new ParametroIn("username", username),
                new ParametroIn("pass", pass));
        }
    }
}
