using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Integration.Base
{
    /// <summary>
    /// Classe que possui a fábrica de objetos de integração.
    /// </summary>
    public class FactoryIntegration  : FactoryRestIntegration
    {
        #region Enumerations

        /// <summary>
        /// Enumeração que possui as possibilidades de conexão com o sistema.
        /// </summary>
        private enum TypeIntegration
        {
            /// <summary>
            /// Conexão utilizando rest para tráfego de informação.
            /// </summary>
            Rest = 0,
            /// <summary>
            /// Conexão direta com a camada de negócio.
            /// </summary>
            Business,

        }

        #endregion

        #region Variables

        /// <summary>
        /// Variável que possui o tipo de conexão para gerenciamento da base de dados.
        /// </summary>
        private static TypeIntegration _typeIntegration;
        /// <summary>
        /// Variável que armazena a fábrica de conexão com integração ao sistema.
        /// </summary>
        private static Business.Interfaces.IFactoryBO _factoryIntegration;

        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Inicializa nova instância da classe <see cref="FactoryIntegration" />.
        /// </summary>
        public FactoryIntegration()
        {

        }
        public FactoryIntegration(Business.Interfaces.IFactoryBO factoryIntegration)
        {
            _factoryIntegration = factoryIntegration;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Método que retorna o tipo de conexão que deve ser realizado para acesso à base de dados.
        /// </summary>
        /// <returns>Tipo de acesso à dados configurado. Caso não encontre, utiliza-se o padrão EntityFramework</returns>
        private static TypeIntegration GetTypeIntegration()
        {
            //Buscando a configuração do tipo de acesso à dados
            string daoType = System.Configuration.ConfigurationManager.AppSettings["FactoryTypeIntegration"];

            //Se existe informação configurada para o tipo de acesso
            if (!string.IsNullOrEmpty(daoType))
            {
                //Verificando qual tipo corresponde ao configurado
                string[] daoTypes = Enum.GetNames(typeof(TypeIntegration));

                //Buscando qual tipo se encaixa
                for (int c = 0; c < daoTypes.Length; c++)
                {
                    //Se encontrou a descrição do tipo de conexão
                    if (string.Compare(daoType, daoTypes[c], true) == 0)
                    {
                        return (TypeIntegration)c;
                    }
                    //Se encontrou o índice do tipo de conexão
                    else if (string.Compare(daoType, c.ToString(), true) == 0)
                    {
                        return (TypeIntegration)c;
                    }//endif

                }//end for c

            }//endif tipo de conexão à dados

            return TypeIntegration.Rest;
        }

        /// <summary>
        /// Método que retorna o objeto de fábrica de objetos para acesso à banco de dados.
        /// </summary>
        /// <returns>Objeto que possui a fábrica de objetos de conexão com o banco de dados.</returns>
        private static Business.Interfaces.IFactoryBO GetFactoryIntegration()
        {
            //Se o objeto de conexão ainda não foi criado
            if (_factoryIntegration == null)
            {
                //Buscando qual tipo de conexão com a base de dados deve utilizar
                _typeIntegration = GetTypeIntegration();

                switch (_typeIntegration)
                {
                    case TypeIntegration.Rest:

                        _factoryIntegration = new FactoryRestIntegration();

                        break;

                    case TypeIntegration.Business:

                        _factoryIntegration = new Business.FactoryBO();

                        break;

                }

            }//endif factoryDao == null

            return _factoryIntegration;
        }
        #endregion

        #region IFactoryDao members

        /// <summary>
        /// Método que cria o objeto de regras de negócio do jogador.
        /// </summary>
        /// <returns>
        /// Objeto que possui regras de negócio do jogador.
        /// </returns>
        public static Business.Interfaces.IJogadorBO CreateJogador()
        {
            return GetFactoryIntegration().CreateJogador();
        }

        /// <summary>
        /// Método que cria o objeto de regras de negócio da modalidade.
        /// </summary>
        /// <returns>
        /// Objeto que possui regras de negócio da modalidade.
        /// </returns>
        public static Business.Interfaces.IModalidadeBO CreateModalidade()
        {
            return GetFactoryIntegration().CreateModalidade();
        }

        #endregion
    }
}
