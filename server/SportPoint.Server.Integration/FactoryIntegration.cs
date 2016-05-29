using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Integration
{
    /// <summary>
    /// Classe que possui a fábrica de objetos de integração.
    /// </summary>
    public class FactoryIntegration 
    {

        #region Variables

        /// <summary>
        /// Variável que armazena a url usada para requisições via REST.
        /// </summary>
        private static string _url;

        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="FactoryIntegration" />.
        /// </summary>
        public FactoryIntegration()
        {

        }
        /// <summary>
        /// Inicializa nova instância da classe <see cref="FactoryIntegration" />.
        /// </summary>
        /// <param name="url">Url de conexão.</param>
        public FactoryIntegration(string url)
        {
            _url = url;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Método que carrega a url para realização das chamadas de integração.
        /// </summary>
        /// <returns>Url configurada.</returns>
        private static string GetUrl()
        {
            //Se não existe url carregada
            if (string.IsNullOrEmpty(_url))
            {
                string url = System.Configuration.ConfigurationManager.AppSettings["UrlIntegration"];

                if (!string.IsNullOrEmpty(url))
                {
                    _url = System.Configuration.ConfigurationManager.AppSettings["UrlIntegration"];
                }
                else
                {
                    _url = "http://localhost:1230/";
                }
            }//endif url null

            return _url;

        }

        #endregion

        #region IFactoryDao members

        /// <summary>
        /// Método que cria o objeto de regras de negócio do jogador.
        /// </summary>
        /// <returns>
        /// Objeto que possui regras de negócio do jogador.
        /// </returns>
        public static JogadorIntegration CreateJogador()
        {
            return new JogadorIntegration (GetUrl ());
        }

        #endregion
    }
}
