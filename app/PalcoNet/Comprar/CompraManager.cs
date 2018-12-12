using PalcoNet.Abm_Cliente;
using PalcoNet.DataBasePackage;
using PalcoNet.Editar_Publicacion;
using PalcoNet.PublicacionesUtils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Comprar
{
    public class CompraManager
    {
        private long idCompra;

        public long IdCompra { get { return idCompra;}}

        public void RealizarCompra(Cliente cliente, Tarjeta tarjeta, Publicacion publicacion, List<Ubicacion> ubicaciones)
        {
            try
            {
                ubicaciones.ForEach(u => Console.WriteLine("Ubicacion: " + u.Id));
                var ubicacionesDt = GetUbicacionesTable(ubicaciones);
                var parametroSalida = new ParametroOut("compra_id", SqlDbType.Int);
                DataBase.GetInstance()
                    .Procedure("ComprarUbicaciones",
                    new ParametroIn("ubicaciones_table", ubicacionesDt),
                    new ParametroIn("cliente_id", cliente.id),
                    new ParametroIn("tarjeta_id", tarjeta.id),
                    new ParametroIn("fecha", Contexto.FechaActual),
                    parametroSalida);
                this.idCompra = Convert.ToInt64(parametroSalida.valorRetorno);
            }
            catch (Exception ex)
            {
                throw new CompraException("Error al realizar compra", ex);
            }
        }

        private DataTable GetUbicacionesTable(List<Ubicacion> ubicaciones)
        {
            DataTable dataTable = new DataTable();
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int64");
            column.ColumnName = "ubicacion_id";
            dataTable.Columns.Add(column);

            foreach (Ubicacion u in ubicaciones)
            {
                row = dataTable.NewRow();
                row["ubicacion_id"] = u.Id;
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }

        public void SumarPuntos()
        {
            try
            {
                DataBase.GetInstance().Procedure("RegistrarPuntosDeCompra", new ParametroIn("compra_id", this.IdCompra));
            }
            catch
            {
                throw new PuntosException();
            }
        }
    }
}
