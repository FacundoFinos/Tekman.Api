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
    public class PreguntasService : IPreguntasService
    {
        private readonly TekmanDBContext _dbContext;
        private readonly IMapper _mapper;
        public PreguntasService(TekmanDBContext bdContext, IMapper mapper)
        {
            _dbContext = bdContext;
            _mapper = mapper;
        }
        public List<Pregunta> ListaPreguntas()
        {
           return  _dbContext.Pregunta.ToList();
        }

        public bool NuevaPregunta(PreguntaDto pregunta)
        {
            try
            {
                var newID = 1;
                //Obtiene el proximo ID, reemplaza el autoincremental de la BD
                if (_dbContext.Pregunta.Count() > 0)
                {
                    newID = _dbContext.Pregunta.Select(x => x.Id).Max() + 1;
                }

                var nuevaPreg = _mapper.Map<Pregunta>(pregunta);
                nuevaPreg.Id = newID;
                //creo una nueva pregunta
                _dbContext.Pregunta.Add(nuevaPreg);
                //creo la respuesta correcta a la pregunta
                _dbContext.PreguntaRespuesta.Add(new PreguntaRespuesta() { 
                    IdPregunta = newID, 
                    RespuestaCorecta = pregunta.RespuestaCorrecta
                    });
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
