using Cyriller;
using System;
using System.Linq;
using System.Text;

namespace DeclensionService.Models
{
    /// <summary>
    /// Исходные данные
    /// </summary>
    public class OriginalData
    {
        public OriginalData() { }
        public OriginalData(string input, CaseEnum caseEnum)
        {
            Input = input;
            CaseEnum = caseEnum;
        }

        /// <summary>
        /// Исходная строка
        /// </summary>
        public string Input { get; set; }
        /// <summary>
        /// Падеж
        /// </summary>
        public CaseEnum CaseEnum { get; set; }
    }
}
