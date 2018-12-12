using PalcoNet.DataBasePackage;
using PalcoNet.Editar_Publicacion;
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

namespace PalcoNet.Comprar
{
    public partial class SeleccionarUbicacionesForm : Form
    {
        private Publicacion publicacion;
        private List<Ubicacion> ubicaciones;
        private List<Ubicacion> carrito = new List<Ubicacion>();
        private Pagina paginaActual = new Pagina(1, 25);

        public SeleccionarUbicacionesForm(Publicacion publicacion)
        {
            InitializeComponent();
            this.publicacion = publicacion;
            checkTipo.Checked = false;
            comboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipo.DataSource = TipoUbicacion.Todos();
            ubicacionesDataGrid.MultiSelect = false;
            carritoDataGrid.MultiSelect = false;
        }

        private void SeleccionarUbicacionesFormcs_Load(object sender, EventArgs e)
        {
            ActualizarTablas();
        }

        private void ActualizarUbicacionesDisponibles()
        {
            ubicaciones = publicacion.GetUbicacionesDisponibles(FiltarPorTipo ? SelectedTipo() : null, paginaActual)
                .Where(u => !CarritoContiene(u.Id)).ToList();
        }

        private Boolean CarritoContiene(long ubicacionId)
        {
            return carrito.Any(u => u.Id.Equals(ubicacionId));
        }

        private Boolean FiltarPorTipo
        {
            get
            {
                return checkTipo.Checked;
            }
        }

        private TipoUbicacion SelectedTipo()
        {
            return (TipoUbicacion)comboTipo.SelectedItem;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Ubicacion ubicacion = (Ubicacion)ubicacionesDataGrid.CurrentRow.DataBoundItem;
                if (ubicacion == null)
                {
                    MessageBox.Show("Debe seleccionar una ubicación");
                    return;
                }
                carrito.Add(ubicacion);
                ActualizarTablas();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una ubicación");
            }
        }

        private void ActualizarTablas()
        {
            ActualizarUbicacionesDisponibles();
            var _ubicaciones = new BindingList<Ubicacion>(this.ubicaciones);
            var ubicacionesBindingSource = new BindingSource(_ubicaciones, null);
            ubicacionesDataGrid.DataSource = ubicacionesBindingSource;

            var _carrito = new BindingList<Ubicacion>(this.carrito);
            var carritoBindingSource = new BindingSource(_carrito, null);
            carritoDataGrid.DataSource = carritoBindingSource;

            lblTotal.Text = "$ " + TotalCompra().ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Ubicacion ubicacion = (Ubicacion)carritoDataGrid.CurrentRow.DataBoundItem;
                if (ubicacion == null)
                {
                    MessageBox.Show("Debe seleccionar una ubicación");
                    return;
                }
                carrito.Remove(ubicacion);
                ActualizarTablas();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una ubicación");
            }
        }

        private void checkTipo_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTablas();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

        }

        private long TotalCompra()
        {
            return carrito.Aggregate(0, (acum, ub) => acum + Convert.ToInt32(ub.Precio));
        }
    }
}
