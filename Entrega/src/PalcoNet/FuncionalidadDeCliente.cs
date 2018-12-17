using PalcoNet.Abm_Cliente;
using PalcoNet.Abm_Rol;
using PalcoNet.LoginUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet
{
    public abstract class FuncionalidadDeCliente
    {
        public void Ejecutarse()
        {
            var usuarioId = (int)Contexto.idUsuarioLogueado;

            Cliente cliente;
            if (Roles.RolesDeUsuario(usuarioId).Any(rol => rol.EsCliente()))
            {
                if (!Contexto.ClienteLogeado.Habilitado)
                {
                    MessageBox.Show("Este cliente no está habilitado para realizar funcionalidades de cliente");
                    return;
                }
                cliente = Contexto.ClienteLogeado;
            }
            else
            {
                var form = new SelectorClienteForm();
                DialogResult result = form.ShowDialog();
                if (result != DialogResult.OK)
                    return;
                cliente = form.Cliente;
            }
            this.RealizarFuncionalidad(cliente);
        }
        public abstract void RealizarFuncionalidad(Cliente cliente);
    }

    public class FuncionalidadComprar : FuncionalidadDeCliente
    {
        public override void RealizarFuncionalidad(Cliente cliente)
        {
            new Comprar.Comprar(cliente).ShowDialog();
        }
    }

    public class FuncionalidadPuntos : FuncionalidadDeCliente
    {
        public override void RealizarFuncionalidad(Cliente cliente)
        {
            new Canje_Puntos.ConsultaPuntos(cliente).ShowDialog();
        }
    }

    public class FuncionalidadHistorialCliente : FuncionalidadDeCliente
    {
        public override void RealizarFuncionalidad(Cliente cliente)
        {
            new Historial_Cliente.historialClienteCompras(cliente).ShowDialog();
        }
    
    }
}
