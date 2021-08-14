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

        public static List<EntidadMenuAndroid> NegocioCargarMenuFecha(DateTime fechaId)
        {
            try
            {
                return DatosMenu.DatosCargarMenuFecha(fechaId);
            }
            catch (Exception) { throw; }
        }

        public static EntidadMenu NegocioObtenerporIdMenu(int id)
        {
            return DatosMenu.ObtenerporIdMenu(id);
        }
        public static bool NegocioModificarMenu(EntidadMenu e)
        {
            return DatosMenu.ModificarMenu(e);
        }

        public static Boolean NegocioEliminarMenu(String id)
        {
            return DatosMenu.EliminarMenu(id);
        }
    }
}
