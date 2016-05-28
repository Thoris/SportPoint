using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SportPoint.Server.Services.Controllers
{
    /// <summary>
    /// Classe genérica que possui as implementações de gerenciamento das entidades.
    /// </summary>
    /// <typeparam name="T">Entidade a ser gerenciada.</typeparam>
    /// <typeparam name="L">Tipo do campo chave da entidade.</typeparam>
    public class GenericApiController<T,L> : AuthorizationController
    {
        #region Variables

        /// <summary>
        /// Variável que possui o objeto de gerenciamento da entidade.
        /// </summary>
        private Dao.IGenericDao<T, L> _dao;

        #endregion

        #region Properties

        /// <summary>
        /// Propriedade que retorna o objeto de acesso à dados para gerencimento da entidade.
        /// </summary>
        protected Dao.IGenericDao<T, L> BaseDao
        {
            get { return _dao; }
        }

        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="GenericApiController{T, L}"/> .
        /// </summary>
        /// <param name="dao">Objeto de conexão de dados.</param>
        public GenericApiController(Dao.IGenericDao<T, L> dao)
        {
            _dao = dao;
        }

        #endregion

        #region Methods


        /// <summary>
        /// Método que busca um registro na lista de entidades.
        /// </summary>
        /// <param name="id">Identificador da entidade a ser encontrado.</param>
        /// <returns>Entidade encontrada, ou nulo caso não encontre</returns>
        [HttpGet]
        public T Find(L id)
        {
            return _dao.Find(id);
        }
        /// <summary>
        /// Método que busca e carrega os atributos da entidade.
        /// </summary>
        /// <param name="entity">Entidade a ser carregada.</param>
        /// <returns>Entidade encontrada, ou nulo caso não encontre.</returns>
        [HttpGet]
        public T Load(T entity)
        {
            return _dao.Load(entity);
        }
        /// <summary>
        /// Método que insere uma entidade na base de dados.
        /// </summary>
        /// <param name="entity">Dados da entidade a ser inserida.</param>
        /// <returns>Quantidade de registros inseridos.</returns>
        [HttpPost]
        public int Insert(T entity)
        {
            return _dao.Insert(entity);
        }
        /// <summary>
        /// Método que apaga uma entidade da base de dados.
        /// </summary>
        /// <param name="entity">Entidade a ser excluída.</param>
        /// <returns>Quantidade de registros excluídos.</returns>
        [HttpPost]
        public int Delete(T entity)
        {
            return _dao.Delete(entity);
        }
        /// <summary>
        /// Método que atualiza os dados da entidade.
        /// </summary>
        /// <param name="oldEntity">Entidade antiga a ser atualizada.</param>
        /// <param name="entity">Dados da entidade que devem ser aplicadas à base de dados.</param>
        /// <returns>Quantidade de registros atualizados.</returns>
        [HttpPost]
        public int Update(T oldEntity, T entity)
        {
            return _dao.Update(oldEntity, entity);
        }
        /// <summary>
        /// Método que carrega uma lista de entidades baseado na condição especificada.
        /// </summary>
        /// <param name="where">String que possui a condição a ser pesquisada.</param>
        /// <returns>Lista de entidades encontradas.</returns>
        [HttpGet]
        public ICollection<T> GetList(string where)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Método que carrega todos as entidades armazenadas na base de dados.
        /// </summary>
        /// <returns>Lista de entidades encontradas.</returns>
        [HttpGet]
        public ICollection<T> GetAll()
        {
            return _dao.GetAll();
        }
        /// <summary>
        /// Método que retorna a quantidade de registros existentes na base de dados referênte à entidade.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public long Count()
        {
            return _dao.Count ();
        }

        #endregion
    }
}