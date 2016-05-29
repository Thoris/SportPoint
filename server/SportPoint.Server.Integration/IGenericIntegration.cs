using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Integration
{
    /// <summary>
    /// Interface que possui as funcionalidades básicas de gerenciamento da entidade.
    /// </summary>
    /// <typeparam name="T">Entidade a ser gerenciada.</typeparam>
    /// <typeparam name="L">Estrututra do campo chave da entidade.</typeparam>
    public interface IGenericIntegration<T, L> : Business.Base.IGenericBusiness<T,L>  where T : class
    {
        
    }
}
