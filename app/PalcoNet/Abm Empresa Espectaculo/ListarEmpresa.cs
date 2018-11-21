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
    public partial class ListarEmpresa : Form
    {
        public ListarEmpresa()
        {
            InitializeComponent();
        }

        private void ListarEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD2C2018DataSet.Empresa' table. You can move, or remove it, as needed.
            this.empresaTableAdapter.Fill(this.gD2C2018DataSet.Empresa);

        }
    }
}
