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
                s.NOM_SOP = e.NOM_SOP.ToUpper();
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

        public static List<EntidadSopa> DatosCargarSopa()
        {
            try
            {
                List<SOPA> listaSOPA = new List<SOPA>();
                List<EntidadSopa> listaEntidadSopa = new List<EntidadSopa>();
                byte[] ARRAY = new byte[] { };
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    var result = from c in contexto.SOPA
                                 select c;
                    listaSOPA = result.ToList();
                }
                foreach (var item in listaSOPA)
                {
                    listaEntidadSopa.Add(new EntidadSopa(
                        item.ID_SOP,
                        item.NOM_SOP,
                       ARRAY
                        )
                        );
                }
                return listaEntidadSopa;
            }
            catch (Exception) { throw; }
        }

        public static EntidadSopa DatosObteneSopa(int id)
        {
            try
            {
                EntidadSopa b = new EntidadSopa();
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    var a = contexto.SOPA.FirstOrDefault(cc => cc.ID_SOP == id);
                    b.ID_SOP = a.ID_SOP;
                    b.NOM_SOP = a.NOM_SOP;
                    b.IMG_SOPA = a.IMG_SOPA.ToArray();
                }
                return b;

            }
            catch (Exception)
            {
                return null;
            }

        }

        public static EntidadSopa DatosObteneSopaWindows(int id)
        {
            try
            {
                byte[] ARRAY = new byte[] { };
                EntidadSopa b = new EntidadSopa();
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    var a = contexto.SOPA.FirstOrDefault(cc => cc.ID_SOP == id);
                    b.ID_SOP = a.ID_SOP;
                    b.NOM_SOP = a.NOM_SOP;
                    b.IMG_SOPA = ARRAY;
                }
                return b;

            }
            catch (Exception)
            {
                return null;
            }

        }

    }
}
