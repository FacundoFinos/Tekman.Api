using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tekman.Repository.Models
{
    public class PreguntaRespuesta
    {
        [Key]
        public int IdPregunta { get; set; }
        public string RespuestaCorecta { get; set; }
    }
}
