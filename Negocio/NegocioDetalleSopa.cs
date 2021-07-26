using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
namespace Negocio
{
    public class NegocioDetalleSopa
    {
        public static Boolean NuevoDetalleSopaNegocio(EntidadDetalleSopa e)
        {

            try
            {
                return DatosDetalleSopa.NuevoDetalleSopaDatos(e);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static String NegocioDetalleSopaObtenerIngredientes(int e)
        {
            try
            {
                return DatosDetalleSopa.DatosDetalleSopaObtenerIngredientes(e);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
