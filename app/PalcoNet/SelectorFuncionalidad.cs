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
                    new Abm_Rol.ListadoRol().ShowDialog();
                    break;
                case 2:
                    new Abm_Cliente.ListarCliente().ShowDialog();
                    break;
                case 3:
                    new Abm_Empresa_Espectaculo.ListarEmpresa().ShowDialog();
                    break;
                case 4:
                    new Abm_Rubro.Form1().ShowDialog();
                    break;
                case 5:
                    new Abm_Grado.ListarGrado().ShowDialog();
                    break;
                case 6:
                    new Editar_Publicacion.EditarPublicacion(new Editar_Publicacion.FuncionCrearPublicacion()).ShowDialog();
                    break;
                case 7:
                    new Editar_Publicacion.ListarPublicacion().ShowDialog();
                    break;
                case 8:
                    new Comprar.Comprar().ShowDialog();
                    break;
                case 9:
                    throw new NotImplementedException("Historial cliente");
                    break;
                case 10:
                    new Canje_Puntos.ConsultaPuntos().ShowDialog();
                    break;
                case 11:
                    throw new NotImplementedException("Rendición comisiones");
                    break;
                case 12:
                    new Listado_Estadistico.ObtenerTop5().ShowDialog();
                    break;
            }
        }

    }
}
