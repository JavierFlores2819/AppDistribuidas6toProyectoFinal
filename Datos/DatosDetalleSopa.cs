using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DatosDetalleSopa
    {
        public static Boolean NuevoDetalleSopaDatos(EntidadDetalleSopa e) {
            try
            {
                DETALLE_SOPA s = new DETALLE_SOPA();
                s.ID_DET_REC = e.ID_DET_REC;
                s.ID_REC_PER = e.ID_REC_PER;
                s.ID_ING_USA = e.ID_ING_USA;

                using (BASEDataContext contexto = new BASEDataContext())
                {
                    contexto.DETALLE_SOPA.InsertOnSubmit(s);
                    contexto.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }


        }


    }
}
