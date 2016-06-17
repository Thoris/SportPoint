using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities.Enum
{
    /// <summary>
    /// Enumeraçao que contém os tipos de confirmação para a partida.
    /// </summary>
    public enum ConfirmacaoTipo : int
    {
        /// <summary>
        /// Ainda não foi confirmado.
        /// </summary>
        Talvez = 0,
        /// <summary>
        /// Indica que participará do jogo.
        /// </summary>
        Sim,
        /// <summary>
        /// Indica que não participará do jogo.
        /// </summary>
        Nao, 
    }
}
