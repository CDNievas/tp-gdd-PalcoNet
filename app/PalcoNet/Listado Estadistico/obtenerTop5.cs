using PalcoNet.DataBasePackage;
using PalcoNet.PublicacionesUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Listado_Estadistico
{
    public partial class ObtenerTop5 : Form
    {
        private int? idEmpresa = null;

        private class Item
        {
            public string Name { get; private set; }
            public int Value { get; private set; }
            public Item(string name, int value)
            {
                Name = name;
                Value = value;
            }
        }

        private List<Control> ControlsBusquedaEmpresas()
        {
            return new List<Control> { lblGrado, lblMes, comboGrado, comboMes };
        }

        private void CambiarVisibilidadControlsBusquedaEmpresas(Boolean unBool)
        {
            ControlsBusquedaEmpresas().ForEach(c => c.Visible = unBool);
        }

        private List<Control> ControlsSeleccionarEmpresas()
        {
            return new List<Control> { btnSeleccionEmpresa, lblEmpresa, txtEmpresa};
        }

        private void CambiarVisibilidadControlsSeleccionarEmpresas(Boolean unBool)
        {
            ControlsSeleccionarEmpresas().ForEach(c => c.Visible = unBool);
        }

        public ObtenerTop5()
        {
            InitializeComponent();
            anioInput.Minimum = 0;
            anioInput.Maximum = Contexto.FechaActual.Year;
            anioInput.Value = Contexto.FechaActual.Year;
            trimestreInput.Minimum = 1;
            trimestreInput.Maximum = 4;
            txtEmpresa.ReadOnly = true;
        }

        private List<Item> MesesByTrimestre(int trimestre)
        {
            switch (trimestre)
            {
                case 1 :
                    return new List<Item>{new Item("Enero", 1), new Item("Febrero", 2), new Item("Marzo", 3) };
                case 2 :
                    return new List<Item> { new Item("Abril", 4), new Item("Mayo", 5), new Item("Junio", 6) };
                case 3 :
                    return new List<Item> { new Item("Julio", 7), new Item("Agosto", 8), new Item("Septiembre", 9) };
                case 4 :
                    return new List<Item> { new Item("Octubre", 10), new Item("Noviembre", 11), new Item("Diciembre", 12) };
                default:
                    return new List<Item>();
            }
        }


        private void obtenerTop5_Load(object sender, EventArgs e)
        {
            tipoListadoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            tipoListadoComboBox.Items.Add(new Item("Empresas con más localidades no vendidas", 1));
            tipoListadoComboBox.Items.Add(new Item("Clientes con mayores puntos vencidos", 2));
            tipoListadoComboBox.Items.Add(new Item("Clientes con mayor cantidad de compras por empresa", 3));
            tipoListadoComboBox.ValueMember = "Value";
            tipoListadoComboBox.DisplayMember = "Name";

            comboGrado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboGrado.DataSource = Grados.Todos();
            comboGrado.DisplayMember = "Descripcion";

            comboMes.DropDownStyle = ComboBoxStyle.DropDownList;

            this.CambiarVisibilidadControlsBusquedaEmpresas(false);
            this.CambiarVisibilidadControlsSeleccionarEmpresas(false);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var anio = anioInput.Value;
            var trimestre = trimestreInput.Value;

            var val = SelectedTipoListadoValue();
            if (val == null)
            {
                MessageBox.Show("Seleccione el tipo de listado requerido");
                return;
            }
            
            switch (val)
            {
                case 1:
                    LlenarListadoEmpresas(anio, trimestre);
                    break;
                case 2:
                    LlenarListadoPuntos(anio, trimestre);
                    break;
                case 3:
                    LlenarListadoClienteCompras(anio, trimestre);
                    break;
            }
        }

        private int? SelectedTipoListadoValue()
        {
            var selectedItem = (Item)tipoListadoComboBox.SelectedItem;

            if (selectedItem == null)
            {
                return null;
            }
            return selectedItem.Value;
        }

        private void LlenarListadoClienteCompras(decimal anio, decimal trimestre)
        {
            if (this.idEmpresa == null)
            {
                MessageBox.Show("Debe seleccionar una empresa");
                return;
            }


            var dt = DataBase.GetInstance()
                .TypedQuery("select * from COMPUMUNDOHIPERMEGARED.ClientesConMasComprasDeEmpresa(@anio, @trimestre, @empresa)"
                , new QueryParameter("anio", SqlDbType.Int, anio)
                , new QueryParameter("trimestre", SqlDbType.Int, trimestre)
                , new QueryParameter("empresa", SqlDbType.Int, (int)this.idEmpresa));
            resultadosDataGrid.DataSource = dt;
            resultadosDataGrid.Columns["Id"].Visible = false;
        }

        private void LlenarListadoPuntos(decimal anio, decimal trimestre)
        {
            var dt = DataBase.GetInstance()
                .TypedQuery("select * from COMPUMUNDOHIPERMEGARED.ClientesConMasPuntosVencidos(@anio, @trimestre)"
                , new QueryParameter("anio", SqlDbType.Int, anio)
                , new QueryParameter("trimestre", SqlDbType.Int, trimestre));
            resultadosDataGrid.DataSource = dt;
            resultadosDataGrid.Columns["Id"].Visible = false;
        }

        private void LlenarListadoEmpresas(decimal anio, decimal trimestre)
        {
            var itemMes = (Item)comboMes.SelectedItem;
            if (itemMes == null)
            {
                MessageBox.Show("Debe seleccionar un mes");
                return;
            }
            var grado = (Grado)comboGrado.SelectedItem;
            if (grado == null)
            {
                MessageBox.Show("Debe seleccionar un grado");
                return;
            }

            var dt = DataBase.GetInstance()
                .TypedQuery("select * from COMPUMUNDOHIPERMEGARED.EmpresasConMenosVentas(@anio, @mes, @grado_id)"
                , new QueryParameter("anio", SqlDbType.Int, anio)
                , new QueryParameter("mes", SqlDbType.Int, itemMes.Value)
                , new QueryParameter("grado_id", SqlDbType.Int, grado.id));
            resultadosDataGrid.DataSource = dt;
        }

        private void tipoListadoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CambiarVisibilidadControlsBusquedaEmpresas(false);
            this.CambiarVisibilidadControlsSeleccionarEmpresas(false);

            switch (SelectedTipoListadoValue())
            {
                case 1:
                    this.CambiarVisibilidadControlsBusquedaEmpresas(true);
                    ActualizarComboMesATrimestre((int)trimestreInput.Value);
                    break;
                case 3:
                    this.CambiarVisibilidadControlsSeleccionarEmpresas(true);
                    break;
            }
        }

        private void ActualizarComboMesATrimestre(int trimestre)
        {
            comboMes.Items.Clear();
            MesesByTrimestre(trimestre).ForEach(mes => comboMes.Items.Add(mes));
            comboMes.DisplayMember = "Name";
        }

        private void trimestreInput_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedTipoListadoValue() == 1)
                ActualizarComboMesATrimestre((int)trimestreInput.Value);
        }

        private void btnSeleccionEmpresa_Click(object sender, EventArgs e)
        {
            var form = new SeleccionEmpresa();
            var dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.idEmpresa = (int)form.empresa.id;
                this.txtEmpresa.Text = form.empresa.razonSocial;
            }
        }
    }
}
