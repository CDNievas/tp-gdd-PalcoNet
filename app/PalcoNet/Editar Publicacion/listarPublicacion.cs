using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Editar_Publicacion
{
    public partial class listarPublicacion : Form
    {
        public listarPublicacion()
        {
            InitializeComponent();
        }

        private void listarPublicacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD2C2018DataSet.Publicacion' table. You can move, or remove it, as needed.
            this.publicacionTableAdapter.Fill(this.gD2C2018DataSet.Publicacion);

        }
    }
}
