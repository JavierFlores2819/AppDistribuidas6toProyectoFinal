using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entidades;
using Negocio;

namespace ServicioJSON
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioProyectJSON" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioProyectJSON
    {
        [OperationContract]
        [WebInvoke(Method = "POST", 
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, 
            UriTemplate = "/ServiciosNuevoPostre")]
        int ServiciosNuevoPostre(EntidadPostre e);
      
        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ServicioNuevoSegundo")]
        int ServicioNuevoSegundo(EntidadSegundo e);
       
        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ServicioNuevoBebida")]
        int ServicioNuevoBebida(EntidadBebida e);
      
        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ServicioNuevaSopa")]
        int ServicioNuevaSopa(EntidadSopa e);
       
        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ServicioNuevoIngrediente")]
        Boolean ServicioNuevoIngrediente(EntidadIngredientes e);

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ServiciosNuevoMenu")]
        int ServiciosNuevoMenu(EntidadMenu e);
       
        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ServicioNuevoDetalleBebida")]
        Boolean ServicioNuevoDetalleBebida(EntidadDetalleBebida e);
        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ServicioNuevoDetallePostre")]
        Boolean ServicioNuevoDetallePostre(EntidadDetallePostre e);
       
        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ServicioNuevoDetalleSegundo")]
        Boolean ServicioNuevoDetalleSegundo(EntidadDetalleSegundo e);
       
        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ServicioNuevoDetalleSopa")]
        Boolean ServicioNuevoDetalleSopa(EntidadDetalleSopa e);
       
        [OperationContract]
        [WebGet(UriTemplate = "ServicioCargarBebida",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json)]
        List<EntidadBebida> ServicioCargarBebida();
        [OperationContract]
        [WebGet(UriTemplate = "ServicioCargarPostre",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json)]
        List<EntidadPostre> ServicioCargarPostre();
        [OperationContract]
        [WebGet(UriTemplate = "ServicioCargarSegundo",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json)]
        List<EntidadSegundo> ServicioCargarSegundo();
        [OperationContract]
        [WebGet(UriTemplate = "ServicioCargarSopa",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json)]
        List<EntidadSopa> ServicioCargarSopa();
        [OperationContract]
        [WebGet(UriTemplate = "ServicioCargarIngredientes",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json)]
        List<EntidadIngredientes> ServicioCargarIngredientes();
        [OperationContract]
        [WebGet(UriTemplate = "ServicioCargarMenu",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json)]
        List<EntidadMenuNombres> ServicioCargarMenu();

        [OperationContract]
        [WebGet(UriTemplate = "ServicioDetalleBebidaObtenerIngredientes/{id}",
            RequestFormat = WebMessageFormat.Json, 
            ResponseFormat = WebMessageFormat.Json)]
        String ServicioDetalleBebidaObtenerIngredientes(string id);
        
        [OperationContract]
        [WebGet(UriTemplate = "ServicioDetallePostreObtenerIngredientes/{id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        String ServicioDetallePostreObtenerIngredientes(string id);
        [OperationContract]
        [WebGet(UriTemplate = "ServicioDetalleSegundoObtenerIngredientes/{id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        String ServicioDetalleSegundoObtenerIngredientes(string id);
        [OperationContract]
        [WebGet(UriTemplate = "ServicioDetalleSopaObtenerIngredientes/{id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        String ServicioDetalleSopaObtenerIngredientes(string id);
    }
}
