using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportPoint.Server.Services.Utils
{
    public class Documentation
    {
        #region Constants

        private const string SeparatorTag = "<separator>";

        #endregion

        #region Methods

        public static string GetSummary(string description)
        {
            if (string.IsNullOrEmpty(description))
                return description;

            string summary = "";
            var endOfSummary = description.IndexOf(SeparatorTag);

            if (endOfSummary != -1)
                summary = description.Substring(0, endOfSummary);
            else
                summary = description;

            return summary;
        }

        public static string [] GetSample(string description)
        {
            if (string.IsNullOrEmpty(description))
                return new string[] { };

            var endOfSummary = description.IndexOf(SeparatorTag);

            if (endOfSummary == -1)
                return new string[] { };

            var containsRemarks = (endOfSummary + SeparatorTag.Length - description.Length) != 0;

            if (containsRemarks)
            {
                var sampleBegin = endOfSummary + SeparatorTag.Length;
                var endOfSample = description.Length - sampleBegin;

                var sample = description.Substring(sampleBegin, endOfSample);

                string[] lines = sample.Split('\n');

                return lines;
            }
            return new string[] { };
        }

        #endregion

    }
}