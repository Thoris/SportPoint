using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.TestsVS.IntegrationTests
{
    [TestClass]
    public class ModalidadeIntegrationTests: GenericBaseTests<Entities.Modalidade>
    {
        #region Constructors/Destructors

          public ModalidadeIntegrationTests()
              : base(new Integration.ModalidadeIntegration(new Base.UrlTest().GetUrl()))
        {

        }

        #endregion

        #region Methods

        public new void TestAllMethods()
        {
            base.TestAllMethods();
        }
        [TestMethod]
        public void TestIntegrationModalidadeLoad()
        {
            base.TestLoad();
        }
        [TestMethod]
        public void TestIntegrationModalidadeInsert()
        {
            base.TestInsert();
        }
        [TestMethod]
        public void TestIntegrationModalidadeUpdate()
        {
            base.TestUpdate();
        }
        [TestMethod]
        public void TestIntegrationModalidadeDelete()
        {
            base.TestDelete();
        }
        [TestMethod]
        public void TestIntegrationModalidadeGetList()
        {
            base.TestGetList();
        }
        [TestMethod]
        public void TestIntegrationModalidadeGetAll()
        {
            base.TestGetAll();
        }
        [TestMethod]
        public void TestIntegrationModalidadeCount()
        {
            base.TestCount();
        }
        [TestMethod]
        public void TestIntegrationModalidadeCountWhere()
        {
            base.TestCountWhere();
        }

        #endregion
    }
}
