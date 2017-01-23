using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.TestsVS.IntegrationTests
{
    [TestClass]
    public class JogadorIntegrationTests : GenericBaseTests<Entities.Jogador>
    {
        #region Constructors/Destructors

        public JogadorIntegrationTests()
            : base(new Integration.JogadorIntegration(new Base.UrlTest().GetUrl()))
        {

        }

        #endregion

        #region Methods

        public new void TestAllMethods()
        {
            base.TestAllMethods();
        }


        [TestMethod]
        public void TestIntegrationJogadorLoad()
        {
            base.TestLoad();
        }
        [TestMethod]
        public void TestIntegrationJogadorInsert()
        {
            base.TestInsert();
        }
        [TestMethod]
        public void TestIntegrationJogadorUpdate()
        {
            base.TestUpdate();
        }
        [TestMethod]
        public void TestIntegrationJogadorDelete()
        {
            base.TestDelete();
        }
        [TestMethod]
        public void TestIntegrationJogadorGetList()
        {
            base.TestGetList();
        }
        [TestMethod]
        public void TestIntegrationJogadorGetAll()
        {
            base.TestGetAll();
        }
        [TestMethod]
        public void TestIntegrationJogadorCount()
        {
            base.TestCount();
        }

        #endregion
    }
}
