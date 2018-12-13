using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalcoNet.Comprar
{
    public class CompraException : Exception
    {
        public CompraException(String msg, Exception inner) : base(msg, inner) { }
    }
}
