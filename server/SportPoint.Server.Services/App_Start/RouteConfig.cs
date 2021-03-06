﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SportPoint.Server.Services
{
    /// <summary>
    /// Classe que trabalha com a configuração de rotas dos controladores.
    /// </summary>
    public class RouteConfig
    {
        #region Methods
        /// <summary>
        /// Método que realiza o registro e configuração da rota especificada.
        /// </summary>
        /// <param name="routes">Coleção de rotas a serem configuradas.</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }

        #endregion
    }
}
