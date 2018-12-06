using PalcoNet.DataBasePackage;
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

        public void UpdateBorrador(long empresaId)
        {
            if(!this.PuedeModificarse())
                throw new Exception("Esta publicación no puede modificarse");
            this.BorrarSectoresBorrador();
            DataBase.GetInstance()
                .TypedQuery(@"update COMPUMUNDOHIPERMEGARED.Publicacion
                              set descripcion = @descripcion,
                              fecha_espectaculo = @fecha_espectaculo, estado = @estado,
                              ciudad = @ciudad, localidad = @localidad, dom_calle = @dom_calle,
                              num_calle = @num_calle, cod_postal = @cod_postal, empresa_id = @empresa_id,
                              rubro_id = @rubro_id, grado_id = @grado_id
                              where id_publicacion = @id_publicacion",
                              new QueryParameter("descripcion", SqlDbType.NVarChar, this.descripcion),
                              new QueryParameter("fecha_espectaculo", SqlDbType.DateTime, this.fechaEspectaculo),
                              new QueryParameter("estado", SqlDbType.NVarChar, this.estado.Codigo()),
                              new QueryParameter("ciudad", SqlDbType.NVarChar, this.ciudad),
                              new QueryParameter("localidad", SqlDbType.NVarChar, this.localidad),
                              new QueryParameter("dom_calle", SqlDbType.NVarChar, this.calle),
                              new QueryParameter("num_calle", SqlDbType.Decimal, GetNumeroCalle(this.nroCalle)),
                              new QueryParameter("cod_postal", SqlDbType.NVarChar, this.codigoPostal),
                              new QueryParameter("empresa_id", SqlDbType.Int, empresaId),
                              new QueryParameter("rubro_id", SqlDbType.Int, this.rubro != null? rubro.id as int? : null),
                              new QueryParameter("grado_id", SqlDbType.Int, this.grado.id),
                              new QueryParameter("id_publicacion", SqlDbType.Int, this.id));
        }

        public void GuardarBorrador(long empresaId)
        {
            if (!this.PuedeModificarse())
                throw new Exception("Esta publicación no puede modificarse");
            var returnPar = new ParametroOut("borrador_id", SqlDbType.Int);

            this.estado = new Borrador();

            DataBase.GetInstance()
                .Procedure("crear_borrador",
                              new NullableInParameter("descripcion", this.descripcion),
                              new NullableInParameter("fecha_espectaculo", this.fechaEspectaculo),
                              new NullableInParameter("estado", this.estado.Codigo()),
                              new NullableInParameter("ciudad", this.ciudad),
                              new NullableInParameter("localidad", this.localidad),
                              new NullableInParameter("dom_calle", this.calle),
                              new NullableInParameter("num_calle", GetNumeroCalle(this.nroCalle)),
                              new NullableInParameter("cod_postal", this.codigoPostal),
                              new NullableInParameter("empresa_id", empresaId),
                              new NullableInParameter("rubro_id", this.rubro != null ? this.rubro.id as int? : null),
                              new NullableInParameter("grado_id", this.grado.id),
                              returnPar);
            this.id = (int)returnPar.valorRetorno;
        }

        private int? GetNumeroCalle(String s)
        {
            try
            {
                return Convert.ToInt32(s);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void BorrarSectoresBorrador(){
            DataBase.GetInstance()
                .Query(@"delete from COMPUMUNDOHIPERMEGARED.Sector
                              where id_borrador = " + this.id);
        }


        public void Publicarse(List<Sector> sectores)
        {
            DataBase.GetInstance()
                .TypedQuery(@"update COMPUMUNDOHIPERMEGARED.Publicacion
                              set fecha_creacion = @fecha, estado = 'PUBLICADA'"
                , new QueryParameter("fecha", SqlDbType.DateTime, Contexto.FechaActual));
            this.estado = new Publicado();
            DataBase.GetInstance()
                .Procedure("generar_ubicaciones_de", new ParametroIn("id_publicacion", this.id));

        }
    }
   
}
