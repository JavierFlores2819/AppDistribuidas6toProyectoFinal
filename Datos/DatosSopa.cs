using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DatosSopa
    {
        public static int NuevaSopa(EntidadSopa e)
        {
            try
            {
                SOPA s = new SOPA();
                s.ID_SOP = e.ID_SOP;
                s.NOM_SOP = e.NOM_SOP;
                s.IMG_SOPA = e.IMG_SOPA;
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    contexto.SOPA.InsertOnSubmit(s);
                    contexto.SubmitChanges();
                    return s.ID_SOP;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

    }
}
