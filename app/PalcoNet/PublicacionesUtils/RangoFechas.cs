using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalcoNet.PublicacionesUtils
{
    class RangoFechas
    {
        public RangoFechas(DateTime dateTime1, DateTime dateTime2)
        {
            this.inicio= dateTime1;
            this.fin = dateTime2;
        }
        public DateTime inicio { get; set; }
        public DateTime fin {get; set;}

        public Boolean EstaDentroDelRango(DateTime otra)
        {
            return otra >= inicio && otra <= fin;
        }




    }
}
