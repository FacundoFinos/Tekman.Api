using System;
using System.Collections.Generic;
using System.Text;

namespace Tekman.Repository.Models
{
    public class Ejercicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Pregunta> Preguntas { get; set; }

    }
}
