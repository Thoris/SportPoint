using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SportPoint.Server.Services
{
    /// <summary>
    /// Classe que possui as configurações de layout de chamada pelo browser.
    /// </summary>
    public static class WebApiConfig
    {
        #region Methods
        /// <summary>
        /// Método que registra a configuração válida para chamada via HTTP;
        /// </summary>
        /// <param name="config">Configuração a ser aplicada.</param>
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();


            config.Routes.MapHttpRoute(
                name: "WithActionApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
        #endregion
    }
}
