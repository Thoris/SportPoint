using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Tests.Console
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Business.JogadorBO jogadorBo =  Business.FactoryBO.CreateJogadorBO();
            jogadorBo.Find(10);

        }
    }
}
