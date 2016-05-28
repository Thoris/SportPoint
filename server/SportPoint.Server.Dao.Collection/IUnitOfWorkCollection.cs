using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.Collection
{
    /// <summary>
    /// Interface que possui o padrão de projetos UnitOfWork
    /// </summary>
    public interface IUnitOfWorkCollection
    {
        /// <summary>
        /// Método que atualiza os dados na base de dados.
        /// </summary>
        /// <returns>Quantidade de registros atualizados.</returns>
        int Save();
    }
}
