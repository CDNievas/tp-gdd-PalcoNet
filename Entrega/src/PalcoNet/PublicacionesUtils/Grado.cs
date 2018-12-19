using PalcoNet.DataBasePackage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace PalcoNet.PublicacionesUtils
{
    public class Grado
    {
        public Grado(int idGrado, string descripcion1, Double comision1, Boolean eliminado)
        {
            this.id = idGrado;
            this.descripcion = descripcion1;
            this.comision = comision1;
            this.eliminado = eliminado;
        }

        public Grado() { }

        public Grado(String descripcion, Double comision)
        {
            this.descripcion = descripcion;
            this.comision = comision;
        }

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
        [DisplayName("Descripción")]
        public String descripcion { get; set; }
        [DisplayName("Comisión")]
        public Double comision { get; set; }
        [DisplayName("¿Dado de baja?")]
        public Boolean eliminado { get; set; }

        public String Show
        {
            get
            {
                return String.Format("{0} Comisión: {1}%", descripcion, comision);
            }
        }


        public static Grado FromDataRow(DataRow _dr)
        {
            var dr = new DataRowExtended(_dr);
            var grado = new Grado();

            grado.id = dr.IntValue("id_grado");
            grado.descripcion = dr.StringValue("descripcion");
            grado.comision = dr.DoubleValue("comision");
            grado.eliminado = dr.BoolValue("eliminado");

            return grado;
        }

        public void Eliminarse()
        {
            DataBase.GetInstance().Query("update COMPUMUNDOHIPERMEGARED.Grado set eliminado = 1 where id_grado = " + this.id);
        }

        public void Guardarse()
        {
            DataBase.GetInstance()
                .TypedQuery(@"insert into COMPUMUNDOHIPERMEGARED.Grado(descripcion, comision)
                              values(@descripcion, @comision)"
                , new QueryParameter("descripcion", SqlDbType.NVarChar, this.descripcion)
                , new QueryParameter("comision", SqlDbType.Decimal, this.comision));
        }

        public void Update()
        {
            String sql = String.Format(@"update COMPUMUNDOHIPERMEGARED.Grado
                                         set descripcion = '{0}', comision = {1}, eliminado = {2}
                                         where id_grado = {3}", this.descripcion, this.comision, this.eliminado? 1 : 0, this.id);
            DataBase.GetInstance().Query(sql);
        }
    }
}
