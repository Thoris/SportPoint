using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.Collection
{
    /// <summary>
    /// Classe que possui o gerenciamento do repositório da entidade.
    /// </summary>
    /// <typeparam name="T">Tipo de entidade a ser gerenciada.</typeparam>
    /// <typeparam name="L">Chave do objeto.</typeparam>
    public class BaseCollectionDao<T, L> : CollectionManager<T, L>, IDisposable, IBaseCollection<T,L> where T : class
    {
        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="BaseCollectionDao{T, L}" />.
        /// </summary>
        /// <param name="keyName">Nome da propriedade chave da entidade.</param>
        public BaseCollectionDao (string keyName)
            : base(keyName)
        {

        }

        #endregion

        #region IGenericDao Methods

        /// <summary>
        /// Método que busca uma entrada através do identificador.
        /// </summary>
        /// <param name="id">Identificador a ser pesquisado.</param>
        /// <returns>Item encontrado, ou null caso não encontre.</returns>
        public T Find(L id)
        {
            for (int c = 0; c < base.Table.Count; c++ )
            {
                L currentKey = base.GetKey(base.Table[c]);
                if (base.CompareKey (id, currentKey))
                {
                    return base.Table[c];
                }
            }
            return null;
        }
        /// <summary>
        /// Método que carrega um registro a partir de dados básicos da entidade.
        /// </summary>
        /// <param name="entity">Entidade que será utilizada para carregar os dados.</param>
        /// <returns>Item encontrado, ou null caso não encontre.</returns>
        public T Load(T entity)
        {
            for (int c = 0; c < base.Table.Count; c++)
            {
                L entityKey = base.GetKey(entity);
                L currentKey = base.GetKey(base.Table[c]);
                if (base.CompareKey(entityKey, currentKey))
                {
                    return base.Table[c];
                }
            }
            return null;
        }
        /// <summary>
        /// Método que insere um registro na base de dados.
        /// </summary>
        /// <param name="entity">Entidade com os dados a serem inseridos.</param>
        /// <returns>Quantidade de registros inseridos.</returns>
        public int Insert(T entity)
        {
            base.Table.Add(entity);

            if (typeof(T).IsSubclassOf(typeof(Entities.Base.IdEntityBase)) ||
               typeof(T) == typeof(Entities.Base.IdEntityBase))
            {
                Entities.Base.IdEntityBase baseModel = entity as Entities.Base.IdEntityBase;
                baseModel.Id = base.Table.Count;
            }

            return 1;
        }
        /// <summary>
        /// Método que exclui um registro da base de dados.
        /// </summary>
        /// <param name="entity">Entidade a ser pesquisada para ser excluída.</param>
        /// <returns>Quantidade de registros a serem excluídos.</returns>
        public int Delete(T entity)
        {
            L entityKey = base.GetKey(entity);

            T foundEntity = this.Find(entityKey);

            if (foundEntity == null)
            {
                return 0;
            }
            else
            {
                bool res = base.Table.Remove(foundEntity);

                if (res)
                    return 1;
                else
                    return 0;
            }
        }
        /// <summary>
        /// Método que atualiza um registro na base de dados.
        /// </summary>
        /// <param name="oldEntity">Registro atual que deve ser pesquisado na base de dados.</param>
        /// <param name="entity">Dados do registro a ser atualizado na base de dados.</param>
        /// <returns>Quantidade de registros atualizados.</returns>
        public int Update(T oldEntity, T entity)
        {
            int total = 0;
            L entityKey = base.GetKey(entity);

            for (int c = 0; c < base.Table.Count; c++)
            {
                L currentKey = base.GetKey(base.Table[c]);
                if (base.CompareKey(entityKey, currentKey))
                {
                    base.Table[c] = entity;
                    total++;
                }
            }

            return total;
        }
        /// <summary>
        /// Método que retorna a lista de registros de entidades a partir de uma condição.
        /// </summary>
        /// <param name="where">Condição a ser usada na pesquisa.</param>
        /// <returns>Lista de entidades encontradas.</returns>
        public ICollection<T> GetList(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            return base.Table.Where(where.Compile()).ToList();
        }
        /// <summary>
        /// Método que retorna lista de registros de uma entidade em específico.
        /// </summary>
        /// <returns>Lista de registros encontrados.</returns>
        public ICollection<T> GetAll()
        {
            return base.Table.ToList();
        }
        /// <summary>
        /// Método que retorna a quantidade de registros da entidade.
        /// </summary>
        /// <returns>Quantidade de registros encontrados.</returns>
        public long Count()
        {
            return base.Table.Count;
        }

        #endregion

        #region IDisposable members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {

        }

        #endregion

    }
}
