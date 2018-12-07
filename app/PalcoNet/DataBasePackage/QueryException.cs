using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalcoNet.DataBasePackage
{
    public class QueryException : Exception
    {
        public QueryException(String msg, Exception ex) : base(msg, ex) { }
    }
}
