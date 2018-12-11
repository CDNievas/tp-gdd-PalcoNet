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
                    new Abm_Rol.ListadoRol().Show();
                    break;
                case 2:
                    new Abm_Cliente.ListarCliente().Show();
                    break;
                case 3:
                    new Abm_Empresa_Espectaculo.ListarEmpresa().Show();
                    break;
                case 4:
                    new Abm_Rubro.Form1().Show();
                    break;
                case 5:
                    new Abm_Grado.ListarGrado().Show();
                    break;
                case 6:
                    new Editar_Publicacion.EditarPublicacion(new Editar_Publicacion.FuncionCrearPublicacion()).Show();
                    break;
                case 7:
                    new Editar_Publicacion.ListarPublicacion().Show();
                    break;
                case 8:
                    new Comprar.Comprar().Show();
                    break;
                case 9:
                    throw new NotImplementedException("Historial cliente");
                    break;
                case 10:
                    new Canje_Puntos.ConsultaPuntos().Show();
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
