using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Tests.Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entities.Jogador test = new Entities.Jogador();
            //test.Login = "Thoris";

            //IDictionary<string, object> res = test.PrimaryKey;

            //new SportPoint.Server.TestsVS.IntegrationTests.ModalidadeIntegrationTests().TestAllMethods();
            //new SportPoint.Server.TestsVS.IntegrationTests.JogadorIntegrationTests().TestAllMethods();


            new SportPoint.Server.TestsVS.DaoTests.EntityFrameworkTests.ModalidadeDaoEFTests().TestAllMethods();

        }
    }
}
