using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeclensionService.Models
{
    /// <summary>
    /// Падежи
    /// * 0 - именительный
    /// * 1 - родительный
    /// * 2 - дательный
    /// * 3 - винительный
    /// * 4 - творительный
    /// * 5 - предложный
    /// </summary>
    public enum CaseEnum
    {        
        Nominative = 0,
        Genitive = 1,
        Dative = 2,
        Accusative = 3,
        Instrumental = 4,
        Prepositional = 5
    }
}
