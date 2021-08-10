using System;
using System.Collections.Generic;
using System.Text;
using Tekman.Service.EntidadesDto;

namespace Tekman.Service.Interface
{
    public interface ICompetenciaService
    {
        public bool NuevaCompetencia();
        public List<CompetenciaDto> ListaCompetencias();
    }
}
