using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NegocioPostre
    {
        public static List<EntidadPostre> NegocioCargarPostre()
        {
            try
            {
                return DatosPostre.DatosCargarPostre();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static int NuevoPostreNegocio(EntidadPostre e)
        {
            try
            {
                return DatosPostre.NuevoPostre(e);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static EntidadPostre NegocioObtenerPostre(int id)
        {
            try
            {
                return DatosPostre.DatosObtenerPostre(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static EntidadPostre NegocioObtenerPostreWindows(int id)
        {
            try
            {
                return DatosPostre.DatosObtenerPostreWindows(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
