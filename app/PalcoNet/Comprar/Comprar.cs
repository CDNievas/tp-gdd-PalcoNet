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


namespace PalcoNet.Comprar
{
    public partial class Comprar : Form
    {
        private Pagina paginaActual = new Pagina(1, 15);
        private DateTime f1 = Contexto.FechaActual;
        private DateTime f2 = Contexto.FechaActual;
        private bool cargadaCategoria = false;
        private List<Rubro> categorias = new List<Rubro>();


        public Comprar()
        {
            InitializeComponent();
            dataGridView1.MultiSelect = false;
            paginaActual = new Pagina(1, 15);
            ActualizarTabla();
            dateDesde.MinDate = Contexto.FechaActual;
            dateHasta.MinDate = Contexto.FechaActual;
            dateDesde.MaxDate = DateTime.MaxValue;
            dateHasta.MaxDate = DateTime.MaxValue;
            checkFecha.Checked = false;
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

            ActualizarTabla();
        }
        //---------------------------------------------------------------------------
        /*
        private void Comprar_Load(object sender, EventArgs e)
        {

        }*/

        //------------------------------- PRIMERA, ULTIMA, SIGUIENTE Y ANTERIOR PAGINA-------------------------------

        private void btnPagPrimera_Click(object sender, EventArgs e)
        {

        }

        private void btnPaginaAnterior_Click(object sender, EventArgs e)
        {
            paginaActual.Previous();
            ActualizarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paginaActual.Next();
            ActualizarTabla();
        }

        private void btnPagUltima_Click(object sender, EventArgs e)
        {
            //paginaActual.Last();
            //ACTUALIZAR TABLA
        }

        //--------------------------------------BUSCAR CON LOS FILTROS -----------------------------------------------------------------------

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            paginaActual.pageNumber = 1;

            if (checkFecha.Checked && dateDesde.Value.Date > dateHasta.Value.Date)
            {
                MessageBox.Show("La segunda fecha no puede ser inferior a la primera \nFECHA 1:" + dateDesde.Text + "\nFECHA 2:" + dateHasta.Text);
                return;
            }
            ActualizarTabla();
        }


        private void ActualizarTabla()
        {
            var lista = new BindingList<Publicacion>(Publicaciones.FiltrarPublicacionesAComprar(
                descripcion:txtPublicacion.Text,
                rango: this.checkFecha.Checked? new RangoFechas(dateDesde.Value, dateHasta.Value) : null,
                rubros: this.categorias,
                pag: this.paginaActual
                ));
            var bindingSource = new BindingSource(lista, null);
            this.dataGridView1.DataSource = bindingSource;
            this.dataGridView1.Columns["id"].Visible = false;
            this.dataGridView1.Columns["estado"].Visible = false;

        }

        private List<listarPublicaciones> filtrarPublicaciones(Pagina pag = null)
        {

            pag = pag == null ? new Pagina(1, 10) : pag;
            var dt = DataBase.GetInstance().Query(cargarPagina1());
            if (paginaActual.pageNumber != 1)
            {
                dt = DataBase.GetInstance().Query(cargarPaginaN());
            }
            var lista = new List<listarPublicaciones>();

            foreach (DataRow dr in dt.Rows)
            {
                lista.Add(listarPublicaciones.traerDe(dr));
            }

            return lista;
        }




        /*
         * 
         * 
         * select 	p.id_publicacion as 'id',
                p.descripcion as 'Espectáculo', 
                u.asiento as 'Asiento', 
                u.fila as 'Fila',  
                tu.descripcion,
                u.precio as 'Precio',
                p.fecha_espectaculo AS 'Fecha',
                p.rubro_id as 'Rubro id',
                p.grado_id as 'Grado id'
            from	COMPUMUNDOHIPERMEGARED.Publicacion p 
            inner join COMPUMUNDOHIPERMEGARED.Ubicacion u ON u.publicacion_id = p.id_publicacion  
            inner join COMPUMUNDOHIPERMEGARED.TipoUbicacion tu on tu.id_tipo_ubicacion = u.tipo_ubicacion_id
            where P.estado LIKE 'Publicada'
            order by p.id_publicacion asc
         */

