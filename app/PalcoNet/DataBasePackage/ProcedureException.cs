using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet
{
    class ProcedureException : Exception
    {
        public ProcedureException(string msg, Exception e) : base(msg, e) { }
    }
}
