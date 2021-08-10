using System;
using System.Collections.Generic;
using System.Text;

namespace Tekman.Repository.Models
{
    public class Actividad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Ejercicio> Ejercicios { get; set; }
        public int CompetenciaID { get; set; }
        public int Tipo { get; set; }
        public double Nota { get; set; }


    }
}
