using PalcoNet.Validadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Cliente
{
    public partial class AltaClienteForm : Form
    {
        public AltaClienteForm()
        {
            InitializeComponent();
            fechaNacimiento.MinDate = new DateTime(1880, 1, 1);
            fechaNacimiento.MaxDate = DateTime.Now;
        }

        private List<TextBox> TodosLosTextbox()
        {
            return this.Controls.OfType<TextBox>().ToList<TextBox>();
        }

        private void btnClienteLimpiar_Click(object sender, EventArgs e)
        {
            TodosLosTextbox().ForEach(t => t.Text = "");
        }

        private void btnDatosTarjeta_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException("Registrar targeta");
        }

        private void btnClienteGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarInputs();
            }
            catch (UserInputException ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarInputs()
        {
            foreach (TextBox t in TodosLosTextbox())
            {
                if (t.Text.Trim().Equals(""))
                    throw new UserInputException("Debe completar todos los campos");
            }
            if (new ValidadorEmail().IsInvalid(this.txtClienteEmail.Text))
                throw new UserInputException("E-mail inválido");
            if(new ValidadorNumerico().IsInvalid(txtClienteTelefono.Text))
                throw new UserInputException("El teléfono debe ser numérico");
            if (new ValidadorNumerico().IsInvalid(txtClienteNro.Text))
                throw new UserInputException("El numéro de calle debe ser numérico");

        }


    }
}
