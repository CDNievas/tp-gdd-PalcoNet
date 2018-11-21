using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace PalcoNet.PublicacionesUtils
{
    class Publicacion
    {
        public long id { get; set; }
        public String descripcion { get; set; }
        public DateTime? fechaPublicacion { get; set; }
        public DateTime? fechaVencimiento { get; set; }
        public DateTime? fechaEspectaculo { get; set; }
        public String descipcionEstado;
        public Estado estado;
        public String ciudad;
        public String localidad;
        public String calle;
        public String nroCalle;
        public String codigoPostal;
        public Rubro rubro = null;
        public Grado grado = null;

        public static Publicacion FromDataRow(DataRow dr)
        {
            var publicacion = new Publicacion();
            var dataRow = new DataRowExtended(dr);

            publicacion.id = dataRow.LongValue("id_publicacion");
            publicacion.descripcion = dataRow.StringValue("descripcion");
            publicacion.fechaPublicacion = dataRow.OrElse<DateTime?>("fecha_publicacion", null);
            publicacion.fechaVencimiento = dataRow.OrElse<DateTime?>("fecha_vencimiento", null);
            publicacion.fechaEspectaculo = dataRow.OrElse<DateTime?>("fecha_espectaculo", null);
            publicacion.descipcionEstado = dataRow.StringValue("estado");
            publicacion.ciudad = dataRow.StringValue("ciudad");
            publicacion.localidad = dataRow.StringValue("localidad");
            publicacion.calle = dataRow.StringValue("dom_calle");
            publicacion.nroCalle = dataRow.StringValue("num_calle");
            publicacion.codigoPostal = dataRow.StringValue("cod_postal");
            publicacion.estado = Estados.Parse(dataRow.StringValue("cod_estado")[0]);
            SetRubro(publicacion, dataRow);
            SetGrado(publicacion, dataRow);

            return publicacion;
        }

        private static void SetRubro(Publicacion p, DataRowExtended dr){
            try{
                var idrubro = dr.IntValue("rubro_id");
                var descripcion = dr.StringValue("rubro_descripcion");
                var rubro = new Rubro(idrubro, descripcion);
                p.rubro = rubro;
            }catch(Exception){
                p.rubro = null;
            }
        }

        public static void SetGrado(Publicacion p, DataRowExtended dr){
            try{
                var idGrado = dr.IntValue("grado_id");
                var descripcion = dr.StringValue("grado_descripcion");
                var comision = dr.StringValue("grado_comision");
                p.grado = new Grado(idGrado, descripcion, comision);
            }catch(Exception){
                p.grado = null;
            }
        }

        public override string ToString()
        {
            return String.Format("Publicacion({0}, {1}, {2}, {3}, {4}, {5})",
                this.id, this.descripcion, this.fechaEspectaculo, this.rubro, this.grado, this.estado);
        }

        
    }
   
}
