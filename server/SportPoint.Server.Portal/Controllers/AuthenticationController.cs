using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace SportPoint.Server.Portal.Controllers
{
    public class AuthenticationController : BaseController
    {
        #region Properties

        protected Entities.Usuario CurrentUser
        {
            get
            {
                if (System.Web.HttpContext.Current.Session == null)
                    return null;

                //Se não possui os dados do login carregado na memória
                if (System.Web.HttpContext.Current.Session["Usuario"] == null)
                {


                    //Se o usuário está autenticado pela autenticação forms
                    if (System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
                    {
                        //LimparLogin();

                        //string login = System.Web.HttpContext.Current.User.Identity.Name;
                        //Model.Seguranca.SegUsuario model =
                        //    new Helpers.InstanceCreator(login).CreateSegurancaUsuarioBO().RecarregarUsuario(login);

                        //LogManager.LogTool.Info(this, "Autenticação do Login: " + login + " - Recarregando");

                        ////Se não encontrou o usuário, ou o mesmo está desativado
                        //if (model == null)
                        //{
                        //    FormsAuthentication.SignOut();
                        //    return null;
                        //}
                        //else
                        //    return model;
                        return null;

                    }
                    else
                        return null;
                }
                else
                    return (Entities.Usuario)System.Web.HttpContext.Current.Session["Usuario"];
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Método que atribui as informações do login do usuário quando ocorrer login.
        /// </summary>
        /// <param name="usuario">Objeto que possui os dados do usuário.</param>
        /// <param name="persistente">Se deve ser persistente para armazenar o login do usuário sem a necessidade de executar o login o tempo todo.</param>
        protected void SetLogin(Entities.Usuario usuario, bool persistente)
        {
            System.Web.HttpContext.Current.Session["Usuario"] = usuario;
            FormsAuthentication.SetAuthCookie(usuario.Login, persistente);

        }
        /// <summary>
        /// Método que limpa os dados do login, executando desta forma, o logoff.
        /// </summary>
        protected void CleanLogin()
        {
            //System.Web.HttpContext.Current.Session["Usuario"] =null;
            System.Web.HttpContext.Current.Session.Clear();
            FormsAuthentication.SignOut();
        }

        #endregion
    }
}