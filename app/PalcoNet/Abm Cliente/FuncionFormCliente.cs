using PalcoNet.Abm_Rol;
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
                CreadorDeUsuarios.CrearNuevoCliente(cliente, cliente.nroDocumento, cliente.nroDocumento, true);
                form.Close();
            }
        }

        public void Setup(AltaCliente form)
        {
            form.Text = "Alta de cliente";
            form.Titulo = "Nuevo Cliente";
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
            cliente.Update();   
            form.Close();
        }

        public void Setup(AltaCliente form)
        {
            form.Text = "Modifición de cliente";
            form.Titulo = "Modificar Cliente";
            form.LlenateConDatosDe(cliente);
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
            form.Text = "Registro de cliente";
            form.Titulo = "Registrarse";
        }

    }

}
