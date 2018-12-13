using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Validadores
{
    class UserInputException: Exception
    {
        public UserInputException(string msg) : base(msg) { }
        public UserInputException() : base() { }
    }
}
