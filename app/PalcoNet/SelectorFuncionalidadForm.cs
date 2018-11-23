using PalcoNet.LoginUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet
{
    public partial class SelectorFuncionalidadForm : Form
    {
        public List<Funcionalidad> Funcionalidades;

        public SelectorFuncionalidadForm()
        {
            InitializeComponent();
        }

        private void SelectorFuncionalidadForm_Load(object sender, EventArgs e)
        {
            boxFuncionalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            boxFuncionalidad.DataSource = Funcionalidades;
            boxFuncionalidad.ValueMember = "Id";
            boxFuncionalidad.DisplayMember = "Descripcion";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                SelectorFuncionalidad.EjecutarFuncionalidad(Convert.ToInt16(boxFuncionalidad.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
