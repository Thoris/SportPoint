using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SportPoint.Server.Services.Controllers.Manager
{
    /// <summary>
    /// Classe que possui o controlador da entidade jogador.
    /// </summary>
    public class JogadorController : GenericApiController<Entities.Jogador, long>
    {
        #region Properties

        /// <summary>
        /// Propriedade que retorna o objeto que possui regras de negócio do gerenciamento da entidade.
        /// </summary>
        private Business.JogadorBO Dao
        {
            get { return (Business.JogadorBO)base.BaseBo; }
        }

        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="JogadorController"/>.
        /// </summary>
        public JogadorController()
            : base ( Business.FactoryBO.CreateJogadorBO())
        {

        }

        #endregion

        #region Methods

        //// GET: api/Jogador
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Jogador/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Jogador
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Jogador/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Jogador/5
        //public void Delete(int id)
        //{
        //}

        [HttpPost]
        public string TT(Entities.Jogador jogador)
        {
            Console.WriteLine("OK");

            return "TOTAL";
        }

        #endregion
    }
}
