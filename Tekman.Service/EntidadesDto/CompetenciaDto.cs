using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tekman.Service.EntidadesDto
{
    public class CompetenciaDto
    {
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public decimal Ponderacion { get; set; }
    }
}
