using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PalcoNet.PublicacionesUtils
{
    class Grado
    {
        private int idGrado;
        private string descripcion1;
        private string comision1;

        public Grado(int idGrado, string descripcion1, string comision1)
        {
            this.idGrado = idGrado;
            this.descripcion1 = descripcion1;
            this.comision1 = comision1;
        }

        public Grado() { }

        public int id {get; set;}
        public String descripcion { get; set; }
        public Double comision { get; set; }

        public static Grado FromDataRow(DataRow _dr)
        {
            var dr = new DataRowExtended(_dr);
            var grado = new Grado();

            grado.id = dr.IntValue("id_grado");
            grado.descripcion = dr.StringValue("descripcion");
            grado.comision = dr.DoubleValue("comision");

            return grado;
        }

       
    }
}
