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

namespace PalcoNet.Abm_Empresa_Espectaculo
{
    public partial class AltaEmpresaForm : Form
    {
        private FuncionFormEmpresa funcion;
        public Empresa empresaAPersistir = null;

        public String Titulo
        {
            get
            {
                return titulo.Text;
            }
            set
            {
                titulo.Text = value;
            }
        }

        public CheckBox CheckHabilitado
        {
            get { return checkHabilitado; }
        }


        public AltaEmpresaForm(FuncionFormEmpresa funcion)
        {
            this.funcion = funcion;
            InitializeComponent();
            ConfigurarLargoTextBox();
        }
        
        private void ConfigurarLargoTextBox()
        {
            txtEmpresaRS.MaxLength = 255;
            txtEmpresaCuit.MaxLength = 255;
            txtEmpresaEmail.MaxLength = 50;
            txtEmpresaTelefono.MaxLength = 30;
            txtEmpresaCiudad.MaxLength = 255;
            txtEmpresaLocalidad.MaxLength = 255;
            txtEmpresaCalle.MaxLength = 50;
            txtEmpresaNro.MaxLength = 9;
            txtEmpresaPiso.MaxLength = 9;
            txtEmpresaDpto.MaxLength = 50;
            txtEmpresaCP.MaxLength = 50;
        }

        private List<TextBox> TodosLosTextbox()
        {
            return this.Controls.OfType<TextBox>().ToList<TextBox>();
        }

        private void altaEmpresa_Load(object sender, EventArgs e)
        {
            funcion.Setup(this);
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
                if (empresaAPersistir == null)
                    empresaAPersistir = new Empresa();

                empresaAPersistir.razonSocial = txtEmpresaRS.Text;
                empresaAPersistir.cuit = txtEmpresaCuit.Text;
                empresaAPersistir.mail = txtEmpresaEmail.Text;
                empresaAPersistir.telefono = txtEmpresaTelefono.Text;
                empresaAPersistir.ciudad = txtEmpresaCiudad.Text;
                empresaAPersistir.localidad = txtEmpresaLocalidad.Text;
                empresaAPersistir.domCalle = txtEmpresaCalle.Text;
                empresaAPersistir.nroCalle = txtEmpresaNro.Text;
                empresaAPersistir.piso = String.IsNullOrWhiteSpace(txtEmpresaPiso.Text) ? null : (int?)Convert.ToInt32(txtEmpresaPiso.Text);
                empresaAPersistir.depto = String.IsNullOrWhiteSpace(txtEmpresaDpto.Text) ? null : txtEmpresaDpto.Text;
                empresaAPersistir.codPostal = txtEmpresaCP.Text;
                empresaAPersistir.fechaCreacion = Contexto.FechaActual;

                Console.WriteLine("Persistien3 " + empresaAPersistir);
                funcion.Guardar(this, empresaAPersistir);
            }
            catch (UserInputException ex)
            {
                MessageBox.Show(ex.Message, "Error",
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
                            MessageBox.Show("El CUIL de esta empresa ya existe en el sistema", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        default:
                            MessageBox.Show("Error al guardar la empresa", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Error al guardar la empresa", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        private void ValidarInputs()
        {
            String msg = "";
            
            foreach (TextBox t in TodosLosTextbox())
            {
                if(!t.Equals(txtEmpresaDpto) && !t.Equals(txtEmpresaPiso))
                    if (String.IsNullOrWhiteSpace(t.Text))
                        msg += "Debe completar todos los campos. \n";
            }

            if (new ValidadorCuil().IsInvalid(txtEmpresaCuit.Text))
                msg += "- CUIL debe tener formato XX-XXXXXXXX-X. \n";           
            if (new ValidadorNumerico().IsInvalid(txtEmpresaTelefono.Text))
                msg += "- Telefono debe ser numerico. \n";
            if (new ValidadorEmail().IsInvalid(this.txtEmpresaEmail.Text))
                msg += "- Email debe tener la forma ejemplo@mail.com \n";
            if (new ValidadorNumerico().IsInvalid(txtEmpresaNro.Text))
                msg += "- Numero de calle debe ser numerico. \n";          
            var piso = txtEmpresaPiso.Text;
            if (!String.IsNullOrWhiteSpace(piso) && new ValidadorNumerico().IsInvalid(piso))        
                msg += "- Piso debe ser numerico. \n";   

            if (!msg.Equals(""))
            {
                throw new UserInputException(msg);
            }

        }

        internal void LlenateCon(Empresa empresa)
        {
            txtEmpresaRS.Text = empresa.razonSocial;
            txtEmpresaCuit.Text = empresa.cuit;
            txtEmpresaEmail.Text = empresa.mail;
            txtEmpresaTelefono.Text = empresa.telefono;
            txtEmpresaCiudad.Text = empresa.ciudad;
            txtEmpresaLocalidad.Text = empresa.localidad;
            txtEmpresaCalle.Text = empresa.domCalle;
            txtEmpresaNro.Text = empresa.nroCalle;
            txtEmpresaPiso.Text = empresa.piso == null? "" : empresa.piso.ToString();
            txtEmpresaDpto.Text = empresa.depto;
            txtEmpresaCP.Text = empresa.codPostal;
            checkHabilitado.Checked = empresa.Habilitado;
            empresaAPersistir = empresa;
            Console.WriteLine("Empresa a persistir " + empresaAPersistir);
        }
    }
    }
