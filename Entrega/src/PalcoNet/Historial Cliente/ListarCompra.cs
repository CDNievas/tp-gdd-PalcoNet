using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace PalcoNet.Historial_Cliente
{
    class ListarHistorialCompra
    {
        [DisplayName("Numero De Compra")]
        public int id { get; set;}
        [DisplayName("Fecha De Compra")]
        public DateTime? fechaCompra { get; set; }
        [DisplayName("Espectaculo Descripcion")]
        public string descripcionEspectaculo {get; set;}
        [DisplayName("Cantidad De Entradas")]
        public int  cantidad { get; set;}
        [DisplayName("Precio")]
        public int precio { get; set; }
        [DisplayName("Modo de pago")]
        public string modoDePagoDespcripion { get; set; }

        public static ListarHistorialCompra historialfromDataRow(DataRow dr)
        {
        var compra= new ListarHistorialCompra();
        var data =  new DataRowExtended(dr);

            compra.id = data.IntValue("Id");
            compra.fechaCompra=data.OrElse<DateTime?>("Fecha de compra", null);
            compra.descripcionEspectaculo= data.StringValue("Descripcion Espectaculo");
            compra.cantidad= data.IntValue("Cantidad");
            compra.precio=data.IntValue("Precio Total");
            compra.modoDePagoDespcripion=data.StringValue("descripcion modo de pago");
         return compra;
        }
    
  /*
   * select  c.id_factura as 'Id', c.fecha as 'Fecha de compra', e.descripcion as 'Descripcion Espectaculo', i.item_factura_cantidad as 'Cantidad', c.total as 'Precio Total',c.forma_pago as 'descripcion modo de pago'   
from COMPUMUNDOHIPERMEGARED.Factura c 
inner join COMPUMUNDOHIPERMEGARED.Item_Factura i on c.id_factura=i.factura_id
inner join COMPUMUNDOHIPERMEGARED.Espectaculo e on i.id_item_factura= e.id_espectaculo
   * */
       
    
    
    }

}

