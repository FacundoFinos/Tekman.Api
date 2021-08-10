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
    public class CompetenciaService : ICompetenciaService
    {
        private readonly TekmanDBContext _dbContext;
        private readonly IMapper _mapper;
        public CompetenciaService(TekmanDBContext bdContext, IMapper mapper)
        {
            _dbContext = bdContext;
            _mapper = mapper;
        }

        
        public List<Competencia> ListaCompetencias()
        {
            return _dbContext.Competencia.ToList();
        }

        public bool NuevaCompetencia(CompetenciaDto competencia)
        {
            try
            {
                //Obtiene el proximo ID, reemplaza el autoincremental de la BD
                var newID = 1;
                if (_dbContext.Competencia.Count() > 0)
                {
                    newID = _dbContext.Competencia.Select(x => x.Id).Max() + 1;
                }                

                var nuevaComp = _mapper.Map<Competencia>(competencia);
                nuevaComp.Id = newID;
                _dbContext.Competencia.Add(nuevaComp);
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
