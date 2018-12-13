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
    public partial class AltaTarjeta : Form
    {
        public Tarjeta TarjetaInicial { get; set; }
        public Tarjeta TarjetaFinal { get; set; }
        public Boolean DebeActualizarTarjeta { get; private set; }

        public AltaTarjeta(Tarjeta tarjeta = null, Boolean debeActualizar = true)
        {
            InitializeComponent();
            dateTimeVencimiento.MinDate = Contexto.FechaActual;
            this.comboTipoTarjeta.DataSource = TipoTarjeta.Todos();
            comboTipoTarjeta.DropDownStyle = ComboBoxStyle.DropDownList;
            this.TarjetaInicial = tarjeta;
            this.DebeActualizarTarjeta = debeActualizar;
            if (debeActualizar)
                this.TarjetaFinal = this.TarjetaInicial;
            if (tarjeta != null)
                this.LlenateConDatosDe(tarjeta);
        }

        private void altaTarjeta_Load(object sender, EventArgs e)
        {

        }

        private List<TextBox> TodosLosTextbox()
        {
            return this.Controls.OfType<TextBox>().ToList<TextBox>();
        }

        private void guardarDatosTarjeta_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarInputs();
                Tarjeta nuevaTarjeta = new Tarjeta();
                nuevaTarjeta.nroTarjeta = txtNroTarjeta.Text;
                nuevaTarjeta.codigoSeguridad = Convert.ToInt32(txtCCV.Text);
                nuevaTarjeta.tipoTarjeta = (TipoTarjeta)comboTipoTarjeta.SelectedItem;
                nuevaTarjeta.fechaVencimiento = dateTimeVencimiento.Value;

                Console.WriteLine(nuevaTarjeta);
                if (TarjetaInicial == null || nuevaTarjeta.FueModificadaRespectoA(TarjetaInicial))
                {
                    DebeActualizarTarjeta = true;
                    TarjetaFinal = nuevaTarjeta;
                }
                DialogResult = DialogResult.OK;
                Close();
            }

            catch (UserInputException ex)
            {
                MessageBox.Show(ex.Message, "Error en el ingreso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void ValidarInputs()
        {
            
            if (new ValidadorNumerico().IsInvalid(this.txtNroTarjeta.Text))
                throw new UserInputException("Tarjeta inválida. Debe ser numerica");
            if (new ValidadorNumerico().IsInvalid(txtCCV.Text))
                throw new UserInputException("El CCV debe ser numérico");
            if (txtCCV.Text.Length > 5)
                throw new UserInputException("El CCV tiene que tener como máximo 5 dígitos");

        }

        public void LlenateConDatosDe(Tarjeta tarjeta)
        {
            Console.WriteLine("Llenando form con tarjeta: " + tarjeta);
            txtNroTarjeta.Text = tarjeta.nroTarjeta;
            txtCCV.Text = tarjeta.codigoSeguridad.ToString();
            comboTipoTarjeta.SelectedItem = tarjeta.tipoTarjeta;
            if (tarjeta.fechaVencimiento < Contexto.FechaActual)
                dateTimeVencimiento.MinDate = tarjeta.fechaVencimiento;
            dateTimeVencimiento.Value = tarjeta.fechaVencimiento;

            this.TarjetaInicial = tarjeta;
        }



    }
}
