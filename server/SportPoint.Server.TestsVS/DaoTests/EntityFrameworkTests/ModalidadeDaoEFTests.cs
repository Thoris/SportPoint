using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.TestsVS.DaoTests.EntityFrameworkTests
{
    [TestClass]
    public class ModalidadeDaoEFTests : GenericBaseEFTests<Entities.Modalidade>
    {
        #region Constructors/Destructors

        public ModalidadeDaoEFTests()
            : base(new Dao.EF.ModalidadeRepositoryDao(new Dao.EF.UnitOfWork ()))
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
        [TestMethod]
        public void TestIntegrationJogadorCountWhere()
        {
            base.TestCountWhere();
        }

        #endregion
    }
}
