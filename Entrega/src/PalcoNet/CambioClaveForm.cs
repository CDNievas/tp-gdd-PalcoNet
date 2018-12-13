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
    public partial class CambioClaveForm : Form
    {
        private int usuarioId;
        private string username;
        private string password;

        public CambioClaveForm(int usuarioId, string username)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
            this.txtUsuario.Text = username;
            this.txtUsuario.ReadOnly = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Trim().Equals("") || txtConfirmacion.Text.Trim().Equals(""))
            {
                MessageBox.Show("Debe ingresar la contraseña");
                return;
            }

            if (!txtPass.Text.Equals(txtConfirmacion.Text))
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }
            if (txtPass.Text.Length > 50)
            {
                MessageBox.Show("La máxima longitud de la contraseña son 50 caracteres");
                return;
            }
            var password = txtPass.Text;

            Console.WriteLine(String.Format("Nuevo pass: '{0}', Id user: {1}", password, this.usuarioId));

            DataBase.GetInstance()
                .TypedQuery(@"update COMPUMUNDOHIPERMEGARED.Usuario
                         set password = HASHBYTES('SHA2_256', @pass), solicitud_cambio_pass = 0
                         where id_usuario = @id"
                , new QueryParameter("pass", SqlDbType.NVarChar, password)
                , new QueryParameter("id", SqlDbType.Int, this.usuarioId));
            Close();
        }
    }
}
