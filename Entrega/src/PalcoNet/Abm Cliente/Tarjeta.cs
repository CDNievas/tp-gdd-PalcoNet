using PalcoNet.DataBasePackage;
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
        public int codigoSeguridad { get; set; }

        [DisplayName("Vencimiento")]
        public DateTime fechaVencimiento { get; set; }

        public static Tarjeta traerDe(DataRow dr)
        {
            var tarjeta = new Tarjeta();
            var data = new DataRowExtended(dr);

            tarjeta.id = data.LongValue("id_tarjeta");

            try
            {
                var tipo = data.StringValue("tipo")[0];
                tarjeta.tipoTarjeta = TipoTarjeta.Parse(tipo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                tarjeta.tipoTarjeta = null;
            }

            tarjeta.nroTarjeta = data.StringValue("nro_tarjeta");
            tarjeta.codigoSeguridad = data.IntValue("ccv");
            tarjeta.fechaVencimiento = data.At<DateTime>("fecha_vencimiento");

            return tarjeta;
        }

        public void SerAsignadaA(int idCliente)
        {
            var salida = new ParametroOut("tarjeta_id", SqlDbType.Int);
            DataBase.GetInstance()
                .Procedure("AsignarTarjetaA",
                new ParametroIn("cliente_id", idCliente),
                new ParametroIn("nro_tarjeta", this.nroTarjeta),
                new ParametroIn("tipo", this.tipoTarjeta.discriminator),
                new ParametroIn("ccv", this.codigoSeguridad),
                new ParametroIn("fecha_vencimiento", this.fechaVencimiento),
                salida);
            var tarjetaID = Convert.ToInt64(salida.valorRetorno);
            Console.WriteLine("Tarjeta ID: " + tarjetaID);
            this.id = tarjetaID;
        }

        public Boolean FueModificadaRespectoA(Tarjeta otra)
        {
            return !(this.nroTarjeta.Equals(otra.nroTarjeta) && this.tipoTarjeta.Equals(otra.tipoTarjeta) && this.codigoSeguridad.Equals(otra.codigoSeguridad) && this.fechaVencimiento.Equals(otra.fechaVencimiento));
        }
    }
}
