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
    public partial class SectorNumeradoForm : Form
    {
        public SectorNumerado Sector { get; set; }

        public SectorNumeradoForm()
        {
            InitializeComponent();
            comboTipoUbicacion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoUbicacion.DataSource = TipoUbicacion.Todos();
            precio.Maximum = Decimal.MaxValue;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtFilaDesde.Text.Trim().Equals("") || txtFilaHasta.Text.Trim().Equals(""))
            {
                MessageBox.Show("Debe completar la fila desde y hasta", "Error en el ingreso",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Sector = new SectorNumerado((TipoUbicacion)comboTipoUbicacion.SelectedItem, (int)precio.Value,
                txtFilaDesde.Text[0], txtFilaHasta.Text[0], (int)asientoDesde.Value, (int)asientoHasta.Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
