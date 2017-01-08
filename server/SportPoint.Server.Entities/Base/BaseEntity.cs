﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Entities.Base
{
    /// <summary>
    /// Classe base que possui funcionalidades compartilhadas da entidade.
    /// </summary>
    public class BaseEntity
    {
        #region Properties
        /// <summary>
        /// Propriedade que retorna a lista de propriedades chave que contemplam a entidade.
        /// </summary>
        public IDictionary<string, object> GetPrimaryKey()
        {
            
            IDictionary<string, object> keys = new Dictionary<string, object>();

                PropertyInfo [] properties = this.GetType().GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    if (Attribute.IsDefined(property, typeof(KeyAttribute)))
                    {
                        keys.Add(property.Name, property.GetValue(this));
                    }
                }

                return keys;

                    //return (from property in this.GetType().GetProperties()
                    //        where Attribute.IsDefined(property, typeof(KeyAttribute))
                    //        orderby ((ColumnAttribute)property.GetCustomAttributes(false).Single(
                    //            attr => attr is ColumnAttribute)).Order ascending
                    //        select property.GetValue(this)).ToArray();
            
        }
        #endregion
    }
}
