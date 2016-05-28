using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.Collection
{
    /// <summary>
    /// Classe que trabalha com a fábrica de objetos para coleção de dados.
    /// </summary>
    public class FactoryCollection : Dao.IFactoryDao
    {
        #region IFactoryDao members

        /// <summary>
        /// Método que cria o objeto de acesso à dados do para gerenciamento do jogador.
        /// </summary>
        /// <returns>
        /// Objeto que possui a instância do jogador.
        /// </returns>
        public IJogadorDao CreateJogadorDao()
        {
            return new Collection.JogadorDaoCollection();
        }

        #endregion
    }
}
