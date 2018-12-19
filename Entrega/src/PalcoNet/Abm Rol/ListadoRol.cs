using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Validadores;

namespace PalcoNet.Abm_Rol
{
    public partial class ListadoRol : Form
    {
        private ValidadorSoloLetras validador;

        public ListadoRol()
        {
            validador = new ValidadorSoloLetras();
            InitializeComponent();
            rolesDataGrid.MultiSelect = false;
            rolesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rolesDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            rolesDataGrid.AllowUserToResizeColumns = true;
        }

        private void listadoRol_Load(object sender, EventArgs e){
        
            ActualizarRoles();
        }

        private void ActualizarRoles()
        {
            var lista = new BindingList<Rol>(Roles.BuscarPorNombre(nombre: txtNombre.Text));
            var bindingSource = new BindingSource(lista, null);

            rolesDataGrid.DataSource = bindingSource;
            rolesDataGrid.Columns["id"].Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var ignored = new AltaRolForm(new NuevoRol()).ShowDialog();
            ActualizarRoles();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            var rol = (Rol)rolesDataGrid.CurrentRow.DataBoundItem;
            rol.nombre = txtNombre.Text;
            var ignored = new AltaRolForm(new ModificarRol(rol)).ShowDialog();
            ActualizarRoles();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            var rol = (Rol)rolesDataGrid.CurrentRow.DataBoundItem;
            if (!rol.habilitado)
            {
                MessageBox.Show("Este rol ya se encuentra deshabilitado", "Error al deshabilitar el rol",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show("Está seguro de deshabilitar el rol " + rol.nombre,
                                     "Solicitud de confirmación",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                rol.Eliminate();
                ActualizarRoles();
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            var rol = (Rol)rolesDataGrid.CurrentRow.DataBoundItem;
            if (rol.habilitado)
            {
                MessageBox.Show("Este rol ya se encuentra habilitado", "Error al habilitar el rol",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
                rol.habilitado = true;
                String sql = String.Format(@"update COMPUMUNDOHIPERMEGARED.Rol
                                            set habilitado = 1
                                            where id_rol = {0}", rol.id);

                DataBase.GetInstance().Query(sql);
                ActualizarRoles();
            
        }

        private void btnGradoBuscar_Click(object sender, EventArgs e)
        {
            ActualizarRoles();
        }

        private void btnGradoLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            ActualizarRoles();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.soloLetras(e);
        }
    }
}
