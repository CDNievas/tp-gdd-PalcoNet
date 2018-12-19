using PalcoNet.DataBasePackage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Abm_Rol
{
    public class Roles
    {
        public static List<Rol> TraerTodos(){
            String sql = "select * from COMPUMUNDOHIPERMEGARED.Rol";
            var dt = DataBase.GetInstance().Query(sql);
            var roles = new List<Rol>();
            foreach (DataRow dr in dt.Rows) {
                roles.Add(Rol.TraerDe(dr));
            }
            return roles;
        }

        public static List<Rol> BuscarPorNombre(String nombre)
        {
            var parametros = new List<QueryParameter>();
            var query = "select * from COMPUMUNDOHIPERMEGARED.Rol ";
            if (nombre != null && !String.IsNullOrWhiteSpace(nombre))
            {
                query += " where nombre like @descParam ";
                parametros.Add(new QueryParameter("descParam", SqlDbType.NVarChar,
                    String.Format("%{0}%", nombre)));
            }
            var dt = DataBase.GetInstance().TypedQuery(query, parametros.ToArray());
            var roles = new List<Rol>();
            foreach (DataRow dr in dt.Rows) {
                roles.Add(Rol.TraerDe(dr));
            }
            return roles;
        
        }

        public static List<Rol> RolesDeUsuario(int idUsuario)
        {
            var dt = DataBase.GetInstance()
                .TypedQuery(@"
                select r.* from COMPUMUNDOHIPERMEGARED.Rol_Usuario ru
                inner join COMPUMUNDOHIPERMEGARED.Rol r on r.id_rol = ru.rol_id
                and ru.usuario_id = @usuarioId and ru.eliminado = 0", new QueryParameter("usuarioId", SqlDbType.Int, idUsuario));
            var roles = new List<Rol>();
            foreach (DataRow dr in dt.Rows)
            {
                roles.Add(Rol.TraerDe(dr));
            }
            return roles;
        }

        public static Rol Cliente
        {
            get
            {
                return RolByName("CLIENTE");
            }
        }

        public static Rol Administrador
        {
            get
            {
                return RolByName("ADMINISTRADOR");
            }
        }

        public static Rol Empresa
        {
            get
            {
                return RolByName("EMPRESA");
            }
        }

        private static Rol RolByName(string p)
        {
            String sql = String.Format("select * from COMPUMUNDOHIPERMEGARED.Rol where nombre like '{0}'",p);
            var dt = DataBase.GetInstance().Query(sql);
            return Rol.TraerDe(dt.Rows[0]);
        }

    }
}
