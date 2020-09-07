using Cyriller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeclensionService
{
    public interface IDeclension
    {
        CyrResult DeclinePhrase(string phrase);
        CyrResult DeclineName(string name);
    }
}
