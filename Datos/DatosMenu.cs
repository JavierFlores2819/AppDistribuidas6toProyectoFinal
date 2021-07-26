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
                        item.ID_MEN,
                        DatosSopa.DatosObtenerNombreSopa(item.ID_SOP_MEN),
                        DatosSegundo.DatosObtenerNombreSegundo(item.ID_SEG_MEN),
                        DatosBebida.DatosObtenerNombreBebida(item.ID_BEB_MEN),
                        DatosPostre.DatosObtenerNombrePostre(item.ID_POS_MEN),
                        item.FECHA_MEN
                        ));
                }
                return listamenuNombreEntidad;
            }
            catch (Exception) { throw; }

        }

    }
}
