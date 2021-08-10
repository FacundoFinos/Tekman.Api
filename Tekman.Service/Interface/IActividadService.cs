using System;
using System.Collections.Generic;
using System.Text;
using Tekman.Repository.Models;
using Tekman.Service.EntidadesDto;

namespace Tekman.Service.Interface
{
    public interface IActividadService
    {
        public bool NuevaActividad(ActividadDto actividad);
        public EnunciadoActividadDto ComenzarActividad(int id);
        decimal EvaluarRespuestas(RespuestaDto respuestas);
        decimal Evaluacion(string tipoEvalauacion);
    }
}
