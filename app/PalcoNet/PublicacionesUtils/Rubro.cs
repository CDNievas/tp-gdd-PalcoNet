using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PalcoNet.PublicacionesUtils
{
    public class Rubro
    {

        public Rubro(int idrubro, string descripcion1)
        {
            this.id = idrubro;
            this.Descripcion = descripcion1;
        }

        public Rubro() { }

        public int id { get; set; }
        public String Descripcion { get; set; }


        public override string ToString()
        {
            return String.Format("Rubro({0}, {1})", this.id, this.Descripcion);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Rubro))
                return false;
            return ((Rubro)obj).id.Equals(this.id);
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public static Rubro FromDataRow(DataRow _dr)
        {
            var dr = new DataRowExtended(_dr);
            var rubro = new Rubro();

            rubro.id = dr.IntValue("id_rubro");
            rubro.Descripcion = dr.StringValue("descripcion");

            return rubro;
        }

        public static Rubro FindById(int rubroId)
        {
            return FromDataRow(DataBase.GetInstance().Query(
                String.Format(
                @"select * from COMPUMUNDOHIPERMEGARED.Rubro
                where id_rubro = {0}", rubroId)).Rows[0]);
        }

        public static List<Rubro> Todos()
        {
            var dt = DataBase.GetInstance().Query("select * from COMPUMUNDOHIPERMEGARED.Rubro");
            var rubros = new List<Rubro>();

            foreach (DataRow dr in dt.Rows)
            {
                rubros.Add(FromDataRow(dr));
            }

            return rubros;
        }
    }
}
