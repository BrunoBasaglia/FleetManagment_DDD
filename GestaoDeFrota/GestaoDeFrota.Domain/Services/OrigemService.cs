using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Domain.Services
{
    public class OrigemService : ServiceBase<Origem>, IOrigemService
    {
        private IOrigemRepository _origemRepository;

        public OrigemService(IOrigemRepository origemRepository) : base(origemRepository)
        {
            _origemRepository = origemRepository;
        }
    }
}
