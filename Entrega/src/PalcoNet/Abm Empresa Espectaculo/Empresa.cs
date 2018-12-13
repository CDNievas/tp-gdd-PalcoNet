using PalcoNet.DataBasePackage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Abm_Empresa_Espectaculo
{
    public class Empresa
    {
        public long id {get; private set;}

        [DisplayName("Razón Social")]
        public String razonSocial { get; set; }

        [DisplayName("CUIT")]
        public String cuit { get; set; }

        [DisplayName("E-mail")]
        public String mail { get; set; }

        [DisplayName("Teléfono")]
        public String telefono { get; set; }

        [DisplayName("Ciudad")]
        public String ciudad { get; set; }

        [DisplayName("Localidad")]
        public String localidad { get; set; }

        [DisplayName("Calle")]
        public String domCalle { get; set; }

        [DisplayName("Nro. Calle")]
        public String nroCalle { get; set; }

        [DisplayName("Piso")]
        public int? piso { get; set; }

        [DisplayName("Depto.")]
        public String depto { get; set; }

        [DisplayName("C.P.")]
        public String codPostal { get; set; }

        [DisplayName("Fecha Creación")]
        public DateTime fechaCreacion { get; set; }

        public Boolean Habilitado { get; set; }
        

        public override string ToString()
        {
            return String.Format("Empresa({4}, {0}, {1}, {2}, {3})", cuit, razonSocial, mail, fechaCreacion, id);
        }

        public static Empresa traerDe(DataRow dr)
        {
            var empresa = new Empresa();
            var _dr = new DataRowExtended(dr);

            empresa.id = Convert.ToInt64(dr["id_empresa"].ToString());
            empresa.cuit = dr["cuit"].ToString();
            empresa.razonSocial = dr["razon_social"].ToString();
            empresa.mail = dr["mail"].ToString();
            empresa.telefono = dr["telefono"].ToString();
            empresa.ciudad = dr["ciudad"].ToString();
            empresa.localidad = dr["localidad"].ToString();
            empresa.domCalle = dr["dom_calle"].ToString();
            empresa.nroCalle = dr["nro_calle"].ToString();
            empresa.piso = _dr.Fold<int?>("piso", null, n => Convert.ToInt32(n.ToString()));
            empresa.depto = dr["depto"].ToString();
            empresa.codPostal = dr["cod_postal"].ToString();
            empresa.fechaCreacion = (DateTime)dr["fecha_creacion"];
            empresa.Habilitado = _dr.BoolValue("habilitado");

            return empresa;
        }


        public void Update()
        {
            var varchar = SqlDbType.NVarChar;
            String sql = @"update COMPUMUNDOHIPERMEGARED.Empresa
            set cuit = @cuit, razon_social = @razon, mail = @mail, telefono = @telefono,
            ciudad = @ciudad, localidad = @localidad, dom_calle = @domCalle, nro_calle = @nroCalle,
            piso = @piso, depto = @depto, cod_postal = @codPostal, habilitado = @habilitado
            where id_empresa = @idEmpresa";

            DataBase.GetInstance()
                .TypedQuery(sql,
                new QueryParameter("cuit", varchar, cuit),
                new QueryParameter("razon", varchar, razonSocial),
                new QueryParameter("mail", varchar, mail),
                new QueryParameter("telefono", varchar, telefono),
                new QueryParameter("ciudad", varchar, ciudad),
                new QueryParameter("localidad", varchar, localidad),
                new QueryParameter("domCalle", varchar, domCalle),
                new QueryParameter("nroCalle", SqlDbType.Decimal, nroCalle),
                new QueryParameter("piso", SqlDbType.Decimal, piso),
                new QueryParameter("depto", varchar, depto),
                new QueryParameter("codPostal", varchar, codPostal),
                new QueryParameter("habilitado", SqlDbType.Bit, Habilitado? 1 : 0),
                new QueryParameter("idEmpresa", SqlDbType.Int, id));
        }
    }
}
