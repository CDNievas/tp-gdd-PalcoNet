using PalcoNet.Validadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private ValidadorSoloLetras validadorLetras;
        private ValidadorSoloLetrasAndNumeros validadorLetrasAndNumeros;
        private ValidadorNumerico validadorNumerico;
        public Tarjeta tarjetaAGuardar { get; set; }
        public Boolean DebeGuardarTarjeta { get; set; }
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
            validadorLetras = new ValidadorSoloLetras();
            validadorLetrasAndNumeros = new ValidadorSoloLetrasAndNumeros();
            validadorNumerico = new ValidadorNumerico();

            
            comboTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoDoc.DataSource = TipoDocumento.Todos();
            ConfigurarLargoTextbox();
        }

        private void ConfigurarLargoTextbox()
        {
            txtClienteNombre.MaxLength = 255;
            txtClienteApellido.MaxLength = 255;
            txtClienteDoc.MaxLength = 30;
            txtClienteCuil.MaxLength = 13;
            txtClienteEmail.MaxLength = 255;
            txtClienteTelefono.MaxLength = 30;
            txtClienteCalle.MaxLength = 255;
            txtClienteNro.MaxLength = 9;
            txtPiso.MaxLength = 9;
            txtClienteDpto.MaxLength = 255;
            txtClienteLoc.MaxLength = 255;
            txtCiudad.MaxLength = 255;
            txtClienteCP.MaxLength = 255;

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
            AltaTarjeta altaTarjeta = new AltaTarjeta(this.tarjetaAGuardar, this.DebeGuardarTarjeta);
            var resultado = altaTarjeta.ShowDialog();
 
            if (resultado == DialogResult.OK && altaTarjeta.DebeActualizarTarjeta)
            {
                this.tarjetaAGuardar = altaTarjeta.TarjetaFinal;
                this.DebeGuardarTarjeta = true;
            }

        }

        private void btnClienteGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarInputs();
                Cliente cliente = ClienteActual == null ? new Cliente() : ClienteActual;
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

                if (this.tarjetaAGuardar == null && this.DebeGuardarTarjeta)
                {
                    MessageBox.Show("Debe ingresar los datos de la tarjeta");
                    return;
                }

                Console.WriteLine(cliente);
                funcionForm.Guardar(this, cliente);
            }
            catch (UserInputException ex)
            {
                MessageBox.Show(ex.Message, "Error en el ingreso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                if (ex.GetBaseException().GetType() == typeof(SqlException))
                {
                    Int32 ErrorCode = ((SqlException)ex.InnerException).Number;
                    switch (ErrorCode)
                    {
                        case 2627:  // Unique constraint error
                            MessageBox.Show("El DNI de este cliente ya existe en el sistema", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        default:
                            MessageBox.Show("Error al guardar el cliente", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Error al guardar el cliente", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ValidarInputs()
        {
            String msg = "";
            Boolean camposIncompletos = false;

            foreach (TextBox t in TodosLosTextbox())
            {
                if (!t.Equals(txtPiso) & !t.Equals(txtClienteDpto))
                    if (t.Text.Trim().Equals(""))
                        camposIncompletos = true;
            }

            if(camposIncompletos)
                msg += "Debe completar todos los campos. \n";
            if(!new ValidadorSoloLetras().IsValid(txtClienteNombre.Text))
                msg += "- Nombre debe contener solo letras. \n";
            if (!new ValidadorSoloLetras().IsValid(txtClienteApellido.Text))
                msg += "- Apellido debe contener solo letras. \n";
            if (new ValidadorNumerico().IsInvalid(txtClienteDoc.Text))
                msg += "- Documento debe contener solo numeros. \n";
            if (!new ValidadorSoloLetrasAndNumeros().IsValid(txtClienteCalle.Text))
                msg += "- Calle debe contener solo letras y números. \n";
            if (!txtPiso.Text.Trim().Equals("") && new ValidadorNumerico().IsInvalid(txtPiso.Text))
                msg += "- Piso debe ser numerico. \n";
            if (new ValidadorEmail().IsInvalid(this.txtClienteEmail.Text))
                msg += "- Email debe tener la forma ejemplo@mail.com \n";
            if (new ValidadorNumerico().IsInvalid(txtClienteTelefono.Text))
                msg += "- Telefono debe ser numerico. \n";
            if (new ValidadorNumerico().IsInvalid(txtClienteNro.Text))
                msg += "- Numero de calle debe ser numerico. \n";
            if (new ValidadorCuil().IsInvalid(txtClienteCuil.Text))
                msg += "- CUIL debe tener formato XX-XXXXXXXX-X. \n";

            try
            {
                string dniFromCuil = txtClienteCuil.Text.Split(new[] { "-" }, StringSplitOptions.None)[1];
                if (!dniFromCuil.Equals(txtClienteDoc.Text))
                    msg += "- CUIL y DNI no coinciden. \n";
            }
            catch 
            {
                msg += "- CUIL debe tener formato XX-XXXXXXXX-X.\n";
            }


            if (!msg.Equals("")) {
                throw new UserInputException(msg); 
            }

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

        /*
        private void txtClienteNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadorLetras.soloLetras(e);
        }

        private void txtClienteApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadorLetras.soloLetras(e);
        }

        private void txtClienteCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadorLetrasAndNumeros.soloLetrasAndNumeros(e);
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadorLetras.soloLetras(e);
        }

        private void txtClienteDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadorNumerico.soloNumeros(e);
        }

        private void txtClienteTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadorNumerico.soloNumeros(e);
        }

        private void txtPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadorNumerico.soloNumeros(e);
        }

        private void txtClienteLoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadorLetrasAndNumeros.soloLetrasAndNumeros(e);
        }

        private void txtClienteCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadorLetrasAndNumeros.soloLetrasAndNumeros(e);
        }

        private void txtClienteNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            validadorNumerico.soloNumeros(e);
        }*/

    }
}
