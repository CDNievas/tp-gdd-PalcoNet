using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.DataBasePackage
{
    class NullableInParameter: ParametroIn
    {
        public NullableInParameter(String nombre, Object valor) : base(nombre, valor ?? (Object)DBNull.Value) { }
    }
}
