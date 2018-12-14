using PalcoNet.DataBasePackage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PalcoNet.Comprar
{
    public class Factura
    {
        public long id { get; set; }

        [DisplayName("fact_nro")]
        public int? fact_nro { get; set; }

        [DisplayName("fact_fecha")]
        public DateTime? fact_fecha { get; set; }

        [DisplayName("fact_total")]
        public int? fact_total { get; set; }

        [DisplayName("fact_pago_desc")]
        public String fact_pago_desc { get; set; }

        [DisplayName("empresa_id")]
        public int? empresa_id { get; set; }

        public static Factura FindByFacturaId(int facturaID)
        {
            var dt = DataBase.GetInstance().Query("select * from COMPUMUNDOHIPERMEGARED.Factura where id_factura = " + facturaID);
            return traerDe(dt.Rows[0]);
        }

        public static Factura traerDe(DataRow dr)
        {
            var factura = new Factura();
            var data = new DataRowExtended(dr);

            factura.id = data.LongValue("id_factura");

            factura.fact_nro = data.Fold<int?>("numero", null, x => Convert.ToInt32(x.ToString()));
            factura.fact_fecha = data.OrElse<DateTime?>("fecha", null);
            factura.fact_total = data.Fold<int?>("total", null, x => Convert.ToInt32(x.ToString()));
            factura.fact_pago_desc = data.StringValue("forma_pago");
            factura.empresa_id = data.Fold<int?>("empresa_id", null, x => Convert.ToInt32(x.ToString()));

            return factura;
        }

        /*
        public static List<Factura> traerFacturas()
        {
            List<Factura> listaFacturas = new List<Factura>();

            var dt = DataBase.GetInstance().Query("SELECT * FROM COMPUMUNDOHIPERMEGARED.Factura");
            int cantidadDeFacturas = dt.Columns.Count;

            for (int i = 0; i < cantidadDeFacturas; i++ )
            {
                Factura fact = traerDe(dt.Rows[i]);
                listaFacturas.Add(fact);
            }

            return listaFacturas;
        }*/

        public static int contarLocalidades(int facturaID)
        {
            var dt = DataBase.GetInstance().Query("SELECT * FROM COMPUMUNDOHIPERMEGARED.Item_Factura where factura_id = " + facturaID);
            return dt.Columns.Count;
        }
    }
}
