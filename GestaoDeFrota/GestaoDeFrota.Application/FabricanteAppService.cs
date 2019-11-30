using GestaoDeFrota.Application.Interface;
using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Application
{
    public class FabricanteAppService : AppServiceBase<Fabricante>, IFabricanteAppService
    {
        public IFabricanteService _fabricanteService;

        public FabricanteAppService(IFabricanteService fabricanteService) : base(fabricanteService)
        {
            _fabricanteService = fabricanteService;
        }
    }
}
