using PalcoNet.Abm_Rol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.LoginUtils
{
    class Usuario
    {
        public int id { get; set; }
        public String username {get; set;}
        public String password { get; set; }
        public String hashPassword { get; set; }
        public short intentos { get; set; }
        public Boolean habilitado { get; set; }
        public Boolean eliminado { get; set; }
        public Rol rol;

        public Usuario(String username, String password, Rol rol) {
            this.username = username;
            this.password = password;
            this.rol = rol;
        }

        public void Persistite() {
            DataBase.GetInstance().procedure("crear_nuevo_usuario",
                new Parametro("username", this.username),
                new Parametro("password", this.password),
                new Parametro("rol_id", rol.id));
        }
    }
}
