using DeclensionService.Models;

namespace DeclensionService.Declension
{
    public interface IDeclensionFacade
    {
        DeclinationResult DeclinePhrase(string phrase, CaseEnum casesEnum);
        DeclinationResult DeclineName(string name, CaseEnum casesEnum);
    }
}
