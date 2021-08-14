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
        [WebGet(UriTemplate = "ServicioDetalleBebidaObtenerIngrediente?id={id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        String ServicioDetalleBebidaObtenerIngredientes(string id);

        [OperationContract]
        [WebGet(UriTemplate = "ServicioDetallePostreObtenerIngredientes?id={id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        String ServicioDetallePostreObtenerIngredientes(string id);
        [OperationContract]
        [WebGet(UriTemplate = "ServicioDetalleSegundoObtenerIngredientes?id={id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        String ServicioDetalleSegundoObtenerIngredientes(string id);
        [OperationContract]
        [WebGet(UriTemplate = "ServicioDetalleSopaObtenerIngredientes?id={id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        String ServicioDetalleSopaObtenerIngredientes(string id);

        [OperationContract]
        [WebGet(UriTemplate = "ServicioCargarMenuFecha?id={id}",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        List<EntidadMenuAndroid> ServicioCargarMenuFecha(String id);

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ServicioNuevoPedido")]
        int ServicioNuevoPedido(EntidadPedido e);

        [OperationContract]
        [WebGet(UriTemplate = "ServicioCargarPedido?id={id}",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        List<EntidadPedido> ServicioCargarPedidos(string id);

        [OperationContract]
        [WebGet(UriTemplate = "ServicioObtenerMenuporId?id={id}",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        EntidadMenu ServicioObtenerMenuporId(int id);

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/ServicioModificarMenu")]
        bool ServicioModificarMenu(EntidadMenu id);

        [OperationContract]
        [WebGet(UriTemplate = "ServicioEliminarMenu?id={id}",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        Boolean ServicioEliminarMenu(String id);

        [OperationContract]
        [WebGet(UriTemplate = "ServicioObtenerSegundo?id={id}",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json)]
        EntidadSegundo ServicioObtenerSegundo(int id);

        [OperationContract]
        [WebGet(UriTemplate = "ServicioObtenerSopa?id={id}",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json)]
        EntidadSopa ServicioObtenerSopa(int id);

        [OperationContract]
        [WebGet(UriTemplate = "ServicioObtenerBebida?id={id}",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json)]
        EntidadBebida ServicioObtenerBebida(int id);

        [OperationContract]
        [WebGet(UriTemplate = "ServicioObtenerPostre?id={id}",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json)]
        EntidadPostre ServicioObtenerPostre(int id);

    }
}
