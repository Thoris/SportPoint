using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.Collection.Base
{
    /// <summary>
    /// Intrface base que contém as declarações do objeto de gerenciamento da entidade.
    /// </summary>
    /// <typeparam name="T">Entidade a ser gerenciada.</typeparam>
    public interface IBaseCollection<T> : Dao.IGenericDao<T> where T : class
    {
    }
}
