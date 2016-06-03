using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities
{
    /// <summary>
    /// Classe que possui a entidade de configuração de horário da turma.
    /// </summary>
    public class Horario
    {
        #region Properties

        /// <summary>
        /// Propriedade que configura/retorna o dia da semana.
        /// </summary>
        public int DiaSemana { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna o horário do jogo.
        /// </summary>
        public TimeSpan Hora { get; set; }
        

        #endregion
    }
}
