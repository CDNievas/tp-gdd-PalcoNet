using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Validadores
{
    public abstract class Validador
    {
        public abstract Boolean IsValid(String s);

        public Boolean IsInvalid(String s)
        {
            return !IsValid(s);
        }
    }
}
