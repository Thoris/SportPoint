﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities
{
    /// <summary>
    /// Entidade do usuário que possui informações básicas de acesso ao sistema.
    /// </summary>
    public abstract class Usuario : Base.IdEntityBase
    {
        #region Properties

        /// <summary>
        /// Login do usuário.
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Senha do usuário.
        /// </summary>
        public string Senha { get; set; }

        #endregion
    }
}
