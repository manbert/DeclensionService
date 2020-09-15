using DeclensionService.Declension;
using DeclensionService.Models;
using System;
using Xunit;

namespace XUnitTestDeclensionService
{
    public class UnitTestDeclensionFacade
    {
        private readonly IDeclensionFacade _declension;

        public UnitTestDeclensionFacade()
        {
            _declension = new DeclensionFacade();
        }

        [Theory]
        [InlineData("����", CaseEnum.Dative)]
        [InlineData("����", CaseEnum.Dative)]
        [InlineData("����", CaseEnum.Dative)]
        [InlineData("������", CaseEnum.Dative)]
        public void DeclensionPhrase(string phrase, CaseEnum caseEnum)
        {
            OriginalData originalData = new OriginalData(phrase, caseEnum);
            var result = _declension.DeclensionOfPhrase(originalData);            
            Assert.True(result.Success);
        }

        [Theory]
        [InlineData("asdfaf", CaseEnum.Dative)]       
        public void DeclensionPhraseError(string phrase, CaseEnum caseEnum)
        {
            OriginalData originalData = new OriginalData(phrase, caseEnum);
            var result = _declension.DeclensionOfPhrase(originalData);
            Assert.False(result.Success);
        }

        [Theory]
        [InlineData("������ ���� ��������", CaseEnum.Dative)]
        [InlineData("������ ����", CaseEnum.Genitive)]
        [InlineData("���� ��������", CaseEnum.Dative)]
        [InlineData("���� ��������", CaseEnum.Dative)]
        [InlineData("���� �.�.", CaseEnum.Dative)]
        public void DeclensionName(string phrase, CaseEnum caseEnum)
        {
            OriginalData originalData = new OriginalData(phrase, caseEnum);
            var result = _declension.DeclensionOfName(originalData);
            Assert.True(result.Success);
        }
    }
}
