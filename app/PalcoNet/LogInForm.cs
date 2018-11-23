using PalcoNet.LoginUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void logIn_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiarLogIn_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
        }

        private void btnIngresarLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                ValidadorLogin.ValidarLogin(username.Text, password.Text);
                throw new NotImplementedException("debería dejarte acceder a tus funciones");
            }
            catch (ProcedureException ex)
            {
                MessageBox.Show(ex.GetSqlErrorMessage(), "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crearUsuario_Click(object sender, EventArgs e)
        {
            new Registro_de_Usuario.CrearUsuarioForm().Show();
        }
    }
}
