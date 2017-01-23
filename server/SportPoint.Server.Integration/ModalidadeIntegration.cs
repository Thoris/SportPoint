using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Integration
{
    /// <summary>
    /// Classe que trabalha com a integração das funcionalidades das modalidades.
    /// </summary>
    public class ModalidadeIntegration : Base.GenericIntegration<Entities.Modalidade>, Business.Interfaces.IModalidadeBO
    {
        #region Constants

        /// <summary>
        /// Nome do módulo usado para realizar a requisição.
        /// </summary>
        private const string ModuleName = "Modalidade";

        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="ModalidadeIntegration" />.
        /// </summary>
        /// <param name="url">Url para chamada dos métodos de integração.</param>
        public ModalidadeIntegration(string url)
            : base (url, ModuleName)
        {

        }

        #endregion
    }
}
