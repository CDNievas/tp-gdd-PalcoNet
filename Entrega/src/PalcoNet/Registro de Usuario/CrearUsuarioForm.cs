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
        private ValidadorSoloLetrasAndNumeros validador;


        public CrearUsuarioForm()
        {
            validador = new ValidadorSoloLetrasAndNumeros();
            InitializeComponent();
            SetupComboRoles();
            
        }

        private Cliente clienteAPersistir = null;
        private Empresa empresaAPersistir = null;
        private Tarjeta tarjetaAPersistir = null;

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
                empresaAPersistir = null;
                var form = new Abm_Cliente.AltaCliente();
                form.funcionForm = new Registrarse();
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    clienteAPersistir = form.ClienteActual;
                    tarjetaAPersistir = form.tarjetaAGuardar;
                }
                    
            }else if (rol.EsEmpresa()){
                clienteAPersistir = null;
                tarjetaAPersistir = null;
                var form = new Abm_Empresa_Espectaculo.AltaEmpresaForm(new Abm_Empresa_Espectaculo.Registro());
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                    empresaAPersistir = form.empresaAPersistir;

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
                    if (tarjetaAPersistir == null)
                        throw new UserInputException("Debe cargar los datos de la tarjeta");
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void PersistirEmpresa()
        {
            CreadorDeUsuarios.CrearNuevaEmpresa(empresaAPersistir, txtUsuario.Text, password.Text);
        }

        private void PersistirCliente()
        {
            DataBase.GetInstance().WithTransaction(() =>
            {
                int idCliente = CreadorDeUsuarios.CrearNuevoCliente(clienteAPersistir, txtUsuario.Text, password.Text);
                tarjetaAPersistir.SerAsignadaA(idCliente);
            });
            
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.soloLetrasAndNumeros(e);
        }


    }
}
