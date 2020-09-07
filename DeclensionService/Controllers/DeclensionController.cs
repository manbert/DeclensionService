using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cyriller;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeclensionService.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class DeclensionController : ControllerBase
    {
        private readonly IDeclension _declination;

        public DeclensionController(IDeclension declination)
        {
            _declination = declination;
        }

        /// <summary>
        /// Склонение словосочетания
        /// </summary>
        /// <param name="phrase"></param>
        /// <returns></returns>
        [HttpGet]
        public CyrResult DeclinePhrase(string phrase)
        {
            return _declination.DeclinePhrase(phrase);
        }

        /// <summary>
        /// Склонение ФИО
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        public CyrResult DeclineName(string name)
        {
            return _declination.DeclineName(name);
        }

    }
}
