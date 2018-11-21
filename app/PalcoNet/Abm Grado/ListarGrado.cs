using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Grado
{
    public partial class ListarGrado : Form
    {
        public ListarGrado()
        {
            InitializeComponent();
        }

        private void ListarGrado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD2C2018DataSet.Grado' table. You can move, or remove it, as needed.
            this.gradoTableAdapter.Fill(this.gD2C2018DataSet.Grado);

        }
    }
}
