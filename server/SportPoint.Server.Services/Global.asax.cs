using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using System.Web.Http.Description;
using SportPoint.Server.Services.HelpProvider;

namespace SportPoint.Server.Services
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);


             AreaRegistration.RegisterAllAreas();

            //WebApiConfig.Register(GlobalConfiguration.Configuration);


            //Para que o formato do retorno da api seja json.
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            //Para tratar o retorno do formato de datas
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.Converters.Add(new Utils.CustomJsonDateFormat());

            //Para gerar a documentação do sistema.
            GlobalConfiguration.Configuration.Services.Replace(typeof(IDocumentationProvider), new XmlCommentDocumentationProvider(HttpContext.Current.Server.MapPath("~/bin/SportPoint.Server.Services.XML")));

            //Cors
            //GlobalConfiguration.Configuration.MessageHandlers.Add(new CorsHandler());
        }
    }
}