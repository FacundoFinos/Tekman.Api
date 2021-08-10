using AutoMapper;
using Tekman.Repository.Models;
using Tekman.Service.EntidadesDto;

namespace Tekman.Service.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Actividad, ActividadDto>().ForMember(x => x.Ejercicios, opt => opt.Ignore());
            CreateMap<ActividadDto, Actividad>().ForMember(x => x.Ejercicios, opt => opt.Ignore());
            CreateMap<Competencia, CompetenciaDto>();
            CreateMap<CompetenciaDto, Competencia>();
            CreateMap<Ejercicio, EjercicioDto>();
            CreateMap<EjercicioDto, Ejercicio>();
            CreateMap<Pregunta, PreguntaDto>();
            CreateMap<PreguntaDto, Pregunta>();
        }
    }
}