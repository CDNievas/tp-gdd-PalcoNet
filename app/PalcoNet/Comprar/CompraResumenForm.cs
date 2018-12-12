using PalcoNet.Abm_Cliente;
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
    public partial class CompraResumenForm : Form
    {
        private Publicacion publicacion;
        private List<Ubicacion> ubicaciones;
        private Tarjeta tarjeta;
        private Cliente cliente;
        private int total;
        private int puntos;

        public CompraResumenForm(Publicacion publicacion, List<Ubicacion> ubicaciones, Tarjeta tarjeta, Cliente cliente)
        {
            InitializeComponent();
            this.publicacion = publicacion;
            this.ubicaciones = ubicaciones;
            this.tarjeta = tarjeta;
            this.cliente = cliente;
        }

        private void CompraResumenForm_Load(object sender, EventArgs e)
        {
            // Llenando datos de espectáculo
            lblNombreEspectaculo.Text = publicacion.descripcion;
            lblFechaHora.Text = publicacion.fechaEspectaculo.ToString();
            lblUbicacionEspectaculo.Text = String.Format("{0} {1}, {2}, {3}",
                publicacion.calle, publicacion.nroCalle, publicacion.localidad, publicacion.ciudad);
            if (String.IsNullOrWhiteSpace(publicacion.calle) && String.IsNullOrWhiteSpace(publicacion.localidad) && String.IsNullOrWhiteSpace(publicacion.ciudad))
                lblUbicacionEspectaculo.Text = "Ubicación no disponible";

            // Llenando datos de publicación
            var _carrito = new BindingList<Ubicacion>(this.ubicaciones);
            var carritoBindingSource = new BindingSource(_carrito, null);
            ubicacionesDataGrid.DataSource = carritoBindingSource;
            ubicacionesDataGrid.Columns["Id"].Visible = false;

            //Llenando datos de tarjeta
            lblTipoTarjeta.Text = tarjeta.tipoTarjeta.ToString();
            var nroTarjeta = tarjeta.nroTarjeta;
            lblUltimosDigitosTarjeta.Text = nroTarjeta.Substring(Math.Max(0, nroTarjeta.Length - 4));

            //Llenando total
            this.total = ubicaciones.Aggregate(0, (acum, ubic) => acum + Convert.ToInt32(ubic.Precio));
            lblTotal.Text = "$ " + this.total.ToString();

            //Puntos
            this.puntos = total / 3;
            lblPuntos.Text = String.Format("Con esta compra usted sumaría {0} puntos", this.puntos);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }
    }
}
