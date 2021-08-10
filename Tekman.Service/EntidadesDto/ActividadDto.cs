using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tekman.Service.EntidadesDto
{
    public class ActividadDto
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public List<int> Ejercicios { get; set; }
        [Required]
        public int CompetenciaID { get; set; }
        [Required]
        public ActividadTipoEnum Tipo { get; set; }
        public double Nota { get; set; }


    }
}
