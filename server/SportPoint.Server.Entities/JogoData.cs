using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities
{
    /// <summary>
    /// Classe que possui a entidade da data do jogo.
    /// </summary>
    public class JogoData
    {
        #region Properties

        /// <summary>
        /// Propriedade que configura/retorna a data do jogo.
        /// </summary>
        public DateTime DataJogo { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna a data de agendamento do jogo.
        /// </summary>
        public DateTime DataAgendamento { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna a data de início de confirmação.
        /// </summary>
        public DateTime DataInicioConfirmacao { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna a data de fim da confirmação.
        /// </summary>
        public DateTime DataFimConfirmacao { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna a descrição da data do jogo.
        /// </summary>
        public string Descricao { get; set; }

        #endregion
    }
}
