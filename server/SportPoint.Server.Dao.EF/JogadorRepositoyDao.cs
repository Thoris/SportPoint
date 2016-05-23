using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.EF
{
    /// <summary>
    /// Classe de acesso à dados através do Entity Framework para gerenciamento de jogadores.
    /// </summary>
    public class JogadorRepositoyDao : BaseRepositoryDao<Entities.Jogador, long>, Dao.IJogadorDao
    {
        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="JogadorRepositoyDao"/>.
        /// </summary>
        /// <param name="unitOfWork">Objeto que possui o padrão unit of work.</param>
        public JogadorRepositoyDao(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

        #endregion
    }
}
