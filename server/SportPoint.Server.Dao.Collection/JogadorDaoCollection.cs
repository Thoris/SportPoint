using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.Collection
{
    /// <summary>
    /// Classe que trabalha com o gerenciamento de dados do jogador.
    /// </summary>
    public class JogadorDaoCollection : Base.BaseCollectionDao<Entities.Jogador>, IJogadorDao
    {
        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="JogadorDaoCollection"/>.
        /// </summary>
        public JogadorDaoCollection()
            : base("Id")
        {

        }

        #endregion
    }
}
