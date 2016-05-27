using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.Collection
{
    /// <summary>
    /// Classe que possui o gerenciamento do repositório da entidade.
    /// </summary>
    /// <typeparam name="T">Tipo de entidade a ser gerenciada.</typeparam>
    /// <typeparam name="L">Chave do objeto.</typeparam>
    public class BaseCollectionDao<T, L> where T : class
    {
        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="BaseCollectionDao{T, L}"/>.
        /// </summary>
        public BaseCollectionDao ()
        {

        }

        #endregion
    }
}
