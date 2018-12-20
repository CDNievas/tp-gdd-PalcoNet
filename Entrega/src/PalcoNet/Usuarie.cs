using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet
{
    public class Usuarie
    {
        private int id;
        private bool habilitado;
        private bool eliminado;

        public Boolean Habilitado
        {
            get
            {
                return this.habilitado;
            }
        }

        public Usuarie(int id, bool habilitado, bool eliminado)
        {
            this.id = id;
            this.habilitado = habilitado;
            this.eliminado = eliminado;
        }

        public void Habilitar()
        {
            DataBase.GetInstance()
                .Query(
                String.Format(@"update COMPUMUNDOHIPERMEGARED.Usuario
                                set habilitado = 1
                                where id_usuario = {0}"
                , this.id)); 
        }

        public void CambiarEstadoEliminacion()
        {
            var nuevoEstado = !this.eliminado;
            DataBase.GetInstance()
                .Query(
                String.Format(@"update COMPUMUNDOHIPERMEGARED.Usuario
                                set eliminado = {0}
                                where id_usuario = {1}"
                , nuevoEstado ? 1 : 0, this.id)); 
        }
    }
}
