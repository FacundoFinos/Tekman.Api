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
    [Route("api/[Controller]")]
    [ApiController]
    public class ActividadController : ControllerBase
    {
        private readonly IActividadService _actividadService;

        public ActividadController(IActividadService actividadService)
        {
            _actividadService = actividadService;
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create(ActividadDto actividad)
        {
            return Ok(_actividadService.NuevaActividad(actividad));
        }

        /// <summary>
        /// Retorna la lista de las preguntas de la actividad correspondiente al ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetActividad")]
        public EnunciadoActividadDto GetActividad(int id)
        {
            return _actividadService.ComenzarActividad(id);
        }

        [HttpPost]
        [Route("Respuestas")]
        public decimal Respuestas(RespuestaDto respuestas)
        {
            return _actividadService.EvaluarRespuestas(respuestas);
        }


    }
}
