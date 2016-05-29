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
    public class GenericApiController<T,L> : AuthorizationController where T :class 
    {
        #region Variables

        /// <summary>
        /// Variável que possui o objeto de gerenciamento da entidade.
        /// </summary>
        private Business.Base.IGenericBusiness<T, L> _bo;

        #endregion

        #region Properties

        /// <summary>
        /// Propriedade que retorna o objeto de acesso à dados para gerencimento da entidade.
        /// </summary>
        protected Business.Base.IGenericBusiness<T, L> BaseBo
        {
            get { return _bo; }
        }

        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="GenericApiController{T, L}"/> .
        /// </summary>
        /// <param name="dao">Objeto de regras de negócio.</param>
        public GenericApiController(Business.Base.IGenericBusiness<T, L> bo)
        {
            _bo = bo;
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
            return _bo.Find(id);
        }
        /// <summary>
        /// Método que busca e carrega os atributos da entidade.
        /// </summary>
        /// <param name="entity">Entidade a ser carregada.</param>
        /// <returns>Entidade encontrada, ou nulo caso não encontre.</returns>
        [HttpGet]
        public T Load(T entity)
        {
            return _bo.Load(entity);
        }
        /// <summary>
        /// Método que insere uma entidade na base de dados.
        /// </summary>
        /// <param name="entity">Dados da entidade a ser inserida.</param>
        /// <returns>True se o registro foi inserido com sucesso.</returns>
        [HttpPost]
        public bool Insert(T entity)
        {
            return _bo.Insert(entity);
        }
        /// <summary>
        /// Método que apaga uma entidade da base de dados.
        /// </summary>
        /// <param name="entity">Entidade a ser excluída.</param>
        /// <returns>True se o registro foi excluído com sucesso.</returns>
        [HttpPost]
        public bool Delete(T entity)
        {
            return _bo.Delete(entity);
        }
        /// <summary>
        /// Método que atualiza os dados da entidade.
        /// </summary>
        /// <param name="oldEntity">Entidade antiga a ser atualizada.</param>
        /// <param name="entity">Dados da entidade que devem ser aplicadas à base de dados.</param>
        /// <returns>True se o registro foi alterado com sucesso.</returns>
        [HttpPost]
        public bool Update(T oldEntity, T entity)
        {
            return _bo.Update(oldEntity, entity);
        }
        /// <summary>
        /// Método que carrega uma lista de entidades baseado na condição especificada.
        /// </summary>
        /// <param name="where">String que possui a condição a ser pesquisada.</param>
        /// <returns>Lista de entidades encontradas.</returns>
        [HttpGet]
        public ICollection<T> GetList(string where)
        {
            return _bo.GetAll();
        }
        /// <summary>
        /// Método que carrega todos as entidades armazenadas na base de dados.
        /// </summary>
        /// <returns>Lista de entidades encontradas.</returns>
        [HttpGet]
        public ICollection<T> GetAll()
        {
            return _bo.GetAll();
        }
        /// <summary>
        /// Método que retorna a quantidade de registros existentes na base de dados referênte à entidade.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public long Count()
        {
            return _bo.Count();
        }

        #endregion
    }
}