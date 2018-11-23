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

namespace PalcoNet.Abm_Empresa_Espectaculo
{
    public partial class altaEmpresa : Form
    {
        public altaEmpresa()
        {
            InitializeComponent();
        }

        private List<TextBox> TodosLosTextbox()
        {
            return this.Controls.OfType<TextBox>().ToList<TextBox>();
        }

        private void altaEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpresaLimpiar_Click(object sender, EventArgs e)
        {
            foreach (TextBox t in TodosLosTextbox())
            {
                t.Text = "";
            }
        }

        private void btnEmpresaGuardar_Click(object sender, EventArgs e)
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

            if (this.txtEmpresaCuit.Text.Trim().Equals("")) // todo validar posta
            {
                throw new UserInputException("Cuit inválido");
            }
            if (new ValidadorNumerico().IsInvalid(txtEmpresaTelefono.Text))
            {
                throw new UserInputException("El campo teléfono debe ser numérico");
            }
            if (new ValidadorNumerico().IsInvalid(txtEmpresaNro.Text))
            {
                throw new UserInputException("El campo Número de calle debe ser numérico");
            }
            if (new ValidadorNumerico().IsInvalid(txtEmpresaNro.Text))
            {
                throw new UserInputException("El piso debe ser un valor numérico");
            }
        }

      

        }
    }
