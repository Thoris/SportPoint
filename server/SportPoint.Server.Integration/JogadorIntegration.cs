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
    public class JogadorIntegration : GenericIntegration<Entities.Jogador, long>
    {
        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="JogadorIntegration"/>.
        /// </summary>
        public JogadorIntegration()
        {

        }

        #endregion
    }
}
