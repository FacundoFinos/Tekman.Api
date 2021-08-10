using System;
using System.Collections.Generic;
using System.Text;

namespace Tekman.Service.EntidadesDto
{
    public class EjercicioDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<PreguntaDto> Preguntas { get; set; }

    }
}
