using GestaoDeFrota.Application.Interface;
using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Application
{
    public class QuilometragemAppService : AppServiceBase<Quilometragem>, IQuilometragemAppService
    {
        public IQuilometragemService _quilometragemService;

        public QuilometragemAppService(IQuilometragemService quilomeragemService) : base(quilomeragemService)
        {
            _quilometragemService = quilomeragemService;
        }
    }
}
