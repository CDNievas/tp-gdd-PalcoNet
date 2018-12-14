using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Abm_Cliente;
using PalcoNet.Abm_Empresa_Espectaculo;
using PalcoNet.Comprar;

namespace PalcoNet.Generar_Rendicion_Comisiones
{
    public partial class GenerarRendiciones : Form
    {
        private Cliente clienteActual;
        private Empresa empresaActual;
        private List<Factura> facturasActuales;

        public GenerarRendiciones(Cliente cliente)
        {
            clienteActual = cliente;
            InitializeComponent();

            Inicializar();
        }

        private void Inicializar()
        {
            facturasActuales = traerFacturas();
            //facturasActuales.Sort((x, y) => DateTime.Compare(x.fact_fecha, y.fact_fecha));


            InicializarGrilla();
        }

        private void InicializarGrilla()
        {
            foreach (var factura in facturasActuales)
            {
                var dt = DataBase.GetInstance().Query("SELECT * FROM COMPUMUNDOHIPERMEGARED.Item_Factura where factura_id = " + factura.id);
                int cantidadLocalidades = dt.Columns.Count;

                DataGridViewRow row = (DataGridViewRow)dataGridViewRendirComisiones.Rows[0].Clone();
                row.Cells[0].Value = factura.fact_nro;
                row.Cells[1].Value = cantidadLocalidades;
                row.Cells[2].Value = factura.fact_fecha;
                row.Cells[3].Value = factura.fact_total;
                row.Cells[4].Value = clienteActual.nombre;
                //row.Cells[5].Value = 

                dataGridViewRendirComisiones.Rows.Add(row);
            }
        }

        public static Factura traerDe(DataRow dr)
        {
            var factura = new Factura();
            var data = new DataRowExtended(dr);

            factura.id = data.LongValue("id_factura");

            factura.fact_nro = data.Fold<int?>("numero", null, x => Convert.ToInt32(x.ToString()));
            factura.fact_fecha = data.OrElse<DateTime?>("fecha", null);
            factura.fact_total = data.Fold<int?>("total", null, x => Convert.ToInt32(x.ToString()));
            factura.fact_pago_desc = data.StringValue("forma_pago");
            factura.empresa_id = data.Fold<int?>("empresa_id", null, x => Convert.ToInt32(x.ToString()));

            return factura;
        }

        public static List<Factura> traerFacturas()
        {
            List<Factura> listaFacturas = new List<Factura>();

            var dt = DataBase.GetInstance().Query("SELECT * FROM COMPUMUNDOHIPERMEGARED.Factura");
            int cantidadDeFacturas = dt.Columns.Count;

            for (int i = 0; i < cantidadDeFacturas; i++)
            {
                Factura fact = traerDe(dt.Rows[i]);
                listaFacturas.Add(fact);
            }

            return listaFacturas;
        }

        private void GenerarRendiciones_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    /*
                    if (e.RowIndex != 0)
                        throw new Exception("Debe empezas rindiendo las facturas mas viejas");
                        */

                    var facturaARendir = facturasActuales[e.RowIndex];
                    if (facturasActuales.Exists(f => f.fact_fecha < facturaARendir.fact_fecha))
                        throw new Exception("Debe empezar rindiendo las facturas mas viejas");
                    //facturaARendir.Rendida = 1;
                    //_facturaRepositorio.Guardar(facturaARendir);
                    /*MessageBox.Show(String.Format("Se rindio la comision de la factura {0} a la empresa {1} con una comision de ${2}",
                        facturaARendir.Numero, facturaARendir.Empresa.RazonSocial, facturaARendir.Items.Sum(i => i.Comision)),
                        "Rendicion OK", MessageBoxButtons.OK, MessageBoxIcon.None);*/

                    dataGridViewRendirComisiones.Rows.Clear();
                    Inicializar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Rendicion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
