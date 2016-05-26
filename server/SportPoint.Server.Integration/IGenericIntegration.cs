﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Integration
{
    /// <summary>
    /// Interface que possui as funcionalidades básicas de gerenciamento da entidade.
    /// </summary>
    /// <typeparam name="T">Entidade a ser gerenciada.</typeparam>
    /// <typeparam name="L">Estrututra do campo chave da entidade.</typeparam>
    public interface IGenericIntegration<T, L> where T : class
    {
        /// <summary>
        /// Método que busca uma entrada através do identificador.
        /// </summary>
        /// <param name="id">Identificador a ser pesquisado.</param>
        /// <returns>Item encontrado, ou null caso não encontre.</returns>
        T Find(L id);
        /// <summary>
        /// Método que carrega um registro a partir de dados básicos da entidade.
        /// </summary>
        /// <param name="entity">Entidade que será utilizada para carregar os dados.</param>
        /// <returns>Item encontrado, ou null caso não encontre.</returns>
        T Load(T entity);
        /// <summary>
        /// Método que insere um registro na base de dados.
        /// </summary>
        /// <param name="entity">Entidade com os dados a serem inseridos.</param>
        /// <returns>Quantidade de registros inseridos.</returns>
        int Insert(T entity);
        /// <summary>
        /// Método que exclui um registro da base de dados.
        /// </summary>
        /// <param name="entity">Entidade a ser pesquisada para ser excluída.</param>
        /// <returns>Quantidade de registros a serem excluídos.</returns>
        int Delete(T entity);
        /// <summary>
        /// Método que atualiza um registro na base de dados.
        /// </summary>
        /// <param name="oldEntity">Registro atual que deve ser pesquisado na base de dados.</param>
        /// <param name="entity">Dados do registro a ser atualizado na base de dados.</param>
        /// <returns>Quantidade de registros atualizados.</returns>
        int Update(T oldEntity, T entity);

        /// <summary>
        /// Método que retorna a lista de registros de entidades a partir de uma condição.
        /// </summary>
        /// <param name="where">Condição a ser usada na pesquisa.</param>
        /// <returns>Lista de entidades encontradas.</returns>
        ICollection<T> GetList(Expression<Func<T, bool>> where);
        /// <summary>
        /// Método que retorna lista de registros de uma entidade em específico.
        /// </summary>
        /// <returns>Lista de registros encontrados.</returns>
        ICollection<T> GetAll();
        /// <summary>
        /// Método que retorna a quantidade de registros da entidade.
        /// </summary>
        /// <returns>Quantidade de registros encontrados.</returns>
        int Count();
    }
}
