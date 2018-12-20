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
            form.TituloForm = "Alta de rol";
        }
        public void Guardar(AltaRolForm form, Rol rol)
        {
            rol.Persistite();
        }
    }

    public class ModificarRol : FuncionRolForm
    {
        private Rol rol;

        public ModificarRol(Rol rol)
        {
            this.rol = rol;
        }

        public void Setup(AltaRolForm form)
        {
            form.TituloForm = "Modificación de rol";
            form.LlenateCon(rol);
        }
        public void Guardar(AltaRolForm form, Rol rol)
        {
            rol.Update();
        }
    }
}
