using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao
{
    /// <summary>
    /// Interface que possui as funcionalidades básicas de acesso à dados para gerenciamento do jogador.
    /// </summary>
    public interface IJogadorDao : IGenericDao<Entities.Jogador, long>
    {
    }
}
