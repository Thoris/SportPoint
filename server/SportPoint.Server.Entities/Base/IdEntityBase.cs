using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities.Base
{
    /// <summary>
    /// Classe base que possui o identificador usado como referência no registro.
    /// </summary>
    public class IdEntityBase : AuditModel
    {
        #region Properties

        /// <summary>
        /// Propriedade que configura/retorna o identificador do registro.
        /// </summary>
        public long Id { get; set; }

        #endregion
    }
}
