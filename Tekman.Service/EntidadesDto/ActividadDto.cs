using System;
using System.Collections.Generic;
using System.Text;

namespace Tekman.Service.EntidadesDto
{
    public class ActividadDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<EjercicioDto> Ejercicios { get; set; }
        public int CompetenciaID { get; set; }
        public ActividadTipoEnum Tipo { get; set; }
        public double Nota { get; set; }


    }
}
