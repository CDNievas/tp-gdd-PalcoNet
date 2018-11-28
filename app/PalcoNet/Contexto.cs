using PalcoNet.Abm_Empresa_Espectaculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet
{
    public static class Contexto
    {
        public static int? idUsuarioLogueado = null;

        public static readonly DateTime FechaActual = DateTime.Now; // todo deberia caragarlo del archiov config

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
    }
}
