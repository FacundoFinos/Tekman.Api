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
    public class EjercicioController : ControllerBase
    {
        private readonly IEjercicioService _ejercicioService;
        public EjercicioController(IEjercicioService ejercicioService)
        {
            _ejercicioService = ejercicioService;
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create(EjercicioDto ejercicio)
        {
            return Ok(_ejercicioService.NuevoEjercicio(ejercicio));
        }

        [HttpGet]
        [Route("ListEjercicios")]
        public List<Ejercicio> ListEjercicios()
        {
            return _ejercicioService.ListaEjercicios();
        }
    }
}
