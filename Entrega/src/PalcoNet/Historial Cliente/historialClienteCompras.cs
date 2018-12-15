using System;
using PalcoNet.DataBasePackage;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Historial_Cliente
{
    public partial class historialClienteCompras : Form
    {
        public historialClienteCompras()
        {
            InitializeComponent();
            ActualizarTabla();
        }



        private void ActualizarTabla() {

            var lista = new BindingList<ListarHistorialCompra>(getCompras());
            var bindingSource = new BindingSource(lista, null);
            this.dataGridView1.DataSource = bindingSource;
        }

        private static List<ListarHistorialCompra> getCompras() 
        {
        var dt= DataBase.GetInstance().Query("select  c.id_factura as 'Id', c.fecha as 'Fecha de compra', e.descripcion as 'Descripcion Espectaculo', i.item_factura_cantidad as 'Cantidad', c.total as 'Precio Total',c.forma_pago as 'descripcion modo de pago' from COMPUMUNDOHIPERMEGARED.Factura c inner join COMPUMUNDOHIPERMEGARED.Item_Factura i on c.id_factura=i.factura_id inner join COMPUMUNDOHIPERMEGARED.Espectaculo e on i.id_item_factura= e.id_espectaculo");
        return comprarFromDataTable(dt);
        }

        private static List<ListarHistorialCompra> comprarFromDataTable(DataTable dt)
        {
            var publicaciones = new List<ListarHistorialCompra>();
            foreach (DataRow dr in dt.Rows)
            {
                publicaciones.Add(ListarHistorialCompra.historialfromDataRow(dr));
            }
            return publicaciones;
        }

    }
}
