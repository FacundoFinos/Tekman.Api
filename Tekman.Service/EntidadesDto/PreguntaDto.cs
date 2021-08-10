using System;
using System.Collections.Generic;
using System.Text;

namespace Tekman.Service.EntidadesDto
{
    public class PreguntaDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string RespuestaAlumna { get; set; }
        public string RespuestaCorrecta { get; set; }
        public bool Resultado { get; set; }
        
    }
}
