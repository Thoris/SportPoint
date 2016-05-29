using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

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
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            

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

            string cmd = _url + command;

            HttpClient client = GetClient();

            HttpResponseMessage response = client.GetAsync(cmd).Result;

            if (response.IsSuccessStatusCode)
            {
                string res = response.Content.ReadAsStringAsync().Result;


            }



            return null;
        }
        /// <summary>
        /// Método que realiza o carregamento da quantidade de registros.
        /// </summary>
        /// <param name="command">Comando a ser executado.</param>
        /// <returns>Quantidade de registros encontrados.</returns>
        protected long HttpGet(string command)
        {
            //T result = default(T);

            string cmd = _url + command;

            HttpClient client = GetClient();

            HttpResponseMessage response = client.GetAsync(cmd).Result;

            if (response.IsSuccessStatusCode)
            {
                string res = response.Content.ReadAsStringAsync().Result;

                return long.Parse(res);

            }


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
          
            HttpResponseMessage response = client.GetAsync(cmd).Result;

            if (response.IsSuccessStatusCode)
            {
                string res = response.Content.ReadAsStringAsync().Result;



            }

            return default(T);
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
        /// <returns>True se conseguiu aplicar os registros especificados.</returns>
        protected bool HttpPost(string command, T entity)
        {
            #region Comments

            //HttpClient client = GetClient();
            //HttpResponseMessage response1 = client.PostAsync("http://localhost:1230/api/Jogador/TT/0", entity, new JsonMediaTypeFormatter()).Result;




            //string json = Newtonsoft.Json.JsonConvert.SerializeObject(entity);
            //HttpContent content1 = new StringContent(json);
            //content1.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            //HttpClient client1 = new HttpClient();
            //client1.BaseAddress = new Uri("http://localhost:1230/api/");
            ////HttpResponseMessage response1 = client1.PostAsync("http://localhost:1230/api/Jogador/Teste", content1).Result;

            //HttpResponseMessage response1 = client1.PostAsync("http://localhost:1230/api/Jogador/TT/0", entity, new JsonMediaTypeFormatter()).Result;


            //if (response1.IsSuccessStatusCode)
            //{
            //    var result = response1.Content.ReadAsAsync<T>().Result;
            //}
            //else
            //{
            //    return 0;
            //}









            //// HTTP POST
            //var gizmo = new Product() { Name = "Gizmo", Price = 100, Category = "Widget" };
            //response = await client.PostAsJsonAsync("api/products", gizmo);
            //if (response.IsSuccessStatusCode)
            //{
            //    // Get the URI of the created resource.
            //    Uri gizmoUrl = response.Headers.Location;
            //}


            

            //var httpClient = new HttpClient();
            //var response = httpClient.PostAsJsonAsync(posturi, model).Result;
            //bool returnValue = response.Content.ReadAsAsync<bool>().Result;


            //string cmd = _url + command;

            //HttpClient client = GetClient();

            //HttpResponseMessage response = client.(cmd).Result;

            //if (response.IsSuccessStatusCode)
            //{
            //    System.Console.WriteLine("Request Message Information:- \n\n" + response.RequestMessage + "\n");
            //    System.Console.WriteLine("Response Message Header \n\n" + response.Content.Headers + "\n");
            //}
            //else
            //{
            //    System.Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            //}




            //var client = new HttpClient();
            //HttpContent content = new HttpContent();
            //client.PostAsync<HttpContent>("http://localhost:44268/api/test", content, new FormUrlEncodedMediaTypeFormatter())
            //    .ContinueWith((postTask) => { postTask.Result.EnsureSuccessStatusCode(); });





            //string cmd = _url + command;

            //HttpClient client = GetClient();
            
            //var data = entity;
            ////response = await client.PostAsJsonAsync("api/products", gizmo);
            //HttpResponseMessage response = client.PostAsync(cmd, data).Result;

            //if (response.IsSuccessStatusCode)
            //{
            //    System.Console.WriteLine("Request Message Information:- \n\n" + response.RequestMessage + "\n");
            //    System.Console.WriteLine("Response Message Header \n\n" + response.Content.Headers + "\n");
            //}
            //else
            //{
            //    System.Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            //}

            //string cmd = _url + command;

            //HttpClient client = GetClient();

            


            //var content = new ObjectContent<long[]>(arr, new JsonMediaTypeFormatter());

            //var response = client.PostAsync(
            //    "https://<uri>/api/orderprocessing/UpdateBatchesToReadyToShip",
            //    content: content);


           
            //MediaTypeFormatter jsonFormatter = new JsonMediaTypeFormatter();
            //HttpContent content = new ObjectContent<T>(entity, jsonFormatter);

            //cmd = "http://localhost:1230/api/Jogador/Teste";



            //Console.WriteLine(content);




            ////string postBody = JsonSerializer(p); 
               
            //var response = client.PostAsync(cmd, content).Result;

            ////var response = client.PostAsync(cmd,
            ////    new StringContent(new JavaScriptSerializer().Serialize(entity),
            ////        Encoding.UTF8, "application/json")
            ////    ).Result;

            //if (response.IsSuccessStatusCode)
            //{

            //}

            #endregion


            HttpClient client = GetClient();
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(entity);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            
            HttpResponseMessage response = client.PostAsync(_url +"/" + command, entity,
                new JsonMediaTypeFormatter()).Result;

            if (response.IsSuccessStatusCode)
            {
                string res = response.Content.ReadAsStringAsync().Result ;

                if (!string.IsNullOrEmpty (res))
                {
                    bool result = bool.Parse(res);

                    return result;
                }                
            }

            return false;
        }        
        /// <summary>
        /// Método que envia os dados de entidades para armazenamento.
        /// </summary>
        /// <param name="command">Comando a ser executado.</param>
        /// <param name="entity1">Entidade 1.</param>
        /// <param name="entity2">Entidade 2.</param>
        /// <returns>True se conseguiu atualizar o registro.</returns>
        protected bool HttpPost(string command, T entity1, T entity2)
        {
            return HttpPost(command, entity2);
        }


        #region Tests

        //private void Test()
        //{
        //    DataContractJsonSerializer serializer = new DataContractJsonSerializer(MyClass.GetType());
        //    MemoryStream ms = new MemoryStream();

        //    serializer.WriteObject(ms, MyClass);
        //    string JsonString = Encoding.Default.GetString(ms.ToArray());
        //}


        ///// <summary>
        ///// Test GET Method
        ///// </summary>
        //private static void GenerateGetRequest()
        //{
        //    //Generate get request
        //    string url = "http://localhost/RestWebService/employee?id=3550";
        //    HttpWebRequest GETRequest = (HttpWebRequest)WebRequest.Create(url);
        //    GETRequest.Method = "GET";

        //    Console.WriteLine("Sending GET Request");
        //    HttpWebResponse GETResponse = (HttpWebResponse)GETRequest.GetResponse();
        //    Stream GETResponseStream = GETResponse.GetResponseStream();
        //    StreamReader sr = new StreamReader(GETResponseStream);

        //    Console.WriteLine("Response from Server");
        //    Console.WriteLine(sr.ReadToEnd());
        //    Console.ReadLine();
        //}

        ///// <summary>
        ///// Test POST Method
        ///// </summary>
        //private static void GeneratePOSTRequest()
        //{
        //    Console.WriteLine("Testing POST Request");
        //    string strURL = "http://localhost/RestWebService/employee";
        //    string strFirstName = "FirstName";
        //    string strLastName = "LastName";
        //    int EmpCode = 111;
        //    string strDesignation = "Janitor";

        //    // The client will be oblivious to server side data type
        //    // So Employee class is not being used here. Code - commented
        //    // To send a POST request -
        //    // 1. Create a Employee xml object in a memory stream
        //    // 2. Create a HTTPRequest object with the required URL
        //    // 3. Set the Method Type = POST and content type = txt/xml
        //    // 4. Get the HTTPRequest in a stream.
        //    // 5. Write the xml in the content of the stream
        //    // 6. Get a response from the erver.

        //    // Through Employee Class - not recommended
        //    //Employee emp = new Employee();
        //    //emp.FirstName = strFirstName;
        //    //emp.LastName = strLastName;
        //    //emp.EmpCode = EmpCode;
        //    //emp.Designation = strDesignation;
        //    //string str = SerializeXML(emp);           

        //    // Create the xml document in a memory stream - Recommended       

        //    byte[] dataByte = GenerateXMLEmployee(strFirstName, strLastName, EmpCode, strDesignation);

        //    HttpWebRequest POSTRequest = (HttpWebRequest)WebRequest.Create(strURL);
        //    //Method type
        //    POSTRequest.Method = "POST";
        //    // Data type - message body coming in xml
        //    POSTRequest.ContentType = "text/xml";
        //    POSTRequest.KeepAlive = false;
        //    POSTRequest.Timeout = 5000;
        //    //Content length of message body
        //    POSTRequest.ContentLength = dataByte.Length;

        //    // Get the request stream
        //    Stream POSTstream = POSTRequest.GetRequestStream();
        //    // Write the data bytes in the request stream
        //    POSTstream.Write(dataByte, 0, dataByte.Length);

        //    //Get response from server
        //    HttpWebResponse POSTResponse = (HttpWebResponse)POSTRequest.GetResponse();
        //    StreamReader reader = new StreamReader(POSTResponse.GetResponseStream(), Encoding.UTF8);
        //    Console.WriteLine("Response");
        //    Console.WriteLine(reader.ReadToEnd().ToString());
        //}

        ///// <summary>
        ///// Test PUT Method
        ///// </summary>
        //private static void GeneratePUTRequest()
        //{
        //    Console.WriteLine("Testing PUT Request");
        //    string Url = "http://localhost/RestWebService/employee";
        //    string strFirstName = "FName";
        //    string strLastName = "LName";
        //    int EmpCode = 111;
        //    string strDesignation = "Assistant";

        //    byte[] dataByte = GenerateXMLEmployee(strFirstName, strLastName, EmpCode, strDesignation);

        //    HttpWebRequest PUTRequest = (HttpWebRequest)HttpWebRequest.Create(Url);
        //    // Decorate the PUT request
        //    PUTRequest.Method = "PUT";
        //    PUTRequest.ContentType = "text/xml";
        //    PUTRequest.ContentLength = dataByte.Length;

        //    // Write the data byte stream into the request stream
        //    Stream PUTRequestStream = PUTRequest.GetRequestStream();
        //    PUTRequestStream.Write(dataByte, 0, dataByte.Length);

        //    //Send request to server and get a response.
        //    HttpWebResponse PUTResponse = (HttpWebResponse)PUTRequest.GetResponse();
        //    //Get the response stream
        //    StreamReader PUTResponseStream = new StreamReader(PUTResponse.GetResponseStream(), Encoding.UTF8);
        //    Console.WriteLine(PUTResponseStream.ReadToEnd().ToString());

        //}

        ///// <summary>
        ///// Test DELETE Method
        ///// </summary>
        //private static void GenerateDELETERequest()
        //{
        //    string Url = "http://localhost/RestWebService/employee?id=111";
        //    HttpWebRequest DELETERequest = (HttpWebRequest)HttpWebRequest.Create(Url);

        //    DELETERequest.Method = "DELETE";
        //    HttpWebResponse DELETEResponse = (HttpWebResponse)DELETERequest.GetResponse();

        //    StreamReader DELETEResponseStream = new StreamReader(DELETEResponse.GetResponseStream(), Encoding.UTF8);
        //    Console.WriteLine("Response Received");
        //    Console.WriteLine(DELETEResponseStream.ReadToEnd().ToString());
        //}

        #endregion

        #endregion
    }
}
