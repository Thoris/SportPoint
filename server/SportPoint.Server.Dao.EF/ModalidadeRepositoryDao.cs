using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.EF
{
    public class ModalidadeRepositoryDao: Base.BaseRepositoryDao<Entities.Modalidade>, Dao.IModalidadeDao
    {
        #region Constructors/Destructors

        public ModalidadeRepositoryDao(Base.IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

        #endregion

    }
}
