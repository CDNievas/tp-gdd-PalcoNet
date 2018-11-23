using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet
{
    class SelectorFuncionalidad
    {

        public static void EjecutarFuncionalidad(short idFuncionalidad)
        {
            switch (idFuncionalidad)
            {
                case 1:
                    throw new NotImplementedException("ABM ROL");
                    break;
                case 2:
                    throw new NotImplementedException("ABM Clientes");
                    break;
                case 3:
                    throw new NotImplementedException("ABM Empresa Espectáculos");
                    break;
                case 4:
                    throw new NotImplementedException("ABM Rubro");
                    break;
                case 5:
                    throw new NotImplementedException("ABM Grado Publicación");
                    break;
                case 6:
                    throw new NotImplementedException("Generar Publicación");
                    break;
                case 7:
                    throw new NotImplementedException("Editar Publiación");
                    break;
                case 8:
                    throw new NotImplementedException("Comprar");
                    break;
                case 9:
                    throw new NotImplementedException("Historial cliente");
                    break;
                case 10:
                    throw new NotImplementedException("Puntos cliente");
                    break;
                case 11:
                    throw new NotImplementedException("Rendición comisiones");
                    break;
                case 12:
                    throw new NotImplementedException("Listado Estadístico");
                    break;
            }
        }

    }
}
