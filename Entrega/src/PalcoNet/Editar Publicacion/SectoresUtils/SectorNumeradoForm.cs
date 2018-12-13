using PalcoNet.Validadores;
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
            try
            {
                if (txtFilaDesde.Text.Trim().Equals("") || txtFilaHasta.Text.Trim().Equals(""))
                    throw new UserInputException("Debe ingresar la fila desde y hasta");
                if (asientoDesde.Value > asientoHasta.Value)
                    throw new UserInputException("El asiento desde debe ser menor o igual al asiento hasta");
                Char filaHasta = txtFilaHasta.Text.ToUpper()[0];
                Char filaDesde = txtFilaDesde.Text.ToUpper()[0];
                if(!Char.IsLetter(filaDesde) ||!Char.IsLetter(filaHasta))
                    throw new UserInputException("Las filas deben ser letras (de la a 'A' la 'Z')");
                if(filaDesde > filaHasta)
                    throw new UserInputException("La fila desde debe ser menor o igual a la fila hasta");

                Sector = new SectorNumerado((TipoUbicacion)comboTipoUbicacion.SelectedItem, (int)precio.Value,
                    filaDesde, filaHasta, (int)asientoDesde.Value, (int)asientoHasta.Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (UserInputException ex)
            {
                MessageBox.Show(ex.Message, "Error en el ingreso",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
