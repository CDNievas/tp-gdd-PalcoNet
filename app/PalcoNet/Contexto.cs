using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet
{
    static class Contexto
    {
        public static int? idUsuarioLogueado = null;

        public static readonly DateTime FechaActual = DateTime.Now; // todo deberia caragarlo del archiov config
    }
}
