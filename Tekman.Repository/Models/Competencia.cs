using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tekman.Repository.Models
{
    public class Competencia
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Ponderacion { get; set; }
    }
}
