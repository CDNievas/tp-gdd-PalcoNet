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
            var rol = Roles.traerTodos().Find(r => r.nombre.Equals("SuperAdministrador"));
            List<Funcionalidad> funcionalidades = Funcionalidades.TraerTodas().Take(3).ToList<Funcionalidad>();
            rol.funcionalidades = funcionalidades;
            rol.Update();
            
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new logIn());
            */
        }
    }
}
