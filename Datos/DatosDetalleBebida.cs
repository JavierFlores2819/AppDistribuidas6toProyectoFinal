using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DatosDetalleBebida
    {
        public static Boolean NuevoDatosDetalleBebida(EntidadDetalleBebida e)
        {
            try
            {
                DETALLE_BEBIDA s = new DETALLE_BEBIDA();
                s.ID_DET_REC = e.ID_DET_REC;
                s.ID_REC_PER = e.ID_REC_PER;
                s.ID_ING_USA = e.ID_ING_USA;

                using (BASEDataContext contexto = new BASEDataContext())
                {
                    contexto.DETALLE_BEBIDA.InsertOnSubmit(s);
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
                List<DETALLE_BEBIDA> listaDETALLE_BEBIDA = new List<DETALLE_BEBIDA>();
               
                List<String> a = new List<string>();
                String b = "";
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    var result = from c in contexto.DETALLE_BEBIDA
                                 where c.ID_REC_PER == id
                                 select c;
                    listaDETALLE_BEBIDA = result.ToList();
                }
                foreach (var item in listaDETALLE_BEBIDA)
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
