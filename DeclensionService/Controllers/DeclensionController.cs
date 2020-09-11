using DeclensionService.Declension;
using DeclensionService.Models;
using Microsoft.AspNetCore.Mvc;


namespace DeclensionService.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class DeclensionController : ControllerBase
    {
        private readonly IDeclensionFacade _declension;

        public DeclensionController(IDeclensionFacade declension)
        {
            _declension = declension;
        }

        /// <summary>
        /// Склонение словосочетания
        /// </summary>
        /// <param name="phrase">Словосочетание или одно существительное\прилагательное</param>
        /// <param name="caseEnum">Падеж</param>
        /// <returns></returns>
        [HttpGet]
        public DeclinationResult DeclinePhrase(string phrase, CaseEnum caseEnum)
        {
            return _declension.DeclinePhrase(phrase, caseEnum);
        }

        /// <summary>
        /// Склонение ФИО
        /// </summary>
        /// <param name="name">ФИО</param>
        /// <param name="caseEnum">Падеж</param>
        /// <returns></returns>
        [HttpGet]
        public DeclinationResult DeclineName(string name, CaseEnum caseEnum)
        {
            return _declension.DeclineName(name , caseEnum);
        }

    }
}
