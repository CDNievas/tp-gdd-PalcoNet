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
        void Guardar(EditarPublicacion form, Publicacion publicacion);
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

        public void Guardar(EditarPublicacion form, Publicacion publicacion)
        {
            throw new NotImplementedException();
        }
    }
}
