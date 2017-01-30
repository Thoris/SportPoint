using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities
{
    /// <summary>
    /// Classe que possui a entidade de identificação se o jogador participará do jogo na data específica.
    /// </summary>
    public class JogoDataConfirmacaoJogador
    {
        #region Properties

        /// <summary>
        /// Propriedade que configura/retorna se o usuário está confirmado para a partida em aberto.
        /// </summary>
        public Enum.ConfirmacaoTipo Confirmado { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna o identificador do jogador que realizou a confirmação.
        /// </summary>
        public int JogadorId { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna a data de confirmação do jogador.
        /// </summary>
        public DateTime DataConfirmacao { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna o motivo da confirmação.
        /// </summary>
        public string Motivo { get; set; }

        #endregion
    }
}
