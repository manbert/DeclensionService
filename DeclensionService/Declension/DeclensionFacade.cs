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
        
        public DeclensionResult DeclensionOfPhrase(OriginalData originalData)
        {
            var preparationData = PrepareData(originalData.Input);
            try
            {
                var result = cyrPhrase.Decline(preparationData, GetConditionsEnum.Strict);
                return new DeclensionResult(result, originalData);
            }
            catch (Exception ex)
            {
                return new DeclensionResult(ex.Message, originalData);
            }
        }

        public DeclensionResult DeclensionOfName(OriginalData originalData)
        {
            try
            {
                var result = cyrName.Decline(originalData.Input);
                return new DeclensionResult(result, originalData);
            }
            catch (Exception ex)
            {
                return new DeclensionResult(ex.Message, originalData);
            }
        }

        private string PrepareData(string phrase)
        {
            return phrase.ToLower();
        }

    }
}
