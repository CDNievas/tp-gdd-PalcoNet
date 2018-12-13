using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Validadores
{
    public class ValidadorSinIncluir : Validador
    {
        private char[] noAdmitidos;

        public ValidadorSinIncluir(char[] noAdmitidos)
        {
            this.noAdmitidos = noAdmitidos;
        }

        public override Boolean IsValid(String s)
        {
            return noAdmitidos.ToList().Any(c => s.Contains(c));
        }

        public ValidadorSinIncluir SinComilla
        {
            get
            {
                return new ValidadorSinIncluir(new char[] { '\'' });
            }
        }
    }
}
