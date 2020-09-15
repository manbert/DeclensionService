using Cyriller;
using Cyriller.Model;

namespace DeclensionService.Models
{
    /// <summary>
    /// Возвращаемый тип
    /// </summary>
    public class DeclensionResult
    {
        public DeclensionResult(OriginalData originalData)
        {
            Success = false;
            OriginalData = originalData;
        }
        public DeclensionResult(CyrResult cyrResult, OriginalData originalData)
        {
            Success = true;
            Output = cyrResult.Get((CasesEnum)originalData.CaseEnum);
            OriginalData = originalData;
        }
        public DeclensionResult(string errorMessage, OriginalData originalData)
        {
            Success = false;
            OriginalData = originalData;
            ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Выражение в указанном падеже
        /// </summary>
        public string Output { get; }
        /// <summary>
        /// Успешность склонения
        /// </summary>
        public bool Success { get; }
        /// <summary>
        /// Входные данные
        /// </summary>
        public OriginalData OriginalData { get; }
        /// <summary>
        /// Ошибка при склонении
        /// </summary>
        public string ErrorMessage {get;}
    }
}
