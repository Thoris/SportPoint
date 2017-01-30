using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.EF
{
    public class JogadorPosicaoRepositoryDao : Base.BaseRepositoryDao<Entities.Ligacoes.JogadorPosicao>, IJogadorPosicaoDao
    {
        #region Constructors/Destructors

        public JogadorPosicaoRepositoryDao(Base.IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        #endregion
    }
}
