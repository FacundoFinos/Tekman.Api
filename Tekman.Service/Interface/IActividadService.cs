using System;
using System.Collections.Generic;
using System.Text;
using Tekman.Service.EntidadesDto;

namespace Tekman.Service.Interface
{
    public interface IActividadService
    {
        public bool NuevaActividad(ActividadDto actividad);
        public List<ActividadDto> ListaActividades();
    }
}
