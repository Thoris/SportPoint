using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Integration
{
    /// <summary>
    /// Classe que trabalha com o gerenciamento de funcionalidades Json
    /// </summary>
    /// <typeparam name="T">Tipo de entidade a ser gerenciado.</typeparam>
    public class JsonManagement<T>
    {
        #region Variables

        /// <summary>
        /// Variável que armazena a url da aplicação.
        /// </summary>
        private string _url;

        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="JsonManagement"/>.
        /// </summary>
        public JsonManagement()
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Propriedade que retorna o objeto usado para chamada das funcionalidades rest.
        /// </summary>
        /// <returns>Objeto HttpClient</returns>
        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(_url);

            return client;
        }
        
        protected void HttpGet(string command, T entity)
        {

        }
        protected void HttpPost(string command, T entity)
        {

        }
        protected void HttpDelete(string command, T entity)
        {

        }
        protected void HttpPut(string command, T entity)
        {

        }

        #endregion
    }
}
