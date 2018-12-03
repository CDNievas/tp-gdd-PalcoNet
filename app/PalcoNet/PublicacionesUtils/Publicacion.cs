using PalcoNet.Editar_Publicacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;


namespace PalcoNet.PublicacionesUtils
{
    public class Publicacion
    {
        public long id { get; set; }

        [DisplayName("Descripción")]
        public String descripcion { get; set; }

        [DisplayName("Fecha publicación")]
        public DateTime? fechaPublicacion { get; set; }

        [DisplayName("Fecha vencimiento")]
        public DateTime? fechaVencimiento { get; set; }

        [DisplayName("Fecha espectáculo")]
        public DateTime? fechaEspectaculo { get; set; }

        [DisplayName("Estado")]
        public Estado estado { get; set; }

        [DisplayName("Ciudad")]
        public String ciudad { get; set; }

        [DisplayName("Localidad")]
        public String localidad { get; set; }

        [DisplayName("Calle")]
        public String calle { get; set; }

        [DisplayName("Nro. calle")]
        public String nroCalle { get; set; }

        [DisplayName("C.P.")]
        public String codigoPostal { get; set; }

        public Rubro rubro = null;

        public Grado grado = null;

        [DisplayName("Rubro")]
        public String DescripcionRubro
        {
            get
            {
                return rubro != null ? rubro.Descripcion : "Sin rubro";
            }
        }

        [DisplayName("Grado")]
        public String DescripcionGrado
        {
            get
            {
                return grado != null ? grado.descripcion : "Sin grado";
            }
        }

        private List<Ubicacion> ubicaciones = null;
        public List<Ubicacion> Ubicaciones
        {
            get
            {
                if (ubicaciones == null)
                    ubicaciones = Ubicacion.FindUbicacionesDePublicacion(this.id);
                return ubicaciones;
            }
            set
            {
                ubicaciones = value;
            }
        }

        public static Publicacion FromDataRow(DataRow dr)
        {
            var publicacion = new Publicacion();
            var dataRow = new DataRowExtended(dr);

            publicacion.id = dataRow.LongValue("id_publicacion");
            publicacion.descripcion = dataRow.StringValue("descripcion");
            publicacion.fechaPublicacion = dataRow.OrElse<DateTime?>("fecha_publicacion", null);
            publicacion.fechaVencimiento = dataRow.OrElse<DateTime?>("fecha_vencimiento", null);
            publicacion.fechaEspectaculo = dataRow.OrElse<DateTime?>("fecha_espectaculo", null);
            publicacion.ciudad = dataRow.StringValue("ciudad");
            publicacion.localidad = dataRow.StringValue("localidad");
            publicacion.calle = dataRow.StringValue("dom_calle");
            publicacion.nroCalle = dataRow.StringValue("num_calle");
            publicacion.codigoPostal = dataRow.StringValue("cod_postal");
            publicacion.estado = Estados.Parse(dataRow.StringValue("estado"));
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
                var comision = dr.DoubleValue("grado_comision");
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



        public bool PuedeModificarse()
        {
            return this.estado.PuedeModificarse();
        }

    }
   
}
