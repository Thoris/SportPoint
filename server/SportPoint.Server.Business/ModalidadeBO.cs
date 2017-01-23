using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Business
{
    /// <summary>
    /// Classe que realiza o gerenciamento de modalidades, e que possui as regras de negócio para a manipulação dos dados.
    /// </summary>
    public class ModalidadeBO : Base.BaseGenericBusinessBO<Entities.Modalidade>, Interfaces.IModalidadeBO
    {
        #region Constructors/Destructors

        public ModalidadeBO(string userName, Dao.IModalidadeDao dao)
            : base (userName, dao)
        {

        }

        #endregion
    }
}
