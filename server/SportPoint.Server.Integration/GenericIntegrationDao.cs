using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Integration
{
    /// <summary>
    /// Classe que trabalha com funcionalidades genéricas para gerenciamento das entidades de integração.
    /// </summary>
    public class GenericIntegrationDao<T, L> : Base.JsonManagement<T, L>, IGenericIntegrationDao<T, L> where T : class
    {
        #region Variables

        /// <summary>
        /// Variável que armazena o nome do módulo a ser enviado a requisição.
        /// </summary>
        private string _moduleName;

        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="GenericIntegration" />.
        /// </summary>
        /// <param name="moduleName">Nome do módulo a ser enviada a requisição via rest.</param>
        /// <param name="url">Url de chamadas para a integração.</param>
        public GenericIntegrationDao(string url, string moduleName)
            : base (url)
        {
            _moduleName = moduleName;
        }

        #endregion

        #region Methods


        #endregion

        #region IGenericIntegration members

        /// <summary>
        /// Método que busca uma entrada através do identificador.
        /// </summary>
        /// <param name="id">Identificador a ser pesquisado.</param>
        /// <returns>Item encontrado, ou null caso não encontre.</returns>
        public T Find(L id)
        {
            string command = "api/" + _moduleName+  "/Find/" + id.ToString();

            T result = base.HttpGet(command, id);

            return result;
        }
        /// <summary>
        /// Método que carrega um registro a partir de dados básicos da entidade.
        /// </summary>
        /// <param name="entity">Entidade que será utilizada para carregar os dados.</param>
        /// <returns>Item encontrado, ou null caso não encontre.</returns>
        public T Load(T entity)
        {
            string command = "api/" + _moduleName + "/Load/";

            T result = base.HttpGet(command, entity);

            return result;
        }
        /// <summary>
        /// Método que insere um registro na base de dados.
        /// </summary>
        /// <param name="entity">Entidade com os dados a serem inseridos.</param>
        /// <returns>Quantidade de registros inseridos.</returns>
        public int Insert(T entity)
        {
            string command = "api/" + _moduleName + "/Insert/";

            int result = base.HttpPost(command, entity);

            //if (result == 1)
            //    return true;
            //else
            //    return false;

            return result;
        }
        /// <summary>
        /// Método que exclui um registro da base de dados.
        /// </summary>
        /// <param name="entity">Entidade a ser pesquisada para ser excluída.</param>
        /// <returns>Quantidade de registros a serem excluídos.</returns>
        public int Delete(T entity)
        {
            string command = "api/" + _moduleName + "/Delete/";

            int result = base.HttpPost(command, entity);

            //if (result >= 1)
            //    return true;
            //else
            //    return false;

            return result;
        }
        /// <summary>
        /// Método que atualiza um registro na base de dados.
        /// </summary>
        /// <param name="oldEntity">Registro atual que deve ser pesquisado na base de dados.</param>
        /// <param name="entity">Dados do registro a ser atualizado na base de dados.</param>
        /// <returns>Quantidade de registros atualizados.</returns>
        public int Update(T oldEntity, T entity)
        {
            string command = "api/" + _moduleName + "/Update/";

            int result = base.HttpPost(command, oldEntity, entity);

            //if (result >= 1)
            //    return true;
            //else
            //    return false;

            return result;
        }
        /// <summary>
        /// Método que retorna a lista de registros de entidades a partir de uma condição.
        /// </summary>
        /// <param name="where">Condição a ser usada na pesquisa.</param>
        /// <returns>Lista de entidades encontradas.</returns>
        public ICollection<T> GetList(Expression<Func<T, bool>> where)
        {
            //string command = "api/" + _moduleName+  "/GetList/";

            //ICollection<T> list = base.HttpGet(command, )


            return null;
        }
        /// <summary>
        /// Método que retorna lista de registros de uma entidade em específico.
        /// </summary>
        /// <returns>Lista de registros encontrados.</returns>
        public ICollection<T> GetAll()
        {
            string command = "api/" + _moduleName + "/GetAll/";

            ICollection<T> list = base.HttpGet(command, 0);

            return list;
        }
        /// <summary>
        /// Método que retorna a quantidade de registros da entidade.
        /// </summary>
        /// <returns>Quantidade de registros encontrados.</returns>
        public long Count()
        {
            string command = "api/" + _moduleName + "/Count/";

            long result = base.HttpGet(command);

            return result;
        }

        #endregion
    }
}
