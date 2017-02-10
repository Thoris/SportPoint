using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SportPoint.Server.Services.Controllers
{
    public class HomeController : Controller
    {
        #region Actions

        public ActionResult Index()
        {
            var api = GlobalConfiguration.Configuration.Services.GetApiExplorer();
            return View(api);
        }

        #endregion
    }
}