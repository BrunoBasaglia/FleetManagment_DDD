using GestaoDeFrota.Domain.Entities;
using GestaoDeFrota.Domain.Interfaces.Repositories;
using GestaoDeFrota.Infra.Contexto;

namespace GestaoDeFrota.Infra.Repositories
{
    public class OrigemRepository : RepositoryBase<Origem>, IOrigemRepository
    {
        private readonly GestaoDeFrotasContexto Db;

        public OrigemRepository(GestaoDeFrotasContexto context) : base(context)
        {
            Db = context;
        }
    }
}
