using PalcoNet.Abm_Cliente;
using PalcoNet.Abm_Empresa_Espectaculo;
using PalcoNet.DataBasePackage;
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
            DataBase.GetInstance().Procedure("crear_usuario_cliente",
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
                new NullableInParameter("depto", cliente.depto),
                new NullableInParameter("piso", cliente.piso),
                new ParametroIn("cod_postal", cliente.codPostal),
                new ParametroIn("fecha_nacimiento", cliente.fechaNacimiento),
                new ParametroIn("fecha_creacion", cliente.fechaCreacion),
                new ParametroIn("rol_id", rolID),
                new ParametroIn("username", username),
                new ParametroIn("pass", pass));
        }

        public static void CrearNuevaEmpresa(Empresa empresa, String username, String pass, int rolId)
        {
            DataBase.GetInstance().Procedure("crear_usuario_empresa",
                new ParametroIn("cuit", empresa.cuit),
                new ParametroIn("razon_social", empresa.razonSocial),
                new ParametroIn("mail", empresa.mail),
                new ParametroIn("telefono", empresa.telefono),
                new ParametroIn("ciudad", empresa.ciudad),
                new ParametroIn("localidad", empresa.localidad),
                new ParametroIn("dom_calle", empresa.domCalle),
                new ParametroIn("nro_calle", empresa.nroCalle),
                new NullableInParameter("piso", empresa.piso),
                new NullableInParameter("depto", empresa.depto),
                new ParametroIn("cod_postal", empresa.codPostal),
                new ParametroIn("fecha_creacion", empresa.fechaCreacion),
                new ParametroIn("rol_id", rolId),
                new ParametroIn("pass", pass),
                new ParametroIn("username", username));
        }
    }

}
