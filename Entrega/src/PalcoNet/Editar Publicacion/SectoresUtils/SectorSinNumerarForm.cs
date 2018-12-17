using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Editar_Publicacion.SectoresUtils
{
    public partial class SectorSinNumerarForm : Form
    {
        public SectorSinNumerar Sector { get; set; }

        public SectorSinNumerarForm()
        {
            InitializeComponent();
        }

        private void SectorSinNumerarForm_Load(object sender, EventArgs e)
        {
            comboTipoUbicacion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoUbicacion.DataSource = TipoUbicacion.Todos();
            cantidad.Minimum = 1;
            cantidad.Maximum = Decimal.MaxValue;
            precio.Maximum = Decimal.MaxValue;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                Sector = new SectorSinNumerar((TipoUbicacion)comboTipoUbicacion.SelectedItem, (int)precio.Value,
                    (int)cantidad.Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un tipo de ubicación");
            }
        }
    }
}
