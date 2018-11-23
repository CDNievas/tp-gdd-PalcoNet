using PalcoNet.Registro_de_Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Cliente
{
    public interface LlamadoDesde
    {
        void apply(AltaClienteForm form, Cliente cliente);
    }

    public class DesdeABMCliente : LlamadoDesde
    {
        public void apply(AltaClienteForm form, Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }

    public class DesdeRegistro : LlamadoDesde
    {
        public void apply(AltaClienteForm form, Cliente cliente)
        {
            form.Cliente = cliente;
            form.DialogResult = DialogResult.OK;
            form.Close();
        }
    }

}
