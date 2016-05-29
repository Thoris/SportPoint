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
    public class JogadorIntegration : GenericIntegration<Entities.Jogador, long>, Business.Interfaces.IJogadorBO
    {
        #region Constants

        /// <summary>
        /// Nome do módulo usado para realizar a requisição.
        /// </summary>
        private const string ModuleName = "Jogador";

        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="JogadorIntegration" />.
        /// </summary>
        /// <param name="url">Url para chamada dos métodos de integração.</param>
        public JogadorIntegration(string url)
            : base (url, ModuleName)
        {

        }

        #endregion
    }
}
