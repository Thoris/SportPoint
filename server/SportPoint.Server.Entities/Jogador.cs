using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities
{
    /// <summary>
    /// Entidade do jogador.
    /// </summary>
    public class Jogador : Base.AuditModel
    {
        #region Properties

        /// <summary>
        /// Identificador do Jogador
        /// </summary>
        public int JogadorId { get; set; }
        /// <summary>
        /// Nome do jogador.
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Data de Nascimento.
        /// </summary>
        public DateTime DataNascimento { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna o email do jogador.
        /// </summary>
        public string Email {get;set;}
        /// <summary>
        /// Propriedade que configura/retorna o telefone do jogador.
        /// </summary>
        public string Telefone { get; set; }
        /// <summary>
        /// Login do usuário que gerencia o jogador.
        /// </summary>
        public string Login { get; set; }

        #endregion
    }
}
