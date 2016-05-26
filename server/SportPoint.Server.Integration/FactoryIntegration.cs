using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Integration
{
    /// <summary>
    /// Classe que possui a fábrica de objetos de integração.
    /// </summary>
    public class FactoryIntegration
    {
        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="FactoryIntegration"/>.
        /// </summary>
        public FactoryIntegration()
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Método que cria um objeto de integração para as funcionalidades de gerenciamento do jogador.
        /// </summary>
        /// <returns>Objeto que integração de gerenciamento do jogador.</returns>
        public static JogadorIntegration CreateJogadorIntegration()
        {
            return new JogadorIntegration();
        }

        #endregion
    }
}
