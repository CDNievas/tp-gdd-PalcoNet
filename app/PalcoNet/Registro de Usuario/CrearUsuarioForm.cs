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
        private Tarjeta tarjetaAPersistir;

        private Rol GetSelectedRol()
        {
            return (Rol)comboTipo.SelectedItem;
        }
        

        private void SetupComboRoles()
        {
            var roles = Roles.TraerTodos()
                .Where(r => (r.EsCliente() || r.EsEmpresa()) & r.habilitado).ToList();

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
            var rol = GetSelectedRol();
            if (rol.EsCliente())
            {
                var form = new Abm_Cliente.AltaCliente();
                form.funcionForm = new Registrarse();
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    clienteAPersistir = form.ClienteActual;
                    tarjetaAPersistir = form.tarjetaAGuardar;
                }
                else
                {
                    clienteAPersistir = null;
                    empresaAPersistir = null;
                }
                    
            }else if (rol.EsEmpresa()){
                var form = new Abm_Empresa_Espectaculo.AltaEmpresaForm(new Abm_Empresa_Espectaculo.Registro());
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                    empresaAPersistir = form.empresaAPersistir;
                else
                {
                    clienteAPersistir = null;
                    empresaAPersistir = null;
                }

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
                if (GetSelectedRol().EsEmpresa())
                {
                    if (empresaAPersistir == null)
                        throw new UserInputException("Debe cargar los datos de la empresa");
                    PersistirEmpresa();
                }
                else if (GetSelectedRol().EsCliente())
                {
                    if (clienteAPersistir == null)
                        throw new UserInputException("Debe cargar los datos del cliente");
                    PersistirCliente();
                }
                this.Close();
                MessageBox.Show("Se ha creado el usuario " + txtUsuario.Text,
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
      
            }
            catch (UserInputException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ProcedureException ex)
            {
                MessageBox.Show(ex.GetSqlErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PersistirEmpresa()
        {
            CreadorDeUsuarios.CrearNuevaEmpresa(empresaAPersistir, txtUsuario.Text, password.Text);
        }

        private void PersistirCliente()
        {
            int idCliente = CreadorDeUsuarios.CrearNuevoCliente(clienteAPersistir, txtUsuario.Text, password.Text);

            this.tarjetaAPersistir.Insert(idCliente);
            

        }


    }
}
