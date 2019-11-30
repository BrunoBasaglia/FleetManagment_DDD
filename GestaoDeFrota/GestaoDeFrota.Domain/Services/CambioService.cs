using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Domain.Services
{
    public class CambioService : ServiceBase<Cambio>, ICambioService
    {
        private ICambioRepository _cambioRepository;

        public CambioService(ICambioRepository cambioRepository) : base(cambioRepository)
        {
            _cambioRepository = cambioRepository;
        }
    }
}
