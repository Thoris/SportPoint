using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.EF
{
    public class HorarioRepositoryDao : Base.BaseRepositoryDao<Entities.Horario>, IHorarioDao
    {
        #region Constructors/Destructors

        public HorarioRepositoryDao(Base.IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        #endregion
    }
}
