using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Abm_Cliente
{
    public class Tarjeta
    {
        public long id { get; set; }

        [DisplayName("Nro. Tarjeta")]
        public String nroTarjeta { get; set; }

        [DisplayName("Tipo Tarjeta")]
        public TipoTarjeta tipoTarjeta { get; set; }

        [DisplayName("Codigo Seguridad")]
        public String codigoSeguridad { get; set; }

        [DisplayName("Vencimiento")]
        public DateTime? fechaVencimiento { get; set; }
        
        /*[DisplayName("Habilitacion")]
        public Bit habilitado { get; set; }*/

        public static Tarjeta traerDe(DataRow dr)
        {
            var tarjeta = new Tarjeta();
            var data = new DataRowExtended(dr);

            tarjeta.id = data.LongValue("id_tarjeta");

            try
            {
                var tipo = data.StringValue("tipo_tarjeta")[0];
                tarjeta.tipoTarjeta = TipoTarjeta.Parse(tipo);
            }
            catch (Exception)
            {
                tarjeta.tipoTarjeta = null;
            }

            tarjeta.nroTarjeta = data.StringValue("nro_tarjeta");
            tarjeta.codigoSeguridad = data.StringValue("ccv");
            tarjeta.fechaVencimiento = data.OrElse<DateTime?>("fecha_vencimiento", null);

            return tarjeta;
        }

        internal void Update()
        {
            String sql = String.Format
                (@" update COMPUMUNDOHIPERMEGARED.Tarjeta
                    set nro_tarjeta = '{0}', tipo_tarjeta = '{1}', ccv = '{2}',
                    fecha_vencimiento = '{3}', habilitado = '{4}'  where id_tarjeta = {4}",
                     nroTarjeta, tipoTarjeta.discriminator, codigoSeguridad, fechaVencimiento, 1 , id);
            var ignored = DataBase.GetInstance().Query(sql);
        }

        public void Insert(int idCliente)
        {
            String sql = String.Format
                (@" INSERT INTO COMPUMUNDOHIPERMEGARED.Tarjeta(nro_tarjeta, tipo, ccv, fecha_vencimiento, cliente_id)
                    VALUES('{0}', '{1}', '{2}', CONVERT(datetime,'{3}', 131),{4})",
                    nroTarjeta, tipoTarjeta.discriminator, codigoSeguridad, fechaVencimiento, idCliente);

            var ignored = DataBase.GetInstance().Query(sql);
        }

    }
}
