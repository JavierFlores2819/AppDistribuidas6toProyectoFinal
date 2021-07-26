using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
   public class NegocioDetallePostre
    {
        public static Boolean NuevoDetallePostreNegocio(EntidadDetallePostre e)
        {
            try
            {
                return DatosDetallePostre.NuevoDatosDetallePostre(e);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static String NegocioDetallePostreObtenerIngredientes(int e)
        {
            try
            {
                return DatosDetallePostre.DatosDetalleBebidaObtenerIngredientes(e);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
