using Cyriller;

namespace DeclensionService
{
    public interface IDeclension
    {
        CyrResult DeclinePhrase(string phrase);
        CyrResult DeclineName(string name);
    }
}
