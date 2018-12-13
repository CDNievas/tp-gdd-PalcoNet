using PalcoNet.Abm_Empresa_Espectaculo;
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

namespace PalcoNet.Listado_Estadistico
{
    public partial class SeleccionEmpresa : Form
    {
        private Pagina paginaActual;
        public Empresa empresa { get; set; }


        public SeleccionEmpresa()
        {
            InitializeComponent();
            this.paginaActual = new Pagina(1, 25);
            ActualizarTabla();
        }
        private List<TextBox> TodosLosTextbox()
        {
            return this.Controls.OfType<TextBox>().ToList<TextBox>();
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
            if (empresasDataGrid.RowCount == 0)
            {
                paginaActual.Previous();
                ActualizarTabla();
            }
        }

        private void ActualizarTabla()
        {
            var _lista = new BuscadorEmpresas()
               .filtrarEmpresas(razonSocial: txtRazonSocial.Text, cuit: txtCuit.Text, email: txtMail.Text, pag: paginaActual);
            _lista.ForEach(e => Console.WriteLine(e));
            var lista = new BindingList<Empresa>(_lista);

            var bindingSource = new BindingSource(lista, null);

            this.empresasDataGrid.DataSource = bindingSource;
 
            this.empresasDataGrid.Columns["id"].Visible = false;
        }

        private void btnPagAnt_Click(object sender, EventArgs e)
        {
            paginaActual.Previous();
            ActualizarTabla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            paginaActual.pageNumber = 1;
            ActualizarTabla();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.empresa = (Empresa)empresasDataGrid.CurrentRow.DataBoundItem;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
