using AutoMapper;
using Tekman.Repository.Models;
using Tekman.Service.EntidadesDto;

namespace Tekman.Service.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Actividad, ActividadDto>();
            CreateMap<ActividadDto, Actividad>();
            CreateMap<Competencia, CompetenciaDto>();
            CreateMap<CompetenciaDto, Competencia>();
            CreateMap<Ejercicio, EjercicioDto>();
            CreateMap<EjercicioDto, Ejercicio>();
            CreateMap<Pregunta, NewPreguntaRequest>();
            CreateMap<NewPreguntaRequest, Pregunta>();
        }
    }
}