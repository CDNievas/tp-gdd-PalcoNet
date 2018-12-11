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
    public partial class ActualizarGrado : Form
    {
        private Grado grado;

        public ActualizarGrado(Grado grado)
        {
            InitializeComponent();
            this.grado = grado;
            this.txtDescripcion.Text = grado.descripcion;
            this.txtComision.Text = grado.comision.ToString();
            this.checkEliminado.Checked = grado.eliminado;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtComision.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidarInputs();
            }
            catch (UserInputException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            grado.comision = ValorComision();
            grado.descripcion = txtDescripcion.Text;
            grado.eliminado = checkEliminado.Checked;
            grado.Update();
            Close();
        }

        private void ValidarInputs()
        {
            if (txtDescripcion.Text.Trim().Equals(""))
                throw new UserInputException("Debe agregar una descripción");
            if (new ValidadorNumeroComa(2).IsInvalid(txtComision.Text) && new ValidadorNumerico().IsInvalid(txtComision.Text))
                throw new UserInputException("El formato de la comisión es incorrecto, debe ser un número entero o con dos cifras decimales");
            try{
                if (ValorComision() > 100 || ValorComision() < 0)
                    throw new UserInputException("El porcentaje de comision debe estar entre 0 y 100");
            }catch(UserInputException){
                throw;
            }catch(Exception){
                throw new UserInputException("Formato de comisión inválido");
            }
        }

        private Double ValorComision()
        {
            return Convert.ToDouble(txtComision.Text);
        }
    }
}
