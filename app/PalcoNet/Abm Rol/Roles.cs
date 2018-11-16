using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Abm_Rol
{
    class Roles
    {
        public static List<Rol> traerTodos(){
            String sql = "select * from COMPUMUNDOHIPERMEGARED.Rol";
            var dt = DataBase.GetInstance().query(sql);
            var roles = new List<Rol>();
            foreach (DataRow dr in dt.Rows) {
                roles.Add(Rol.traerDe(dr));
            }
            return roles;
        }
    }
}
