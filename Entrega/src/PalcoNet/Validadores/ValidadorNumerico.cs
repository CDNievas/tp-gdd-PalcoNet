using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PalcoNet.Validadores
{
    class ValidadorNumerico: Validador
    {
        override public Boolean IsValid(String s)
        {
            String pattern = @"^[0-9][0-9]*$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(s);
        }

        public void soloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
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
                //MessageBox.Show("Solo números");
            }
        }
    }
}
