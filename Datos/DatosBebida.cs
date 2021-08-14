using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DatosBebida
    {
        public static int NuevoDatosBebida(EntidadBebida e)
        {
            try
            {
                BEBIDA s = new BEBIDA();
                s.ID_BEB = e.ID_BEB;
                s.NOM_BEB = e.NOM_BEB.ToUpper();
                s.IMG_BEBIDA = e.IMG_BEBIDA;

                using (BASEDataContext contexto = new BASEDataContext())
                {
                    contexto.BEBIDA.InsertOnSubmit(s);
                    contexto.SubmitChanges();
                    return s.ID_BEB;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<EntidadBebida> DatosCargarBebida()
        {
            try
            {
                List<BEBIDA> listaBEBIDA = new List<BEBIDA>();
                List<EntidadBebida> listaEntidadBEBIDA = new List<EntidadBebida>();

                using (BASEDataContext contexto = new BASEDataContext())
                {
                    var result = from c in contexto.BEBIDA
                                 select c;
                    listaBEBIDA = result.ToList();
                }
                foreach (var item in listaBEBIDA)
                {
                    listaEntidadBEBIDA.Add(new EntidadBebida(
                        item.ID_BEB,
                        item.NOM_BEB,
                        item.IMG_BEBIDA.ToArray()
                        )
                        );
                }
                return listaEntidadBEBIDA;
            }
            catch (Exception) { throw; }
        }

        public static EntidadBebida DatosObtenerBebida(int id)
        {
            try
            {
                EntidadBebida b = new EntidadBebida();
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    var a = contexto.BEBIDA.FirstOrDefault(cc => cc.ID_BEB == id);
                    b.NOM_BEB= a.NOM_BEB;
                    b.ID_BEB = a.ID_BEB;
                    b.IMG_BEBIDA = a.IMG_BEBIDA.ToArray();
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
