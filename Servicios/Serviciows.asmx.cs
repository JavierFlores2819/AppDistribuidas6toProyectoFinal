using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Entidades;
using Negocio;

namespace Servicios
{
    /// <summary>
    /// Descripción breve de Serviciows
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Serviciows : WebService
    {
        [WebMethod]
        public int ServiciosNuevoPostre(EntidadPostre e)
        {
            return NegocioPostre.NuevoPostreNegocio(e);
        }
        [WebMethod]
        public int ServicioNuevoSegundo(EntidadSegundo e)
        {
            return NegocioSegundo.NuevSegundoNegocio(e);
        }
        [WebMethod]
        public int ServicioNuevoBebida(EntidadBebida e)
        {
            return NegocioBebida.NuevoBebidaNegocio(e);
        }
        [WebMethod]
        public int ServicioNuevaSopa(EntidadSopa e)
        {
            return NegocioSopa.NuevaSopaNegocio(e);
        }
        [WebMethod]
        public Boolean ServicioNuevoIngrediente(EntidadIngredientes e)
        {
            return NegocioIngredientes.NuevoIngredienteNegocio(e);
        }
        [WebMethod]
        public int ServiciosNuevoMenu(EntidadMenu e)
        {
            return NegocioMenu.NuevoMenuNegocio(e);
        }
        [WebMethod]
        public Boolean ServicioNuevoDetalleBebida(EntidadDetalleBebida e)
        {
            return NegocioDetalleBebida.NuevoDetalleBebidaNegocio(e);
        }
        [WebMethod]
        public Boolean ServicioNuevoDetallePostre(EntidadDetallePostre e)
        {
            return NegocioDetallePostre.NuevoDetallePostreNegocio(e);
        }
        [WebMethod]
        public Boolean ServicioNuevoDetalleSegundo(EntidadDetalleSegundo e)
        {
            return NegocioDetalleSegundo.NuevoDetalleSegundoNegocio(e);
        }
        [WebMethod]
        public Boolean ServicioNuevoDetalleSopa(EntidadDetalleSopa e)
        {

            return NegocioDetalleSopa.NuevoDetalleSopaNegocio(e);
        }

        [WebMethod]
        public List<EntidadBebida> ServicioCargarBebida()
        {
            return NegocioBebida.NegocioCargarBebida();
        }

        [WebMethod]
        public List<EntidadPostre> ServicioCargarPostre()
        {
            return NegocioPostre.NegocioCargarPostre();

        }

        [WebMethod]
        public List<EntidadSegundo> ServicioCargarSegundo()
        {
            return NegocioSegundo.NegocioCargarSegundo();
        }

        [WebMethod]
        public List<EntidadSopa> ServicioCargarSopa()
        {
            return NegocioSopa.NegocioCargarSopa();
        }

        [WebMethod]
        public List<EntidadIngredientes> ServicioCargarIngredientes()
        {
            return NegocioIngredientes.CargarIngredientesNegocio();
        }

        [WebMethod]
        public List<EntidadMenuNombres> ServicioCargarMenu()
        {
            return NegocioMenu.NegocioCargarMenu();
        }

        [WebMethod]
        public String ServicioDetalleBebidaObtenerIngredientes(int e)
        {
            return NegocioDetalleBebida.NegocioDetalleBebidaObtenerIngredientes(e);
        }


        [WebMethod]
        public String ServicioDetallePostreObtenerIngredientes(int e)
        {
            return NegocioDetallePostre.NegocioDetallePostreObtenerIngredientes(e);
        }

        [WebMethod]
        public String ServicioDetalleSegundoObtenerIngredientes(int e)
        {
            return NegocioDetalleSegundo.NegocioDetalleSegundoObtenerIngredientes(e);
        }

        [WebMethod]
        public String ServicioDetalleSopaObtenerIngredientes(int e)
        {
            return NegocioDetalleSopa.NegocioDetalleSopaObtenerIngredientes(e);
        }



    }
}
