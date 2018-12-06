using PalcoNet.PublicacionesUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalcoNet.Editar_Publicacion
{
    public interface FuncionFormPublicacion
    {
        void Setup(EditarPublicacion form);
        void GuardarBorrador(EditarPublicacion form, Publicacion publicacion);
//        void Publicar(EditarPublicacion form, Publicacion publicacion)
    }

    public class FuncionModificarPublicacion : FuncionFormPublicacion
    {
        private Publicacion publicacion;

        public FuncionModificarPublicacion(Publicacion publicacion)
        {
            this.publicacion = publicacion;
        }

        public void Setup(EditarPublicacion form)
        {
            form.LlenateCon(publicacion);
        }

        public void GuardarBorrador(EditarPublicacion form, Publicacion publicacion)
        {
            publicacion.UpdateBorrador(Contexto.GetEmpresaLogeadaId());
            form.GuardarSectores();
        }
    }

    public class FuncionCrearPublicacion : FuncionFormPublicacion
    {
        public void Setup(EditarPublicacion form)
        {
            form.CargarSectoresVacios();
        }

        public void GuardarBorrador(EditarPublicacion form, Publicacion publicacion)
        {
            publicacion.GuardarBorrador(Contexto.GetEmpresaLogeadaId());
            form.GuardarSectores();
        }
    }
}
