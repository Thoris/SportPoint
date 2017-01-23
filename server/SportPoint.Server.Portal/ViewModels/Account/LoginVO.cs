using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportPoint.Server.Portal.ViewModels.Account
{
    /// <summary>
    /// Classe que trabalha com o gerenciamento do login.
    /// </summary>
    public class LoginVO
    {
        /// <summary>
        /// Propriedade que configura/retorna o login do usuário.
        /// </summary>
        [Required]
        public string Login { get; set; }

        /// <summary>
        /// Propriedade que configura/retorna a senha do usuário.
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        /// <summary>
        /// Propriedade que configura/retorna se deve relembrar da senha ao acessar o sistema novamente.
        /// </summary>
        public bool Lembrar { get; set; }
    }
}