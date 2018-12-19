using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PalcoNet.Validadores
{
    public class ValidadorCuil : Validador
    {
        public override Boolean IsValid(String s)
        {
            string pattern = "^[0-9]{2}-[0-9]{8}-[0-9]$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(s);
        }
    }
}
