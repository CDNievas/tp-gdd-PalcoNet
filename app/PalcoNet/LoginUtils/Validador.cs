using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.LoginUtils
{
    class ValidadorLogin
    {
        // tira excepción si el login es incorrecto
        public static void ValidarLogin(String username, String password){
            DataBase.GetInstance().procedure("intentar_logear",
                new Parametro("username", username),
                new Parametro("password", password));
        }
    }
}
