using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Validadores
{
    class ValidadorNumerico: Validador
    {
        override public Boolean IsValid(String s)
        {
            int myInt;
            bool isNumerical = int.TryParse(s, out myInt);
            return isNumerical;
        }
    }
}
