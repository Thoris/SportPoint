using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Business.Interfaces
{
    public interface IFactoryBO
    {
        IJogadorBO CreateJogador();
        IModalidadeBO CreateModalidade();
    }
}
