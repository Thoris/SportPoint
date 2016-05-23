using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities
{
    /// <summary>
    /// Entidade do jogador.
    /// </summary>
    public class Jogador : Usuario
    {
        #region Properties
        
        /// <summary>
        /// Nome do jogador.
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Data de Nascimento.
        /// </summary>
        public DateTime DataNascimento { get; set; }

        #endregion
    }
}
