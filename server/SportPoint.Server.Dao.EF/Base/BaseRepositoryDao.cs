using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.EF.Base
{
    /// <summary>
    /// Classe base que possui as informações de gerenciamento de acesso à dados para recursos de entity framework.
    /// </summary>
    /// <typeparam name="T">Classe da entidade que deve ser gerenciada.</typeparam>
    /// <typeparam name="L">Identificador do objeto a ser gerenciado.</typeparam>
    public class BaseRepositoryDao<T> : IDisposable, Dao.IGenericDao<T> where T : class
    {
        #region Constants

        /// <summary>
        /// Constante que armazena o provider default para a string de conexão.
        /// </summary>
        public const string DefaultProvider = "DBProvider";

        #endregion

        #region Variables

        /// <summary>
        /// Objeto de conexão com o banco de dados.
        /// </summary>
        private UnitOfWork _context;

        #endregion

        #region Properties

        /// <summary>
        /// Retorna o objeto que possui as conexões.
        /// </summary>
        /// <value>
        /// Objeto que possui as conexões.
        /// </value>
        protected UnitOfWork DataContext
        {
            get { return _context; }
        }

        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Inicializa a instância da classe <see cref="BaseRepository{T}"/>.
        /// </summary>
        /// <param name="context">Objeto de conexão de banco de dados.</param>
        /// <exception cref="System.ArgumentNullException">context</exception>
        public BaseRepositoryDao(IUnitOfWork context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            _context = context as UnitOfWork;
        }

        #endregion

        #region IGeneric members
       
        /// <summary>
        /// Método que carrega um registro a partir de dados básicos da entidade.
        /// </summary>
        /// <param name="entity">Entidade que será utilizada para carregar os dados.</param>
        /// <returns>
        /// Item encontrado, ou null caso não encontre.
        /// </returns>
        public T Load(T entity)
        {
            Entities.Base.BaseEntity keyEntity = entity as Entities.Base.BaseEntity;

            object[] keys = keyEntity.GetKeys();


            T model = _context.Set<T>().Find(keys);

            return model;
        }
        /// <summary>
        /// Método que insere um registro na base de dados.
        /// </summary>
        /// <param name="entity">Entidade com os dados a serem inseridos.</param>
        /// <returns>
        /// Identificador do registro para caso de tipos numéricos, ou quantidade de registros afetados.
        /// </returns>
        public long Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            int result = _context.Save();

            return result;
        }
        /// <summary>
        /// Método que exclui um registro da base de dados.
        /// </summary>
        /// <param name="entity">Entidade a ser pesquisada para ser excluída.</param>
        /// <returns>
        /// Quantidade de registros a serem excluídos.
        /// </returns>
        public int Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            int result = _context.Save();

            return result;
        }
        /// <summary>
        /// Método que atualiza um registro na base de dados.
        /// </summary>
        /// <param name="oldEntity">Registro atual que deve ser pesquisado na base de dados.</param>
        /// <param name="entity">Dados do registro a ser atualizado na base de dados.</param>
        /// <returns>
        /// Quantidade de registros atualizados.
        /// </returns>
        public int Update(T entity)
        {



            var entry = _context.Entry<T>(entity);

            if (entry.State == EntityState.Detached)
            {
                var set = _context.Set<T>();

                Entities.Base.BaseEntity data = entity as Entities.Base.BaseEntity;

                T attachedEntity = set.Find(data.GetKeys());

                if (attachedEntity != null)
                {
                    var attachedEntry = _context.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(entity);
                }
                else
                {
                    entry.State = EntityState.Modified; // This should attach entity
                }
            }

            int result = _context.Save();
            return result;





            //_entities.Entry(entity).State = System.Data.EntityState.Modified;

            //ERR-------------------------
            //T existing = _context.Set<T>().Find(1);
            //if (existing != null)
            //{
            //    _context.Entry(existing).CurrentValues.SetValues(entity);
            //    _context.SaveChanges();
            //}


            //DbEntityEntry<T> entry = _context.Entry(entity);


            //var oc = ((IObjectContextAdapter)_context).ObjectContext;
            //ObjectStateEntry stateEntry = oc.ObjectStateManager.GetObjectStateEntry(entry.Entity);


            //int value = (int)GetPrimaryKeyValue(entry);

            //if (value == 0)
            //{

            //}

            //if (entry.State == EntityState.Detached)
            //{
            //    _context.Set<T>().Attach(entity);
            //    entry.State = EntityState.Modified;
            //}

            //_context.Entry(entity).CurrentValues.SetValues(entity);
            //int result = _context.Save();
            //ERR-------------------------









            //var entry = _context.Entry<T>(entity);

            //if (entry.State == EntityState.Detached)
            //{
            //    var set = _context.Set<T>();

            //    Model.BaseModel data = oldEntity as Model.BaseModel;

            //    T attachedEntity = set.Find(data.ID);

            //    if (attachedEntity != null)
            //    {
            //        var attachedEntry = _context.Entry(attachedEntity);
            //        attachedEntry.CurrentValues.SetValues(entity);
            //    }
            //    else
            //    {
            //        entry.State = EntityState.Modified; // This should attach entity
            //    }
            //}

            //int result = _context.Save();
            //return result;


            return 0;
        }
        /// <summary>
        /// Método que retorna a lista de registros de entidades a partir de uma condição.
        /// </summary>
        /// <param name="where">Condição a ser usada na pesquisa.</param>
        /// <returns>
        /// Lista de entidades encontradas.
        /// </returns>
        public ICollection<T> GetList(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            return _context.Set<T>().Where(where).ToList();
        }
        /// <summary>
        /// Método que retorna lista de registros de uma entidade em específico.
        /// </summary>
        /// <returns>
        /// Lista de registros encontrados.
        /// </returns>
        public ICollection<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        /// <summary>
        /// Método que retorna a quantidade de registros da entidade.
        /// </summary>
        /// <returns>
        /// Quantidade de registros encontrados.
        /// </returns>
        public long Count()
        {
            int result = _context.Set<T>().Count();

            return result;

        }

        #endregion

        #region IDiposable members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            _context.Dispose();
        }

        #endregion
    }
}
