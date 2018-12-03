using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Cliente
{
    public interface FuncionFormTarjeta
    {
        void Guardar(altaTarjeta form, Tarjeta tarjeta);
        void Setup(altaTarjeta form);
    }

    public class AltaTarjeta : FuncionFormTarjeta
    {
        public void Guardar(altaTarjeta form, Tarjeta tarjeta)
        {
            throw new NotImplementedException();
        }

        public void Setup(altaTarjeta form)
        {
            // No hace nada
        }
    }

    public class RegistrarTarjeta : FuncionFormTarjeta
    {
        public void Guardar(altaTarjeta form, Tarjeta tarjeta)
        {
            form.TarjetaActual = tarjeta;
            form.DialogResult = DialogResult.OK;
            form.Close();
        }

        public void Setup(altaTarjeta form)
        {
            // No hace nada
        }

    }

}
