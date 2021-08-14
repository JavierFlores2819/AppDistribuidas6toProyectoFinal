using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NegocioPedido
    {
        public static int NegocioNuevoPedido(EntidadPedido e)
        {
            return DatosPedido.DatosNuevoPedido(e);
        }

        public static List<EntidadPedido> NegocioCargarPedidos(string id)
        {
            return DatosPedido.DatosCargarPedidos(id);
        }

    }
}
