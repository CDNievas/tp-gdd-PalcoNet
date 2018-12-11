using PalcoNet.Abm_Rol;
using PalcoNet.LoginUtils;
using PalcoNet.Registro_de_Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Cliente
{
    public interface FuncionFormCliente
    {
        void Guardar(AltaCliente form, Cliente cliente);
        void Setup(AltaCliente form);
    }

    public class Alta : FuncionFormCliente
    {
        public void Guardar(AltaCliente form, Cliente cliente)
        {
            DialogResult dialogResult = MessageBox.Show("Al crear este cliente autogenerará su usuario y contraseña. ¿Desea continuar?",
                "Solicitud de confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var user = cliente.nroDocumento;
                var password = PassGenerator.CreateRandomPassword(20);
                DataBase.GetInstance().WithTransaction(() =>
                {
                    var idCliente = CreadorDeUsuarios.CrearNuevoCliente(cliente, user, password, true);
                    form.tarjetaAGuardar.SerAsignadaA(idCliente);
                });
                form.Close();
                new UsuarioPassForm(user, password).ShowDialog();
            }
        }

        public void Setup(AltaCliente form)
        {
            form.CheckHabilitado.Visible = false;
            form.Text = "Alta de cliente";
            form.Titulo = "Nuevo Cliente";
            form.DebeGuardarTarjeta = true;
            form.tarjetaAGuardar = null;
        }
    }

    public class Modificar : FuncionFormCliente
    {
        private Cliente cliente;

        public Modificar(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public void Guardar(AltaCliente form, Cliente cliente)
        {
            DataBase.GetInstance().WithTransaction(() =>
            {
                cliente.Habilitado = form.CheckHabilitado.Checked;
                cliente.Update();
                if (form.DebeGuardarTarjeta)
                    form.tarjetaAGuardar.SerAsignadaA((int)cliente.id);
            });
            form.Close();
            MessageBox.Show(String.Format("El cliente {0} {1} ha sido actualizado", cliente.nombre, cliente.apellido),
                    "Cliente actualizado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Setup(AltaCliente form)
        {
            form.Text = "Modifición de cliente";
            form.Titulo = "Modificar Cliente";
            form.CheckHabilitado.Visible = true;
            form.LlenateConDatosDe(cliente);
            form.DebeGuardarTarjeta = false;
            form.tarjetaAGuardar = cliente.GetTarjeta();
        }
    }

    public class Registrarse : FuncionFormCliente
    {
        public void Guardar(AltaCliente form, Cliente cliente)
        {
            form.ClienteActual = cliente;
            form.DialogResult = DialogResult.OK;
            form.Close();
        }

        public void Setup(AltaCliente form)
        {
            form.CheckHabilitado.Visible = false;
            form.Text = "Registro de cliente";
            form.Titulo = "Registrarse";
            form.DebeGuardarTarjeta = true;
            form.tarjetaAGuardar = null;
        }

    }

}
