using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportPoint.Server.Services.Controllers
{
    /// <summary>
    /// Classe que realiza o gerenciamento da entidade jogador.
    /// </summary>
    public class JogadorApiController : GenericController<Entities.Jogador, long>
    {
        #region Constructors/Destructors


        /// <summary>
        /// Inicializa nova instância da classe <see cref="JogadorApiController"/>.
        /// </summary>
        /// <param name="bo">Objeto de regra de negócio usado para gerenciar a entidade.</param>
        public JogadorApiController(Business.JogadorBO bo)
            : base(bo)
        {

        }

        #endregion

        #region Methods

        public Entities.Jogador Test()
        {
            return new Entities.Jogador()
            {
                Nome = "Teste",
                Id = 10,
                Login = "login"
            };
        }

        #endregion
    }
}