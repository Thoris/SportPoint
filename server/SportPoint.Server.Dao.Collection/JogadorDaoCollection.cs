using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.Collection
{
    /// <summary>
    /// Classe que trabalha com o gerenciamento de dados do jogador.
    /// </summary>
    public class JogadorDaoCollection : IJogadorDao
    {
        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="JogadorDaoCollection"/>.
        /// </summary>
        public JogadorDaoCollection()
        {

        }

        #endregion


        #region IJogadorDao members

        public Entities.Jogador Find(long id)
        {
            throw new NotImplementedException();
        }

        public Entities.Jogador Load(Entities.Jogador entity)
        {
            throw new NotImplementedException();
        }

        public int Insert(Entities.Jogador entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(Entities.Jogador entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Entities.Jogador oldEntity, Entities.Jogador entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<Entities.Jogador> GetList(System.Linq.Expressions.Expression<Func<Entities.Jogador, bool>> where)
        {
            throw new NotImplementedException();
        }

        public ICollection<Entities.Jogador> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
