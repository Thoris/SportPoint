using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Integration
{
    /// <summary>
    /// Classe que trabalha com a integração das funcionalidades do jogador.
    /// </summary>
    public class JogadorIntegrationDao : GenericIntegrationDao<Entities.Jogador, long>, Dao.IJogadorDao
    {
        #region Constants

        /// <summary>
        /// Nome do módulo usado para realizar a requisição.
        /// </summary>
        private const string ModuleName = "Jogador";

        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="JogadorIntegrationDao" />.
        /// </summary>
        /// <param name="url">Url para chamada dos métodos de integração.</param>
        public JogadorIntegrationDao(string url)
            : base (url, ModuleName)
        {

        }

        #endregion
    }
}
