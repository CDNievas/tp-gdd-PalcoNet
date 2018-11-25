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
    public partial class AltaEmpresaForm : Form
    {
        private FuncionFormEmpresa funcion;
        public Empresa empresaAPersistir = null;

        public AltaEmpresaForm(FuncionFormEmpresa funcion)
        {
            this.funcion = funcion;
            InitializeComponent();
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
                empresaAPersistir.piso = txtEmpresaPiso.Text.Trim().Equals("") ? null : (int?)Convert.ToInt32(txtEmpresaPiso.Text);
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
            
            
        }

        private void ValidarInputs()
        {
            foreach (TextBox t in TodosLosTextbox())
            {
                if(!t.Equals(txtEmpresaDpto) && !t.Equals(txtEmpresaPiso))
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
            empresaAPersistir = empresa;
            Console.WriteLine("Empresa a persistir " + empresaAPersistir);
        }
    }
    }
