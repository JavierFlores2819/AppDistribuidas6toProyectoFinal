using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NegocioMenu
    {
        public static int NuevoMenuNegocio(EntidadMenu e)
        {
            try
            {
                return DatosMenu.NuevoMenu(e);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<EntidadMenuNombres> NegocioCargarMenu()
        {
            try
            {
                return DatosMenu.DatosCargarMenu();
            }
            catch (Exception) { throw; }
        }

    }
}
