using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tekman.Service.EntidadesDto
{
    public class ActividadDto
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public List<int> Ejercicios { get; set; }
        [Required]
        public int CompetenciaID { get; set; }
        [Required]
        public string TipoActividad { get; set; }


    }
}
