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

        public Comprar()
        {
            InitializeComponent();
        }

        private List<TextBox> TodosLosTextbox()
        {
            return this.Controls.OfType<TextBox>().ToList<TextBox>();
        }

        private void Comprar_Load(object sender, EventArgs e)
        {
            paginaActual = new Pagina(1, 25);
            comprasDataGrid.MultiSelect = true;
            //ACTUALIZAR TABLA
        }

        private void btnComprasLimpiar_Click(object sender, EventArgs e)
        {
            TodosLosTextbox().ForEach(t => t.Text = "");
        }

        private void btnPaginaAnterior_Click(object sender, EventArgs e)
        {
            paginaActual.Previous();
            //ACTUALIZARTABLA
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paginaActual.Next();
            //ACTUALIZARTABLA
        }

        private void btnPagUltima_Click(object sender, EventArgs e)
        {
            paginaActual.Last();
            //ACTUALIZAR TABLA
        }

        private void btnPagPrimera_Click(object sender, EventArgs e)
        {
            paginaActual.First();
            //ACTUALIZAR TABLA
        }


    }
}