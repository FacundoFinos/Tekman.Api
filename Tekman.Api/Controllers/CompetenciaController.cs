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
    public class CompetenciaController : ControllerBase
    {
        private readonly ICompetenciaService _competenciaService;
        public CompetenciaController(ICompetenciaService competenciaService)
        {
            _competenciaService = competenciaService;
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create(CompetenciaDto competencia)
        {
            return Ok(_competenciaService.NuevaCompetencia(competencia));
        }

        [HttpGet]
        [Route("ListCompetencias")]
        public List<Competencia> ListCompetencias()
        {
            return _competenciaService.ListaCompetencias();
        }

        
    }
}
