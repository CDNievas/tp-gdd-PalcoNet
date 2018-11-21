using PalcoNet.Abm_Rol;
using PalcoNet.LoginUtils;
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
            /*
            var rol = Roles.traerTodos().Find(r => r.nombre.Equals("ADMINISTRADOR"));

            new Usuario("tincho", "ziracusa", rol).Persistite();
            */
            try
            {
                ValidadorLogin.ValidarLogin("tincho", "cualquier cosas");
            }
            catch (ProcedureException ex) {
                Console.WriteLine(ex.InnerException.Message);
            }
            

            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new logIn());
            */
        }
    }
}
