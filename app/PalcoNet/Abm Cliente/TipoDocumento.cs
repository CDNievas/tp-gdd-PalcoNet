using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Abm_Cliente
{
    public abstract class TipoDocumento
    {
        abstract public char discriminator {get;}
        public static TipoDocumento Parse(char c)
        {
            switch (c)
            {
                case 'D':
                    return new DNI();
                case 'C':
                    return new LC();
                case 'E':
                    return new LE();
                default:
                    throw new Exception();
            }
        }

        public static List<TipoDocumento> Todos(){
            return new List<TipoDocumento> { new DNI(), new LC(), new LE() };
        }

        public override bool Equals(object obj)
        {
         	 if(obj is TipoDocumento)
                 return ((TipoDocumento)obj).discriminator.Equals(this.discriminator);
             else
                 return false;
        }

        public override int GetHashCode()
        {
 	         return discriminator.GetHashCode();
        }

        public class DNI : TipoDocumento
        {
            override public char discriminator {get{return 'D';}}

            public override string ToString()
            {
                return "DNI";
            }
        }


        public class LC : TipoDocumento
        {
            override public char discriminator {get{return 'C';}}

            public override string ToString()
            {
                return "LC";
            }
        }


        public class LE : TipoDocumento
        {
            override public char discriminator {get{return 'E';}}

            public override string ToString()
            {
                return "LE";
            }
        }

    }
}
