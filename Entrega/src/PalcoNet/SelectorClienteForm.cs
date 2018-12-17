using PalcoNet.Abm_Cliente;
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

namespace PalcoNet
{
    public partial class SelectorClienteForm : Form
    {
        private Pagina paginaActual;
        public SelectorClienteForm()
        {
            InitializeComponent();
            paginaActual = new Pagina(1, 15);
            ActualizarTabla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            paginaActual.pageNumber = 1;
            ActualizarTabla();
        }

        private List<TextBox> TodosLosTextbox()
        {
            return this.Controls.OfType<TextBox>().ToList<TextBox>();
        }

        private void ActualizarTabla()
        {
            var lista = new BindingList<Cliente>(new Buscador().
                filtrarClientes(nombre: txtName.Text, apellido: txtApellido.Text,
                dni: txtDocumento.Text, email: txtMail.Text, pag: paginaActual));
            var bindingSource = new BindingSource(lista, null);

            this.clientesDataGrid.DataSource = bindingSource;
            this.clientesDataGrid.Columns["id"].Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TodosLosTextbox().ForEach(t => t.Text = "");
            ActualizarTabla();
        }

        private void btnPagSig_Click(object sender, EventArgs e)
        {
            paginaActual.Next();
            ActualizarTabla();
            if (clientesDataGrid.RowCount == 0)
            {
                paginaActual.Previous();
                ActualizarTabla();
            }
        }

        private void btnPagAnt_Click(object sender, EventArgs e)
        {
            paginaActual.Previous();
            ActualizarTabla();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = (Cliente)clientesDataGrid.CurrentRow.DataBoundItem;
                this.Cliente = cliente;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar a un cliente");
            }
        }



        public Cliente Cliente { get; set; }
    }
}
