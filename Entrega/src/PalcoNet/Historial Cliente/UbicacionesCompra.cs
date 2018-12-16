using PalcoNet.DataBasePackage;
using System;
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
    public partial class UbicacionesCompra : Form
    {
        private int idCompra;

        public UbicacionesCompra(int idCompra)
        {
            InitializeComponent();
            this.idCompra = idCompra;
        }

        private void UbicacionesCompra_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataBase.GetInstance()
                .TypedQuery(@"select u.asiento as [Asiento], u.fila as [Fila], u.sin_numerar as [Sin Numerar?], t.descripcion as [Tipo de Ubicación], u.precio as [Precio Ubicación]
                            from COMPUMUNDOHIPERMEGARED.Ubicacion u inner join COMPUMUNDOHIPERMEGARED.TipoUbicacion t on t.id_tipo_ubicacion = u.tipo_ubicacion_id and u.compra_id = @compraId"
                , new QueryParameter("compraId", SqlDbType.Int, this.idCompra));
        }
    }
}
