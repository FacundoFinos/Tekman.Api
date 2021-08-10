using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tekman.Repository.Models
{
    public class Actividad
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Ejercicio> Ejercicios { get; set; }
        public int CompetenciaID { get; set; }
        public string TipoActividad { get; set; }


    }
}
