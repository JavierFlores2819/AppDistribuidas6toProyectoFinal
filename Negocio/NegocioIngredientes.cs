using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NegocioIngredientes
    {
        public static Boolean NuevoIngredienteNegocio(EntidadIngredientes e)
        {
            try
            {
                return DatosIngredientes.NuevoIngrediente(e);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<EntidadIngredientes> CargarIngredientesNegocio()
        {
            try
            {
                return DatosIngredientes.CargarIngredienteDatos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Boolean NegocioEliminarIngrediente(String id)
        {
            try
            {
                return DatosIngredientes.EliminarIngrediente(id);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
