using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities.Base
{
    /// <summary>
    /// Classe que trabalha com a entidade usando o nome como objeto chave.
    /// </summary>
    public class NameEntityBase : AuditModel
    {
        #region Properties

        /// <summary>
        /// Propriedade que configura/retorna o nome da entidade.
        /// </summary>
        public string Name { get; set; }

        #endregion
    }
}
