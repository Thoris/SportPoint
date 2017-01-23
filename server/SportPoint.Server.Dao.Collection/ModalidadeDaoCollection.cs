using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.Collection
{
    /// <summary>
    /// Classe que trabalha com o gerenciamento de dados das modalidades.
    /// </summary>
    public class ModalidadeDaoCollection : Base.BaseCollectionDao<Entities.Modalidade>, IModalidadeDao
    {
        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="ModalidadeDaoCollection"/>.
        /// </summary>
        public ModalidadeDaoCollection()
            : base("Id")
        {

        }

        #endregion
    }
}
