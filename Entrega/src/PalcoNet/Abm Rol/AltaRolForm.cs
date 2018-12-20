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
using PalcoNet.Validadores;

namespace PalcoNet.Abm_Rol
{
    public partial class AltaRolForm : Form
    {
        private FuncionRolForm funcion;
        private Rol rol;
        private ValidadorSoloLetras validador;
        public String TituloForm
        {
            get
            {
                return label2.Text;
            }
            set
            {
                label2.Text = value;
            }
        }

        public AltaRolForm(FuncionRolForm funcion)
        {
            validador = new ValidadorSoloLetras();
            InitializeComponent();
            this.funcion = funcion;
        }

        private void AltaRolForm_Load(object sender, EventArgs e)
        {
            txtNombre.MaxLength = 50;
            LoadFuncionalidades();
            funcion.Setup(this);
        }

        private void LoadFuncionalidades()
        {
            var listaFun = Funcionalidades.TraerTodas();
            funcionalidadesCheckList.Items.AddRange(listaFun.ToArray());
            funcionalidadesCheckList.DisplayMember = "Descripcion";
            funcionalidadesCheckList.CheckOnClick = true;
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

            String msg = "";
            if (String.IsNullOrEmpty(txtNombre.Text))
                msg += "- Debe completar el nombre del rol. \n";

            if (funcionalidadesCheckList.CheckedItems.Count == 0)
                msg += "- El rol debe tener al menos una funcionalidad \n";
            

            if(!String.IsNullOrEmpty(msg)){
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var funcionalidades = funcionalidadesCheckList.CheckedItems.OfType<Funcionalidad>().ToList();
            if(this.rol == null)
                this.rol = new Rol();
            rol.nombre = txtNombre.Text;
            rol.funcionalidades = funcionalidades;

            try
            {
                funcion.Guardar(this, rol);
                this.Close();
            }
            catch (ProcedureException ex)
            {
                MessageBox.Show(ex.GetSqlErrorMessage(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenateCon(Rol rol)
        {
            txtNombre.Text = rol.nombre;

            for (int a = 0; a < funcionalidadesCheckList.Items.Count; a++)
            {
                var unaFuncionalidad = funcionalidadesCheckList.Items[a];
                if(rol.funcionalidades.Contains(unaFuncionalidad))
                    funcionalidadesCheckList.SetItemChecked(a, true);
            }
            this.rol = rol;
                
        }

    }
}
