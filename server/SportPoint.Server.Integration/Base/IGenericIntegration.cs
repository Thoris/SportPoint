﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Integration.Base
{
    /// <summary>
    /// Interface que possui as funcionalidades básicas de gerenciamento da entidade.
    /// </summary>
    /// <typeparam name="T">Entidade a ser gerenciada.</typeparam>
    public interface IGenericIntegration<T> : Business.Base.IGenericBusiness<T>  where T : class
    {
        
    }
}
