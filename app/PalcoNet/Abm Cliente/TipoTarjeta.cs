using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Abm_Cliente
{
    public abstract class TipoTarjeta
    {
        abstract public char discriminator { get; }
        public static TipoTarjeta Parse(char c)
        {
            switch (c)
            {
                case 'V':
                    return new Visa();
                case 'M':
                    return new Mastercard();
                case 'A':
                    return new AmericanExpress();
                default:
                    throw new Exception();
            }
        }

        public static List<TipoTarjeta> Todos()
        {
            return new List<TipoTarjeta> { new Visa(), new Mastercard(), new AmericanExpress() };
        }

        public override bool Equals(object obj)
        {
            if (obj is TipoTarjeta)
                return ((TipoTarjeta)obj).discriminator.Equals(this.discriminator);
            else
                return false;
        }

        public override int GetHashCode()
        {
            return discriminator.GetHashCode();
        }

        public class Visa : TipoTarjeta
        {
            override public char discriminator { get { return 'V'; } }

            public override string ToString()
            {
                return "Visa";
            }
        }


        public class Mastercard : TipoTarjeta
        {
            override public char discriminator { get { return 'M'; } }

            public override string ToString()
            {
                return "Mastercard";
            }
        }


        public class AmericanExpress : TipoTarjeta
        {
            override public char discriminator { get { return 'A'; } }

            public override string ToString()
            {
                return "American Express";
            }
        }

    }
}
