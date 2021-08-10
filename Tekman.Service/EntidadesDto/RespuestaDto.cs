using System;
using System.Collections.Generic;
using System.Text;

namespace Tekman.Service.EntidadesDto
{
    public class RespuestaDto
    {
        public int IdActividad { get; set; }

        public Dictionary<int, string> Respuestas { get; set; }
    }
}
