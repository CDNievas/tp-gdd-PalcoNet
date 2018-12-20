using PalcoNet.Abm_Cliente;
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
using PalcoNet.DateTimeExtensions;


namespace PalcoNet.Comprar
{
    public partial class Comprar : Form
    {
        private Pagina paginaActual = new Pagina(1, 15);
        private DateTime f1 = Contexto.FechaActual;
        private DateTime f2 = Contexto.FechaActual;
        private List<Rubro> categorias = new List<Rubro>();
        private Cliente cliente;
        private int countResult;

        public Comprar(Cliente cliente)
        {
            InitializeComponent();
            dataGridView1.MultiSelect = false;
            paginaActual = new Pagina(1, 15);

            dateDesde.MinDate = Contexto.FechaActual;
            dateHasta.MinDate = Contexto.FechaActual;
            dateDesde.MaxDate = DateTime.MaxValue;
            dateHasta.MaxDate = DateTime.MaxValue;
            checkFecha.Checked = false;
            this.cliente = cliente;
            ActualizarTabla();
            ActualizarCantPaginas();
        }

        private void ActualizarTextPaginaActual()
        {
            txtPagActual.Text = paginaActual.pageNumber.ToString();
        }

        //--------------------------------------------BORRAR LOS FILTROS-------------------------------
        private List<TextBox> TodosLosTextbox()
        {
            return this.Controls.OfType<TextBox>().ToList<TextBox>();
        }

        private void btnComprasLimpiar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Limpiando filtros");
            txtPublicacion.Text = "";
            dateDesde.Value = Contexto.FechaActual;
            dateHasta.Value = Contexto.FechaActual;
            checkFecha.Checked = false;
            categorias = new List<Rubro>();
            RefreshLblCategorias();
            paginaActual.pageNumber = 1;
            ActualizarCantPaginas();
            ActualizarTabla();
        }

        //------------------------------- PRIMERA, ULTIMA, SIGUIENTE Y ANTERIOR PAGINA-------------------------------

        private void btnPagPrimera_Click(object sender, EventArgs e)
        {
            paginaActual.pageNumber = 1;
            ActualizarTabla();
        }

        private void btnPaginaAnterior_Click(object sender, EventArgs e)
        {
            paginaActual.Previous();
            ActualizarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (paginaActual.TieneSiguiente(this.countResult))
            {
                paginaActual.Next();
                ActualizarTabla();
            }
        }

        private void btnPagUltima_Click(object sender, EventArgs e)
        {
            paginaActual.Last(countResult);
            ActualizarTabla();
        }

        //--------------------------------------BUSCAR CON LOS FILTROS -----------------------------------------------------------------------

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (checkFecha.Checked && dateDesde.Value.Date > dateHasta.Value.Date)
            {
                MessageBox.Show("La segunda fecha no puede ser inferior a la primera \nFECHA 1:" + dateDesde.Text + "\nFECHA 2:" + dateHasta.Text);
                return;
            }

            ActualizarCantPaginas();
            paginaActual.pageNumber = 1;
            ActualizarTabla();
        }

        private void ActualizarCantPaginas()
        {
            this.countResult = Publicaciones.CantidadDePublicacionesAComprar(
            descripcion: txtPublicacion.Text,
            rango: this.checkFecha.Checked ? new RangoFechas(dateDesde.Value, FechaHastaInclusive()) : null,
            rubros: this.categorias);
            txtUltimaPag.Text = paginaActual.LastPageNumer(countResult).ToString();
        }


        private void ActualizarTabla()
        {
            var lista = new BindingList<Publicacion>(Publicaciones.FiltrarPublicacionesAComprar(
                descripcion:txtPublicacion.Text,
                rango: this.checkFecha.Checked? new RangoFechas(dateDesde.Value, FechaHastaInclusive()) : null,
                rubros: this.categorias,
                pag: this.paginaActual
                ));
            var bindingSource = new BindingSource(lista, null);
            this.dataGridView1.DataSource = bindingSource;
            this.dataGridView1.Columns["id"].Visible = false;
            this.dataGridView1.Columns["estado"].Visible = false;
            ActualizarTextPaginaActual();
        }

        private DateTime FechaHastaInclusive()
        {
            return this.dateHasta.Value.ChangeTime(23, 59, 59, 999);
        }


        private void btnCategoria_Click(object sender, EventArgs e)
        {
            var form = new SeleccionCategoriaForm(this.categorias);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.categorias = form.Categorias;
                RefreshLblCategorias();
            }
        }
        private void RefreshLblCategorias()
        {
            bool b = true;
            lblCategorias.Text = categorias.Aggregate("", (s, rubro) => { var r = s + (b ? "" : ";") + rubro.Descripcion; b = false; return r; });
        }

        private void btnElegirUbicaciones_Click(object sender, EventArgs e)
        {
            try
            {
                var publicacion = GetSelectedPublicacion();
                if (publicacion == null)
                {
                    MessageBox.Show("Debe seleccionar una publicación");
                    return;
                }

                new SeleccionarUbicacionesForm(publicacion, cliente).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una publicación");
            }
            ActualizarTabla();
        }

        private Publicacion GetSelectedPublicacion()
        {
            return (Publicacion)dataGridView1.CurrentRow.DataBoundItem;
        }



    }

}