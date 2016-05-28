using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.Collection
{
    /// <summary>
    /// Intrface base que contém as declarações do objeto de gerenciamento da entidade.
    /// </summary>
    /// <typeparam name="T">Entidade a ser gerenciada.</typeparam>
    /// <typeparam name="L">Chave da entidade.</typeparam>
    public interface IBaseCollection<T,L> : Dao.IGenericDao<T, L> where T : class
    {
    }
}
