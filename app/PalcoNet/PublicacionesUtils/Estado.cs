using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalcoNet.PublicacionesUtils
{
    abstract class Estado
    {
        public abstract String Name();
        public abstract char Codigo();
        public override bool Equals(object obj)
        {
            if (!(obj is Estado))
                return false;
            return ((Estado)obj).Codigo().Equals(this.Codigo());
        }

        public override int GetHashCode()
        {
            return this.Codigo().GetHashCode();
        }

        public override string ToString()
        {
            return this.Name();
        }
    }

    class Borrador : Estado
    {
        public override String Name()
        {
            return "Borrador";
        }

        public override char Codigo()
        {
            return 'B';
        }

        
    }

    class Publicado : Estado
    {
        public override String Name()
        {
            return "Publicado";
        }

        public override char Codigo()
        {
            return 'P';
        }
    }
    class Finalizado : Estado
    {
        public override String Name()
        {
            return "Finalizado";
        }

        public override char Codigo()
        {
            return 'F';
        }
    }

    class Indefinido : Estado
    {
        public override String Name()
        {
            return "Indefinido";
        }

        public override char Codigo()
        {
            return 'U';
        }
    }
}
