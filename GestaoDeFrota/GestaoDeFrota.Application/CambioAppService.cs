using GestaoDeFrota.Application.Interface;
using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Application
{
    public class CambioAppService : AppServiceBase<Cambio>, ICambioAppService
    {
        public ICambioService _cambioService;

        public CambioAppService(ICambioService cambioService) : base(cambioService)
        {
            _cambioService = cambioService;
        }
    }
}
