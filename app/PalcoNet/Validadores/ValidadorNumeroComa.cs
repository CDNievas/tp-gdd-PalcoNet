using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PalcoNet.Validadores
{
    public class ValidadorNumeroComa : Validador
    {
        private int cantidadDecimales;

        public ValidadorNumeroComa(int cantidadDecimales)
        {
            this.cantidadDecimales = cantidadDecimales;
        }

        public override Boolean IsValid(String s)
        {
            NumberFormatInfo nfi = NumberFormatInfo.CurrentInfo;
            string pattern = @"^[0-9]*";
            pattern += Regex.Escape(nfi.CurrencyDecimalSeparator);
            pattern += "[0-9]{" + cantidadDecimales + "}$";
            Console.WriteLine(pattern);
            Regex regex = new Regex(pattern);
            return regex.IsMatch(s);
        }
    }
}
