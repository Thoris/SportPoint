using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.EF
{
    public class PosicaoRepositoryDao : Base.BaseRepositoryDao<Entities.Posicao>, IPosicaoDao
    {
        #region Constructors/Destructors

        public PosicaoRepositoryDao(Base.IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        #endregion
    }
}