        //---------------------------------------------QUERIES PARA BUSCAR PAGINAS------------------------------------------
        private String cargarPagina1()
        {
            String queryPrincipal = "SELECT " + " TOP (" + 10.ToString() + ") " + " ";
            queryPrincipal += "p.id_publicacion as 'id', p.descripcion as 'Espectáculo', u.asiento as 'Asiento', u.fila as 'Fila',  tu.descripcion as 'Ubicacion Descripcion',";
            queryPrincipal += "'$ ' +CONVERT(varchar(15), u.precio as )  as 'Precio', ";
            queryPrincipal += "CONVERT(nvarchar(15), DAY(fecha_espectaculo))+'/'+CONVERT(nvarchar(15), MONTH(fecha_espectaculo))+'/'+CONVERT(nvarchar(15), YEAR(fecha_espectaculo)) as 'Fecha de evento', p.rubro_id as 'Rubro id',p.grado_id as 'Grado id' ";
            queryPrincipal += " FROM [COMPUMUNDOHIPERMEGARED].Publicacion p ";
            queryPrincipal += "inner join COMPUMUNDOHIPERMEGARED.Ubicacion u ON u.publicacion_id = p.id_publicacion inner join COMPUMUNDOHIPERMEGARED.TipoUbicacion tu on tu.id_tipo_ubicacion = u.tipo_ubicacion_id";
            queryPrincipal += where();
            return queryPrincipal;
        }

        private String cargarPaginaN()
        {
            String queryPrincipal = cargarPagina1();
            String queryExcluyente = " AND p.id_publicacion NOT IN (SELECT TOP (" + (paginaActual.pageNumber - 1) * 10 + ") ";
            queryExcluyente += "up.ubiXpubli_ID";
            queryExcluyente += " FROM [COMPUMUNDOHIPERMEGARED].Publicacion p ";
            queryExcluyente += "inner join COMPUMUNDOHIPERMEGARED.Ubicacion u ON u.publicacion_id = p.id_publicacion inner join COMPUMUNDOHIPERMEGARED.TipoUbicacion tu on tu.id_tipo_ubicacion = u.tipo_ubicacion_id";
            queryExcluyente += where() + ") ";
            queryPrincipal += queryExcluyente;
            return queryPrincipal;
        }

        private string where()
        {
            var where = "where P.estado LIKE 'Publicada'";
            if (txtPublicacion.Text != "")
            {
                where += "AND p.descripcion LIKE '" + txtPublicacion.Text.Trim() + "%' ";
            }
            if (cargadaCategoria)
            {
                where += comandoCategoria();
            }

            //FALTARIA ACA VER TEMA DE UBICACIONES 
            return where;
        }

        private String comandoCategoria()
        {
            String cadena, primero, resto; ;
            int separardor;
            bool hayMasDe1 = false;
            String listaCategorias = lblCategorias.Text;
            //chequeo si el lablel esta vacio (no filtro por categoria)
            if (listaCategorias == "")
            {
                return "";
            }
            cadena = " AND ( ";
            //separo la lista y le agrego lo necesario
            while (listaCategorias.Contains(";"))
            {
                separardor = listaCategorias.IndexOf(";");
                primero = listaCategorias.Substring(0, separardor);
                if (separardor != (listaCategorias.Length - 1))
                {
                    resto = listaCategorias.Substring(separardor + 1, listaCategorias.Length - separardor - 1);

                    listaCategorias = resto;
                }
                else
                {
                    listaCategorias = "";
                }

                if (hayMasDe1)
                {
                    cadena += " OR r.rubro_descripcion LIKE '" + primero + "' ";
                }
                else
                {
                    cadena += " r.rubro_descripcion LIKE '" + primero + "' ";
                    hayMasDe1 = true;
                }
            }
            cadena += ") ";
            return cadena;
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

                new SeleccionarUbicacionesForm(publicacion).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una publicación");
            }

        }

        private Publicacion GetSelectedPublicacion()
        {
            return (Publicacion)dataGridView1.CurrentRow.DataBoundItem;
        }



    }

}