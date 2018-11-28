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
            _lista.ForEach(e => Console.WriteLine(e));
            var lista = new BindingList<Empresa>(_lista);

            var bindingSource = new BindingSource(lista, null);

            this.empresasDataGrid.DataSource = bindingSource;
            this.empresasDataGrid.AllowUserToAddRows = false;
            foreach (DataGridViewColumn c in empresasDataGrid.Columns)
            {
                c.ReadOnly = true;
            }
            this.empresasDataGrid.Columns["id"].Visible = false;
        }

        private void ListarEmpresa_Load(object sender, EventArgs e)
        {
            paginaActual = new Pagina(1, 25);
            empresasDataGrid.MultiSelect = false;
            
            ActualizarTabla();
        }

        private void btnPagAnt_Click(object sender, EventArgs e)
        {
            paginaActual.Previous();
            ActualizarTabla();
        }

        private void btnPagSig_Click(object sender, EventArgs e)
        {
           paginaActual.Next();
            ActualizarTabla();
            Console.WriteLine("Hay " + empresasDataGrid.RowCount + " empresas");
            if (empresasDataGrid.RowCount == 0)
                btnPagAnt_Click(null, null);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TodosLosTextbox().ForEach(t => t.Text = "");
            ActualizarTabla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            paginaActual.pageNumber = 1;
            ActualizarTabla();
        }

        private void btnEmpresaMod_Click(object sender, EventArgs e)
        {
            var empresa = (Empresa)empresasDataGrid.CurrentRow.DataBoundItem;
            Console.WriteLine("Modificando " + empresa);
            var ignored = new AltaEmpresaForm(new Modificacion(empresa)).ShowDialog();
        }
    }
}
