using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalcoNet.PublicacionesUtils
{
    public class RangoFechas
    {
        public RangoFechas(DateTime inicio, DateTime fin)
        {
            this.inicio = inicio;
            this.fin = fin;
        }
        public DateTime inicio { get; set; }
        public DateTime fin {get; set;}

        public Boolean EstaDentroDelRango(DateTime otra)
        {
            return otra >= inicio && otra <= fin;
        }




    }
}
