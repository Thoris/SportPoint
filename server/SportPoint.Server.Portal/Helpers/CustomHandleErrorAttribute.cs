using SportPoint.Server.LogManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportPoint.Server.Portal.Helpers
{
    /// <summary>
    /// Classe customizada de gerenciamento de erro.
    /// </summary>
    public class CustomHandleErrorAttribute : HandleErrorAttribute
    {
        #region Eventos

        /// <summary>
        /// Evento iniciado quando uma exceção ocorrer.
        /// </summary>
        /// <param name="filterContext">Filtro do contexto que gerou a exceção..</param>
        public override void OnException(ExceptionContext filterContext)
        {

            LogTool.Fatal(filterContext.Controller, filterContext.Exception);


            base.OnException(filterContext);
        }

        #endregion
    }
}