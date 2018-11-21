using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PalcoNet.PublicacionesUtils
{
    class Rubro
    {

        public Rubro(int idrubro, string descripcion1)
        {
            this.id = idrubro;
            this.descripcion = descripcion1;
        }

        public Rubro() { }

        public int id { get; set; }
        public String descripcion { get; set; }


        public override string ToString()
        {
            return String.Format("Rubro({0}, {1})", this.id, this.descripcion);
        }

        public static Rubro FromDataRow(DataRow _dr)
        {
            var dr = new DataRowExtended(_dr);
            var rubro = new Rubro();

            rubro.id = dr.IntValue("id_rubro");
            rubro.descripcion = dr.StringValue("descripcion");

            return rubro;
        }

        public static Rubro FindById(int rubroId)
        {
            return FromDataRow(DataBase.GetInstance().query(
                String.Format(
                @"select * from COMPUMUNDOHIPERMEGARED.Rubro
                where id_rubro = {0}", rubroId)).Rows[0]);
        }
    }
}
