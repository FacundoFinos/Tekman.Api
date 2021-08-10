using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tekman.Repository.Models
{
    public class ActividadTipo
    {
        [Key]
        public string Tipo { get; set; }
        public decimal Ponderacion { get; set; }
    }
}
