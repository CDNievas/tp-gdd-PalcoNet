using PalcoNet.LoginUtils;
using PalcoNet.Registro_de_Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PalcoNet.Abm_Empresa_Espectaculo
{
    public interface FuncionFormEmpresa
    {
        void Setup(AltaEmpresaForm form);
        void Guardar(AltaEmpresaForm form, Empresa empresa);
    }

    public class Modificacion : FuncionFormEmpresa
    {
        private Empresa empresa;

        public Modificacion(Empresa empresa)
        {
            this.empresa = empresa;
        }

        public void Setup(AltaEmpresaForm form)
        {
            form.Text = "Modificación de empresa";
            form.Titulo = "Modificar empresa";
            form.CheckHabilitado.Visible = true;
            form.LlenateCon(empresa);
        }

        public void Guardar(AltaEmpresaForm form, Empresa empresa)
        {
            Console.WriteLine("Updating empresa con ID " + empresa.id);
            empresa.Habilitado = form.CheckHabilitado.Checked;
            empresa.Update();
            form.Close();
        }
    }

    public class Registro : FuncionFormEmpresa
    {

        public void Setup(AltaEmpresaForm form)
        {
            form.Text = "Registro de Empresa";
            form.Titulo = "Registrar empresa";
            form.CheckHabilitado.Visible = false;
        }

        public void Guardar(AltaEmpresaForm form, Empresa empresa)
        {
            form.DialogResult = DialogResult.OK;
            form.Close();
        }
    }

    public class AltaEmpresa : FuncionFormEmpresa
    {
        public void Setup(AltaEmpresaForm form)
        {
            form.Text = "Alta de Empresa";
            form.Titulo = "Nueva empresa";
            form.CheckHabilitado.Visible = false;
        }

        public void Guardar(AltaEmpresaForm form, Empresa empresa)
        {
            DialogResult dialogResult = MessageBox.Show("Al dar de alta la empresa autogenerará un usuario para la misma. ¿Desea continuar?",
                "Solicitud de confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var user = empresa.cuit;
                var pass = PassGenerator.CreateRandomPassword(20);
                CreadorDeUsuarios.CrearNuevaEmpresa(empresa, user, pass, true);
                form.Close();
                new UsuarioPassForm(user, pass).ShowDialog();
                
            }
            
        }
    }
}
