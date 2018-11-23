using PalcoNet.Abm_Rol;
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

namespace PalcoNet.Registro_de_Usuario
{
    public partial class CrearUsuarioForm : Form
    {
        public CrearUsuarioForm()
        {
            InitializeComponent();
            SetupComboRoles();
            
        }

        private void SetupComboRoles()
        {
            var roles = Roles.traerTodos();

            comboTipo.DataSource = roles;
            comboTipo.DisplayMember = "nombre";
            comboTipo.ValueMember = "nombre";
            comboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnDisponible_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException("Debería checkear si el nombre está disponible");
        }

        private void btnAgregarInfo_Click(object sender, EventArgs e)
        {
            var texto = comboTipo.SelectedValue.ToString().ToUpper();
            if (texto.Equals("CLIENTE"))
            {
                new Abm_Cliente.AltaClienteForm().Show();
            }else if (texto.Equals("EMPRESA")){
                new Abm_Empresa_Espectaculo.altaEmpresa().Show();
            }else{
                MessageBox.Show("Este tipo de usuario no posee campos adicionales", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClienteLimpiar_Click(object sender, EventArgs e)
        {
            password.Text = "";
            txtUsuario.Text = "";
            txtConfirmarContra.Text = "";
        }

        private void btnClienteCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var username = txtUsuario.Text;
                var pass1 = password.Text;
                var pass2 = txtConfirmarContra.Text;

                if (pass1.Equals(pass2))
                {
                    throw new UserInputException("El password no se corresponde con la confirmacion");
                }
            }
            catch (UserInputException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
