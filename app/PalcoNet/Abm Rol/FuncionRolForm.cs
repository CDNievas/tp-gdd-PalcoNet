using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Abm_Rol
{
    public interface FuncionRolForm
    {
        void Setup(AltaRolForm form);
        void Guardar(AltaRolForm form, Rol rol);
    }

    public class NuevoRol : FuncionRolForm
    {
        public void Setup(AltaRolForm form)
        {
            //nada
        }
        public void Guardar(AltaRolForm form, Rol rol)
        {
            rol.Persistite();
        }
    }
}
