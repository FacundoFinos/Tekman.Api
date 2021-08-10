using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpGet]
        [Route("ListEjercicios")]
        public List<ActividadDto> ListEjercicios(int? id)
        {
           return _actividadService.ListaActividades();
        }
    }
}
