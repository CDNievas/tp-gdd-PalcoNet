using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Generar_Publicacion
{
    public partial class DateTimeForm : Form
    {
        public DateTime Fecha { get; set; }

        public DateTimeForm()
        {
            InitializeComponent();
        }

        private void DateTimeForm_Load(object sender, EventArgs e)
        {
            pickerFecha.MinDate = Contexto.FechaActual;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Fecha = pickerFecha.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
