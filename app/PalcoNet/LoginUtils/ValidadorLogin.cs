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
    public class ValidadorLogin
    {
        // tira excepción si el login es incorrecto
        public static int ValidarLogin(String username, String password){
            Console.WriteLine(String.Format("User: {0}, Pass: {1}", username, password));
            var output = new ParametroOut("id_usuario", SqlDbType.Int);
            DataBase.GetInstance().Procedure("intentar_logear",
                new ParametroIn("username", username),
                new ParametroIn("password", password),
                output);
            Console.WriteLine(output.valorRetorno.ToString());
            return Convert.ToInt32(output.valorRetorno.ToString());
        }

        public static Boolean EstaDisponible(String username)
        {
            var sql = String.Format(@"select 1 from COMPUMUNDOHIPERMEGARED.Usuario where username = '{0}'", username);
            var dt = DataBase.GetInstance().Query(sql);
            return dt.Rows.Count == 0;
        }
    }
}
