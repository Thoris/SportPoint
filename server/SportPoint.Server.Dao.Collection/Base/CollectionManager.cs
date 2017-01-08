using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.Collection.Base
{
    /// <summary>
    /// Classe que gerencia o objeto na lista.
    /// </summary>
    /// <typeparam name="T">Entidade a ser gerenciada.</typeparam>
    public class CollectionManager <T> where T : class
    {
        #region Variables

        /// <summary>
        /// Variável que armazena a lista de objetos a serem gerenciados.
        /// </summary>
        private IList<T> _list;
        /// <summary>
        /// Variável que armazena o nome da propriedade chave de gerenciamento da entidade.
        /// </summary>
        private string _keyName;

        #endregion

        #region Properties

        /// <summary>
        /// Propriedade que configura/retorna dados da tabela correspondente à coleção.
        /// </summary>
        protected IList<T> Table
        {
            get { return _list; }
            set { _list = value; }
        }
        /// <summary>
        /// Propriedade que retorna o nome da chave da entidade a ser gerenciada.
        /// </summary>
        protected string KeyName
        {
            get { return _keyName; }
        }

        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="CollectionManager{T, L}" />.
        /// </summary>
        /// <param name="keyName">Nome da chave.</param>
        public CollectionManager(string keyName)
        {
            _list = new List<T>();
            _keyName = keyName;
        }

        #endregion       

        #region Methods

        /// <summary>
        /// Método que compara os valores.
        /// </summary>
        /// <param name="item1">Chave do item 1 a ser comparado.</param>
        /// <param name="item2">Chave do item 2 a ser comparado.</param>
        /// <returns>true se ambos valores forem iguais, senão, false.</returns>
        protected bool CompareKey(T item1, T item2)
        {
            return object.Equals(item1, item2);

            //return ReferenceEquals(item1, item2);
        }

        protected bool CompareKeys(Entities.Base.BaseEntity c1, Entities.Base.BaseEntity c2)
        {
            IDictionary<string, object> p1 = c1.GetPrimaryKey();
            IDictionary<string, object> p2 = c2.GetPrimaryKey();

            if (p1.Count != p2.Count)
                return false;

            foreach (KeyValuePair<string, object> entry in p1)
            {
                if (entry.Value != p2[entry.Key])
                {
                    return false;
                }

            }

            return true;

        }
        ///// <summary>
        ///// Método que retorna o valor do campo chave da entidade.
        ///// </summary>
        ///// <param name="entity">Entidade a ser manipulada.</param>
        ///// <param name="name">Nome da propriedade a ser usada como chave.</param>
        ///// <returns>Valor da chave da entidade.</returns>
        //protected L GetKey(T entity, string name)
        //{
        //    var propertyInfo = entity.GetType().GetProperty(name);
        //    var value = propertyInfo.GetValue(entity, null);

        //    return (L)value;
        //}
        ///// <summary>
        ///// Método que retorna o valor do campo chave da entidade.
        ///// </summary>
        ///// <param name="entity">Entidade a ser manipulada.</param>
        ///// <returns>Valor da chave da entidade.</returns>
        //protected L GetKey(T entity)
        //{
        //    return GetKey(entity, _keyName);
        //}
        #endregion
    }
}
