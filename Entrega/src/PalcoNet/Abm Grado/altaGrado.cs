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
            txtDescripcionGrado.MaxLength = 25;
            txtComision.MaxLength = 7;
        }

        private void btnGradoGuardar_Click(object sender, EventArgs e)
        {
            Double porcentaje = 0;
            string msg = "";

            if (new ValidadorNumeroComa(2).IsInvalid(txtComision.Text) && new ValidadorNumerico().IsInvalid(txtComision.Text))
            {
                msg += "- El formato de la comisión es incorrecto, debe ser un número entero o con dos cifras decimales\n";
            }
            if (txtDescripcionGrado.Text.Trim().Equals(""))
            {
                msg += "- Debe ingresar una descripción\n";
            }
            try
            {
                porcentaje = Convert.ToDouble(txtComision.Text);
                if (porcentaje > 100 || porcentaje < 0)
                {
                    msg += "- El porcentaje de comisión debe estar entre 0 y 100\n";
                }
            }
            catch
            {
                msg += "- La comisión debe ser un número\n";
            }

            if (!String.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg);
                return;
            }

            var grado = new Grado(txtDescripcionGrado.Text, porcentaje);
            grado.Guardarse();
            Close();


        }
    }
}
