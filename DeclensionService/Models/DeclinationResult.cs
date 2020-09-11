using Cyriller;
using Cyriller.Model;

namespace DeclensionService.Models
{
    /// <summary>
    /// Возвращаемый тип
    /// </summary>
    public class DeclinationResult
    {
        public DeclinationResult() 
        {
            Success = false;
        }
        public DeclinationResult(CyrResult cyrResult, CaseEnum caseEnum)
        {
            Success = true;
            Output = cyrResult.Get((CasesEnum)caseEnum);
            Nominative = cyrResult.Get(CasesEnum.Nominative);
            CaseEnum = caseEnum;
        }        

        /// <summary>
        /// Входное выражение
        /// </summary>
        public string Nominative { get;}  
        /// <summary>
        /// Выражение в указанном падеже
        /// </summary>
        public string Output { get;}
        /// <summary>
        /// Указанный падеж
        /// </summary>
        public CaseEnum CaseEnum { get;}
        /// <summary>
        /// Успешность склонения
        /// </summary>
        public bool Success { get; }
    }
}
