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
    public partial class altaTarjeta : Form
    {
        public Tarjeta TarjetaActual { get; set; }
        public FuncionFormTarjeta funcionForm { get; set; }

        public altaTarjeta()
        {
            InitializeComponent();
            dateTimeVencimiento.MinDate = Contexto.FechaActual;
            this.comboTipoTarjeta.DataSource = TipoTarjeta.Todos();
            comboTipoTarjeta.DropDownStyle = ComboBoxStyle.DropDownList;
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
                Tarjeta tarjeta = TarjetaActual == null ? new Tarjeta() : TarjetaActual;
                tarjeta.nroTarjeta = txtNroTarjeta.Text;
                tarjeta.codigoSeguridad = txtCCV.Text;
                tarjeta.tipoTarjeta = (TipoTarjeta)comboTipoTarjeta.SelectedItem;
                tarjeta.fechaVencimiento = dateTimeVencimiento.Value;


                Console.WriteLine(tarjeta);
                funcionForm.Guardar(this, tarjeta);
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
            { }

            if (new ValidadorNumerico().IsInvalid(this.txtNroTarjeta.Text))
                throw new UserInputException("Tarjeta inválida. Debe ser numerica");
            if (new ValidadorNumerico().IsInvalid(txtCCV.Text))
                throw new UserInputException("El CCV debe ser numérico");
        }

        internal void LlenateConDatosDe(Abm_Cliente.Tarjeta tarjeta)
        {
            txtNroTarjeta.Text = tarjeta.nroTarjeta;
            txtCCV.Text = tarjeta.codigoSeguridad;
            comboTipoTarjeta.SelectedItem = tarjeta.tipoTarjeta;
            if (tarjeta.fechaVencimiento != null)
                dateTimeVencimiento.Value = (DateTime)tarjeta.fechaVencimiento;

            this.TarjetaActual = tarjeta;
        }

    }
}
