using System;
using System.Collections.Generic;
using System.Text;
using Tekman.Repository.Models;
using Tekman.Service.EntidadesDto;

namespace Tekman.Service.Interface
{
    public interface ICompetenciaService
    {
        public bool NuevaCompetencia(CompetenciaDto competencia);
        public List<Competencia> ListaCompetencias();
    }
}
