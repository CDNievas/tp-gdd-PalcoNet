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
        void Guardar(AltaClienteForm form, Cliente cliente);
        void Setup(AltaClienteForm form);
    }

    public class Alta : FuncionFormCliente
    {
        public void Guardar(AltaClienteForm form, Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Setup(AltaClienteForm form)
        {
            // No hace nada
        }
    }

    public class Modificar : FuncionFormCliente
    {
        private Cliente cliente;

        public Modificar(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public void Guardar(AltaClienteForm form, Cliente cliente)
        {
            cliente.Update();   
            form.Close();
        }

        public void Setup(AltaClienteForm form)
        {
            form.LlenateConDatosDe(cliente);
        }
    }

    public class Registrarse : FuncionFormCliente
    {
        public void Guardar(AltaClienteForm form, Cliente cliente)
        {
            form.ClienteActual = cliente;
            form.DialogResult = DialogResult.OK;
            form.Close();
        }

        public void Setup(AltaClienteForm form)
        {
            // No hace nada
        }

    }

}
