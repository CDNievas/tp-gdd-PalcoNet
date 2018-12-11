using PalcoNet.PublicacionesUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Grado
{
    public partial class ListarGrado : Form
    {
        private Boolean eliminados = false;

        public ListarGrado()
        {
            InitializeComponent();
        }

        private void ListarGrado_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el grado " + GradoSeleccionado().descripcion + "?",
                "Solicitud confirmación", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                GradoSeleccionado().Eliminarse();
                ActualizarTabla();
            }
        }

        private Grado GradoSeleccionado()
        {
            return gradosDataGrid.CurrentRow.DataBoundItem as Grado;
        }

        private void ActualizarTabla()
        {
            var lista = Grados.Todos(eliminados).OrderByDescending(g => g.comision);
            var bindingSource = new BindingSource(lista, null);

            gradosDataGrid.DataSource = bindingSource;
            gradosDataGrid.Columns["id"].Visible = false;
            gradosDataGrid.Columns["Show"].Visible = false;

            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new AltaGrado().ShowDialog();
            ActualizarTabla();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            new ActualizarGrado(GradoSeleccionado()).ShowDialog();
            ActualizarTabla();
        }

        private void checkEliminados_CheckedChanged(object sender, EventArgs e)
        {
            eliminados = checkEliminados.Checked;
            ActualizarTabla();
        }
    }
}
