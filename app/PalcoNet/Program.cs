using PalcoNet.Abm_Cliente;
using PalcoNet.Abm_Rol;
using PalcoNet.LoginUtils;
using PalcoNet.Registro_de_Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {   
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            

            
            /*
            Cliente cliente = new Cliente();
            cliente.cuil = "dfsadfa";
            cliente.tipoDocumento = 'D';
            cliente.nroDocumento = "45654";
            cliente.nombre = "martin";
            cliente.apellido = "mallea";
            cliente.mail = "dfsa";
            cliente.telefono = "4605";
            cliente.ciudad = "";
            cliente.localidad = "dfsa";
            cliente.domCalle = "dsfdfsa";
            cliente.nroCalle = "12";
            cliente.depto = "dfsa";
            cliente.piso = 21;
            cliente.codPostal = "!··";
            cliente.fechaCreacion = DateTime.Now;
            cliente.fechaNacimiento = DateTime.Now;

            CreadorDeUsuarios.CrearNuevoCliente(cliente, "mnmallea", "1234", 1);*/
        }
    }
}
