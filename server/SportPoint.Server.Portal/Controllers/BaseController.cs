using SportPoint.Server.Portal.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace SportPoint.Server.Portal.Controllers
{
    public class BaseController : Controller
    {
        #region Methods

        /// <summary>
        /// Método que aplica novo idioma ao sistema.
        /// </summary>
        /// <param name="culture">Cultura que deve ser aplicada.</param>
        public void SetCulture(string culture)
        {
            //Verificando se a cultura é válida
            culture = CultureHelper.GetImplementedCulture(culture);

            //Armazena na requisição a cultura válida
            HttpCookie cookie = Request.Cookies["_culture"];
            if (cookie != null)
                cookie.Value = culture;   //Atualiza o cookie
            else
            {
                cookie = new HttpCookie("_culture");
                cookie.Value = culture;
                cookie.Expires = DateTime.Now.AddYears(1);
            }
            Response.Cookies.Add(cookie);
        }            

        #endregion

        #region Events

        /// <summary>
        /// Evento iniciado quando a ação do contexto do controle corrente for iniciado.
        /// </summary>
        /// <param name="callback">O callback.</param>
        /// <param name="state">Estado da requisição.</param>
        /// <returns>
        /// Retorna uma instância do IAsyncController.
        /// </returns>
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {

            string cultureName = null;

            // Tenta fazer a leitura do cabeçalho da requisição 
            HttpCookie cultureCookie = Request.Cookies["_culture"];
            if (cultureCookie != null)
                cultureName = cultureCookie.Value;
            else
                cultureName = Request.UserLanguages != null && Request.UserLanguages.Length > 0 ?
                        Request.UserLanguages[0] : null;
            // Busca o nome válido da cultura
            cultureName = CultureHelper.GetImplementedCulture(cultureName);

            // Modifica a thread corrente com o nome da cultura
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureName);
            //Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(cultureName);

            return base.BeginExecuteCore(callback, state);
        }



        #endregion

        #region Actions

        /// <summary>
        /// Ação que abre a tela de ajuda da página analisada.
        /// </summary>
        /// <param name="controllerName">Nome do controlador que gerou a página.</param>
        /// <param name="controllerAction">Ação do controlador que gerou a página.</param>
        /// <param name="lang">Idioma que deve ser apresentado.</param>
        /// <returns>
        /// Conteúdo do html com os dados da ajuda.
        /// </returns>
        public ActionResult Ajuda(string controllerName, string controllerAction, string lang)
        {
            string idiomaPadrao = "pt-BR";

            string language = lang;

            //Se não possui nenhum idioma selecionado, utiliza-se padrão brasileiro
            if (string.IsNullOrEmpty(language))
                language = idiomaPadrao;

            if (!System.IO.Directory.Exists(Server.MapPath("~/Ajuda/" + language)))
                language = idiomaPadrao;

            string caminhoCompleto = Server.MapPath("~/Ajuda/" + language + "/");

            if (!string.IsNullOrEmpty(controllerName) && !string.IsNullOrEmpty(controllerAction))
                caminhoCompleto += controllerName + "/" + controllerAction + ".html";

            if (!System.IO.File.Exists(caminhoCompleto))
                caminhoCompleto = Server.MapPath("~/Ajuda/" + language + "/Default.html");

            return new FilePathResult(caminhoCompleto, "text/html");

        }

        #endregion

    }
}