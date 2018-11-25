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
    public partial class ListadoRol : Form
    {
        public ListadoRol()
        {
            InitializeComponent();
        }

        private void listadoRol_Load(object sender, EventArgs e){
        
            ActualizarRoles();
        }

        private void ActualizarRoles()
        {
            var lista = new BindingList<Rol>(Roles.TraerTodos());
            var bindingSource = new BindingSource(lista, null);

            rolesDataGrid.DataSource = bindingSource;
            rolesDataGrid.Columns["id"].Visible = false;
            rolesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rolesDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            rolesDataGrid.AllowUserToResizeColumns = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var ignored = new AltaRolForm(new NuevoRol()).ShowDialog();
        }
    }
}
