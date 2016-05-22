using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities.Base
{
    /// <summary>
    /// Interface que possui propriedades básicas para o gerenciamento de um registro.
    /// </summary>
    /// <typeparam name="T">Tipo de entidade a ser gerenciada.</typeparam>
    public interface IBaseModel<T>
    {
        /// <summary>
        /// Configura/retorna o identificador do registro.
        /// </summary>
        /// <value>
        /// Identificador do registro.
        /// </value>
        T ID { get; set; }
    }
}
