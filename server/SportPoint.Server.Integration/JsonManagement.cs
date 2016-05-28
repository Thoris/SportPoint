using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Integration.Base
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
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            

    //client.BaseAddress = new Uri("http://localhost:9000/");
    //client.DefaultRequestHeaders.Accept.Clear();
    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

    //// New code:
    //HttpResponseMessage response = await client.GetAsync("api/products/1");
    //if (response.IsSuccessStatusCode)
    //{
    //    Product product = await response.Content.ReadAsAsync>Product>();
    //    Console.WriteLine("{0}\t${1}\t{2}", product.Name, product.Price, product.Category);
    //}

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

            string cmd = _url + command;

            HttpClient client = GetClient();
            // List all Names.  
            

            HttpResponseMessage response = client.GetAsync(cmd).Result;  // Blocking call!  
            if (response.IsSuccessStatusCode)
            {
                System.Console.WriteLine("Request Message Information:- \n\n" + response.RequestMessage + "\n");
                System.Console.WriteLine("Response Message Header \n\n" + response.Content.Headers + "\n");
            }
            else
            {
                System.Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }


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
            //// HTTP POST
            //var gizmo = new Product() { Name = "Gizmo", Price = 100, Category = "Widget" };
            //response = await client.PostAsJsonAsync("api/products", gizmo);
            //if (response.IsSuccessStatusCode)
            //{
            //    // Get the URI of the created resource.
            //    Uri gizmoUrl = response.Headers.Location;
            //}


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
