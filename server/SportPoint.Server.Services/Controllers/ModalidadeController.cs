using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportPoint.Server.Services.Controllers
{
    public class ModalidadeController : GenericApiController<Entities.Modalidade>
    {
        #region Properties

        /// <summary>
        /// Propriedade que retorna o objeto que possui regras de negócio do gerenciamento da entidade.
        /// </summary>
        private Business.ModalidadeBO Dao
        {
            get { return (Business.ModalidadeBO)base.BaseBo; }
        }

        #endregion

        #region Constructors/Destructors

        public ModalidadeController()
            : base ( new Business.FactoryBO().CreateModalidade())
        {

        }

        #endregion

        #region Methods
        #endregion
    }
}