using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DatosPostre
    {
        public static int NuevoPostre(EntidadPostre e)
        {
            try
            {
                POSTRE s = new POSTRE();
                s.ID_POS = e.ID_POS;
                s.NOM_POS = e.NOM_POS.ToUpper();
                s.IMG_POSTRE = e.IMG_POSTRE;
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    contexto.POSTRE.InsertOnSubmit(s);
                    contexto.SubmitChanges();
                    return s.ID_POS;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static List<EntidadPostre> DatosCargarPostre()
        {
            try
            {
                List<POSTRE> listaPOSTRE = new List<POSTRE>();
                List<EntidadPostre> listaEntidadPOSTRE = new List<EntidadPostre>();

                using (BASEDataContext contexto = new BASEDataContext())
                {
                    var result = from c in contexto.POSTRE
                                 select c;
                    listaPOSTRE = result.ToList();
                }
                foreach (var item in listaPOSTRE)
                {
                    listaEntidadPOSTRE.Add(new EntidadPostre(
                        item.ID_POS,
                        item.NOM_POS,
                        item.IMG_POSTRE.ToArray()
                        )
                        );
                }
                return listaEntidadPOSTRE;
            }
            catch (Exception) { throw; }
        }

        public static EntidadPostre DatosObtenerPostre(int id)
        {
            try
            {
                EntidadPostre b = new EntidadPostre();
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    var a = contexto.POSTRE.FirstOrDefault(cc => cc.ID_POS == id);
                    b.NOM_POS = a.NOM_POS;
                    b.ID_POS = a.ID_POS;
                    b.IMG_POSTRE = a.IMG_POSTRE.ToArray();
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
