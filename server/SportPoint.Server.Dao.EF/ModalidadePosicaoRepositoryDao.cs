using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.EF
{
    public class ModalidadePosicaoRepositoryDao : Base.BaseRepositoryDao<Entities.ModalidadePosicao>, IModalidadePosicaoDao
    {
        #region Constructors/Destructors

        public ModalidadePosicaoRepositoryDao(Base.IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        #endregion
    }
}
