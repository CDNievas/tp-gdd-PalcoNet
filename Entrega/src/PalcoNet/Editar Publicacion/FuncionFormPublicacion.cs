using PalcoNet.Abm_Empresa_Espectaculo;
using PalcoNet.PublicacionesUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalcoNet.Editar_Publicacion
{
    public abstract class FuncionFormPublicacion
    {
        public Empresa Empresa { get; set; }
        public abstract void Setup(EditarPublicacion form);
        public abstract void GuardarBorrador(EditarPublicacion form, Publicacion publicacion);

    }

    public class FuncionModificarPublicacion : FuncionFormPublicacion
    {
        private Publicacion publicacion;

        public FuncionModificarPublicacion(Publicacion publicacion)
        {
            this.publicacion = publicacion;
        }

        public override void Setup(EditarPublicacion form)
        {
            form.LlenateCon(publicacion);
        }

        public override void GuardarBorrador(EditarPublicacion form, Publicacion publicacion)
        {
            publicacion.UpdateBorrador(this.Empresa.id);
            form.GuardarSectores();
        }
    }

    public class FuncionCrearPublicacion : FuncionFormPublicacion
    {

        public override void Setup(EditarPublicacion form)
        {
            form.CargarSectoresVacios();
        }

        public override void GuardarBorrador(EditarPublicacion form, Publicacion publicacion)
        {
            publicacion.GuardarBorrador(this.Empresa.id);
            form.GuardarSectores();
        }
    }
}
