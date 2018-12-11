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
        public ConsultaPuntos()
        {
            InitializeComponent();
        }

        private void ConsultaPuntos_Load(object sender, EventArgs e)
        {
            this.Text = "Canje de puntos";
            puntos.Text = Contexto.ClienteLogeado.GetPuntos().ToString();
        }

        private void btnPremios_Click(object sender, EventArgs e)
        {
            new CanjearPuntos(Contexto.ClienteLogeado).ShowDialog();
            puntos.Text = Contexto.ClienteLogeado.GetPuntos().ToString();            
        }
    }
}