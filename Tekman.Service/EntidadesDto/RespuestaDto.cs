using System;
using System.Collections.Generic;
using System.Text;

namespace Tekman.Service.EntidadesDto
{
    public class RespuestaDto
    {
        public int IdActividad { get; set; }

        public List<Respuestas> Respuestas { get; set; }
    }

    public class Respuestas
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
