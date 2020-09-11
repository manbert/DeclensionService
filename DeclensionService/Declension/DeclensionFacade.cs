using Cyriller;
using Cyriller.Model;
using DeclensionService.Models;
using System;

namespace DeclensionService.Declension
{
    public class DeclensionFacade : IDeclensionFacade
    {
        private static CyrNounCollection cyrNounCollection;
        private static CyrAdjectiveCollection cyrAdjectiveCollection;
        private static CyrPhrase cyrPhrase;
        private static CyrName cyrName;

        public DeclensionFacade()
        {
            cyrNounCollection = new CyrNounCollection();            
            cyrAdjectiveCollection = new CyrAdjectiveCollection();
            cyrPhrase = new CyrPhrase(cyrNounCollection, cyrAdjectiveCollection);
            cyrName = new CyrName();
        }
        
        public DeclinationResult DeclinePhrase(string phrase, CaseEnum casesEnum)
        {
            try
            {
                var result = cyrPhrase.Decline(phrase, GetConditionsEnum.Strict);
                return new DeclinationResult(result, casesEnum);
            }
            catch(Exception ex)
            {
                return new DeclinationResult();
            }            
        }

        public DeclinationResult DeclineName(string name, CaseEnum casesEnum)
        {
            try
            {
                var result = cyrName.Decline(name);
                return new DeclinationResult(result, casesEnum);
            }
            catch (Exception ex)
            {
                return new DeclinationResult();
            }      
        
        }
    }
}
