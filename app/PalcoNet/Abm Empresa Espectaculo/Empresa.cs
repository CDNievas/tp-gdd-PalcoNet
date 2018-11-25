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

            return empresa;
        }


        internal void Update()
        {
            String sql = String.Format(@"update COMPUMUNDOHIPERMEGARED.Empresa
            set cuit = '{0}', razon_social = '{1}', mail = '{2}', telefono = '{3}',
            ciudad = '{4}', localidad = '{5}', dom_calle = '{6}', nro_calle = {7},
            piso = {8}, depto = '{9}', cod_postal = '{10}'
            where id_empresa = {11}
            ", cuit, razonSocial, mail, telefono,
             ciudad, localidad, domCalle, nroCalle,
             piso == null? null : piso, depto, codPostal,
             id);
            var ignored = DataBase.GetInstance().Query(sql);
        }
    }
}
