using SportPoint.Server.Portal.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportPoint.Server.Portal.Controllers
{
    public class AccountController : AuthorizationController
    {
        #region Methods

        /// <summary>
        /// Método que redireciona para um local específico.
        /// </summary>
        /// <param name="returnUrl">Url de retorno.</param>
        /// <returns>Resultado da ação para o redirecionamento.</returns>
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        #endregion

        #region Actions
        /// <summary>
        /// Ação que redireciona para a visualização da tela de login.
        /// </summary>
        /// <param name="returnUrl">Url de retorno para acessar depois de logar.</param>
        /// <returns>
        /// View da tela de login.
        /// </returns>
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        /// <summary>
        /// Ação de post que recebe as informações digitadas pelo usuário para realizar o login no sistema.
        /// </summary>
        /// <param name="model">Modelo que possui os dados do login.</param>
        /// <param name="returnUrl">URL de retorno caso exista para redirecionamento.</param>
        /// <returns>
        /// Redirecionamento da url.
        /// </returns>
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginVO model, string returnUrl)
        {
            if (ModelState.IsValid)
            {

                //Business.Seguranca.SegUsuarioBO.ValidacaoUsuario res;

                //Helpers.Config config = new Helpers.Config();
                //config.Atualizar();



                ////Realizando a validação do usuário.
                //Model.Resultados.SegUsuarioResultado usuario = _bo.ValidarUsuario(model.Login, model.Senha,
                //    config.GrupoNomePerfilAdmin, config.GrupoNomePerfilSistema, out res);

                ////Verificando o resultado da autenticação do usuário
                //switch (res)
                //{
                //    case Business.Seguranca.SegUsuarioBO.ValidacaoUsuario.Desativado:

                //        ModelState.AddModelError("", Resources.Views.Account.Mensagens.UsuarioDesativado);
                //        LogManager.LogTool.Error(this, "Usuário: " + model.Login + " Desativado.");

                //        break;
                //    case Business.Seguranca.SegUsuarioBO.ValidacaoUsuario.QtdSenhaInvalidaExcedido:

                //        ModelState.AddModelError("", Resources.Views.Account.Mensagens.LimiteTentativaExcedida);
                //        LogManager.LogTool.Error(this, "Usuário: " + model.Login + " com limite de tentativa excedida.");

                //        break;
                //    case Business.Seguranca.SegUsuarioBO.ValidacaoUsuario.SenhaInvalida:

                //        ModelState.AddModelError("", Resources.Views.Account.Mensagens.SenhaInvalida);
                //        LogManager.LogTool.Error(this, "Senha inválida do Usuário: " + model.Login + " .");

                //        break;
                //    case Business.Seguranca.SegUsuarioBO.ValidacaoUsuario.UsuarioNaoEncontrado:

                //        ModelState.AddModelError("", Resources.Views.Account.Mensagens.UsuarioInvalido);
                //        LogManager.LogTool.Error(this, "Usuário: " + model.Login + " Não encontrado.");

                //        break;
                //    case Business.Seguranca.SegUsuarioBO.ValidacaoUsuario.FaltaPermissao:

                //        ModelState.AddModelError("", Resources.Views.Account.Mensagens.FaltaPermissao);
                //        LogManager.LogTool.Error(this, "Falta de permissão para o Usuário: " + model.Login + " .");

                //        break;
                //    case Business.Seguranca.SegUsuarioBO.ValidacaoUsuario.Ok:

                //        //Atribui dados do usuário na memória
                //        base.AtribuirLogin(usuario, model.Lembrar);

                //        LogManager.LogTool.Warn(this, "Autenticação do Login: " + usuario.USUARIO + ". Permissão: " + usuario.Grupo);

                //        //Buscando os pontos de medição permitidos pelo usuário
                //        //base.PontosPermitidos = _bo.RetornarPontosUsuario(usuario.USUARIO_ID);


                //        return RedirectToLocal(returnUrl);

                //}
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }
        /// <summary>
        /// Ação que realiza o logoff do usuário.
        /// </summary>
        /// <returns>Visualização da página de login.</returns>
        public ActionResult LogOff()
        {
            LogManager.LogTool.Warn(this, "Logoff do sistema (" + this.CurrentUser.Login + ")");


            //Indicando que o usuário não está mais autenticado.
            base.CleanLogin();


            return RedirectToAction("Login", "Account");
        }
        /// <summary>
        /// Método que configura a cultura do sistema.
        /// </summary>
        /// <param name="culture">Cultura a ser configurado.</param>
        /// <returns>Tela de login.</returns>
        [AllowAnonymous]
        public ActionResult ConfigCulture(string culture)
        {

            base.SetCulture(culture);
            return RedirectToAction("Login");
        }

        /// <summary>
        /// Ação que apresenta a tela que o login do usuário foi expirado.
        /// </summary>
        /// <returns>Tela que possui a informação que o login do usuário foi expirado</returns>
        [AllowAnonymous]
        public ActionResult LoginExpirado()
        {
            LogManager.LogTool.Info(this, "Tempo de inatividade do sistema expirado. (" + this.CurrentUser.Login + ")");


            return View();
        }

        #endregion
    }
}