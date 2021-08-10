using System;
using System.Collections.Generic;
using System.Text;
using Tekman.Service.EntidadesDto;

namespace Tekman.Service.Interface
{
    public interface IPreguntasService
    {
        public bool NuevaPregunta();
        public List<PreguntaDto> ListaPreguntas();
    }
}
