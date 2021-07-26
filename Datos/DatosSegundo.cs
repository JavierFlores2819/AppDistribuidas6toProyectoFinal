using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DatosSegundo
    {
        public static int NuevoSegundo(EntidadSegundo e)
        {
            try
            {
                SEGUNDO s = new SEGUNDO();
                s.ID_SEG = e.ID_SEG;
                s.NOM_SEG = e.NOM_SEG.ToUpper();
                s.IMG_SEGUNDO = e.IMG_Segundo;
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    contexto.SEGUNDO.InsertOnSubmit(s);
                    contexto.SubmitChanges();
                    return s.ID_SEG;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public static List<EntidadSegundo> DatosCargarSegundo()
        {
            try
            {
                List<SEGUNDO> listaSEGUNDO = new List<SEGUNDO>();
                List<EntidadSegundo> listaEntidadSegundo = new List<EntidadSegundo>();

                using (BASEDataContext contexto = new BASEDataContext())
                {
                    var result = from c in contexto.SEGUNDO
                                 select c;
                    listaSEGUNDO = result.ToList();
                }
                foreach (var item in listaSEGUNDO)
                {
                    listaEntidadSegundo.Add(new EntidadSegundo(
                        item.ID_SEG,
                        item.NOM_SEG,
                        item.IMG_SEGUNDO.ToArray()
                        )
                        );
                }
                return listaEntidadSegundo;
            }
            catch (Exception) { throw; }

        }

        public static String DatosObtenerNombreSegundo(int id)
        {
            try
            {
                String b = "";
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    var a = contexto.SEGUNDO.FirstOrDefault(cc => cc.ID_SEG == id);
                    b = a.NOM_SEG;
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
