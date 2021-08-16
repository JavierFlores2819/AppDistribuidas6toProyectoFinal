using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Datos
{
    public class DatosMenu
    {
        public static int NuevoMenu(EntidadMenu e)
        {
            try
            {
                MENU s = new MENU();
                s.ID_MEN = e.ID_MEN;
                s.ID_SOP_MEN = e.ID_SOP_MEN;
                s.ID_SEG_MEN = e.ID_SEG_MEN;
                s.ID_POS_MEN = e.ID_POS_MEN;
                s.ID_BEB_MEN = e.ID_BEB_MEN;
                s.FECHA_MEN = e.FECHA_MEN;
                s.CAN_PED_MEN = e.CANTIDAD;
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    contexto.MENU.InsertOnSubmit(s);
                    contexto.SubmitChanges();
                    return s.ID_MEN;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public static EntidadMenu ObtenerporIdMenu(int id)
        {
            try
            {
                EntidadMenu e = new EntidadMenu();
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    var m = contexto.MENU.FirstOrDefault(cc => cc.ID_MEN == id);
                    e.ID_MEN = m.ID_MEN;
                    e.CANTIDAD = m.CAN_PED_MEN;
                    e.ID_SOP_MEN = m.ID_SOP_MEN;
                    e.ID_SEG_MEN = m.ID_SEG_MEN;
                    e.ID_BEB_MEN = m.ID_BEB_MEN;
                    e.ID_POS_MEN = m.ID_POS_MEN;
                    e.FECHA_MEN = m.FECHA_MEN;
                }
                return e;

            }
            catch (Exception)
            {
                return null;
            }

        }
        public static bool ModificarMenu(EntidadMenu e)
        {
            try
            {
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    var m = contexto.MENU.FirstOrDefault(cc => cc.ID_MEN == e.ID_MEN);
                    m.ID_SOP_MEN = e.ID_SOP_MEN;
                    m.ID_SEG_MEN = e.ID_SEG_MEN;
                    m.ID_BEB_MEN = e.ID_BEB_MEN;
                    m.ID_POS_MEN = e.ID_POS_MEN;                  
                    contexto.SubmitChanges();
                }
                return true;
            }
            catch (Exception) { return false; }
        }
        public static Boolean EliminarMenu(String id)
        {
            try
            {
                int id1 = int.Parse(id);
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    var c = contexto.MENU.FirstOrDefault(cc => cc.ID_MEN == id1);
                    contexto.MENU.DeleteOnSubmit(c);     
                    contexto.SubmitChanges();
                    EliminarMenuPedidos(id);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean EliminarMenuPedidos(String id) {
            try
            {
                int id1 = int.Parse(id);
                using (BASEDataContext contexto = new BASEDataContext())
                {

                    var result = from c in contexto.PEDIDOS
                                 where c.MENU == id1
                                 select c;

                    foreach (var item in result.ToList())
                    {
                        contexto.PEDIDOS.DeleteOnSubmit(item);
                        contexto.SubmitChanges();
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        

            public static List<EntidadMenuNombres> DatosCargarMenu()
        {
            try
            {
                List<MENU> listamenu = new List<MENU>();
                List<EntidadMenuNombres> listamenuNombreEntidad = new List<EntidadMenuNombres>();
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    var result = from c in contexto.MENU
                                 select c;
                    listamenu = result.ToList();
                }
                foreach (var item in listamenu)
                {
                    listamenuNombreEntidad.Add(new EntidadMenuNombres(
                        item.CAN_PED_MEN,
                        item.ID_MEN,
                        DatosSopa.DatosObteneSopaWindows(item.ID_SOP_MEN).NOM_SOP,
                        DatosSegundo.DatosObtenerSegundoWindows(item.ID_SEG_MEN).NOM_SEG,
                        DatosBebida.DatosObtenerBebidaWindows(item.ID_BEB_MEN).NOM_BEB,
                        DatosPostre.DatosObtenerPostreWindows(item.ID_POS_MEN).NOM_POS,
                        item.FECHA_MEN
                        ));
                }
                return listamenuNombreEntidad;
            }
            catch (Exception) { throw; }

        }

        public static List<EntidadMenuAndroid> DatosCargarMenuFecha(DateTime fechaId)
        {
            var a = fechaId;
            try
            {
                List<MENU> listamenu = new List<MENU>();
                List<EntidadMenuAndroid> listamenuNombreEntidad = new List<EntidadMenuAndroid>();
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    var result = from c in contexto.MENU
                                 where c.FECHA_MEN == fechaId
                                 select c;
                    listamenu = result.ToList();
                }
                foreach (var item in listamenu)
                {
                    listamenuNombreEntidad.Add(new EntidadMenuAndroid(
                        item.ID_MEN,

                        item.ID_SOP_MEN,
                        DatosSopa.DatosObteneSopa(item.ID_SOP_MEN).NOM_SOP,
                        DatosSopa.DatosObteneSopa(item.ID_SOP_MEN).IMG_SOPA,

                        item.ID_SEG_MEN,
                        DatosSegundo.DatosObtenerSegundo(item.ID_SEG_MEN).NOM_SEG,
                        DatosSegundo.DatosObtenerSegundo(item.ID_SEG_MEN).IMG_Segundo,

                        item.ID_BEB_MEN,
                        DatosBebida.DatosObtenerBebida(item.ID_BEB_MEN).NOM_BEB,
                        DatosBebida.DatosObtenerBebida(item.ID_BEB_MEN).IMG_BEBIDA,

                        item.ID_POS_MEN,
                        DatosPostre.DatosObtenerPostre(item.ID_POS_MEN).NOM_POS,
                        DatosPostre.DatosObtenerPostre(item.ID_POS_MEN).IMG_POSTRE,

                       "SOPA: " + DatosDetalleSopa.DatosDetalleSopaObtenerIngredientes(item.ID_SOP_MEN) + "\n"
                        + "SEGUNDO: " + DatosDetalleSegundo.DatosDetalleSegundoObtenerIngredientes(item.ID_SEG_MEN) + "\n"
                        + "BEBIDA: " + DatosDetalleBebida.DatosDetalleBebidaObtenerIngredientes(item.ID_BEB_MEN) + "\n"
                        + "POSTRE/ENTRADA: " + DatosDetallePostre.DatosDetalleBebidaObtenerIngredientes(item.ID_POS_MEN)
                        ,
                        item.FECHA_MEN
                        ));
                }
                return listamenuNombreEntidad;
            }
            catch (Exception) { throw; }

        }

    }
}
