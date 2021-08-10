using System;
using System.Collections.Generic;
using System.Text;
using Tekman.Repository.Models;

namespace Tekman.Service.EntidadesDto
{
    public class EnunciadoActividadDto
    {
        public int IdActividad { get; set; }
        public List<Ejercicio>  Ejercicios { get; set; }
    }
}
