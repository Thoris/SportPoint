using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Business
{
    /// <summary>
    /// Classe que trabalha com a fabrica do objetos de regra de negócio.
    /// </summary>
    public class FactoryBO
    {
        #region Variables

        /// <summary>
        /// Variável que armazena a fábrica de conexão com banco de dados.
        /// </summary>
        private static Dao.IFactoryDao _factoryDao;

        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="FactoryBO"/>.
        /// </summary>
        public FactoryBO()
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Método que retorna o objeto de fábrica de objetos para acesso à banco de dados.
        /// </summary>
        /// <returns>Objeto que possui a fábrica de objetos de conexão com o banco de dados.</returns>
        private static Dao.IFactoryDao GetFactoryDao()
        {
            if (_factoryDao == null)
            {
                _factoryDao = new Dao.EF.FactoryDaoEF();
            }

            return _factoryDao;
        }

        /// <summary>
        /// Método que cria o objeto de regra de negócio de gerenciamento do jogador.
        /// </summary>
        /// <returns>Objeto de gerenciamento de regras do jogador.</returns>
        public static JogadorBO CreateJogadorBO()
        {
            return new JogadorBO("", GetFactoryDao().CreateJogadorDao());
        }

        #endregion
    }
}
