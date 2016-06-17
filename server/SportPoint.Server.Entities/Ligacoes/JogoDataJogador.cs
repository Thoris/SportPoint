using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities.Ligacoes
{
    /// <summary>
    /// Classe que trabalha com os jogadores que participaram da data do jogo.
    /// </summary>
    public class JogoDataJogador
    {
        #region Properties

        /// <summary>
        /// Propriedade que configura/retorna o identificador da Data do jogo.
        /// </summary>
        public long IdJogoData { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna o identificador do jogador
        /// </summary>
        public string JogadorLogin { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna a ordem de chegada
        /// </summary>
        public int OrdemChegada { get; set; }

        #endregion
    }
}
