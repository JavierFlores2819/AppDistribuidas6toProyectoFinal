using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
   public class NegocioDetalleSegundo
    {
        public static Boolean NuevoDetalleSegundoNegocio(EntidadDetalleSegundo e)
        {
            try
            {
                return DatosDetalleSegundo.NuevoDatosDetalleSegundo(e);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static String NegocioDetalleSegundoObtenerIngredientes(int e)
        {
            try
            {
                return DatosDetalleSegundo.DatosDetalleSegundoObtenerIngredientes(e);
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
