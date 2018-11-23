using PalcoNet.Abm_Cliente;
using PalcoNet.Abm_Empresa_Espectaculo;
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

        private Cliente clienteAPersistir;
        private Empresa empresaAPersistir;

        private String GetSelectedText()
        {
            return ((Rol)comboTipo.SelectedItem).nombre;
        }
        

        private void SetupComboRoles()
        {
            var roles = Roles.traerTodos()
                .Where(r => r.nombre.ToUpper().Equals("CLIENTE") || r.nombre.ToUpper().Equals("EMPRESA")).ToList();

            comboTipo.DataSource = roles;
            comboTipo.DisplayMember = "nombre";
            comboTipo.ValueMember = "id";
            comboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnDisponible_Click(object sender, EventArgs e)
        {
            if(LoginUtils.ValidadorLogin.EstaDisponible(txtUsuario.Text)){
                lblEstado.Text = "Sí";
            }
            else{
                lblEstado.Text = "No";
            }
        }

        private void btnAgregarInfo_Click(object sender, EventArgs e)
        {
            var texto = GetSelectedText();
            if (texto.Equals("CLIENTE"))
            {
                var form = new Abm_Cliente.AltaClienteForm();
                form.funcionForm = new Registrarse();
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                    clienteAPersistir = form.ClienteActual;
                    
            }else if (texto.Equals("EMPRESA")){
                new Abm_Empresa_Espectaculo.AltaEmpresaForm(new Abm_Empresa_Espectaculo.Registro()).Show();
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
                var pass1 = password.Text;
                var pass2 = txtConfirmarContra.Text;

                if (!pass1.Equals(pass2))
                {
                    throw new UserInputException("El password no se corresponde con la confirmacion");
                }
                if (GetSelectedText().ToUpper().Equals("EMPRESA"))
                {
                    throw new NotImplementedException();
                }
                else if (GetSelectedText().ToUpper().Equals("CLIENTE"))
                {
                    PersistirCliente();
                }
            }
            catch (UserInputException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PersistirCliente()
        {
            try
            {
                CreadorDeUsuarios.CrearNuevoCliente(clienteAPersistir, txtUsuario.Text, password.Text,
                    Convert.ToInt32(comboTipo.SelectedValue.ToString()));
            }
            catch (ProcedureException e)
            {
                MessageBox.Show(e.GetSqlErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Console.WriteLine("PERSISTI3");
        }


    }
}
