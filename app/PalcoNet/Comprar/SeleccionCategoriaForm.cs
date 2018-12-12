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
    public partial class SeleccionCategoriaForm : Form
    {
        private List<Rubro> categoriasSeleccionadas;
        private List<Rubro> categoriasAElegir;

        public List<Rubro> Categorias
        {
            get
            {
                return this.categoriasSeleccionadas;
            }
        }

        public SeleccionCategoriaForm(List<Rubro> categorias)
        {
            InitializeComponent();
            this.categoriasSeleccionadas = categorias;
            this.categoriasAElegir = Rubro.Todos().Where(r => !categoriasSeleccionadas.Contains(r)).ToList();
            Refrescar();
        }
        private void SeleccionCategoriaForm_Load(object sender, EventArgs e)
        {
            listBoxCategorias.DisplayMember = "Descripcion";
            listBoxCategorias.ValueMember = "id";
            listBoxSeleccionadas.DisplayMember = "Descripcion";
            listBoxSeleccionadas.ValueMember = "id";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int selectedValue;
            try
            {
                selectedValue = (int)listBoxCategorias.SelectedValue;
                Console.WriteLine(selectedValue);
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un item");
                return;
            }
            Rubro categoria = categoriasAElegir.First(c => c.id == selectedValue);
            Console.WriteLine(categoria);
            categoriasAElegir.Remove(categoria);
            categoriasSeleccionadas.Add(categoria);
            Refrescar();
        }

        private void Refrescar()
        {
            var seleccionadasBindingList = new BindingList<Rubro>(this.categoriasSeleccionadas);
            listBoxSeleccionadas.DataSource = seleccionadasBindingList;

            var categoriasBindingList = new BindingList<Rubro>(this.categoriasAElegir);
            listBoxCategorias.DataSource = categoriasBindingList;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedValue;
            try
            {
                selectedValue = (int)listBoxSeleccionadas.SelectedValue;
                Console.WriteLine(selectedValue);
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un item");
                return;
            }
            Rubro categoria = categoriasSeleccionadas.First(c => c.id == selectedValue);
            Console.WriteLine(categoria);
            categoriasSeleccionadas.Remove(categoria);
            categoriasAElegir.Add(categoria);
            Refrescar();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

    }    
}
