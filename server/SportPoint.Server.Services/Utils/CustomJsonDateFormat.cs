using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportPoint.Server.Services.Utils
{
    /// <summary>
    /// Classe criada exclusivamente para tratar o formato de retorno do tipo data em JSON.
    /// </summary>
    public class CustomJsonDateFormat : DateTimeConverterBase
    {
        #region Methods

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return reader.Value.ToString();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(string.Format("{0:dd/MM/yyyy HH:mm:ss}", (DateTime)value));

        }

        #endregion
    }
}