using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Dao.Collection.Base
{
    /// <summary>
    /// Classe que possui o gerenciamento dos recursos do tipo UnitOfWork
    /// </summary>
    public class UnitOfWorkCollection : IUnitOfWorkCollection
    {
        #region Properties

        /// <summary>
        /// Propriedade que configura/retorna registros de jogadores.
        /// </summary>
        public JogadorDaoCollection Jogadores { get; set; }

        public ModalidadeDaoCollection Modalidades { get; set; }

        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="UnitOfWorkCollection"/>.
        /// </summary>
        public UnitOfWorkCollection()
        {
            Jogadores = new JogadorDaoCollection();
            Modalidades = new ModalidadeDaoCollection();
        }

        #endregion

        #region Methods

        

        #endregion

        #region IUnitOfWork members

        /// <summary>
        /// Método que atualiza os dados na base de dados.
        /// </summary>
        /// <returns>
        /// Quantidade de registros atualizados.
        /// </returns>
        public int Save()
        {

            return 0;
        }

        #endregion
    }
}
