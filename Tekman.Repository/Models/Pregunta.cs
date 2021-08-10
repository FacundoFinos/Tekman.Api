using System;
using System.Collections.Generic;
using System.Text;

namespace Tekman.Repository.Models
{
    public class Pregunta
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string RespuestaAlumna { get; set; }
        public string RespuestaCorrecta { get; set; }
        public bool Resultado { get; set; }
        
    }
}
