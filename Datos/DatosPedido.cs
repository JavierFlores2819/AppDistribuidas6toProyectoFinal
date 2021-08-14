using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DatosPedido
    {
        public static int DatosNuevoPedido(EntidadPedido e)
        {
            try
            {
                PEDIDOS s = new PEDIDOS();
                s.ID = e.ID_PED;
                s.CLIENTE = e.CLI_PED;
                s.CANTIDAD = e.CANT_PED;
                s.MENU = e.MENU_PED;
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    contexto.PEDIDOS.InsertOnSubmit(s);
                    contexto.SubmitChanges();
                    return s.ID;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public static List<EntidadPedido> DatosCargarPedidos(string id)
        {
            try
            {
                List<PEDIDOS> listaPEDIDOS = new List<PEDIDOS>();
                List<EntidadPedido> listapedido = new List<EntidadPedido>();
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    var result = from c in contexto.PEDIDOS
                                 where c.MENU == int.Parse(id)
                                 select c;
                    listaPEDIDOS = result.ToList();
                }
                foreach (var item in listaPEDIDOS)
                {
                    listapedido.Add(new EntidadPedido(
                        item.ID,
                        item.CLIENTE,
                        item.MENU,
                        item.CANTIDAD
                        ));
                }
                return listapedido;
            }
            catch (Exception) { throw; }

        }



    }
}
