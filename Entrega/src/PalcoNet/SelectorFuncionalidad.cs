using PalcoNet.Abm_Empresa_Espectaculo;
using PalcoNet.Listado_Estadistico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                case 6: //Crear publicacion
                    new Editar_Publicacion.EditarPublicacion(new Editar_Publicacion.FuncionCrearPublicacion()).ShowDialog();
                    break;
                case 7:
                    Empresa empresa;
                    try
                    {
                        empresa = Contexto.EmpresaLogeada;
                        var id = empresa.id;
                    }
                    catch {
                        MessageBox.Show("Seleccione una empresa", "Empresa", MessageBoxButtons.OK);
                        var form = new SeleccionEmpresa();
                        var result = form.ShowDialog();
                        if (result != DialogResult.OK)
                            return;
                        empresa = form.empresa;
                    }
                    new Editar_Publicacion.ListarPublicacion(empresa).ShowDialog();
                    break;
                case 8:
                    new FuncionalidadComprar().Ejecutarse();
                    break;
                case 9:
                    new FuncionalidadHistorialCliente().Ejecutarse();
                    break;
                case 10:
                    new FuncionalidadPuntos().Ejecutarse();
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
