using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;
using Negocio;


namespace ServicioJSON
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioProyectJSON" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioProyectJSON.svc o ServicioProyectJSON.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioProyectJSON : IServicioProyectJSON
    {
     
        public int ServiciosNuevoPostre(EntidadPostre e)
        {
            return NegocioPostre.NuevoPostreNegocio(e);
        }
     
        public int ServicioNuevoSegundo(EntidadSegundo e)
        {
            return NegocioSegundo.NuevSegundoNegocio(e);
        }
      
        public int ServicioNuevoBebida(EntidadBebida e)
        {
            return NegocioBebida.NuevoBebidaNegocio(e);
        }
        
        public int ServicioNuevaSopa(EntidadSopa e)
        {
            return NegocioSopa.NuevaSopaNegocio(e);
        }

        public Boolean ServicioNuevoIngrediente(EntidadIngredientes e)
        {
            return NegocioIngredientes.NuevoIngredienteNegocio(e);
        }
        public int ServiciosNuevoMenu(EntidadMenu e)
        {
            return NegocioMenu.NuevoMenuNegocio(e);
        }
        public Boolean ServicioNuevoDetalleBebida(EntidadDetalleBebida e)
        {
            return NegocioDetalleBebida.NuevoDetalleBebidaNegocio(e);
        }
        public Boolean ServicioNuevoDetallePostre(EntidadDetallePostre e)
        {
            return NegocioDetallePostre.NuevoDetallePostreNegocio(e);
        }
        public Boolean ServicioNuevoDetalleSegundo(EntidadDetalleSegundo e)
        {
            return NegocioDetalleSegundo.NuevoDetalleSegundoNegocio(e);
        }
        public Boolean ServicioNuevoDetalleSopa(EntidadDetalleSopa e)
        {

            return NegocioDetalleSopa.NuevoDetalleSopaNegocio(e);
        }

        public List<EntidadBebida> ServicioCargarBebida()
        {
            return NegocioBebida.NegocioCargarBebida();
        }

        public List<EntidadPostre> ServicioCargarPostre()
        {
            return NegocioPostre.NegocioCargarPostre();

        }

        public List<EntidadSegundo> ServicioCargarSegundo()
        {
            return NegocioSegundo.NegocioCargarSegundo();
        }

        public List<EntidadSopa> ServicioCargarSopa()
        {
            return NegocioSopa.NegocioCargarSopa();
        }

        public List<EntidadIngredientes> ServicioCargarIngredientes()
        {
            return NegocioIngredientes.CargarIngredientesNegocio();
        }

        public List<EntidadMenuNombres> ServicioCargarMenu()
        {
            return NegocioMenu.NegocioCargarMenu();
        }

        public String ServicioDetalleBebidaObtenerIngredientes(string e)
        {
            int s = int.Parse(e);
            return NegocioDetalleBebida.NegocioDetalleBebidaObtenerIngredientes(s);
        }

        public String ServicioDetallePostreObtenerIngredientes(string e)
        {
            int s = int.Parse(e);
            return NegocioDetallePostre.NegocioDetallePostreObtenerIngredientes(s);
        }

        public String ServicioDetalleSegundoObtenerIngredientes(string e)
        {
            int s = int.Parse(e);
            return NegocioDetalleSegundo.NegocioDetalleSegundoObtenerIngredientes(s);
        }

        public String ServicioDetalleSopaObtenerIngredientes(string e)
        {
            int s = int.Parse(e);
            return NegocioDetalleSopa.NegocioDetalleSopaObtenerIngredientes(s);
        }

    }
}
