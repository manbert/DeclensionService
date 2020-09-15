using DeclensionService.Models;

namespace DeclensionService.Declension
{
    public interface IDeclensionFacade
    {  
        DeclensionResult DeclensionOfPhrase(OriginalData inputData);
        DeclensionResult DeclensionOfName(OriginalData inputData);
    }
}
