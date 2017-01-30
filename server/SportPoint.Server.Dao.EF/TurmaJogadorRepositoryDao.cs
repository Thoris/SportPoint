using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.EF
{
    public class TurmaJogadorRepositoryDao : Base.BaseRepositoryDao<Entities.Ligacoes.TurmaJogador>, ITurmaJogadorDao
    {
        #region Constructors/Destructors

        public TurmaJogadorRepositoryDao(Base.IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        #endregion
    }
}
