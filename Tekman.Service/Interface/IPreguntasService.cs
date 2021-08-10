using System;
using System.Collections.Generic;
using System.Text;
using Tekman.Repository.Models;
using Tekman.Service.EntidadesDto;

namespace Tekman.Service.Interface
{
    public interface IPreguntasService
    {
        public bool NuevaPregunta(PreguntaDto pregunta);
        public List<Pregunta> ListaPreguntas();
    }
}
