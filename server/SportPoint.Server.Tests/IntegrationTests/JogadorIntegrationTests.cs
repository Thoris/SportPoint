using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Tests.IntegrationTests
{
    public class JogadorIntegrationTests : GenericBaseTests<Entities.Jogador>
    {
        #region Constructors/Destructors

        public JogadorIntegrationTests()
            : base ( new Integration.JogadorIntegration(new Base.UrlTest().GetUrl()))
        {

        }

        #endregion

        #region Methods

        public new void TestAllMethods()
        {
            base.TestAllMethods();
        }

        #endregion
    }
}
