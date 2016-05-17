using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities
{
    public class EntityBase
    {
        #region Properties

        public string CriadoPor { get; set; }
        public DateTime DataCriacao { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime DataModificacao { get; set; }
        public bool IsAtivo { get; set; }

        #endregion
    }
}
