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
    public partial class AltaCliente : Form
    {
        public Cliente ClienteActual { get; set; }
        public FuncionFormCliente funcionForm { get; set; }
        public Tarjeta tarjetaAGuardar { get; set; }
        public CheckBox CheckHabilitado
        {
            get
            {
                return checkHabilitado;
            }
        }

        public String Titulo
        {
            get
            {
                return this.titulo.Text;
            }
            set
            {
                this.titulo.Text = value;
            }
        }

        public AltaCliente()
        {
            InitializeComponent();
            fechaNacimiento.MinDate = new DateTime(1880, 1, 1);
            fechaNacimiento.MaxDate = Contexto.FechaActual;

            
            comboTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoDoc.DataSource = TipoDocumento.Todos();
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
            altaTarjeta altaTarjeta = new altaTarjeta();
            altaTarjeta.funcionForm = new RegistrarTarjeta();
            var resultado = altaTarjeta.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.tarjetaAGuardar = altaTarjeta.TarjetaActual;
            }

        }

        private void btnClienteGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarInputs();
                Cliente cliente = ClienteActual == null? new Cliente() : ClienteActual;
                cliente.cuil = txtClienteCuil.Text;
                cliente.tipoDocumento = (TipoDocumento)comboTipoDoc.SelectedItem;
                cliente.nroDocumento = txtClienteDoc.Text;
                cliente.nombre = txtClienteNombre.Text;
                cliente.apellido = txtClienteApellido.Text;
                cliente.mail = txtClienteEmail.Text;
                cliente.telefono = txtClienteTelefono.Text;
                cliente.ciudad = txtCiudad.Text;
                cliente.localidad = txtClienteLoc.Text;
                cliente.domCalle = txtClienteCalle.Text;
                cliente.nroCalle = txtClienteNro.Text;
                cliente.codPostal = txtClienteCP.Text;

                try
                {
                    cliente.piso = Convert.ToInt32(txtPiso.Text);
                }
                catch (Exception)
                {
                    cliente.piso = null;
                }

                if (txtClienteDpto.Text != null && !txtClienteDpto.Text.Trim().Equals(""))
                    cliente.depto = txtClienteDpto.Text;
                else
                    cliente.depto = null;

                cliente.fechaNacimiento = fechaNacimiento.Value;
                cliente.fechaCreacion = Contexto.FechaActual;

                Console.WriteLine(cliente);
                funcionForm.Guardar(this, cliente);
            }
            catch (UserInputException ex)
            {
                MessageBox.Show(ex.Message, "Error en el ingreso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarInputs()
        {
            foreach (TextBox t in TodosLosTextbox())
            {
                if(!t.Equals(txtPiso) & !t.Equals(txtClienteDpto))
                    if (t.Text.Trim().Equals(""))
                        throw new UserInputException("Debe completar todos los campos");
            }
            if (!txtPiso.Text.Trim().Equals("") && new ValidadorNumerico().IsInvalid(txtPiso.Text))
                throw new UserInputException("Piso inválido");
            if (new ValidadorEmail().IsInvalid(this.txtClienteEmail.Text))
                throw new UserInputException("E-mail inválido");
            if(new ValidadorNumerico().IsInvalid(txtClienteTelefono.Text))
                throw new UserInputException("El teléfono debe ser numérico");
            if (new ValidadorNumerico().IsInvalid(txtClienteNro.Text))
                throw new UserInputException("El numéro de calle debe ser numérico");
            if (new ValidadorCuil().IsInvalid(txtClienteCuil.Text))
                throw new UserInputException("Cuil inválido");

            string dniFromCuil = txtClienteCuil.Text.Split(new[] { "-" }, StringSplitOptions.None)[1];
            if (!dniFromCuil.Equals(txtClienteDoc.Text))
                throw new UserInputException("El CUIL y el DNI no coinciden");
        }

        private void AltaClienteForm_Load(object sender, EventArgs e)
        {
            funcionForm.Setup(this);
        }

        public void LlenateConDatosDe(Abm_Cliente.Cliente cliente)
        {
            txtClienteNombre.Text = cliente.nombre;
            txtClienteApellido.Text = cliente.apellido;
            comboTipoDoc.SelectedItem = cliente.tipoDocumento;
            txtClienteDoc.Text = cliente.nroDocumento;
            txtClienteCuil.Text = cliente.cuil;
            txtClienteEmail.Text = cliente.mail;
            txtClienteTelefono.Text = cliente.telefono;
            txtClienteCalle.Text = cliente.nroCalle;
            txtClienteNro.Text = cliente.nroCalle;
            txtPiso.Text = cliente.piso.ToString();
            txtClienteDpto.Text = cliente.depto;
            txtClienteLoc.Text = cliente.localidad;
            txtCiudad.Text = cliente.ciudad;
            txtClienteCP.Text = cliente.codPostal;
            if(cliente.fechaNacimiento != null)
                fechaNacimiento.Value = (DateTime)cliente.fechaNacimiento;
            checkHabilitado.Checked = cliente.Habilitado;
            this.ClienteActual = cliente;
        }
    }
}
