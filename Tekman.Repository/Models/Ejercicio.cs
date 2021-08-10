﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tekman.Repository.Models
{
    public class Ejercicio
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Pregunta> Preguntas { get; set; }

    }
}
