using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.EF
{
    public class JogoDataJogadorRepositoryDao : Base.BaseRepositoryDao<Entities.Ligacoes.JogoDataJogador>, IJogoDataJogadorDao
    {
        #region Constructors/Destructors

        public JogoDataJogadorRepositoryDao(Base.IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        #endregion
    }
}
