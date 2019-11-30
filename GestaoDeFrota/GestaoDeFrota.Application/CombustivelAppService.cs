using GestaoDeFrota.Application.Interface;
using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Application
{
    public class CombustivelAppService : AppServiceBase<Combustivel>, ICombustivelAppService
    {
        public ICombustivelService _combustivelService;

        public CombustivelAppService(ICombustivelService combustivelService) : base(combustivelService)
        {
            _combustivelService = combustivelService;
        }
    }
}
