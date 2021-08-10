using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tekman.Api.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class EjercicioController : ControllerBase
    {
        [HttpPost]
        [Route("Create")]
        public IActionResult Create()
        {
            return Ok();
        }

        [HttpGet]
        [Route("ListEjercicios")]
        public ActionResult ListEjercicios(int? id)
        {
            return Ok();
        }
    }
}
