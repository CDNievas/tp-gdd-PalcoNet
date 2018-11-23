﻿using PalcoNet.Validadores;
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
    public partial class AltaClienteForm : Form
    {
        public Cliente Cliente { get; set; }
        public LlamadoDesde llamadoDesde { get; set; }

        public AltaClienteForm()
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
            throw new NotImplementedException("Registrar targeta");
        }

        private void btnClienteGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarInputs();
                Cliente cliente = new Cliente();
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
                llamadoDesde.apply(this, cliente);
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

        }



        
    }
}