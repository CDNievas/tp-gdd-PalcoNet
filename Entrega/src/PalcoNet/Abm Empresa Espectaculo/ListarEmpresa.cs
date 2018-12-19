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

namespace PalcoNet.Abm_Empresa_Espectaculo
{
    public partial class ListarEmpresa : Form
    {
        private Pagina paginaActual;
        private int countResult;

        private List<TextBox> TodosLosTextbox()
        {
            return this.Controls.OfType<TextBox>().ToList<TextBox>();
        }

        public ListarEmpresa()
        {
            InitializeComponent();
        }

        private void ActualizarTabla()
        {
            var _lista = new BuscadorEmpresas()
                .filtrarEmpresas(razonSocial: txtRazonSocial.Text, cuit: txtCuit.Text, email: txtMail.Text, pag: paginaActual);
            var lista = new BindingList<Empresa>(_lista);

            var bindingSource = new BindingSource(lista, null);

            this.empresasDataGrid.DataSource = bindingSource;
            this.empresasDataGrid.Columns["id"].Visible = false;
            ActualizarTextPaginaActual();
        }

        private void ActualizarCantPaginas()
        {
            this.countResult = new BuscadorEmpresas().CantidadDeEmpresasAFiltrar(razonSocial: txtRazonSocial.Text, cuit: txtCuit.Text, email: txtMail.Text);
            this.txtUltimaPag.Text = paginaActual.LastPageNumer(countResult).ToString();
        }

        private void ListarEmpresa_Load(object sender, EventArgs e)
        {
            paginaActual = new Pagina(1, 15);
            empresasDataGrid.MultiSelect = false;
            
            ActualizarTabla();
            ActualizarCantPaginas();
        }

        private void btnPagAnt_Click(object sender, EventArgs e)
        {
            paginaActual.Previous();
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

        private void btnEmpresaMod_Click(object sender, EventArgs e)
        {
            var empresa = (Empresa)empresasDataGrid.CurrentRow.DataBoundItem;
            Console.WriteLine("Modificando " + empresa);
            var ignored = new AltaEmpresaForm(new Modificacion(empresa)).ShowDialog();
            ActualizarTabla();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            new AltaEmpresaForm(new AltaEmpresa()).ShowDialog();
            ActualizarTabla();
        }

        private void btnEmpresaBaja_Click(object sender, EventArgs e)
        {
            var empresa = (Empresa)empresasDataGrid.CurrentRow.DataBoundItem;
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea deshabilitar la empresa " + empresa.razonSocial + "?",
                "Solicitud de confirmación", MessageBoxButtons.YesNo);
            try
            {
                if (dialogResult == DialogResult.Yes)
                {
                    empresa.Habilitado = false;
                    empresa.Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void btnPagPrimera_Click(object sender, EventArgs e)
        {
            paginaActual.pageNumber = 1;
            ActualizarTabla();
        }

        private void btnPagUltima_Click(object sender, EventArgs e)
        {
            paginaActual.Last(countResult);
            ActualizarTabla();
        }

        private void ActualizarTextPaginaActual()
        {
            txtPagActual.Text = paginaActual.pageNumber.ToString();
        }
    }
}
