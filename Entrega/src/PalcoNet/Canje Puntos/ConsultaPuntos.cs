using PalcoNet.Abm_Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Canje_Puntos
{
    public partial class ConsultaPuntos : Form
    {
        private Cliente cliente;
        public ConsultaPuntos(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void ConsultaPuntos_Load(object sender, EventArgs e)
        {
            this.Text = "Canje de puntos";
            puntos.Text = cliente.GetPuntos().ToString();
        }

        private void btnPremios_Click(object sender, EventArgs e)
        {
            new CanjearPuntos(cliente).ShowDialog();
            puntos.Text = cliente.GetPuntos().ToString();            
        }
    }
}