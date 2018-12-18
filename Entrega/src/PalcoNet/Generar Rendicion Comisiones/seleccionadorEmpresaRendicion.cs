using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Abm_Empresa_Espectaculo;
using PalcoNet.DataBasePackage;

namespace PalcoNet.Generar_Rendicion_Comisiones
{
    public partial class seleccionadorEmpresaRendicion : Form
    {    

        private Pagina paginaActual;
        public Empresa empresa { get; set; }

        public seleccionadorEmpresaRendicion()
        {
            InitializeComponent();
            this.paginaActual = new Pagina(1, 25);
            cantComprasInput.Minimum = 1;
        }

        private List<TextBox> TodosLosTextbox()
        {
            return this.Controls.OfType<TextBox>().ToList<TextBox>();
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
        

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            paginaActual.pageNumber = 1;
            ActualizarTabla();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            TodosLosTextbox().ForEach(t => t.Text = "");
            ActualizarTabla();
        }

        private void btnPagAnt_Click_1(object sender, EventArgs e)
        {
            paginaActual.Previous();
            ActualizarTabla();
        }

        private void btnPagSig_Click_1(object sender, EventArgs e)
        {
            paginaActual.Next();
            ActualizarTabla();
            if (empresasDataGrid.RowCount == 0)
            {
                paginaActual.Previous();
                ActualizarTabla();
            }
        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            if (empresasDataGrid.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una empresa");
                return;
            }
            this.empresa = (Empresa)empresasDataGrid.CurrentRow.DataBoundItem;
            try
            {
                int cantidadDeComprasARendir = Convert.ToInt32(cantComprasInput.Value);
                DialogResult = DialogResult.OK;
                new Generar_Rendicion_Comisiones.GenerarRendiciones(this.empresa, cantidadDeComprasARendir).ShowDialog();
                Close();
            }
            catch
            {
                MessageBox.Show("Debe ingresar cantidad de compras a rendir obligatoriamente.");
            }
        }

        private void seleccionadorEmpresaRendicion_Load_1(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
    }
}
