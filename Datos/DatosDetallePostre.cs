using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DatosDetallePostre
    {
        public static Boolean NuevoDatosDetallePostre(EntidadDetallePostre e)
        {
            try
            {
                DETALLE_POSTRE s = new DETALLE_POSTRE();
                s.ID_DET_REC = e.ID_DET_REC;
                s.ID_REC_PER = e.ID_REC_PER;
                s.ID_ING_USA = e.ID_ING_USA;

                using (BASEDataContext contexto = new BASEDataContext())
                {
                    contexto.DETALLE_POSTRE.InsertOnSubmit(s);
                    contexto.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static String DatosDetalleBebidaObtenerIngredientes(int id)
        {
            try
            {
                List<DETALLE_POSTRE> listaDETALLE_POSTRE = new List<DETALLE_POSTRE>();

                List<String> a = new List<string>();
                String b = "";
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    var result = from c in contexto.DETALLE_POSTRE
                                 where c.ID_REC_PER == id
                                 select c;
                    listaDETALLE_POSTRE = result.ToList();
                }
                foreach (var item in listaDETALLE_POSTRE)
                {
                    b += DatosIngredientes.DatosObtenerIdIngrediente(item.ID_ING_USA) + ", ";
                }
                return b;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
