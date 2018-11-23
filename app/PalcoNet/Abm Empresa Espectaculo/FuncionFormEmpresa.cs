using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalcoNet.Abm_Empresa_Espectaculo
{
    public interface FuncionFormEmpresa
    {
        void Setup(AltaEmpresaForm form);
        void Guardar(AltaEmpresaForm form, Empresa empresa);
    }

    public class Modificacion : FuncionFormEmpresa
    {
        private Empresa empresa;

        public Modificacion(Empresa empresa)
        {
            this.empresa = empresa;
        }

        public void Setup(AltaEmpresaForm form)
        {
            form.LlenateCon(empresa);
        }

        public void Guardar(AltaEmpresaForm form, Empresa empresa)
        {
            Console.WriteLine("Updating empresa con ID " + empresa.id);
            empresa.Update();
            form.Close();
        }
    }

    public class Registro : FuncionFormEmpresa
    {

        public void Setup(AltaEmpresaForm form)
        {
            // no hace nada
        }

        public void Guardar(AltaEmpresaForm form, Empresa empresa)
        {
            throw new NotImplementedException();
        }
    }
}
