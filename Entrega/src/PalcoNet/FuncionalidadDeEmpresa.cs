using PalcoNet.Abm_Cliente;
using PalcoNet.Abm_Empresa_Espectaculo;
using PalcoNet.Abm_Rol;
using PalcoNet.Listado_Estadistico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet
{
    public abstract class FuncionalidadDeEmpresa
    {
        public void Ejecutarse()
        {
            var usuarioId = (int)Contexto.idUsuarioLogueado;

            Empresa empresa;
            if (Roles.RolesDeUsuario(usuarioId).Any(rol => rol.EsEmpresa()))
            {
                try
                {
                    if (!Contexto.EmpresaLogeada.Habilitado)
                    {
                        MessageBox.Show("Esta empresa no está habilitada para realizar funcionalidades de empresa");
                        return;
                    }
                    empresa = Contexto.EmpresaLogeada;
                }
                catch
                {//todo pensar algo mejor que esto
                    MessageBox.Show("Seleccione una empresa", "Empresa", MessageBoxButtons.OK);
                    var form = new SeleccionEmpresa();
                    DialogResult result = form.ShowDialog();
                    if (result != DialogResult.OK)
                        return;
                    empresa = form.empresa;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una empresa", "Empresa", MessageBoxButtons.OK);
                var form = new SeleccionEmpresa();
                DialogResult result = form.ShowDialog();
                if (result != DialogResult.OK)
                    return;
                empresa = form.empresa;
            }
            this.RealizarFuncionalidad(empresa);
        }

        public abstract void RealizarFuncionalidad(Empresa empresa);
    }

    public class FuncionalidadListarPublicacion : FuncionalidadDeEmpresa
    {
        public override void RealizarFuncionalidad(Empresa empresa)
        {
            new Editar_Publicacion.ListarPublicacion(empresa).ShowDialog();
        }
    }

    public class FuncionalidadCrearPublicacion : FuncionalidadDeEmpresa
    {
        public override void RealizarFuncionalidad(Empresa empresa)
        {
            new Editar_Publicacion.EditarPublicacion(new Editar_Publicacion.FuncionCrearPublicacion(), empresa)
                .ShowDialog();
        }
    }
}
