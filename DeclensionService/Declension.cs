using Cyriller;
using Cyriller.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeclensionService
{
    public class Declension : IDeclension
    {
        private static CyrNounCollection cyrNounCollection;
        private static CyrAdjectiveCollection cyrAdjectiveCollection;
        private static CyrPhrase cyrPhrase;
        private static CyrName cyrName;

        public Declension()
        {
            cyrNounCollection = new CyrNounCollection();            
            cyrAdjectiveCollection = new CyrAdjectiveCollection();
            cyrPhrase = new CyrPhrase(cyrNounCollection, cyrAdjectiveCollection);
            cyrName = new CyrName();
        }
        
        public CyrResult DeclinePhrase(string phrase)
        {
            var result = cyrPhrase.Decline(phrase, GetConditionsEnum.Strict);
            return result;
        }

        public CyrResult DeclineName(string name)
        {
            var result = cyrName.Decline(name);
            return result;
        }
    }
}
