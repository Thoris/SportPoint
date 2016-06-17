using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities
{
    /// <summary>
    /// Classe que contém a ligação entre modalidade e posição do jogador.
    /// </summary>
    public class ModalidadePosicao
    {
        #region Properties

        /// <summary>
        /// Propriedade que configura/retorna o identificador da modalidade.
        /// </summary>
        public long IdModalidade { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna o nome da posição disponível para a modalidade.
        /// </summary>
        public string Nome { get; set; }

        #endregion
    }
}
