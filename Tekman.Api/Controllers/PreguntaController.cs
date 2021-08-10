using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tekman.Service.EntidadesDto;

namespace Tekman.Api.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PreguntaController : ControllerBase
    {
        
        [HttpPost]
        [Route("Create")]
        public IActionResult Create(ActividadDto actividad)
        {
            return Ok();     
        }

        [HttpGet]
        [Route("ListPreguntas")]
        public ActionResult ListPreguntas(int? id)
        {
            return Ok();
        }
        
    }
}
