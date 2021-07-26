using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DatosIngredientes
    {
        public static Boolean NuevoIngrediente(EntidadIngredientes e)
        {
            try
            {
                INGREDIENTES s = new INGREDIENTES();
                s.ID_ING = e.ID_ING;
                s.NOM_ING = e.NOM_ING.ToUpper();

                using (BASEDataContext contexto = new BASEDataContext())
                {
                    contexto.INGREDIENTES.InsertOnSubmit(s);
                    contexto.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<EntidadIngredientes> CargarIngredienteDatos()
        {
            try
            {
                List<INGREDIENTES> listaIngredi = new List<INGREDIENTES>();
                List<EntidadIngredientes> listaIngredieEntidad = new List<EntidadIngredientes>();

                using (BASEDataContext contexto = new BASEDataContext())
                {
                    var result = from c in contexto.INGREDIENTES
                                 select c;
                    listaIngredi = result.ToList();
                }
                foreach (var item in listaIngredi)
                {
                    listaIngredieEntidad.Add(new EntidadIngredientes(
                        item.ID_ING,
                        item.NOM_ING
                        )
                        );
                }
                return listaIngredieEntidad;
            }
            catch (Exception) { throw; }
        }


        public static String DatosObtenerIdIngrediente(int id)
        {
            try
            {
                String b = "";
                using (BASEDataContext contexto = new BASEDataContext())
                {
                    var a = contexto.INGREDIENTES.FirstOrDefault(cc => cc.ID_ING == id);
                    b = a.NOM_ING;
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
