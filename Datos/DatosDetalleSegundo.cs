using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Datos
{
    public class DatosDetalleSegundo
    {
        public static Boolean NuevoDatosDetalleSegundo(EntidadDetalleSegundo e)
        {
            try
            {
                DETALLE_SEGUNDO s = new DETALLE_SEGUNDO();
                s.ID_DET_REC = e.ID_DET_REC;
                s.ID_REC_PER = e.ID_REC_PER;
                s.ID_ING_USA = e.ID_ING_USA;

                using (BASEDataContext contexto = new BASEDataContext())
                {
                    contexto.DETALLE_SEGUNDO.InsertOnSubmit(s);
                    contexto.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }


        }

        public static String DatosDetalleSegundoObtenerIngredientes(int id)
        {
            try
            {
                List<DETALLE_SEGUNDO> listaDETALLE_SEGUNDO = new List<DETALLE_SEGUNDO>();

                List<String> a = new List<string>();
                String b = "";
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    var result = from c in contexto.DETALLE_SEGUNDO
                                 where c.ID_REC_PER == id
                                 select c;
                    listaDETALLE_SEGUNDO = result.ToList();
                }
                foreach (var item in listaDETALLE_SEGUNDO)
                {
                    b += DatosIngredientes.DatosObtenerIdIngrediente(item.ID_ING_USA) + " ";
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
