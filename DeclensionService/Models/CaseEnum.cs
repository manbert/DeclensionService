namespace DeclensionService.Models
{
    /// <summary>
    /// Падежи
    /// * 1 - именительный
    /// * 2 - родительный
    /// * 3 - дательный
    /// * 4 - винительный
    /// * 5 - творительный
    /// * 6 - предложный
    /// </summary>
    public enum CaseEnum
    {
        Nominative = 1,
        Genitive = 2,
        Dative = 3,
        Accusative = 4,
        Instrumental = 5,
        Prepositional = 6
    }
}
