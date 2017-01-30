using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.EF
{
    public class PartidaRepositoryDao : Base.BaseRepositoryDao<Entities.Partida>, IPartidaDao
    {
        #region Constructors/Destructors

        public PartidaRepositoryDao(Base.IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        #endregion
    }
}
