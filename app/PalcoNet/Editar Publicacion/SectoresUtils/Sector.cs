using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Editar_Publicacion
{
    public abstract class Sector
    {
        [DisplayName("Tipo Ubicación")]
        public TipoUbicacion tipoUbicacion { get; set; }
        public Boolean numerado { get; set; }
        [DisplayName("Precio")]
        public long precio { get; set; }

        public Sector(TipoUbicacion tipoUbicacion, long precio)
        {
            this.tipoUbicacion = tipoUbicacion;
            this.numerado = numerado;
            this.precio = precio;
        }

        public static Sector FromDataRow(System.Data.DataRow dr)
        {
            var unDr = new DataRowExtended(dr);

            var numerado = unDr.BoolValue("numerado");
            var tipoUbicacion = new TipoUbicacion(
                id: unDr.IntValue("id_tipo_ubicacion"),
                codigo: unDr.LongValue("codigo"),
                descripcion: unDr.StringValue("descripcion"));
            var precio = unDr.LongValue("precio");

            if (numerado)
            {
                var asientoDesde = unDr.IntValue("asiento_desde");
                var asientoHasta = unDr.IntValue("asiento_hasta");
                var filaDesde = unDr.StringValue("fila_desde")[0];
                var filaHasta = unDr.StringValue("fila_hasta")[0];
                return new SectorNumerado(asientoDesde: asientoDesde, asientoHasta: asientoHasta,
                    filaDesde: filaDesde, filaHasta: filaHasta, precio: precio, tipoUbicacion: tipoUbicacion);
            }
            else
            {
                var cantidad = unDr.IntValue("cantidad");
                return new SectorSinNumerar(tipoUbicacion, precio, cantidad);
            }
        }

        public abstract void PersistiteParaUn(int idBorrador);
    }

    public class SectorNumerado : Sector
    {
        [DisplayName("Fila desde")]
        public char filaDesde { get; set; }
        [DisplayName("Fila hasta")]
        public char filaHasta { get; set; }
        [DisplayName("Asiento desde")]
        public int asientoDesde { get; set; }
        [DisplayName("Asiento hasta")]
        public int asientoHasta { get; set; }

        public SectorNumerado(TipoUbicacion tipoUbicacion, long precio,
            char filaDesde, char filaHasta, int asientoDesde, int asientoHasta)
            : base(tipoUbicacion, precio)
        {
            this.filaDesde = filaDesde;
            this.filaHasta = filaHasta;
            this.asientoDesde = asientoDesde;
            this.asientoHasta = asientoHasta;
        }

        override public void PersistiteParaUn(int idBorrador)
        {
            var sql = String.Format(
            @"insert into COMPUMUNDOHIPERMEGARED.Sector(id_borrador, numerado, tipo_ubicacion_id,
              fila_desde, fila_hasta, asiento_desde, asiento_hasta, precio)
              values({0}, 1, {1}, '{2}', '{3}', {4}, {5}, {6})"
            , idBorrador, tipoUbicacion.id, filaDesde, filaHasta, asientoDesde, asientoHasta, precio);
            DataBase.GetInstance().Query(sql);
        }

    }

    public class SectorSinNumerar : Sector
    {
        [DisplayName("Cantidad")]
        public int cantidad { get; set; }

        public SectorSinNumerar(TipoUbicacion tipoUbicacion, long precio, int cantidad)
            : base(tipoUbicacion, precio)
        {
            this.cantidad = cantidad;
        }

        override public void PersistiteParaUn(int idBorrador)
        {
            var sql = String.Format(
                @"insert into COMPUMUNDOHIPERMEGARED.Sector(id_borrador, numerado, tipo_ubicacion_id, cantidad, precio)
                  values({0}, 0, {1}, {2}, {3})"
                , idBorrador, tipoUbicacion.id, cantidad, precio);
            DataBase.GetInstance().Query(sql);
        }
        
    }
}
