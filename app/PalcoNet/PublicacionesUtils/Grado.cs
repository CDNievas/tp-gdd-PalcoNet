using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PalcoNet.PublicacionesUtils
{
    public class Grado
    {
        public Grado(int idGrado, string descripcion1, Double comision1)
        {
            this.id = idGrado;
            this.descripcion = descripcion1;
            this.comision = comision1;
        }

        public Grado() { }

        public override bool Equals(object obj)
        {
            if(obj is Grado)
                return ((Grado)obj).id.Equals(this.id);
            return false;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public int id {get; set;}
        public String descripcion { get; set; }
        public Double comision { get; set; }

        public String Show
        {
            get
            {
                return String.Format("{0} Comisión: {1}", descripcion, comision);
            }
        }


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
