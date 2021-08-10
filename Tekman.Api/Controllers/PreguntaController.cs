using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tekman.Repository.Models;
using Tekman.Service.EntidadesDto;
using Tekman.Service.Interface;

namespace Tekman.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PreguntaController : ControllerBase
    {
        private readonly IPreguntasService _preguntasService;
        public PreguntaController(IPreguntasService preguntasService)
        {
            _preguntasService = preguntasService;
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create(NewPreguntaRequest pregunta)
        {
            _preguntasService.NuevaPregunta(pregunta);
            return Ok();     
        }
        
        [HttpGet]
        [Route("ListPreguntas")]
        public List<Pregunta> ListPreguntas()
        {
            return _preguntasService.ListaPreguntas();
        }
        
    }
}
