using PalcoNet.PublicacionesUtils;
using PalcoNet.Validadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Grado
{
    public partial class AltaGrado : Form
    {
        public AltaGrado()
        {
            InitializeComponent();
        }

        private void btnGradoLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcionGrado.Text = "";
            txtComision.Text = "";
        }

        private void AltaGrado_Load(object sender, EventArgs e)
        {

        }

        private void btnGradoGuardar_Click(object sender, EventArgs e)
        {
            Double porcentaje;
            if (new ValidadorNumeroComa(2).IsInvalid(txtComision.Text) && new ValidadorNumerico().IsInvalid(txtComision.Text))
            {
                MessageBox.Show("El formato de la comisión es incorrecto, debe ser un número entero o con dos cifras decimales");
                return;
            }

            try
            {
                porcentaje = Convert.ToDouble(txtComision.Text);
            }
            catch
            {
                MessageBox.Show("La comisión debe ser un número");
                return;
            }
            if (porcentaje > 100 || porcentaje < 0)
            {
                MessageBox.Show("El porcentaje de comisión debe estar entre 0 y 100");
                return;
            }
            if (txtDescripcionGrado.Text.Trim().Equals(""))
            {
                MessageBox.Show("Debe ingresar una descripción");
                return;
            }
            var grado = new Grado(txtDescripcionGrado.Text, porcentaje);
            grado.Guardarse();
            Close();
        }
    }
}
