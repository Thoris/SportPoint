using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities.Base
{
    /// <summary>
    /// Classe base da entidade que possui informações básicas do registro.
    /// </summary>
    public class AuditModel
    {
        #region Properties

        /// <summary>
        /// Propriedade que configura/retorna o login do usuário que criou o registro.
        /// </summary>
        public string CriadoPor { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna a data de criação do registro.
        /// </summary>
        public DateTime DataCriacao { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna o login do usuário que modificou o registro.
        /// </summary>
        public string ModificadoPor { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna a data de modificação do registro.
        /// </summary>
        public DateTime DataModificacao { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna um flag se o registro está ativo.
        /// </summary>
        public bool IsAtivo { get; set; }

        #endregion
    }
}
