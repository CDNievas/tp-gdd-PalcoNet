using PalcoNet.DataBasePackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.LoginUtils
{
    class ValidadorLogin
    {
        // tira excepción si el login es incorrecto
        public static int ValidarLogin(String username, String password){
            var output = new ParametroOut("id_usuario", SqlDbType.Int);
            DataBase.GetInstance().procedure("intentar_logear",
                new ParametroIn("username", username),
                new ParametroIn("password", password),
                output);
            Console.WriteLine(output.valorRetorno.ToString());
            return Convert.ToInt32(output.valorRetorno.ToString());
        }
    }
}
