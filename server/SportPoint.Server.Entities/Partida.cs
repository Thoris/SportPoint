using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities
{
    /// <summary>
    /// Classe que possui a entidade da partida ocorrida na data do jogo.
    /// </summary>
    public class Partida
    {
        #region Properties

        /// <summary>
        /// Propriedade que configura/retorna o identificador da data do jogo
        /// </summary>
        public long IdJogoData { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna o número da partida.
        /// </summary>
        public int NumeroPartida { get; set; }

        #endregion
    }
}
