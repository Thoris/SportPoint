using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Business.Base
{
    /// <summary>
    /// Interface genérica que possui informações básicas no gerenciamento das entidades.
    /// </summary>
    /// <typeparam name="T">Tipo de entidade a ser manipulada.</typeparam>
    /// <typeparam name="L">Tipo de entidade chave a ser usada na manipulação dos dados.</typeparam>
    public interface IGenericBusiness<T, L>
    {
        /// <summary>
        /// Método que busca um registro específico a partir de um identificador.
        /// </summary>
        /// <param name="id">Identificador a ser pesquisado.</param>
        /// <returns>Registro encontrado, ou null caso não encontre.</returns>
        T Find(L id);
        /// <summary>
        /// Método que carrega os detalhes de um registro a partir dos dados chave.
        /// </summary>
        /// <param name="entity">Entidade que possui informações básicas do registro a ser carregado.</param>
        /// <returns>Registro encontrado, ou null caso não encontre.</returns>
        T Load(T entity);
        /// <summary>
        /// Método que insere um registro na entidade.
        /// </summary>
        /// <param name="entity">Dados do registro a ser inserido.</param>
        /// <returns>true se conseguiu inserir, senão, false.</returns>
        bool Insert(T entity);
        /// <summary>
        /// Método que apaga um registro da entidade.
        /// </summary>
        /// <param name="entity">Dados do registro a ser excluído.</param>
        /// <returns>true se conseguiu excluir o registro, senão, falso.</returns>
        bool Delete(T entity);
        /// <summary>
        /// Método que atualiza dados do registro na entidade.
        /// </summary>
        /// <param name="oldEntity">Registro atual da base de dados.</param>
        /// <param name="entity">Registro com os dados a ser atualizado na base de dados.</param>
        /// <returns>true se conseguiu atualizar os dados do registro, senão, false.</returns>
        bool Update(T oldEntity, T entity);


        /// <summary>
        /// Método que retorna a lista de registro de uma entidade.
        /// </summary>
        /// <param name="where">Condição a ser pesquisada.</param>
        /// <returns>Lista de registros de uma entidades, senão, nulo.</returns>
        ICollection<T> GetList(Expression<Func<T, bool>> where);
        /// <summary>
        /// Método que retorna todos os registros de uma entidade.
        /// </summary>
        /// <returns>Lista de registros de uma entidade, senão, nulo</returns>
        ICollection<T> GetAll();
        /// <summary>
        /// Método que retorna a quantidade de registros de uma entidade.
        /// </summary>
        /// <returns>Quantidade de registros de uma entidade.</returns>
        long Count();

    }
}
