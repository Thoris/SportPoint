using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.TestsVS.BusinessTests
{
    [TestClass]
    public class ModalidadeBOTests : GenericBaseBOTests<Entities.Modalidade>
    {
        #region Constructors/Destructors

        public ModalidadeBOTests()
            : base(new Business.FactoryBO().CreateModalidade())
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
