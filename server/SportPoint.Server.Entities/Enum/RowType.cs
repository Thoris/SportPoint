using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities.Enum
{
    /// <summary>
    /// Enumeração que identifica o tipo de registro da entidade.
    /// </summary>
    public enum RowType : int
    {
        /// <summary>
        /// Identifica que o registro foi criado e que não houve alteração de ambiente algum.
        /// </summary>
        Nennhum = 0,
        /// <summary>
        /// Identifica que o registro foi alterado pelo dispositivo móvel.
        /// </summary>
        Mobile = 1,
        /// <summary>
        /// Identifica que o registro foi alterado pelo ambiente do servidor.
        /// </summary>
        Server = 2,
    }
}
