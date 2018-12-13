using PalcoNet.Abm_Cliente;
using PalcoNet.Abm_Empresa_Espectaculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Globalization;

namespace PalcoNet
{
    public static class Contexto
    {
        public static int? idUsuarioLogueado = null;

        public static readonly DateTime FechaActual = DateTime.ParseExact(ConfigurationManager.AppSettings["System_DateTime"], "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        public static long GetEmpresaLogeadaId()
        {
            return EmpresaLogeada.id;
        }

        private static Empresa empresaLogeada = null;
        public static Empresa EmpresaLogeada
        {
            get
            {
                if (empresaLogeada == null)
                    empresaLogeada = new BuscadorEmpresas().FindEmpresaByUsuarioId((int)idUsuarioLogueado);
                return empresaLogeada;
            }
            set{
                empresaLogeada = value;
            }
        }

        private static Cliente clienteLogeado = null;
        public static Cliente ClienteLogeado
        {
            get
            {
                if (clienteLogeado == null)
                    clienteLogeado = Cliente.FindByUserId((int) idUsuarioLogueado);
                return clienteLogeado;
            }
            set
            {
                clienteLogeado = value;
            }
        }

    }
}
