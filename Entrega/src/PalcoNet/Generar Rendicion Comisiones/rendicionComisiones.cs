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
using PalcoNet.DataBasePackage;

namespace PalcoNet.Generar_Rendicion_Comisiones
{
    public partial class GenerarRendiciones : Form
    {
        public Empresa empresaActual;
        public int comprasARendir;

        public GenerarRendiciones(Empresa empresa, int cantidadComprasARendir)
        {
            empresaActual = empresa;
            comprasARendir = cantidadComprasARendir;
            InitializeComponent();
        }

        private void GenerarRendiciones_Load(object sender, EventArgs e)
        {
            dataGridViewRendirComisiones.MultiSelect = false;
            ActualizarTabla();
            if (dataGridViewRendirComisiones.RowCount == 0)
            {
                MessageBox.Show("Esta empresa no tiene compras disponibles para rendir");
                Close();
                return;
            }
            var cantCompras = dataGridViewRendirComisiones.RowCount;
            if (cantCompras < comprasARendir)
            {
                DialogResult result = MessageBox.Show("Esta empresa sólo tiene " + cantCompras + " para rendir\n¿Desea continuar rindiendo esa cantidad?",
                    "", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    Close();
            }
        }

        private void ActualizarTabla()
        {
            BuscadorCompras buscador = new BuscadorCompras();
            var unasCompras = buscador.
                filtrarCompras(empresaActual.id, comprasARendir);
            this.dataGridViewRendirComisiones.DataSource = unasCompras;
            this.dataGridViewRendirComisiones.Columns["empresa_ID"].Visible = false;
            this.dataGridViewRendirComisiones.Columns["compra_ID"].Visible = false;

            double total = 0;
            for (int i = 0; i < dataGridViewRendirComisiones.Rows.Count; ++i){
                total += Convert.ToDouble(dataGridViewRendirComisiones.Rows[i].Cells["Comisión a cobrar"].Value);
            }

            this.label1.Text += "$ " + total;
  
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
                        throw new Exception("Debe empezas rindiendo las facturas mas viejas");*/                        
                    
                    /*var facturaARendir = facturasActuales[e.RowIndex];

                    var dr = DataBase.GetInstance().Query("SELECT SUM(CAST ((it.item_factura_monto*comision/100.0) AS decimal(6,2))) as comision_cobrada FROM COMPUMUNDOHIPERMEGARED.Item_Factura it INNER JOIN COMPUMUNDOHIPERMEGARED.Ubicacion u ON it.ubicacion_id = u.id_ubicacion INNER JOIN COMPUMUNDOHIPERMEGARED.Publicacion p ON u.publicacion_id = p.id_publicacion INNER JOIN COMPUMUNDOHIPERMEGARED.Grado g ON p.grado_id = g.id_grado WHERE factura_id = "+ facturaARendir.id +" GROUP BY factura_id ORDER BY it.factura_id");
                    float comisionCobrada = (float) dr.Rows[0]["comision_cobrada"];

                    var dt = DataBase.GetInstance().Query("SELECT f.empresa_id AS empresaID, razon_social AS razonSocial FROM COMPUMUNDOHIPERMEGARED.Factura f INNER JOIN COMPUMUNDOHIPERMEGARED.Empresa e ON f.empresa_id = e.id_empresa WHERE f.id_factura = " + facturaARendir.id);
                    int empresaID = (int) dt.Rows[0]["empresaID"];
                    String razonSocial = (String) dt.Rows[0]["razonSocial"];

                    if (facturasActuales.Exists(f => f.fact_fecha < facturaARendir.fact_fecha))
                        throw new Exception("Debe empezar rindiendo las facturas mas viejas");
                    //facturaARendir.Rendida = 1;
                    //_facturaRepositorio.Guardar(facturaARendir);
                    MessageBox.Show(String.Format("Se rindio la comision de la factura {0} a la empresa con ID: {1} y razon social: {2} con una comision de ${3}",
                        facturaARendir.fact_nro, empresaID, razonSocial,comisionCobrada,
                        "Rendicion OK", MessageBoxButtons.OK, MessageBoxIcon.None));

                    dataGridViewRendirComisiones.Rows.Clear();
                    Inicializar();*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Rendicion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRendirComisiones_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase.GetInstance().Procedure("RendirComisionesDeEmpresa",
                    new ParametroIn("empresa_id", empresaActual.id),
                    new ParametroIn("cantidad_a_rendir", comprasARendir),
                    new ParametroIn("fecha_actual", Contexto.FechaActual));
                Close();
                MessageBox.Show("Compras rendidas");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "\n" + ex.Message + "\n" + ex.StackTrace);
                MessageBox.Show("Error al rendir comisiones");
            }
        }


    }
}
