using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
    }
}
