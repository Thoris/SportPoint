using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
//using System.Net.Http;
//using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace SportPoint.Server.Tests.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            //Business.JogadorBO jogadorBo = Business.FactoryBO.CreateJogadorBO();
            //jogadorBo.Insert(new Entities.Jogador() { Login = "TEste1", Nome = "Teste1" });
            //jogadorBo.Insert(new Entities.Jogador() { Login = "TEste2", Nome = "Teste2" });
            //Entities.Jogador entida = jogadorBo.Find(1);

            //var httpClient = new System.Net.Http.HttpClient();
            //var response = httpClient.PostAsJsonAsync(posturi, model).Result;
            //bool returnValue = response.Content.ReadAsAsync<bool>().Result;

            //Entities.Jogador ent = new Entities.Jogador();
            //ent.Login = "Teste";
            //ent.Nome = "testesassa";


            //var client = new System.Net.Http.HttpClient();
            //var response = client.PostAsync("http://localhost:1230/api/jogador/insert", new StringContent(
            //    new JavaScriptSerializer().Serialize(ent), Encoding.UTF8, "application/json")
            //    ).Result;




            //JsonSerializer




            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://localhost:1230/");
            //// Add an Accept header for JSON format.  
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //// List all Names.  
            //HttpResponseMessage response = client.GetAsync("api/Jogador/Find").Result;  // Blocking call!  
            //if (response.IsSuccessStatusCode)
            //{
            //    System.Console.WriteLine("Request Message Information:- \n\n" + response.RequestMessage + "\n");
            //    System.Console.WriteLine("Response Message Header \n\n" + response.Content.Headers + "\n");
            //}
            //else
            //{
            //    System.Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            //}
            //System.Console.ReadLine(); 

            //Business.JogadorBO jogadorBo =  Business.FactoryBO.CreateJogadorBO();
            //jogadorBo.Insert(new Entities.Jogador() { Login = "teste1", Nome = "Teste1" });
            //jogadorBo.Insert(new Entities.Jogador() { Login = "teste2", Nome = "Teste2" });

            //jogadorBo.Find(2);
















            //Integration.JogadorIntegration jogadorInt = Integration.FactoryIntegration.CreateJogador();
            ////jogadorInt.Find(1);

            //jogadorInt.Insert(new Entities.Jogador() { Login = "teste1", Nome = "Teste1" });
            //jogadorInt.Insert(new Entities.Jogador() { Login = "teste2", Nome = "Teste2" });


            ////long total = jogadorInt.Count();
            ////jogadorInt.Delete(new Entities.Jogador() { Id = 1 });
            //ICollection<Entities.Jogador> list =  jogadorInt.GetAll();
            

            //Entities.Jogador res = jogadorInt.Find(2);
        }
    }
}
