using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities
{
    /// <summary>
    /// Classe que possui dados da entidade modalidade.
    /// </summary>
    public class Modalidade : Base.IdEntityBase
    {
        #region Properties

        /// <summary>
        /// Propriedade que configura/retorna o nome da modalidade.
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna a descrição da modalidade.
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Propriedade que configura/retorna a quantidade de pessoas por time.
        /// </summary>
        public int QtdPessoasTime { get; set; }

        #endregion
    }
}
