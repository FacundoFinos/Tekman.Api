using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tekman.Repository;
using Tekman.Repository.Models;
using Tekman.Service.EntidadesDto;
using Tekman.Service.Interface;

namespace Tekman.Service.Services
{
    public class EjercicioService : IEjercicioService
    {
        private readonly TekmanDBContext _dbContext;
        private readonly IMapper _mapper;
        public EjercicioService(TekmanDBContext bdContext, IMapper mapper)
        {
            _dbContext = bdContext;
            _mapper = mapper;
        }
        public List<Ejercicio> ListaEjercicios()
        {
            _dbContext.Ejercicio.ToList();
        }

        public bool NuevoEjercicio(EjercicioDto ejercicio)
        {
            try
            {
                //Obtiene el proximo ID, reemplaza el autoincremental de la BD
                var newID = _dbContext.Ejercicio.Select(x => x.Id).Max() + 1;

                //Busco las preguntas mediante el ID proporcionado y las agrego al ejercicio que se creará.
                var listaPreguntas = _dbContext.Pregunta.Where(p => ejercicio.PreguntasID.Contains(p.Id)).ToList();

                //Valido que la actividad contenga al menos un ejercicio asociado
                if (listaPreguntas.Count() == 0)
                {
                    throw new Exception("El ejercicio no tiene preguntas asociadas. Revise la lista de id de preguntas del request.");
                }

                var nuevoEjerc = _mapper.Map<Ejercicio>(ejercicio);
                nuevoEjerc.Id = newID;
                nuevoEjerc.Preguntas = listaPreguntas;
                _dbContext.Ejercicio.Add(nuevoEjerc);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
