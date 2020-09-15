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
        /// Склонение словосочетания (перевод в нижний регистр переводится автоматически)
        /// </summary>
        /// <param name="originalData">Словосочетание и падеж</param>        
        /// <returns></returns>
        [HttpPost]
        public DeclensionResult DeclensionOfPhrase([FromBody] OriginalData originalData)
        {
            return _declension.DeclensionOfPhrase(originalData);
        }

        /// <summary>
        /// Склонение ФИО
        /// </summary>
        /// <param name="originalData">ФИО и падеж</param>        
        /// <returns></returns>
        [HttpPost]
        public DeclensionResult DeclensionOfName([FromBody] OriginalData originalData)
        {
            return _declension.DeclensionOfName(originalData);
        }

    }
}
