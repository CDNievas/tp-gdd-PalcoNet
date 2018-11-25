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

namespace PalcoNet.Abm_Rol
{
    public partial class AltaRolForm : Form
    {
        private FuncionRolForm funcion;

        public AltaRolForm(FuncionRolForm funcion)
        {
            InitializeComponent();
            this.funcion = funcion;
        }

        private void AltaRolForm_Load(object sender, EventArgs e)
        {
            var listaFun = Funcionalidades.TraerTodas();
            funcionalidadesCheckList.Items.AddRange(listaFun.ToArray());
            funcionalidadesCheckList.DisplayMember = "Descripcion";
            funcionalidadesCheckList.CheckOnClick = true;
            funcion.Setup(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (int i in funcionalidadesCheckList.CheckedIndices)
            {
                funcionalidadesCheckList.SetItemCheckState(i, CheckState.Unchecked);
            }
            txtNombre.Text = "";
        }

        private void btnClienteGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Equals("") || funcionalidadesCheckList.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe ingresar todos los datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var funcionalidades = funcionalidadesCheckList.CheckedItems.OfType<Funcionalidad>().ToList();;
            var rol = new Rol(txtNombre.Text.Trim(), funcionalidades);

            funcion.Guardar(this, rol);
        }
    }
}
