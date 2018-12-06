using PalcoNet.DataBasePackage;
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

namespace PalcoNet.Editar_Publicacion
{
    public partial class ListarPublicacion : Form
    {
        private Pagina PaginaActual;

        public ListarPublicacion()
        {
            InitializeComponent();
            PaginaActual = new Pagina(1, 15);
            publicacionesDataGrid.MultiSelect = false;
        }

        private Boolean SoloBorradores
        {
            get
            {
                return checkBorrador.Checked;
            }
        }

        private void listarPublicacion_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            var lista = new BindingList<Publicacion>(Publicaciones.PublicacionesByEmpresaId(Contexto.GetEmpresaLogeadaId(), PaginaActual, SoloBorradores));
            var bindingSource = new BindingSource(lista, null);

            publicacionesDataGrid.DataSource = bindingSource;
            publicacionesDataGrid.Columns["id"].Visible = false;
        }

        private void btnPagSig_Click(object sender, EventArgs e)
        {
            PaginaActual.Next();
            ActualizarTabla();
            if (publicacionesDataGrid.RowCount == 0)
                btnPagAnt_Click(null, null);
        }

        private void btnPagAnt_Click(object sender, EventArgs e)
        {
            PaginaActual.Previous();
            ActualizarTabla();
        }

        private void btnPublicacionLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            Publicacion publicacion;
            try
            {
                publicacion = PublicacionSeleccionada();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debe seleccionar una publicacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!publicacion.PuedeModificarse())
            {
                MessageBox.Show("Esta publicación no puede modificarse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var ignored = new EditarPublicacion(new FuncionModificarPublicacion(publicacion)).ShowDialog();
            ActualizarTabla();
        }

        private Publicacion PublicacionSeleccionada()
        {
            return (Publicacion)publicacionesDataGrid.CurrentRow.DataBoundItem;
        }

        private void checkBorrador_CheckedChanged(object sender, EventArgs e)
        {
            PaginaActual.pageNumber = 1;
            ActualizarTabla();
        }

    }
}
