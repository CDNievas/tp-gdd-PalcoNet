using PalcoNet.LoginUtils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Abm_Rol
{
    class Rol
    {
        public short id {get; set; }
        public List<Funcionalidad> funcionalidades {get; set; }
        public String nombre {get; set; }
        public Boolean habilitado {get; set; }

        public Rol(String nombre, List<Funcionalidad> funcionalidades) {
            this.nombre = nombre;
            this.funcionalidades = funcionalidades;
            this.habilitado = true;
        }

        private Rol() { }

        public static Rol traerDe(DataRow dr)
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

        public void eliminate(){
            DataBase.GetInstance().procedure("eliminar_rol", new ParametroIn("id_rol", id));
        }

        public void Persistite() {
            var dataTable = getFuncionalidadesTable();
            DataBase.GetInstance().procedure("crearNuevoRol",
                new ParametroIn("listaFuncionalidad", dataTable),
                new ParametroIn("nombre", this.nombre));
        }

        private DataTable getFuncionalidadesTable()
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
                row["funcionalidad_id"] = f.id;
                dataTable.Rows.Add(row);
            }
            return dataTable;

        }

        public void Update() {
            var funcionalidadesTable = getFuncionalidadesTable();
            DataBase.GetInstance().procedure("actualizarRol",
                new ParametroIn("rol_id", this.id),
                new ParametroIn("listaFuncionalidad", funcionalidadesTable));
        }
    }
}
