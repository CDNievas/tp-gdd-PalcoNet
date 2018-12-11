using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Canje_Puntos;
using PalcoNet.Abm_Cliente;

namespace PalcoNet.Canje_Puntos
{
    public partial class CanjearPuntos : Form
    {
        private Cliente cliente;

        private Boolean SoloDisponibles
        {
            get
            {
                return checkSoloDisponibles.Checked;
            }
        }

        public CanjearPuntos(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void canjearPuntos_Load(object sender, EventArgs e)
        {
            lblPuntosCliente.Text = cliente.GetPuntos().ToString();
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            var lista = new BindingList<Premio>(Premio.GetPremiosPorCantPuntos(cliente.GetPuntos(), SoloDisponibles));
            var bindingSource = new BindingSource(lista, null);

            premiosDataGrid.DataSource = bindingSource;
            premiosDataGrid.Columns["id"].Visible = false;
            
        }

        private void checkSoloDisponibles_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void btnCanjear_Click(object sender, EventArgs e)
        {
            var premio = premiosDataGrid.CurrentRow.DataBoundItem as Premio;
            if (cliente.GetPuntos() < premio.puntosRequeridos)
            {
                MessageBox.Show("No posee suficientes puntos para este premio");
                return;
            }
            String msg = String.Format("¿Está seguro de canjear {0} puntos por un {1}?", lblCanjearPuntos.Text, premio.Descripcion);
            DialogResult dialogResult = MessageBox.Show(msg, "Solicitud de confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;

            try
            {//@cliente_id int, @premio_id int, @fecha_actual datetime
                DataBase.GetInstance()
                    .Procedure("realizarCanje",
                    new ParametroIn("cliente_id", cliente.id),
                    new ParametroIn("premio_id", premio.Id),
                    new ParametroIn("fecha_actual", Contexto.FechaActual));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
                MessageBox.Show("Ha ocurrido un error");
                return;
            }
            MessageBox.Show("Canje realizado");
            ActualizarTabla();
            lblPuntosCliente.Text = cliente.GetPuntos().ToString();
        }

      
    }
}
