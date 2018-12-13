using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalcoNet.PublicacionesUtils
{
    public abstract class Estado
    {
        public abstract String Name();
        public abstract String Codigo();
        public override bool Equals(object obj)
        {
            if (!(obj is Estado))
                return false;
            return ((Estado)obj).Codigo().Equals(this.Codigo());
        }

        public abstract bool PuedeModificarse();

        public override int GetHashCode()
        {
            return this.Codigo().GetHashCode();
        }

        public override string ToString()
        {
            return this.Name();
        }
    }

    public class Borrador : Estado
    {
        public override String Name()
        {
            return "Borrador";
        }

        public override String Codigo()
        {
            return "B";
        }

        public override bool PuedeModificarse()
        {
            return true;
        }
    }

    public class Publicado : Estado
    {
        public override String Name()
        {
            return "Publicada";
        }

        public override String Codigo()
        {
            return "P";
        }

        public override bool PuedeModificarse()
        {
            return false;
        }
    }
    public class Finalizado : Estado
    {
        public override String Name()
        {
            return "Finalizada";
        }

        public override String Codigo()
        {
            return "F";
        }

        public override bool PuedeModificarse()
        {
            return false;
        }
    }
}
