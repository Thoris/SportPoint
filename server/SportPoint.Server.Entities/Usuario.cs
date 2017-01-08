using SportPoint.Server.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities
{
    /// <summary>
    /// Entidade do usuário que possui informações básicas de acesso ao sistema.
    /// </summary>
    public abstract class Usuario : AuditModel
    {
        #region Properties


        /// <summary>
        /// Login do usuário.
        /// </summary>
        [Key]
        public string Login { get; set; }
        /// <summary>
        /// Senha do usuário.
        /// </summary>
        public string Senha { get; set; }

        #endregion
    }
}
