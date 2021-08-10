using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tekman.Service.EntidadesDto
{
    public class EjercicioDto
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public List<int> PreguntasID { get; set; }

    }
}
