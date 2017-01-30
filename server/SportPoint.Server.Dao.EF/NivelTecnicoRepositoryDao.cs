using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.EF
{
    public class NivelTecnicoRepositoryDao : Base.BaseRepositoryDao<Entities.NivelTecnico>, INivelTecnicoDao
    {
        #region Constructors/Destructors

        public NivelTecnicoRepositoryDao(Base.IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        #endregion
    }
}
