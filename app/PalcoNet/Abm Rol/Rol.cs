using PalcoNet.LoginUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Abm_Rol
{
    public class Rol
    {
        public short id {get; private set; }

        [DisplayName("Nombre")]
        public String nombre { get; set; }

        public List<Funcionalidad> funcionalidades { get; set; }

        [DisplayName("Funcionalidades")]
        public String funcionalidadesString {
            get{
                var stringArr = funcionalidades.Select(x => x.Descripcion).ToArray<String>();
                return string.Join(",", stringArr);
            }
        }

        [DisplayName("Habilitado?")]
        public Boolean habilitado {get; set; }

        public Rol(String nombre, List<Funcionalidad> funcionalidades) {
            this.nombre = nombre;
            this.funcionalidades = funcionalidades;
            this.habilitado = true;
        }

        public Boolean EsCliente(){
            return this.nombre.ToLower().Equals("cliente");
        }

        public Boolean EsEmpresa(){
            return this.nombre.ToLower().Equals("empresa");
        }

        public Boolean EsAdministrador(){
            return this.nombre.ToLower().Equals("administrador");
        }

        public Rol() { }

        public static Rol TraerDe(DataRow dr)
        {
            var rol = new Rol();
            rol.id = Convert.ToInt16(dr["id_rol"]);
            rol.nombre = dr["nombre"].ToString();
            rol.habilitado = Convert.ToBoolean(dr["habilitado"]);
            rol.funcionalidades = Funcionalidades.findFuncionalidadesByRolId(rol.id);
            return rol;
        }

        public override string ToString()
        {
            return String.Format("Rol({0}, {1}, {2})", id, nombre, habilitado);
        }

        public void Eliminate(){
            DataBase.GetInstance().Procedure("eliminar_rol", new ParametroIn("id_rol", id));
        }

        public void Persistite() {
            var dataTable = GetFuncionalidadesTable();
            DataBase.GetInstance().Procedure("crearNuevoRol",
                new ParametroIn("listaFuncionalidad", dataTable),
                new ParametroIn("nombre", this.nombre));
        }

        private DataTable GetFuncionalidadesTable()
        {
            DataTable dataTable = new DataTable();
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int16");
            column.ColumnName = "funcionalidad_id";
            dataTable.Columns.Add(column);

            foreach (Funcionalidad f in funcionalidades)
            {
                row = dataTable.NewRow();
                row["funcionalidad_id"] = f.Id;
                dataTable.Rows.Add(row);
            }
            return dataTable;

        }

        public void Update() {
            var funcionalidadesTable = GetFuncionalidadesTable();
            DataBase.GetInstance().Procedure("actualizarRol",
                new ParametroIn("rol_id", this.id),
                new ParametroIn("listaFuncionalidad", funcionalidadesTable));
        }
    }
}
