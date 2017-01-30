﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.EF
{
    public class JogoDataRepositoryDao : Base.BaseRepositoryDao<Entities.JogoData>, IJogoDataDao
    {
        #region Constructors/Destructors

        public JogoDataRepositoryDao(Base.IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        #endregion
    }
}
