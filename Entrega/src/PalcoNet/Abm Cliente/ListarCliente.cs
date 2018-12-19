using PalcoNet.DataBasePackage;
using PalcoNet.Validadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Cliente
{
    public partial class ListarCliente : Form
    {
        private Pagina paginaActual;
        private int countResult;

        public ListarCliente()
        {
            InitializeComponent();

        }

        private List<TextBox> TodosLosTextbox()
        {
            return this.Controls.OfType<TextBox>().ToList<TextBox>();
        }

        private void ListarCliente_Load(object sender, EventArgs e)
        {
            paginaActual = new Pagina(1, 25);
            clientesDataGrid.MultiSelect = false;
            ActualizarTabla();
            ActualizarCantPaginas();
        }

        private void btnClienteBaja_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)clientesDataGrid.CurrentRow.DataBoundItem;
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea deshabilitar el cliente "
                + cliente.nombre + " " + cliente.apellido + "?",
                "Solicitud de confirmación", MessageBoxButtons.YesNo);
            try
            {
                if (dialogResult == DialogResult.Yes)
                {
                    cliente.Habilitado = false;
                    cliente.Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void ActualizarTabla()
        {
            var lista = new BindingList<Cliente>(new Buscador().
                filtrarClientes(nombre: txtName.Text, apellido:txtApellido.Text,
                dni: txtDocumento.Text, email: txtMail.Text, pag: paginaActual));
            var bindingSource = new BindingSource(lista, null);

            this.clientesDataGrid.DataSource = bindingSource;
            this.clientesDataGrid.Columns["id"].Visible = false;
            ActualizarTextPaginaActual();
        }

        private void ActualizarCantPaginas()
        {
            this.countResult = new Buscador().CantidadDeClientesAFiltrar(nombre: txtName.Text, apellido: txtApellido.Text,
                dni: txtDocumento.Text, email: txtMail.Text);
            this.txtUltimaPag.Text = paginaActual.LastPageNumer(countResult).ToString();
        }

        private void ActualizarTextPaginaActual()
        {
            txtPagActual.Text = paginaActual.pageNumber.ToString();
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TodosLosTextbox().ForEach(t => t.Text = "");
            paginaActual.pageNumber = 1;
            ActualizarCantPaginas();
            ActualizarTabla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarCantPaginas();
            paginaActual.pageNumber = 1;
            ActualizarTabla();
        }

        private void btnPagSig_Click(object sender, EventArgs e)
        {
            if (paginaActual.TieneSiguiente(this.countResult))
            {
                paginaActual.Next();
                ActualizarTabla();
            }
        }

        private void btnPagAnt_Click(object sender, EventArgs e)
        {
            paginaActual.Previous();
            ActualizarTabla();
        }

        private void btnClienteMod_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)clientesDataGrid.CurrentRow.DataBoundItem;
            var form = new AltaCliente();
            Console.WriteLine("Modificando cliente: " + cliente);
            form.funcionForm = new Modificar(cliente);
            try
            {
                var ignored = form.ShowDialog();
                
            }
            catch (ProcedureException ex)
            {
                MessageBox.Show(ex.GetSqlErrorMessage(), "Error al actualizar el cliente",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            ActualizarTabla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var form = new AltaCliente();
            form.funcionForm = new Alta();
            form.ShowDialog();
        }

        private void btnPagUltima_Click(object sender, EventArgs e)
        {
            paginaActual.Last(countResult);
            ActualizarTabla();
        }

        private void btnPagPrimera_Click(object sender, EventArgs e)
        {
            paginaActual.pageNumber = 1;
            ActualizarTabla();
        }

        
       

        
    }
}
