using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NegocioDetalleBebida
    {
        public static Boolean NuevoDetalleBebidaNegocio(EntidadDetalleBebida e)
        {
            try
            {
                return DatosDetalleBebida.NuevoDatosDetalleBebida(e);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static String NegocioDetalleBebidaObtenerIngredientes(int e)
        {
            try
            {
                return DatosDetalleBebida.DatosDetalleBebidaObtenerIngredientes(e);
            }
            catch (Exception)
            {
                throw;
            }

        }


    }
}
