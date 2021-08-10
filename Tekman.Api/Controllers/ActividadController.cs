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

        /// <summary>
        /// Recibe una lista de respuetas para una actividad y calcula el resultado de la misma.
        /// </summary>
        /// <param name="respuestas"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Respuestas")]
        public decimal Respuestas(RespuestaDto respuestas)
        {
            return _actividadService.EvaluarRespuestas(respuestas);
        }

        /// <summary>
        /// Obtine la nota final de la evaluacion del alumno.
        /// El parametro de entrada es "A" para calcularla por actividades, "C" para calcularla por competencia
        /// </summary>
        /// <param name="tipoEvalauacion"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Evaluacion")]
        public decimal Evaluacion(string tipoEvalauacion)
        {
            return _actividadService.Evaluacion(tipoEvalauacion);
        }
    }
}
