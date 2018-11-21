using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.PublicacionesUtils
{
    class Estados
    {
        private static List<Estado> todos  = null;

        public static List<Estado> Todos()
        {
            if (todos == null)
            {
                todos = new List<Estado> { new Borrador(), new Publicado(), new Finalizado(), new Indefinido() };
            }
            return todos;
        }

        public static Estado Parse(char cod)
        {
            return Todos().Find(e => e.Codigo().Equals(cod));
        }
    }
}
