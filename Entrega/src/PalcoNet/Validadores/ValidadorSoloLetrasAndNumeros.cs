using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Validadores
{
    class ValidadorSoloLetrasAndNumeros
    {


        public Boolean IsValid(String s)
        {
            return s.All(c => Char.IsNumber(c) || Char.IsLetter(c) || Char.IsSeparator(c) || Char.IsControl(c) || Char.IsWhiteSpace(c));
        }

        public void soloLetrasAndNumeros(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                //MessageBox.Show("Solo letras y/o numeros");
            }
        }
    }
}
