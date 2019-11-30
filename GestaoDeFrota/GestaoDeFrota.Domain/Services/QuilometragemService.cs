using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Domain.Services
{
    public class QuilometragemService : ServiceBase<Quilometragem>, IQuilometragemService
    {
        private IQuilometragemRepository _quilometragemRepository;

        public QuilometragemService(IQuilometragemRepository quilometragemRepository) : base(quilometragemRepository)
        {
            _quilometragemRepository = quilometragemRepository;
        }
    }
}
