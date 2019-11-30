using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Domain.Services
{
    public class FabricanteService : ServiceBase<Fabricante>, IFabricanteService
    {
        private IFabricanteRepository _fabricanteRepository;

        public FabricanteService(IFabricanteRepository fabricanteRepository) : base(fabricanteRepository)
        {
            _fabricanteRepository = fabricanteRepository;
        }
    }
}
