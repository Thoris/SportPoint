using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Business
{
    /// <summary>
    /// Classe que realiza o gerenciamento de jogadores, e que possui as regras de negócio para a manipulação dos dados.
    /// </summary>
    public class JogadorBO : BaseGenericBusinessBO<Entities.Jogador, long>
    {
        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="JogadorBO"/>.
        /// </summary>
        /// <param name="userName">Nome do usuário corrente que está manipulando o sistema.</param>
        /// <param name="dao">Objeto de acesso à dados..</param>
        public JogadorBO(string userName, Dao.IJogadorDao dao)
            : base (userName, dao)
        {

        }

        #endregion
    }
}
