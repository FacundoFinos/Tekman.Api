using System;
using System.Collections.Generic;
using System.Text;
using Tekman.Repository.Models;
using Tekman.Service.EntidadesDto;

namespace Tekman.Service.Interface
{
    public interface IEjercicioService
    {
        public bool NuevoEjercicio(EjercicioDto ejercicio);
        public List<Ejercicio> ListaEjercicios();
    }
}
