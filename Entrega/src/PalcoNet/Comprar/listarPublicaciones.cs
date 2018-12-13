using System;
using PalcoNet.DataBasePackage;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Comprar
{
    class listarPublicaciones
    {
        [DisplayName("Id Espectaculo ")]
        public long id { get; set; }
        [DisplayName("Espectaculo")]
        public string espectaculo { get; set; }
        [DisplayName("Asiento")]
        public int asiento { get; set; }
        [DisplayName("Fila")]
        public string fila { get; set; }
        [DisplayName("Ubicacion Descripcion")]
        public string uDescrip { get; set; }
        [DisplayName("Precio")]
        public int precio { get; set; }
        [DisplayName("Fecha Espectaculo")]
        public DateTime? fechaEspectaculo { get; set; }
        [DisplayName("Id Rubro")]
        public long idRubro { get; set; }
        [DisplayName("Id Grado")]
        public long idGrado { get; set; }


        public static listarPublicaciones traerDe(DataRow dr)
        {
            var publicacion = new listarPublicaciones();
            var data = new DataRowExtended(dr);

            publicacion.id = data.LongValue("Id");
            publicacion.espectaculo = data.StringValue("Espectáculo");
            publicacion.asiento = data.IntValue("Asiento");
            publicacion.fila = data.StringValue("Fila");
            publicacion.uDescrip = data.StringValue("Ubicacion Descripcion");
            publicacion.precio=data.IntValue("Precio");
            publicacion.fechaEspectaculo=data.OrElse<DateTime?>("Fecha de evento", null);
            publicacion.idRubro = data.LongValue("Rubro id");
            publicacion.idGrado = data.LongValue("Grado id");

            return publicacion;
           
        }

    }

}


/*
String queryPrincipal = "SELECT " + " TOP (" + 10.ToString() + ") " + " ";
            queryPrincipal += "p.id_publicacion as 'id', p.descripcion as 'Espectáculo', u.asiento as 'Asiento', u.fila as 'Fila',  tu.descripcion,";
            queryPrincipal += "'$ ' +CONVERT(varchar(15), u.precio as )  as 'Precio', ";
            queryPrincipal += "CONVERT(nvarchar(15), DAY(fecha_espectaculo))+'/'+CONVERT(nvarchar(15), MONTH(fecha_espectaculo))+'/'+CONVERT(nvarchar(15), YEAR(fecha_espectaculo)) as 'Fecha de evento', p.rubro_id as 'Rubro id',p.grado_id as 'Grado id' ";
            queryPrincipal += " FROM [COMPUMUNDOHIPERMEGARED].Publicacion p ";
            queryPrincipal += "inner join COMPUMUNDOHIPERMEGARED.Ubicacion u ON u.publicacion_id = p.id_publicacion inner join COMPUMUNDOHIPERMEGARED.TipoUbicacion tu on tu.id_tipo_ubicacion = u.tipo_ubicacion_id";
            queryPrincipal += where();
            return queryPrincipal;
*/