using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocio
{
    public class NegocioSopa
    {
        public static int NuevaSopaNegocio(EntidadSopa e)
        {
            try
            {
               return DatosSopa.NuevaSopa(e);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<EntidadSopa> NegocioCargarSopa()
        {
            try
            {
                return DatosSopa.DatosCargarSopa();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
