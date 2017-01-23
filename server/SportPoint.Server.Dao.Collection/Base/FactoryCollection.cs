using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.Collection.Base
{
    /// <summary>
    /// Classe que trabalha com a fábrica de objetos para coleção de dados.
    /// </summary>
    public class FactoryCollection : Dao.IFactoryDao
    {
        #region Variables

        /// <summary>
        /// Variável local que possui os dados do padrão unit of work.
        /// </summary>
        private static UnitOfWorkCollection _unitOfWork;

        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="FactoryCollection"/>.
        /// </summary>
        public FactoryCollection()
        {
            _unitOfWork = new UnitOfWorkCollection();
        }

        #endregion

        #region IFactoryDao members

        /// <summary>
        /// Método que cria o objeto de acesso à dados do para gerenciamento do jogador.
        /// </summary>
        /// <returns>
        /// Objeto que possui a instância do jogador.
        /// </returns>
        public IJogadorDao CreateJogadorDao()
        {
            return _unitOfWork.Jogadores;
            //return new Collection.JogadorDaoCollection();
        }
        public IModalidadeDao CreateModalidadeDao()
        {
            return _unitOfWork.Modalidades;
        }
        #endregion



    }
}
