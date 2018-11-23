﻿using PalcoNet.DataBasePackage;
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
    public partial class ListarCliente : Form
    {
        private Pagina paginaActual;

        public ListarCliente()
        {
            InitializeComponent();

        }

        private List<TextBox> TodosLosTextbox()
        {
            return this.Controls.OfType<TextBox>().ToList<TextBox>();
        }

        private void ListarCliente_Load(object sender, EventArgs e)
        {
            paginaActual = new Pagina(1, 25);
            ActualizarTabla();
        }

        private void btnClienteBaja_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ActualizarTabla()
        {
            var lista = new BindingList<Cliente>(new Buscador().
                filtrarClientes(nombre: txtName.Text, apellido:txtApellido.Text,
                dni: txtDocumento.Text, email: txtMail.Text, pag: paginaActual));
            var bindingSource = new BindingSource(lista, null);

            this.clientesDataGrid.DataSource = bindingSource;
            this.clientesDataGrid.Columns["id"].Visible = false;
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TodosLosTextbox().ForEach(t => t.Text = "");
            ActualizarTabla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            paginaActual.pageNumber = 1;
            ActualizarTabla();
        }

        private void btnPagSig_Click(object sender, EventArgs e)
        {
            paginaActual.Next();
            ActualizarTabla();
        }

        private void btnPagAnt_Click(object sender, EventArgs e)
        {
            paginaActual.Previous();
            ActualizarTabla();
        }

       

        
    }
}