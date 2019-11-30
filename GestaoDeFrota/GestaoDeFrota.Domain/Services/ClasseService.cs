using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Domain.Interfaces.Services;

namespace GestaoDeFrota.Domain.Services
{
    public class ClasseService : ServiceBase<Classe>, IClasseService
    {
        private IClasseRepository _classeRepository;

        public ClasseService(IClasseRepository classeRepository) : base(classeRepository)
        {
            _classeRepository = classeRepository;
        }
    }
}
