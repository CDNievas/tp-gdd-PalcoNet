using PalcoNet.DataBasePackage;
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
    public partial class ListarUsuaries : Form
    {
        private Pagina pagina;
        public ListarUsuaries()
        {
            InitializeComponent();
            pagina = new Pagina(1, 15);
        }

        private void ListarUsuaries_Load(object sender, EventArgs e)
        {
            this.Text = "Usuarios";
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            usuariesDataGrid.DataSource = String.IsNullOrWhiteSpace(txtUsername.Text) ? BuscarUsuarios() : BuscarUsuariosPorNombre();
        }

        private DataTable BuscarUsuarios()
        {
            return DataBase.GetInstance().Query(@"select id_usuario as ID, username as [Nombre usuario],
            intentos as [Cantidad de Intentos],
            habilitado as [¿Habilitado?], eliminado as [¿Eliminado?]
            from COMPUMUNDOHIPERMEGARED.Usuario "
            + String.Format(" ORDER BY id_usuario OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY",
            pagina.FirstResultIndex(), pagina.pageSize));
        }

        private DataTable BuscarUsuariosPorNombre()
        {
            return DataBase.GetInstance().TypedQuery(@"select id_usuario as ID, username as [Nombre usuario],
            intentos as [Cantidad de Intentos],
            habilitado as [¿Habilitado?], eliminado as [¿Eliminado?]
            from COMPUMUNDOHIPERMEGARED.Usuario
            where username like @namelike "
                + String.Format(" ORDER BY id_usuario OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY",
            pagina.FirstResultIndex(), pagina.pageSize)
                , new QueryParameter("namelike", SqlDbType.NVarChar, "%" + txtUsername.Text + "%"));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.pagina.pageNumber = 1;
            ActualizarTabla();
        }

        //Habilitar / deshabilitar
        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            Usuarie usuarie;
            try{
                usuarie = SelectedUser();
            }catch(Exception ex){
                Console.WriteLine(ex + "\n" + ex.Message + "\n" + ex.StackTrace);
                MessageBox.Show("Debe seleccionar un usuario");
                return;
            }
            if (usuarie.Habilitado)
            {
                MessageBox.Show("Este usuario ya se encontraba habilitado");
                return;
            }
            usuarie.Habilitar();
            ActualizarTabla();
        }

        //Eliminar / dar de alta
        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            Usuarie usuarie;
            try
            {
                usuarie = SelectedUser();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex + "\n" + ex.Message + "\n" + ex.StackTrace);
                MessageBox.Show("Debe seleccionar un usuario");
                return;
            }
            usuarie.CambiarEstadoEliminacion();
            ActualizarTabla();
        }

        private Usuarie SelectedUser()
        {
            var cells = usuariesDataGrid.CurrentRow.Cells;
            return new Usuarie(id:Convert.ToInt32(cells["ID"].Value),
                habilitado: Convert.ToBoolean(cells["¿Habilitado?"].Value),
                eliminado: Convert.ToBoolean(cells["¿Eliminado?"].Value));
        }

        private void btnPagAnt_Click(object sender, EventArgs e)
        {
            pagina.Previous();
            ActualizarTabla();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            ActualizarTabla();
        }

        private void btnPagSig_Click(object sender, EventArgs e)
        {
            pagina.Next();
            ActualizarTabla();
            if (usuariesDataGrid.RowCount == 0)
            {
                pagina.Previous();
                ActualizarTabla();
            }
        }
    }
}
