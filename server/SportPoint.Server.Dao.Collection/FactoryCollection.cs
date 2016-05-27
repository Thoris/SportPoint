using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.Collection
{
    /// <summary>
    /// Classe que trabalha com a fábrica de objetos para coleção de dados.
    /// </summary>
    public class FactoryCollection : Dao.IFactoryDao
    {
        #region IFactoryDao members

        public IJogadorDao CreateJogadorDao()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
