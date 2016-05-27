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
    /// <typeparam name="L">Chave do item da entidade.</typeparam>
    public class JsonManagement<T, L>
    {
        #region Variables

        /// <summary>
        /// Variável que armazena a url da aplicação.
        /// </summary>
        private string _url;

        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="JsonManagement" />.
        /// </summary>
        /// <param name="url">Url de conexão com o objeto de conexão com a base.</param>
        public JsonManagement(string url)
        {
            _url = url;
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
        /// <summary>
        /// Método que realiza o carregamento dos dados.
        /// </summary>
        /// <param name="command">Comando a ser executado.</param>
        /// <param name="max">Quantidade máxima de registros. Caso configurado = 0 ou negativo, retornar todos os registros.</param>
        /// <returns>
        /// Lista de itens encontrados.
        /// </returns>
        protected ICollection<T> HttpGet(string command, long max)
        {
            return null;
        }
        /// <summary>
        /// Método que realiza o carregamento da quantidade de registros.
        /// </summary>
        /// <param name="command">Comando a ser executado.</param>
        /// <returns>Quantidade de registros encontrados.</returns>
        protected long HttpGet(string command)
        {
            return 0;
        }
        /// <summary>
        /// Método que realiza o carregamento de um item baseado na chave específica.
        /// </summary>
        /// <param name="command">Comando a ser executado.</param>
        /// <param name="key">Chave usada na pesquisa.</param>
        /// <returns>Objeto encontrado, ou nulo caso não encontre.</returns>
        protected T HttpGet(string command, L key)
        {
            T result = default(T);

            return result;
        }
        /// <summary>
        /// Método que realiza o carregamento de um item baseado em sua entidade.
        /// </summary>
        /// <param name="command">Comando a ser executado.</param>
        /// <param name="entity">Entidade usada como filtro.</param>
        /// <returns>Entidade encontrada, caso contrário, nulo.</returns>
        protected T HttpGet(string command, T entity)
        {
            T result = default(T);

            return result;
        }
        /// <summary>
        /// Método que envia os dados da entidade para armazenamento.
        /// </summary>
        /// <param name="command">Comando a ser executado.</param>
        /// <param name="entity">Entidade que possui os dados a serem armazenados.</param>
        /// <returns>Quantidade de registros aplicados.</returns>
        protected int HttpPost(string command, T entity)
        {
            return 0;
        }
        /// <summary>
        /// Método que envia os dados de entidades para armazenamento.
        /// </summary>
        /// <param name="command">Comando a ser executado.</param>
        /// <param name="entity1">Entidade 1.</param>
        /// <param name="entity2">Entidade 2.</param>
        /// <returns>Quantidade de registros afetados.</returns>
        protected int HttpPost(string command, T entity1, T entity2)
        {
            return 0;
        }

        #endregion
    }
}
