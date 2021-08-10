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
    public class ActividadService : IActividadService
    {
        private readonly TekmanDBContext _dbContext;
        private readonly IMapper _mapper;
        public ActividadService(TekmanDBContext bdContext, IMapper mapper)
        {
            _dbContext = bdContext;
            _mapper = mapper;
        }

        public EnunciadoActividadDto ComenzarActividad(int id)
        {
            try
            {
                var actividad = _dbContext.Actividad.Find(id);

                EnunciadoActividadDto enunciadoActividadDto = new EnunciadoActividadDto()
                {
                    IdActividad = actividad.Id,
                    Ejercicios = actividad.Ejercicios.ToList()
                };
                return enunciadoActividadDto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public decimal EvaluarRespuestas(RespuestaDto respuestas)
        {
            try
            {
                foreach (var respuesta in respuestas.Respuestas)
                {
                    var respuestaCorecta = _dbContext.PreguntaRespuesta.Find(respuesta.Key);

                    _dbContext.RespuestaAlumno.Add(new RespuestaAlumno()
                    {
                        IdAlumno = 1,
                        IdActividad = respuestas.IdActividad,
                        IdPregunta = respuesta.Key,
                        Respuesta = respuesta.Value,
                        Resultado = (respuesta.Value == respuestaCorecta.RespuestaCorecta)
                    });

                }
                _dbContext.SaveChanges();

                //calculo de la nota:
                //Para este caso el calculo de la nota se basa en el numero de respuestas correctas/preguntas de la actividad * 10;
                var respuestasCorrectas = _dbContext.RespuestaAlumno.Where(p => p.Resultado).Count();
                decimal resultado = (respuestasCorrectas / respuestas.Respuestas.Count()) * 10;

                return Math.Round(resultado,1);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<ActividadDto> ListaActividades()
        {
            throw new NotImplementedException();
        }
        public bool NuevaActividad(ActividadDto actividad)
        {
            try
            { 
                //Valido que exista la competencia asociada.
                if(_dbContext.Competencia.Find(actividad.CompetenciaID) == null)
                {
                    throw new Exception("La competencia que ha informado no existe. Por favor verifique el Id enviado.");
                }

                //Busco los ejercicios mediante el ID proporcionado y los agrego a la actividad que se creará.
                var listaEjercicios = _dbContext.Ejercicio.Where(p => actividad.Ejercicios.Contains(p.Id)).ToList();
                
                //Valido que la actividad contenga al menos un ejercicio asociado
                if (listaEjercicios.Count() == 0)
                {
                    throw new Exception("La actividad no tiene ejercicios asociados. Revise la lista de id de ejercicios del request.");
                }

                //Obtiene el proximo ID, reemplaza el autoincremental de la BD
                var newID = _dbContext.Ejercicio.Select(x => x.Id).Max() + 1;

                var nuevaAct = _mapper.Map<Actividad>(actividad);
                nuevaAct.Ejercicios = listaEjercicios;
                nuevaAct.Id = newID;
                _dbContext.Actividad.Add(nuevaAct);
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
