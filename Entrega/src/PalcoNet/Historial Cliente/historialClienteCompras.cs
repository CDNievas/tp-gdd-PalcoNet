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
using PalcoNet.Abm_Cliente;

namespace PalcoNet.Historial_Cliente
{
    public partial class historialClienteCompras : Form
    {
        private int countResult;
        private Cliente cliente;
        private Pagina pagina = new Pagina(1, 13);

        public historialClienteCompras(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            ActualizarTabla();
            ActualizarCantPaginas();
        }

        private void ActualizarTabla() {
            this.dataGridView1.DataSource = getCompras();
            dataGridView1.Columns["Id Compra"].Visible = false;
            this.txtPagActual.Text = pagina.pageNumber.ToString();
        }

        private void ActualizarCantPaginas()
        {
            var dt = DataBase.GetInstance().TypedQuery("select count(*) as cantidad from COMPUMUNDOHIPERMEGARED.ComprasDeCliente(@clienteID)",
                new QueryParameter("clienteID", SqlDbType.Int, cliente.id));
            this.countResult = Convert.ToInt32(dt.Rows[0]["cantidad"]);
            txtUltimaPag.Text = pagina.LastPageNumer(countResult).ToString();
        }

        private DataTable getCompras() 
        {
            return DataBase.GetInstance().TypedQuery(String.Format("select * from COMPUMUNDOHIPERMEGARED.ComprasDeCliente(@clienteID) ORDER BY [Fecha] desc OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY",
                pagina.FirstResultIndex(), pagina.pageSize), new QueryParameter("clienteID", SqlDbType.Int, cliente.id));
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

        private void btnPagSiguiente_Click(object sender, EventArgs e)
        {
            if (pagina.TieneSiguiente(countResult))
            {
                pagina.Next();
                ActualizarTabla();
            }
        }
        
        private void btnPagAnterior_Click(object sender, EventArgs e)
        {
            pagina.Previous();
            ActualizarTabla();
        }

        private void btnUbicaciones_Click(object sender, EventArgs e)
        {
            try
            {
                new UbicacionesCompra(idCompraSeleccionada()).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una compra para ver sus ubicaciones");
            }
        }

        private int idCompraSeleccionada() {
            return (int)this.dataGridView1.CurrentRow.Cells["Id Compra"].Value;
        }

        private void btnPagUltima_Click(object sender, EventArgs e)
        {
            pagina.Last(countResult);
            ActualizarTabla();
        }

        private void btnPagPrimera_Click(object sender, EventArgs e)
        {
            pagina.First();
            ActualizarTabla();
        }


    }
}
