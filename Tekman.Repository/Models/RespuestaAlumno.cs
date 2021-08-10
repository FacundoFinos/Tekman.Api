using System;
using System.Collections.Generic;
using System.Text;

namespace Tekman.Repository.Models
{
    public class RespuestaAlumno
    {
        public int IdPregunta { get; set; }
        public int IdActividad { get; set; }
        public int IdAlumno { get; set; }
        public string Respuesta { get; set; }
        public bool Resultado { get; set; }
    }
}
