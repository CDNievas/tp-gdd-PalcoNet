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


namespace PalcoNet.Comprar
{
    public partial class Comprar : Form
    {
        private Pagina paginaActual;
        private DateTime f1=DateTime.Today;
        private DateTime f2=DateTime.Today;
        private bool cargadaCategoria = false;


        public Comprar()
        {
            InitializeComponent();
        }

        //--------------------------------------------BORRAR LOS FILTROS-------------------------------
        private List<TextBox> TodosLosTextbox()
        {
            return this.Controls.OfType<TextBox>().ToList<TextBox>();
        }

        private void btnComprasLimpiar_Click(object sender, EventArgs e)
        {
            TodosLosTextbox().ForEach(t => t.Text = "");

            //ACTUALIZAR LA TABLA 
        }
        //---------------------------------------------------------------------------

        private void Comprar_Load(object sender, EventArgs e)
        {
          
           paginaActual = new Pagina(1, 25);
            dataGridView1.MultiSelect = true;
            actualizarTabla();
           
        }

      //------------------------------- PRIMERA, ULTIMA, SIGUIENTE Y ANTERIOR PAGINA-------------------------------

           private void btnPagPrimera_Click(object sender, EventArgs e)
           {
            
           }

           private void btnPaginaAnterior_Click(object sender, EventArgs e)
           {
               //paginaActual.Previous();
               //ACTUALIZARTABLA
           }

           private void button1_Click(object sender, EventArgs e)
           {
               //paginaActual.Next();
               //ACTUALIZARTABLA
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
         
            if (dateDesde.Value.Date > dateHasta.Value.Date)
            {
                MessageBox.Show("La segunda fecha no puede ser inferior a la primera \nFECHA 1:" + dateDesde.Text + "\nFECHA 2:" + dateHasta.Text);
                return;
            }
            DateTime hoy = DateTime.Today;
            if (hoy > dateDesde.Value.Date)
            {
                MessageBox.Show("La fecha inicial no puede ser menor que la actual");
                return;
            }
            actualizarTabla();
            }
        
              
      private void actualizarTabla()
        {
            var lista = new BindingList<listarPublicaciones>(filtrarPublicaciones(pag:paginaActual));
            var bindingSource = new BindingSource(lista, null);
            this.dataGridView1.DataSource = bindingSource;
            this.dataGridView1.Columns["id"].Visible = false;
            this.dataGridView1.AllowUserToAddRows = false;
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.ReadOnly = true;
            }
        }

        private List<listarPublicaciones> filtrarPublicaciones(Pagina pag = null)
        {
            
            pag = pag == null ? new Pagina(1, 10) : pag;
            var dt = DataBase.GetInstance().Query(cargarPagina1());
            if(paginaActual.pageNumber!=1){
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

        private String cargarPaginaN(){
        String queryPrincipal = cargarPagina1();
        String queryExcluyente = " AND p.id_publicacion NOT IN (SELECT TOP (" + (paginaActual.pageNumber - 1) * 10 + ") ";
            queryExcluyente += "up.ubiXpubli_ID";
            queryExcluyente += " FROM [COMPUMUNDOHIPERMEGARED].Publicacion p ";
            queryExcluyente += "inner join COMPUMUNDOHIPERMEGARED.Ubicacion u ON u.publicacion_id = p.id_publicacion inner join COMPUMUNDOHIPERMEGARED.TipoUbicacion tu on tu.id_tipo_ubicacion = u.tipo_ubicacion_id";
            queryExcluyente += where()+ ") ";
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
            String cadena, primero, resto;;
            int separardor; 
            bool hayMasDe1 = false;
            String listaCategorias = lblCategorias.Text;
            //chequeo si el lablel esta vacio (no filtro por categoria)
            if(listaCategorias==""){
                return "";
            }
            cadena = " AND ( ";
            //separo la lista y le agrego lo necesario
            while (listaCategorias.Contains(";"))
            {
                separardor = listaCategorias.IndexOf(";");
                primero = listaCategorias.Substring(0, separardor);
                 if (separardor != (listaCategorias.Length-1))
                {
                    resto = listaCategorias.Substring(separardor+1, listaCategorias.Length - separardor-1);
                    
                    listaCategorias = resto;
                }
                else {
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

     

        }

    }