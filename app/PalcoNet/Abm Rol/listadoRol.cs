using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Rol
{
    public partial class listadoRol : Form
    {
        public listadoRol()
        {
            InitializeComponent();
        }

        private void listadoRol_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD2C2018DataSet.Rol' table. You can move, or remove it, as needed.
            this.rolTableAdapter.Fill(this.gD2C2018DataSet.Rol);

        }
    }
}
