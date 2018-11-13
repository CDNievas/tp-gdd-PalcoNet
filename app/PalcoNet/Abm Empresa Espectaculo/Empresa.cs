using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Abm_Empresa_Espectaculo
{
    class Empresa
    {
        long id {get; set;}
        String cuit { get; set; }
        String razonSocial { get; set; }
        String mail { get; set; }
        String telefono { get; set; }
        String ciudad { get; set; }
        String localidad { get; set; }
        String domCalle { get; set; }
        String nroCalle { get; set; }
        int piso { get; set; }
        String depto { get; set; }
        String codPostal { get; set; }
        DateTime fechaCreacion { get; set; }
        

        public override string ToString()
        {
            return String.Format("Empresa({0}, {1}, {2}, {3})", cuit, razonSocial, mail, fechaCreacion);
        }

        public static Empresa traerDe(DataRow dr)
        {
            var empresa = new Empresa();

            empresa.id = Convert.ToInt64(dr["id_empresa"].ToString());
            empresa.cuit = dr["cuit"].ToString();
            empresa.razonSocial = dr["razon_social"].ToString();
            empresa.mail = dr["mail"].ToString();
            empresa.telefono = dr["telefono"].ToString();
            empresa.ciudad = dr["ciudad"].ToString();
            empresa.localidad = dr["localidad"].ToString();
            empresa.domCalle = dr["dom_calle"].ToString();
            empresa.nroCalle = dr["nro_calle"].ToString();
            empresa.piso = Convert.ToInt32(dr["piso"].ToString());
            empresa.depto = dr["depto"].ToString();
            empresa.codPostal = dr["cod_postal"].ToString();
            empresa.fechaCreacion = (DateTime)dr["fecha_creacion"];

            return empresa;
        }
        
    }
}
