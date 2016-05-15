using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportPoint.Server.Portal.Startup))]
namespace SportPoint.Server.Portal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app) 
        {
            ConfigureAuth(app);
        }
    }
}
