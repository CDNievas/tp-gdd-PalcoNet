using PalcoNet.Editar_Publicacion;
using PalcoNet.PublicacionesUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Generar_Publicacion
{
    public partial class PublicacionMultiFechaForm : Form
    {
        private Publicacion publicacion;
        public List<DateTime> fechas { get; set; }
        private List<Sector> sectores;

        public PublicacionMultiFechaForm(List<Sector> sectores, Publicacion publicacion)
        {
            InitializeComponent();
            this.sectores = sectores;
            this.publicacion = publicacion;
            this.fechas = new List<DateTime>();
        }

        private void PublicacionMultiFechaForm_Load(object sender, EventArgs e){
            UpdateListBox();
        }

        public void UpdateListBox()
        {
            var bindingList = new BindingList<DateTime>(this.fechas);
            fechasListBox.DataSource = bindingList;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!EstanOrdenadas(fechas))
            {
                MessageBox.Show("Las fechas deben ser ingresadas en órden.");
                return;
            }
            if (fechas.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una fecha");
                return;
            }
            if (fechas[0] < Contexto.FechaActual)
            {
                MessageBox.Show("La fecha en que se publicará no puede ser anterior a la actual");
                return;
            }

            try
            {
                Publicacion.PublicarFechas(publicacion, fechas, sectores);
                Close();
                MessageBox.Show("Se han realizado las publicaciones");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("No se pudo realizar la publicacion");
            }

        }

        private Boolean EstanOrdenadas(List<DateTime> fechas)
        {
            var otraLista = new List<DateTime>(fechas);

            otraLista.Sort();
            return otraLista.SequenceEqual(fechas);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            fechas.Remove(Selected());
            UpdateListBox();
        }

        private DateTime Selected()
        {
            return (DateTime)fechasListBox.SelectedItem;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new DateTimeForm();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                fechas.Add(form.Fecha);
                UpdateListBox();
            }
        }

    }
}
