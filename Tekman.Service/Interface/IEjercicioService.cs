using System;
using System.Collections.Generic;
using System.Text;
using Tekman.Service.EntidadesDto;

namespace Tekman.Service.Interface
{
    public interface IEjercicioService
    {
        public bool NuevoEjercicio();
        public List<EjercicioDto> ListaEjercicios();
    }
}
