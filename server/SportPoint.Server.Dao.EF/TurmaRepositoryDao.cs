using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.EF
{
    public class TurmaRepositoryDao : Base.BaseRepositoryDao<Entities.Turma>, ITurmaDao
    {
        #region Constructors/Destructors

        public TurmaRepositoryDao(Base.IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        #endregion
    }
}
