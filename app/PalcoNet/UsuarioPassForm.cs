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
    public partial class UsuarioPassForm : Form
    {
        public UsuarioPassForm(string user, string pass)
        {
            InitializeComponent();

            txtUser.ReadOnly = true;
            txtUser.Text = user;

            txtPass.ReadOnly = true;
            txtPass.Text = pass;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
