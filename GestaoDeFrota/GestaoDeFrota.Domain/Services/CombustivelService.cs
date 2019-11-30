using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Domain.Services
{
    public class CombustivelService : ServiceBase<Combustivel>, ICombustivelService
    {
        private ICombustivelRepository _combustivelRepository;

        public CombustivelService(ICombustivelRepository combustivelRepository) : base(combustivelRepository)
        {
            _combustivelRepository = combustivelRepository;
        }
    }
}
