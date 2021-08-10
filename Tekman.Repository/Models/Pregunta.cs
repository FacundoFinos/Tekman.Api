using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tekman.Repository.Models
{
    public class Pregunta
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        
    }
}
