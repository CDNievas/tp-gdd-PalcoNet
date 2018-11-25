using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.PublicacionesUtils
{
    class Grados
    {
        public static List<Grado> Todos()
        {
            var dt = DataBase.GetInstance().Query(@"select * from COMPUMUNDOHIPERMEGARED.Grado");
            return GradosFromDataTable(dt);
        }

        public static List<Grado> GradosFromDataTable(DataTable dt)
        {
            var grados = new List<Grado>();
            foreach (DataRow dr in dt.Rows)
            {
                grados.Add(Grado.FromDataRow(dr));
            }
            return grados;
        }

        public static Grado FindGradoById(int gradoId)
        {
            String sql = String.Format("select * from COMPUMUNDOHIPERMEGARED.Grado where id_grado = {0}", gradoId);
            var dt = DataBase.GetInstance().Query(sql);
            return Grado.FromDataRow(dt.Rows[0]);
        }
    }
}
