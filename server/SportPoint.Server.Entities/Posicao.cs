using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities
{
    /// <summary>
    /// Classe da entidade que possui as informações da posição do jogador.
    /// </summary>
    public class Posicao : Base.IdEntityBase
    {
        #region Properties

        /// <summary>
        /// Propriedade que configura/retorna o nome da posição.
        /// </summary>
        public string Nome { get; set; }

        #endregion
    }
}
